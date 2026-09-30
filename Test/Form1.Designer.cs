namespace Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            btnDelete = new Button();
            btnClear = new Button();
            btnAdd = new Button();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            comboCountry = new ComboBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            label6 = new Label();
            Country = new Label();
            lblEmail = new Label();
            label3 = new Label();
            lblName = new Label();
            lblId = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 77);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(radioButton3);
            panel3.Controls.Add(radioButton2);
            panel3.Controls.Add(radioButton1);
            panel3.Controls.Add(comboCountry);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(txtAddress);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(Country);
            panel3.Controls.Add(lblEmail);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(lblName);
            panel3.Controls.Add(lblId);
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 390);
            panel3.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(72, 355);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(200, 310);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(72, 310);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(248, 251);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(60, 19);
            radioButton3.TabIndex = 13;
            radioButton3.TabStop = true;
            radioButton3.Text = "Others";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(179, 251);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(118, 251);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboCountry
            // 
            comboCountry.FormattingEnabled = true;
            comboCountry.Location = new Point(133, 205);
            comboCountry.Name = "comboCountry";
            comboCountry.Size = new Size(121, 23);
            comboCountry.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(142, 152);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(142, 114);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(142, 83);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(67, 253);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 6;
            label6.Text = "Gender";
            // 
            // Country
            // 
            Country.AutoSize = true;
            Country.Location = new Point(62, 205);
            Country.Name = "Country";
            Country.Size = new Size(50, 15);
            Country.TabIndex = 5;
            Country.Text = "Country";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(67, 160);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 122);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 3;
            label3.Text = "Address";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(67, 83);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(67, 43);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 1;
            lblId.Text = "Id";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(390, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(410, 390);
            panel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(410, 390);
            dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 467);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtName;
        private Label label6;
        private Label Country;
        private Label lblEmail;
        private Label label3;
        private Label lblName;
        private Label lblId;
        private Button btnDelete;
        private Button btnClear;
        private Button btnAdd;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ComboBox comboCountry;
        private DataGridView dataGridView1;
    }
}
