namespace HMS.Forms
{
    partial class AddAppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAppointmentForm));
            pictureBox1 = new PictureBox();
            lblSubtitle = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            btnAssign = new Label();
            lblTitle = new Label();
            txtPatient = new TextBox();
            txtTimestamp = new TextBox();
            txtNote = new TextBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            txtDoctor = new TextBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
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
            lblSubtitle.Text = "Create an appointment";
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
            btnAssign.Location = new Point(53, 343);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(234, 35);
            btnAssign.TabIndex = 10;
            btnAssign.Text = "Assign Appointment";
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
            lblTitle.Text = "Appointment";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPatient
            // 
            txtPatient.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtPatient.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtPatient.BackColor = Color.FromArgb(237, 242, 246);
            txtPatient.BorderStyle = BorderStyle.None;
            txtPatient.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPatient.ForeColor = Color.FromArgb(110, 114, 117);
            txtPatient.Location = new Point(63, 156);
            txtPatient.Name = "txtPatient";
            txtPatient.PlaceholderText = "Patient";
            txtPatient.Size = new Size(214, 18);
            txtPatient.TabIndex = 1;
            // 
            // txtTimestamp
            // 
            txtTimestamp.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimestamp.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTimestamp.BackColor = Color.FromArgb(237, 242, 246);
            txtTimestamp.BorderStyle = BorderStyle.None;
            txtTimestamp.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimestamp.ForeColor = Color.FromArgb(110, 114, 117);
            txtTimestamp.Location = new Point(63, 249);
            txtTimestamp.Name = "txtTimestamp";
            txtTimestamp.PlaceholderText = "Check-in Time";
            txtTimestamp.Size = new Size(214, 18);
            txtTimestamp.TabIndex = 3;
            // 
            // txtNote
            // 
            txtNote.BackColor = Color.FromArgb(237, 242, 246);
            txtNote.BorderStyle = BorderStyle.None;
            txtNote.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNote.ForeColor = Color.FromArgb(110, 114, 117);
            txtNote.Location = new Point(63, 296);
            txtNote.Name = "txtNote";
            txtNote.PlaceholderText = "Note";
            txtNote.Size = new Size(214, 18);
            txtNote.TabIndex = 4;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(205, 212, 230);
            pictureBox6.Location = new Point(53, 324);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(234, 3);
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(237, 242, 246);
            pictureBox7.Location = new Point(53, 289);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(234, 35);
            pictureBox7.TabIndex = 13;
            pictureBox7.TabStop = false;
            // 
            // txtDoctor
            // 
            txtDoctor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtDoctor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtDoctor.BackColor = Color.FromArgb(237, 242, 246);
            txtDoctor.BorderStyle = BorderStyle.None;
            txtDoctor.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDoctor.ForeColor = Color.FromArgb(110, 114, 117);
            txtDoctor.Location = new Point(63, 202);
            txtDoctor.Name = "txtDoctor";
            txtDoctor.PlaceholderText = "Doctor";
            txtDoctor.Size = new Size(214, 18);
            txtDoctor.TabIndex = 2;
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
            // AddAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(334, 395);
            Controls.Add(txtDoctor);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox9);
            Controls.Add(txtNote);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox7);
            Controls.Add(txtTimestamp);
            Controls.Add(txtPatient);
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
            Name = "AddAppointmentForm";
            ShowIcon = false;
            Text = "Hospital Management System";
            FormClosed += AddAppointmentForm_FormClosed;
            Load += AddAppointmentForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
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
        private TextBox txtPatient;
        private TextBox txtTimestamp;
        private TextBox txtNote;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private TextBox txtDoctor;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
    }
}