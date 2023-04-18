namespace HMS.Forms
{
    partial class AddMedicalHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMedicalHistoryForm));
            pictureBox1 = new PictureBox();
            lblSubtitle = new Label();
            btnAssign = new Label();
            lblTitle = new Label();
            txtHistory = new TextBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            lblSubtitle.Text = "Add new medical history";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAssign
            // 
            btnAssign.BackColor = Color.FromArgb(102, 126, 234);
            btnAssign.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnAssign.ForeColor = Color.White;
            btnAssign.Location = new Point(53, 315);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(234, 35);
            btnAssign.TabIndex = 10;
            btnAssign.Text = "Report History";
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
            lblTitle.Text = "Medical History";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtHistory
            // 
            txtHistory.BackColor = Color.FromArgb(237, 242, 246);
            txtHistory.BorderStyle = BorderStyle.None;
            txtHistory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtHistory.ForeColor = Color.FromArgb(110, 114, 117);
            txtHistory.Location = new Point(63, 155);
            txtHistory.Multiline = true;
            txtHistory.Name = "txtHistory";
            txtHistory.PlaceholderText = "Fractured nose";
            txtHistory.Size = new Size(214, 137);
            txtHistory.TabIndex = 1;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(205, 212, 230);
            pictureBox6.Location = new Point(53, 298);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(234, 3);
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(237, 242, 246);
            pictureBox7.Location = new Point(53, 146);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(234, 155);
            pictureBox7.TabIndex = 13;
            pictureBox7.TabStop = false;
            // 
            // AddMedicalHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(334, 359);
            Controls.Add(txtHistory);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox7);
            Controls.Add(btnAssign);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddMedicalHistoryForm";
            ShowIcon = false;
            Text = "Hospital Management System";
            FormClosed += AddMedicalHistoryForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblSubtitle;
        private Label btnAssign;
        private Label lblTitle;
        private TextBox txtHistory;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
    }
}