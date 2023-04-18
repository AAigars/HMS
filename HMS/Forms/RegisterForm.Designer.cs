namespace HMS.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtFirstName = new TextBox();
            txtPassword = new TextBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            lblLogin = new Label();
            btnRegister = new Label();
            txtLastName = new TextBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(134, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(102, 126, 234);
            lblTitle.Location = new Point(124, 86);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(81, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Register";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtitle.ForeColor = Color.FromArgb(110, 114, 117);
            lblSubtitle.Location = new Point(94, 111);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(149, 21);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Create your account";
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
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(237, 242, 246);
            txtFirstName.BorderStyle = BorderStyle.None;
            txtFirstName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.ForeColor = Color.FromArgb(110, 114, 117);
            txtFirstName.Location = new Point(61, 157);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new Size(214, 18);
            txtFirstName.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(237, 242, 246);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.FromArgb(110, 114, 117);
            txtPassword.Location = new Point(61, 251);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(214, 18);
            txtPassword.TabIndex = 8;
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
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.FromArgb(102, 126, 234);
            lblLogin.Location = new Point(73, 335);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(193, 21);
            lblLogin.TabIndex = 11;
            lblLogin.Text = "Already have an account?";
            lblLogin.Click += lblLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(102, 126, 234);
            btnRegister.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(53, 290);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(234, 35);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Register";
            btnRegister.TextAlign = ContentAlignment.MiddleCenter;
            btnRegister.MouseClick += btnRegister_Click;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(237, 242, 246);
            txtLastName.BorderStyle = BorderStyle.None;
            txtLastName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.ForeColor = Color.FromArgb(110, 114, 117);
            txtLastName.Location = new Point(61, 205);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(214, 18);
            txtLastName.TabIndex = 15;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(205, 212, 230);
            pictureBox6.Location = new Point(53, 231);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(234, 3);
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(237, 242, 246);
            pictureBox7.Location = new Point(53, 196);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(234, 35);
            pictureBox7.TabIndex = 13;
            pictureBox7.TabStop = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(334, 381);
            Controls.Add(txtLastName);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox7);
            Controls.Add(btnRegister);
            Controls.Add(lblLogin);
            Controls.Add(txtPassword);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(txtFirstName);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegisterForm";
            ShowIcon = false;
            Text = "Hospital Management System";
            FormClosed += RegisterForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label lblSubtitle;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txtFirstName;
        private TextBox txtPassword;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label lblLogin;
        private Label btnRegister;
        private TextBox txtLastName;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
    }
}