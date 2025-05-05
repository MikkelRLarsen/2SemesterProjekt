namespace _2SemesterProjekt.Pages.UserControls.ExaminationUserControl
{
	partial class ExaminationCard
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
			components = new System.ComponentModel.Container();
			profilePicture = new PictureBox();
			customerPhoneNumberLabel = new Label();
			label3 = new Label();
			label2 = new Label();
			label5 = new Label();
			label7 = new Label();
			label1 = new Label();
			PetNameLabel = new Label();
			label6 = new Label();
			customerNumberLabel = new Label();
			customerNameLabel = new Label();
			customerIdLabel = new Label();
			CollapsePictureBox = new PictureBox();
			collapseTimer = new System.Windows.Forms.Timer(components);
			((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
			((System.ComponentModel.ISupportInitialize)CollapsePictureBox).BeginInit();
			SuspendLayout();
			// 
			// profilePicture
			// 
			profilePicture.Image = Properties.Resources.member;
			profilePicture.Location = new Point(13, 15);
			profilePicture.Margin = new Padding(4, 5, 4, 5);
			profilePicture.Name = "profilePicture";
			profilePicture.Size = new Size(139, 174);
			profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
			profilePicture.TabIndex = 12;
			profilePicture.TabStop = false;
			// 
			// customerPhoneNumberLabel
			// 
			customerPhoneNumberLabel.AutoSize = true;
			customerPhoneNumberLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			customerPhoneNumberLabel.Location = new Point(709, 75);
			customerPhoneNumberLabel.Margin = new Padding(4, 0, 4, 0);
			customerPhoneNumberLabel.Name = "customerPhoneNumberLabel";
			customerPhoneNumberLabel.Size = new Size(116, 27);
			customerPhoneNumberLabel.TabIndex = 21;
			customerPhoneNumberLabel.Text = "12345678";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(620, 75);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(47, 27);
			label3.TabIndex = 20;
			label3.Text = "Tlf:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(620, 25);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(225, 27);
			label2.TabIndex = 19;
			label2.Text = "Kontaktoplysninger";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.Location = new Point(195, 75);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(74, 27);
			label5.TabIndex = 15;
			label5.Text = "Navn:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label7.Location = new Point(620, 125);
			label7.Margin = new Padding(4, 0, 4, 0);
			label7.Name = "label7";
			label7.Size = new Size(77, 27);
			label7.TabIndex = 22;
			label7.Text = "Email:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(195, 125);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(101, 27);
			label1.TabIndex = 17;
			label1.Text = "Adresse:";
			// 
			// PetNameLabel
			// 
			PetNameLabel.AutoSize = true;
			PetNameLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			PetNameLabel.Location = new Point(307, 75);
			PetNameLabel.Margin = new Padding(4, 0, 4, 0);
			PetNameLabel.Name = "PetNameLabel";
			PetNameLabel.Size = new Size(110, 27);
			PetNameLabel.TabIndex = 16;
			PetNameLabel.Text = "PetName";
			PetNameLabel.UseMnemonic = false;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.Location = new Point(709, 125);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(199, 27);
			label6.TabIndex = 23;
			label6.Text = "mail@outlook.dk";
			label6.UseMnemonic = false;
			// 
			// customerNumberLabel
			// 
			customerNumberLabel.AutoSize = true;
			customerNumberLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			customerNumberLabel.Location = new Point(195, 25);
			customerNumberLabel.Margin = new Padding(4, 0, 4, 0);
			customerNumberLabel.Name = "customerNumberLabel";
			customerNumberLabel.Size = new Size(110, 27);
			customerNumberLabel.TabIndex = 13;
			customerNumberLabel.Text = "Kundenr:";
			// 
			// customerNameLabel
			// 
			customerNameLabel.AutoSize = true;
			customerNameLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			customerNameLabel.Location = new Point(307, 125);
			customerNameLabel.Margin = new Padding(4, 0, 4, 0);
			customerNameLabel.Name = "customerNameLabel";
			customerNameLabel.Size = new Size(200, 27);
			customerNameLabel.TabIndex = 18;
			customerNameLabel.Text = "CustomerAddress";
			customerNameLabel.UseMnemonic = false;
			// 
			// customerIdLabel
			// 
			customerIdLabel.AutoSize = true;
			customerIdLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			customerIdLabel.Location = new Point(307, 25);
			customerIdLabel.Margin = new Padding(4, 0, 4, 0);
			customerIdLabel.Name = "customerIdLabel";
			customerIdLabel.Size = new Size(40, 27);
			customerIdLabel.TabIndex = 14;
			customerIdLabel.Text = "##";
			// 
			// CollapsePictureBox
			// 
			CollapsePictureBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			CollapsePictureBox.Image = Properties.Resources.collapseArrow;
			CollapsePictureBox.Location = new Point(915, 298);
			CollapsePictureBox.Name = "CollapsePictureBox";
			CollapsePictureBox.Size = new Size(85, 75);
			CollapsePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
			CollapsePictureBox.TabIndex = 24;
			CollapsePictureBox.TabStop = false;
			CollapsePictureBox.Click += CollapsePictureBox_Click;
			// 
			// collapseTimer
			// 
			collapseTimer.Tick += collapseTimer_Tick;
			// 
			// ExaminationCard
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(CollapsePictureBox);
			Controls.Add(profilePicture);
			Controls.Add(customerPhoneNumberLabel);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label5);
			Controls.Add(label7);
			Controls.Add(label1);
			Controls.Add(PetNameLabel);
			Controls.Add(label6);
			Controls.Add(customerNumberLabel);
			Controls.Add(customerNameLabel);
			Controls.Add(customerIdLabel);
			Margin = new Padding(4, 5, 4, 5);
			Name = "ExaminationCard";
			Size = new Size(1000, 373);
			((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
			((System.ComponentModel.ISupportInitialize)CollapsePictureBox).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox profilePicture;
		private Label customerPhoneNumberLabel;
		private Label label3;
		private Label label2;
		private Label label5;
		private Label label7;
		private Label label1;
		private Label PetNameLabel;
		private Label label6;
		private Label customerNumberLabel;
		private Label customerNameLabel;
		private Label customerIdLabel;
		private PictureBox CollapsePictureBox;
		private System.Windows.Forms.Timer collapseTimer;
	}
}
