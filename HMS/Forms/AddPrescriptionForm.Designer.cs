namespace HMS.Forms
{
    partial class AddPrescriptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPrescriptionForm));
            pictureBox1 = new PictureBox();
            lblSubtitle = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            btnAssign = new Label();
            lblTitle = new Label();
            txtMedicine = new TextBox();
            txtDosage = new TextBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            lblSubtitle.Text = "Create an prescription";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(205, 212, 230);
            pictureBox4.Location = new Point(53, 184);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(234, 3);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(237, 242, 246);
            pictureBox5.Location = new Point(53, 149);
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
            btnAssign.Location = new Point(53, 246);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(234, 35);
            btnAssign.TabIndex = 10;
            btnAssign.Text = "Assign Prescription";
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
            lblTitle.Text = "Prescription";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMedicine
            // 
            txtMedicine.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtMedicine.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtMedicine.BackColor = Color.FromArgb(237, 242, 246);
            txtMedicine.BorderStyle = BorderStyle.None;
            txtMedicine.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMedicine.ForeColor = Color.FromArgb(110, 114, 117);
            txtMedicine.Location = new Point(63, 156);
            txtMedicine.Name = "txtMedicine";
            txtMedicine.PlaceholderText = "Medicine";
            txtMedicine.Size = new Size(214, 18);
            txtMedicine.TabIndex = 12;
            // 
            // txtDosage
            // 
            txtDosage.BackColor = Color.FromArgb(237, 242, 246);
            txtDosage.BorderStyle = BorderStyle.None;
            txtDosage.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDosage.ForeColor = Color.FromArgb(110, 114, 117);
            txtDosage.Location = new Point(63, 203);
            txtDosage.Name = "txtDosage";
            txtDosage.PlaceholderText = "Dosage";
            txtDosage.Size = new Size(214, 18);
            txtDosage.TabIndex = 15;
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
            // AddPrescriptionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(334, 307);
            Controls.Add(txtDosage);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox7);
            Controls.Add(txtMedicine);
            Controls.Add(btnAssign);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddPrescriptionForm";
            ShowIcon = false;
            Text = "Hospital Management System";
            FormClosed += AddPrescriptiontForm_FormClosed;
            Load += AddPrescriptionForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblSubtitle;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label btnAssign;
        private Label lblTitle;
        private TextBox txtMedicine;
        private TextBox txtDosage;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
    }
}