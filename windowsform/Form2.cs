using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using static Microsoft.VisualBasic.Interaction;

using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsform
{
    using System.Data.SqlClient;
    using System.IO;
    using static Microsoft.VisualBasic.Interaction;


    public partial class Form2 : Form
    {
        string imgPath = "";
        byte[] imgData = null;

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Form2()
        {


            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string ConStr = ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString;
            con = new SqlConnection(ConStr);
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string value = InputBox("Enter Employee No. to Search.");

            if (int.TryParse(value, out int Eno))
            {
                try
                {
                    cmd.CommandText = "Employee_Select";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Eno", Eno);
                    cmd.Parameters.AddWithValue("@Status", true);

                    con.Open();
                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        textBox1.Text = dr["Eno"].ToString();
                        textBox2.Text = dr["Ename"].ToString();
                        textBox3.Text = dr["Job"].ToString();
                        textBox4.Text = dr["Salary"].ToString();

                        if (dr["Photo"] != DBNull.Value)
                        {
                            imgData = (byte[])dr["Photo"];
                            using (MemoryStream ms = new MemoryStream(imgData))
                            {
                                pictureBox1.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            imgData = null;
                            imgPath = "";
                            pictureBox1.Image = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "No employee exists with the given number.",
                            "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Error Message",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show(
                    "Employee No. should be integer value.",
                    "Conversion Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
            

           
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            imgPath = "";
            imgData = null;
            pictureBox1.Image = null;
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
            textBox2.Focus();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "New")
            {
                btnClear.PerformClick();
                btnNew.Text = "Insert";
            }
            else
            {
                try
                {
                    cmd.CommandText = "Employee_Insert";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Ename", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Job", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Salary", textBox4.Text);
                    if (imgPath.Trim().Length > 0)
                    {
                        imgData = File.ReadAllBytes(imgPath);
                        cmd.Parameters.AddWithValue("@Photo", imgData);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Photo", DBNull.Value);
                        cmd.Parameters["@Photo"].SqlDbType = SqlDbType.VarBinary;
                    }
                    cmd.Parameters.Add("@Eno", SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    textBox1.Text = cmd.Parameters["@Eno"].Value.ToString();
                    imgData = null; imgPath = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                    btnNew.Text = "New";
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "Employee_Update";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Eno", textBox1.Text);
                cmd.Parameters.AddWithValue("@Ename", textBox2.Text);
                cmd.Parameters.AddWithValue("@Job", textBox3.Text);
                cmd.Parameters.AddWithValue("@Salary", textBox4.Text);
                if (imgData == null && imgPath.Trim().Length == 0)
                {
                    cmd.Parameters.AddWithValue("@Photo", DBNull.Value);
                    cmd.Parameters["@Photo"].SqlDbType = SqlDbType.VarBinary;
                }
                else if (imgPath.Trim().Length > 0)
                {
                    imgData = File.ReadAllBytes(imgPath);
                    cmd.Parameters.AddWithValue("@Photo", imgData);
                }
                else if (imgPath.Trim().Length == 0 && imgData != null)
                {
                    cmd.Parameters.AddWithValue("@Photo", imgData);
                }
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record updated in Database-Table.", "Information Message", MessageBoxButtons.OK,
              MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "Employee_Delete";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Eno", textBox1.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                btnClear.PerformClick();
                MessageBox.Show("Record deleted from Database-Table.", "Information Message", MessageBoxButtons.OK,
              MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
            this.Close();

        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Jpeg Images|*.jpg|Bitmap Images|*.bmp|All Files|*.*";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                imgPath = openFileDialog1.FileName;
                pictureBox1.ImageLocation = imgPath;
            }

        }


    }
}
