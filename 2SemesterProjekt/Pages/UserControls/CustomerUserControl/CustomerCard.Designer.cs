namespace _2SemesterProjekt
{
	partial class CustomerCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            profilePicture = new PictureBox();
            customerIdLabel = new Label();
            customerAddressLabel = new Label();
            label = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            customerPhoneNumberLabel = new Label();
            customerNameLabel = new Label();
            label5 = new Label();
            customerEmailLabel = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
            SuspendLayout();
            // 
            // profilePicture
            // 
            profilePicture.Anchor = AnchorStyles.Left;
            profilePicture.Image = Properties.Resources.member;
            profilePicture.Location = new Point(6, 4);
            profilePicture.Margin = new Padding(3, 4, 3, 4);
            profilePicture.Name = "profilePicture";
            profilePicture.Size = new Size(68, 80);
            profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePicture.TabIndex = 0;
            profilePicture.TabStop = false;
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Font = new Font("Gadugi", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerIdLabel.Location = new Point(144, 7);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new Size(21, 16);
            customerIdLabel.TabIndex = 2;
            customerIdLabel.Text = "##";
            // 
            // customerAddressLabel
            // 
            customerAddressLabel.AutoSize = true;
            customerAddressLabel.Font = new Font("Gadugi", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerAddressLabel.Location = new Point(144, 47);
            customerAddressLabel.Name = "customerAddressLabel";
            customerAddressLabel.Size = new Size(105, 16);
            customerAddressLabel.TabIndex = 6;
            customerAddressLabel.Text = "CustomerAddress";
            customerAddressLabel.UseMnemonic = false;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Gadugi", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(80, 7);
            label.Name = "label";
            label.Size = new Size(58, 16);
            label.TabIndex = 1;
            label.Text = "Kundenr:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(80, 47);
            label1.Name = "label1";
            label1.Size = new Size(54, 16);
            label1.TabIndex = 5;
            label1.Text = "Adresse:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(270, 7);
            label2.Name = "label2";
            label2.Size = new Size(116, 16);
            label2.TabIndex = 7;
            label2.Text = "Kontaktoplysninger";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(270, 27);
            label3.Name = "label3";
            label3.Size = new Size(25, 16);
            label3.TabIndex = 8;
            label3.Text = "Tlf:";
            // 
            // customerPhoneNumberLabel
            // 
            customerPhoneNumberLabel.AutoSize = true;
            customerPhoneNumberLabel.Font = new Font("Gadugi", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerPhoneNumberLabel.Location = new Point(323, 27);
            customerPhoneNumberLabel.Name = "customerPhoneNumberLabel";
            customerPhoneNumberLabel.Size = new Size(63, 16);
            customerPhoneNumberLabel.TabIndex = 9;
            customerPhoneNumberLabel.Text = "12345678";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Font = new Font("Gadugi", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerNameLabel.Location = new Point(144, 27);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new Size(94, 16);
            customerNameLabel.TabIndex = 4;
            customerNameLabel.Text = "CustomerName";
            customerNameLabel.UseMnemonic = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(80, 27);
            label5.Name = "label5";
            label5.Size = new Size(39, 16);
            label5.TabIndex = 3;
            label5.Text = "Navn:";
            // 
            // customerEmailLabel
            // 
            customerEmailLabel.AutoSize = true;
            customerEmailLabel.Font = new Font("Gadugi", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerEmailLabel.Location = new Point(323, 47);
            customerEmailLabel.Name = "customerEmailLabel";
            customerEmailLabel.Size = new Size(101, 16);
            customerEmailLabel.TabIndex = 11;
            customerEmailLabel.Text = "mail@outlook.dk";
            customerEmailLabel.UseMnemonic = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gadugi", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(270, 47);
            label7.Name = "label7";
            label7.Size = new Size(39, 16);
            label7.TabIndex = 10;
            label7.Text = "Email:";
            // 
            // CustomerCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            Controls.Add(profilePicture);
            Controls.Add(customerPhoneNumberLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(customerNameLabel);
            Controls.Add(customerEmailLabel);
            Controls.Add(label);
            Controls.Add(customerAddressLabel);
            Controls.Add(customerIdLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerCard";
            Size = new Size(480, 88);
            ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox profilePicture;
		private Label customerIdLabel;
		private Label customerAddressLabel;
		private Label label;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label customerPhoneNumberLabel;
		private Label customerNameLabel;
		private Label label5;
		private Label customerEmailLabel;
		private Label label7;


	}
}
