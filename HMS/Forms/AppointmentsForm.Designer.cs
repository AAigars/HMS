﻿namespace HMS.Forms
{
    partial class AppointmentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentsForm));
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblName = new Label();
            pictureBox1 = new PictureBox();
            btnPatients = new Label();
            label2 = new Label();
            btnAdmin = new Label();
            pictureBox4 = new PictureBox();
            tblAppointments = new PictureBox();
            pictureBox6 = new PictureBox();
            btnAdd = new Label();
            btnPrevious = new Label();
            btnNext = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblAppointments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(205, 212, 230);
            pictureBox3.Location = new Point(0, 41);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(917, 3);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(237, 242, 246);
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(902, 45);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.FromArgb(237, 242, 246);
            lblName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.FromArgb(102, 126, 234);
            lblName.Location = new Point(36, 11);
            lblName.Name = "lblName";
            lblName.Size = new Size(90, 21);
            lblName.TabIndex = 9;
            lblName.Text = "Your Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(237, 242, 246);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnPatients
            // 
            btnPatients.AutoSize = true;
            btnPatients.BackColor = Color.FromArgb(237, 242, 246);
            btnPatients.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPatients.ForeColor = Color.FromArgb(110, 114, 117);
            btnPatients.Location = new Point(754, 11);
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new Size(68, 21);
            btnPatients.TabIndex = 10;
            btnPatients.Text = "Patients";
            btnPatients.Click += btnPatients_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(237, 242, 246);
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(110, 114, 117);
            label2.Location = new Point(633, 11);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 11;
            label2.Text = "Appointments";
            // 
            // btnAdmin
            // 
            btnAdmin.AutoSize = true;
            btnAdmin.BackColor = Color.FromArgb(237, 242, 246);
            btnAdmin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdmin.ForeColor = Color.FromArgb(110, 114, 117);
            btnAdmin.Location = new Point(828, 11);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(58, 21);
            btnAdmin.TabIndex = 12;
            btnAdmin.Text = "Admin";
            btnAdmin.Click += btnAdmin_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(102, 126, 234);
            pictureBox4.Location = new Point(625, 41);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(130, 3);
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // tblAppointments
            // 
            tblAppointments.BackColor = Color.FromArgb(237, 242, 246);
            tblAppointments.Location = new Point(12, 59);
            tblAppointments.Name = "tblAppointments";
            tblAppointments.Size = new Size(878, 243);
            tblAppointments.TabIndex = 14;
            tblAppointments.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(205, 212, 230);
            pictureBox6.Location = new Point(12, 97);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(878, 3);
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(102, 126, 234);
            btnAdd.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(12, 311);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(38, 35);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "+";
            btnAdd.TextAlign = ContentAlignment.MiddleCenter;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.FromArgb(102, 126, 234);
            btnPrevious.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrevious.ForeColor = Color.White;
            btnPrevious.Location = new Point(808, 311);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(38, 35);
            btnPrevious.TabIndex = 26;
            btnPrevious.Text = "<";
            btnPrevious.TextAlign = ContentAlignment.MiddleCenter;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(102, 126, 234);
            btnNext.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(852, 311);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(38, 35);
            btnNext.TabIndex = 25;
            btnNext.Text = ">";
            btnNext.TextAlign = ContentAlignment.MiddleCenter;
            btnNext.Click += btnNext_Click;
            // 
            // AppointmentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(901, 355);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(btnAdd);
            Controls.Add(pictureBox6);
            Controls.Add(tblAppointments);
            Controls.Add(pictureBox4);
            Controls.Add(btnAdmin);
            Controls.Add(label2);
            Controls.Add(btnPatients);
            Controls.Add(lblName);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AppointmentsForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Hospital Management System";
            FormClosed += AppointmentsForm_FormClosed;
            Load += AppointmentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblAppointments).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label lblName;
        private PictureBox pictureBox1;
        private Label btnPatients;
        private Label label2;
        private Label btnAdmin;
        private PictureBox pictureBox4;
        private PictureBox tblAppointments;
        private PictureBox pictureBox6;
        private Label btnAdd;
        private Label btnPrevious;
        private Label btnNext;
    }
}