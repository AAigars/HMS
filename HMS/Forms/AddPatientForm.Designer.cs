namespace HMS.Forms
{
    partial class AddPatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatientForm));
            pictureBox1 = new PictureBox();
            lblSubtitle = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            btnAssign = new Label();
            lblTitle = new Label();
            txtFirstName = new TextBox();
            txtDateOfBirth = new TextBox();
            txtAddress = new TextBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            txtLastName = new TextBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            txtPhoneNumber = new TextBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            txtGender = new TextBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(134, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtitle.ForeColor = Color.FromArgb(110, 114, 117);
            lblSubtitle.Location = new Point(53, 111);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(234, 21);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Create an patient";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(237, 242, 246);
            pictureBox2.Location = new Point(53, 148);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(234, 35);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(205, 212, 230);
            pictureBox3.Location = new Point(53, 183);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(234, 3);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(205, 212, 230);
            pictureBox4.Location = new Point(53, 277);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(234, 3);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(237, 242, 246);
            pictureBox5.Location = new Point(53, 242);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(234, 35);
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // btnAssign
            // 
            btnAssign.BackColor = Color.FromArgb(102, 126, 234);
            btnAssign.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnAssign.ForeColor = Color.White;
            btnAssign.Location = new Point(53, 429);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(234, 35);
            btnAssign.TabIndex = 10;
            btnAssign.Text = "Create Patient";
            btnAssign.TextAlign = ContentAlignment.MiddleCenter;
            btnAssign.Click += btnAssign_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(102, 126, 234);
            lblTitle.Location = new Point(83, 83);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(168, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Patient";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFirstName
            // 
            txtFirstName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtFirstName.BackColor = Color.FromArgb(237, 242, 246);
            txtFirstName.BorderStyle = BorderStyle.None;
            txtFirstName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.ForeColor = Color.FromArgb(110, 114, 117);
            txtFirstName.Location = new Point(63, 156);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new Size(214, 18);
            txtFirstName.TabIndex = 11;
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtDateOfBirth.BackColor = Color.FromArgb(237, 242, 246);
            txtDateOfBirth.BorderStyle = BorderStyle.None;
            txtDateOfBirth.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateOfBirth.ForeColor = Color.FromArgb(110, 114, 117);
            txtDateOfBirth.Location = new Point(63, 249);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.PlaceholderText = "Date of Birth";
            txtDateOfBirth.Size = new Size(214, 18);
            txtDateOfBirth.TabIndex = 12;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(237, 242, 246);
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.ForeColor = Color.FromArgb(110, 114, 117);
            txtAddress.Location = new Point(63, 337);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address";
            txtAddress.Size = new Size(214, 18);
            txtAddress.TabIndex = 15;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(205, 212, 230);
            pictureBox6.Location = new Point(53, 365);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(234, 3);
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(237, 242, 246);
            pictureBox7.Location = new Point(53, 330);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(234, 35);
            pictureBox7.TabIndex = 13;
            pictureBox7.TabStop = false;
            // 
            // txtLastName
            // 
            txtLastName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtLastName.BackColor = Color.FromArgb(237, 242, 246);
            txtLastName.BorderStyle = BorderStyle.None;
            txtLastName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.ForeColor = Color.FromArgb(110, 114, 117);
            txtLastName.Location = new Point(63, 202);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(214, 18);
            txtLastName.TabIndex = 18;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(205, 212, 230);
            pictureBox8.Location = new Point(53, 230);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(234, 3);
            pictureBox8.TabIndex = 17;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.FromArgb(237, 242, 246);
            pictureBox9.Location = new Point(53, 195);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(234, 35);
            pictureBox9.TabIndex = 16;
            pictureBox9.TabStop = false;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.FromArgb(237, 242, 246);
            txtPhoneNumber.BorderStyle = BorderStyle.None;
            txtPhoneNumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhoneNumber.ForeColor = Color.FromArgb(110, 114, 117);
            txtPhoneNumber.Location = new Point(63, 385);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Phone Number";
            txtPhoneNumber.Size = new Size(214, 18);
            txtPhoneNumber.TabIndex = 21;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.FromArgb(205, 212, 230);
            pictureBox10.Location = new Point(53, 413);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(234, 3);
            pictureBox10.TabIndex = 20;
            pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.FromArgb(237, 242, 246);
            pictureBox11.Location = new Point(53, 378);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(234, 35);
            pictureBox11.TabIndex = 19;
            pictureBox11.TabStop = false;
            // 
            // txtGender
            // 
            txtGender.BackColor = Color.FromArgb(237, 242, 246);
            txtGender.BorderStyle = BorderStyle.None;
            txtGender.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtGender.ForeColor = Color.FromArgb(110, 114, 117);
            txtGender.Location = new Point(63, 295);
            txtGender.Name = "txtGender";
            txtGender.PlaceholderText = "Gender";
            txtGender.Size = new Size(214, 18);
            txtGender.TabIndex = 24;
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = Color.FromArgb(205, 212, 230);
            pictureBox12.Location = new Point(53, 323);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(234, 3);
            pictureBox12.TabIndex = 23;
            pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.BackColor = Color.FromArgb(237, 242, 246);
            pictureBox13.Location = new Point(53, 288);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(234, 35);
            pictureBox13.TabIndex = 22;
            pictureBox13.TabStop = false;
            // 
            // AddPatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(334, 483);
            Controls.Add(txtGender);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox13);
            Controls.Add(txtPhoneNumber);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox11);
            Controls.Add(txtLastName);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox9);
            Controls.Add(txtAddress);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox7);
            Controls.Add(txtDateOfBirth);
            Controls.Add(txtFirstName);
            Controls.Add(btnAssign);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddPatientForm";
            ShowIcon = false;
            Text = "Hospital Management System";
            FormClosed += AddPatientForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblSubtitle;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label btnAssign;
        private Label lblTitle;
        private TextBox txtFirstName;
        private TextBox txtDateOfBirth;
        private TextBox txtAddress;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private TextBox txtLastName;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private TextBox txtPhoneNumber;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private TextBox txtGender;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
    }
}