namespace windowsform
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelLeft = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnClear = new Button();
            btnNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            btnSelect = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            panelRight = new Panel();
            button7 = new Button();
            btnLoadImage = new Button();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelLeft.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 391);
            panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.0452881F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.9547119F));
            tableLayoutPanel1.Controls.Add(panelLeft, 0, 0);
            tableLayoutPanel1.Controls.Add(panelRight, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 391);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(128, 255, 128);
            panelLeft.Controls.Add(tableLayoutPanel3);
            panelLeft.Controls.Add(tableLayoutPanel2);
            panelLeft.Controls.Add(label4);
            panelLeft.Controls.Add(label3);
            panelLeft.Controls.Add(label2);
            panelLeft.Controls.Add(textBox2);
            panelLeft.Controls.Add(textBox3);
            panelLeft.Controls.Add(textBox4);
            panelLeft.Controls.Add(textBox1);
            panelLeft.Controls.Add(label1);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(3, 3);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(306, 385);
            panelLeft.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableLayoutPanel3.Controls.Add(btnClear, 1, 0);
            tableLayoutPanel3.Controls.Add(btnNew, 2, 0);
            tableLayoutPanel3.Controls.Add(btnUpdate, 0, 1);
            tableLayoutPanel3.Controls.Add(btnDelete, 1, 1);
            tableLayoutPanel3.Controls.Add(btnClose, 2, 1);
            tableLayoutPanel3.Controls.Add(btnSelect, 0, 0);
            tableLayoutPanel3.Location = new Point(9, 212);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(299, 102);
            tableLayoutPanel3.TabIndex = 15;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 192, 128);
            btnClear.Dock = DockStyle.Fill;
            btnClear.Location = new Point(101, 3);
            btnClear.Name = "btnClear";
            btnClear.Padding = new Padding(5);
            btnClear.Size = new Size(92, 45);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(255, 192, 128);
            btnNew.Dock = DockStyle.Fill;
            btnNew.Location = new Point(199, 3);
            btnNew.Name = "btnNew";
            btnNew.Padding = new Padding(5);
            btnNew.Size = new Size(97, 45);
            btnNew.TabIndex = 17;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 192, 128);
            btnUpdate.Dock = DockStyle.Fill;
            btnUpdate.Location = new Point(3, 54);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Padding = new Padding(5);
            btnUpdate.Size = new Size(92, 45);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 192, 128);
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(101, 54);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(5);
            btnDelete.Size = new Size(92, 45);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 192, 128);
            btnClose.Dock = DockStyle.Fill;
            btnClose.Location = new Point(199, 54);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(5);
            btnClose.Size = new Size(97, 45);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.FromArgb(255, 192, 128);
            btnSelect.Dock = DockStyle.Fill;
            btnSelect.Location = new Point(3, 3);
            btnSelect.Name = "btnSelect";
            btnSelect.Padding = new Padding(5);
            btnSelect.Size = new Size(92, 45);
            btnSelect.TabIndex = 19;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Location = new Point(343, 229);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 167);
            label4.Name = "label4";
            label4.Size = new Size(50, 17);
            label4.TabIndex = 7;
            label4.Text = "Salary:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 119);
            label3.Name = "label3";
            label3.Size = new Size(34, 17);
            label3.TabIndex = 6;
            label3.Text = "Job:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 73);
            label2.Name = "label2";
            label2.Size = new Size(53, 17);
            label2.TabIndex = 5;
            label2.Text = "Ename:";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(82, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 25);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(82, 117);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 25);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(82, 165);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(180, 25);
            textBox4.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(82, 27);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(180, 25);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 27);
            label1.Name = "label1";
            label1.Size = new Size(35, 17);
            label1.TabIndex = 0;
            label1.Text = "Eno:";
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.FromArgb(128, 255, 128);
            panelRight.Controls.Add(button7);
            panelRight.Controls.Add(btnLoadImage);
            panelRight.Controls.Add(pictureBox1);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(315, 3);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(482, 385);
            panelRight.TabIndex = 1;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button7.BackColor = Color.Red;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(744, 3);
            button7.Name = "button7";
            button7.Size = new Size(24, 24);
            button7.TabIndex = 2;
            button7.Text = "X";
            button7.UseVisualStyleBackColor = false;
            // 
            // btnLoadImage
            // 
            btnLoadImage.BackColor = Color.FromArgb(255, 192, 128);
            btnLoadImage.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoadImage.Location = new Point(10, 266);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(473, 45);
            btnLoadImage.TabIndex = 1;
            btnLoadImage.Text = "LoadImage";
            btnLoadImage.UseVisualStyleBackColor = false;
            btnLoadImage.Click += btnLoadImage_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Blue;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(486, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Gold;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 64, 0);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(0, 0, 10, 0);
            lblTitle.Size = new Size(800, 59);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Employee Details";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelLeft;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnClear;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClose;
        private Button btnSelect;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox1;
        private Label label1;
        private Panel panelRight;
        private Button button7;
        private Button btnLoadImage;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private OpenFileDialog openFileDialog1;
    }
}