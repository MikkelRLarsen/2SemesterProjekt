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
			PetPicture = new PictureBox();
			ExaminationLabel = new Label();
			label3 = new Label();
			label5 = new Label();
			label7 = new Label();
			label1 = new Label();
			PetSpeciesLabel = new Label();
			DateLabel = new Label();
			customerNumberLabel = new Label();
			PetNameLabel = new Label();
			CollapsePictureBox = new PictureBox();
			collapseTimer = new System.Windows.Forms.Timer(components);
			label2 = new Label();
			StatusLabel = new Label();
			label11 = new Label();
			label8 = new Label();
			CustomerPhoneNumberLabel = new Label();
			label12 = new Label();
			CustomerNameLabel = new Label();
			label9 = new Label();
			EmployeeNameLabel = new Label();
			BirthdayLabel = new Label();
			((System.ComponentModel.ISupportInitialize)PetPicture).BeginInit();
			((System.ComponentModel.ISupportInitialize)CollapsePictureBox).BeginInit();
			SuspendLayout();
			// 
			// PetPicture
			// 
			PetPicture.Image = Properties.Resources.member;
			PetPicture.Location = new Point(13, 15);
			PetPicture.Margin = new Padding(4, 5, 4, 5);
			PetPicture.Name = "PetPicture";
			PetPicture.Size = new Size(139, 174);
			PetPicture.SizeMode = PictureBoxSizeMode.StretchImage;
			PetPicture.TabIndex = 12;
			PetPicture.TabStop = false;
			// 
			// ExaminationLabel
			// 
			ExaminationLabel.AutoSize = true;
			ExaminationLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			ExaminationLabel.Location = new Point(649, 38);
			ExaminationLabel.Margin = new Padding(4, 0, 4, 0);
			ExaminationLabel.Name = "ExaminationLabel";
			ExaminationLabel.Size = new Size(253, 27);
			ExaminationLabel.TabIndex = 21;
			ExaminationLabel.Text = "Behandling/Operation";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(500, 38);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(141, 27);
			label3.TabIndex = 20;
			label3.Text = "Behandling:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.Location = new Point(161, 88);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(52, 27);
			label5.TabIndex = 15;
			label5.Text = "Art:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label7.Location = new Point(500, 88);
			label7.Margin = new Padding(4, 0, 4, 0);
			label7.Name = "label7";
			label7.Size = new Size(70, 27);
			label7.TabIndex = 22;
			label7.Text = "Dato:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(161, 138);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(67, 27);
			label1.TabIndex = 17;
			label1.Text = "Født:";
			// 
			// PetSpeciesLabel
			// 
			PetSpeciesLabel.AutoSize = true;
			PetSpeciesLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			PetSpeciesLabel.Location = new Point(258, 88);
			PetSpeciesLabel.Margin = new Padding(4, 0, 4, 0);
			PetSpeciesLabel.Name = "PetSpeciesLabel";
			PetSpeciesLabel.Size = new Size(118, 27);
			PetSpeciesLabel.TabIndex = 16;
			PetSpeciesLabel.Text = "Hund/Kat";
			PetSpeciesLabel.UseMnemonic = false;
			// 
			// DateLabel
			// 
			DateLabel.AutoSize = true;
			DateLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			DateLabel.Location = new Point(649, 88);
			DateLabel.Margin = new Padding(4, 0, 4, 0);
			DateLabel.Name = "DateLabel";
			DateLabel.Size = new Size(144, 27);
			DateLabel.TabIndex = 23;
			DateLabel.Text = "##/##/####";
			DateLabel.UseMnemonic = false;
			// 
			// customerNumberLabel
			// 
			customerNumberLabel.AutoSize = true;
			customerNumberLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			customerNumberLabel.Location = new Point(161, 38);
			customerNumberLabel.Margin = new Padding(4, 0, 4, 0);
			customerNumberLabel.Name = "customerNumberLabel";
			customerNumberLabel.Size = new Size(74, 27);
			customerNumberLabel.TabIndex = 13;
			customerNumberLabel.Text = "Navn:";
			// 
			// PetNameLabel
			// 
			PetNameLabel.AutoSize = true;
			PetNameLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			PetNameLabel.Location = new Point(258, 38);
			PetNameLabel.Margin = new Padding(4, 0, 4, 0);
			PetNameLabel.Name = "PetNameLabel";
			PetNameLabel.Size = new Size(40, 27);
			PetNameLabel.TabIndex = 14;
			PetNameLabel.Text = "##";
			// 
			// CollapsePictureBox
			// 
			CollapsePictureBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			CollapsePictureBox.Location = new Point(895, 296);
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
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(500, 138);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(85, 27);
			label2.TabIndex = 25;
			label2.Text = "Status:";
			// 
			// StatusLabel
			// 
			StatusLabel.AutoSize = true;
			StatusLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			StatusLabel.Location = new Point(649, 138);
			StatusLabel.Margin = new Padding(4, 0, 4, 0);
			StatusLabel.Name = "StatusLabel";
			StatusLabel.Size = new Size(231, 27);
			StatusLabel.TabIndex = 26;
			StatusLabel.Text = "Kommende/Afslutet";
			StatusLabel.UseMnemonic = false;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label11.Location = new Point(40, 235);
			label11.Margin = new Padding(4, 0, 4, 0);
			label11.Name = "label11";
			label11.Size = new Size(225, 27);
			label11.TabIndex = 27;
			label11.Text = "Kontaktoplysninger";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label8.Location = new Point(40, 330);
			label8.Margin = new Padding(4, 0, 4, 0);
			label8.Name = "label8";
			label8.Size = new Size(47, 27);
			label8.TabIndex = 30;
			label8.Text = "Tlf:";
			// 
			// CustomerPhoneNumberLabel
			// 
			CustomerPhoneNumberLabel.AutoSize = true;
			CustomerPhoneNumberLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			CustomerPhoneNumberLabel.Location = new Point(199, 330);
			CustomerPhoneNumberLabel.Margin = new Padding(4, 0, 4, 0);
			CustomerPhoneNumberLabel.Name = "CustomerPhoneNumberLabel";
			CustomerPhoneNumberLabel.Size = new Size(124, 27);
			CustomerPhoneNumberLabel.TabIndex = 31;
			CustomerPhoneNumberLabel.Text = "########";
			CustomerPhoneNumberLabel.UseMnemonic = false;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label12.Location = new Point(40, 287);
			label12.Margin = new Padding(4, 0, 4, 0);
			label12.Name = "label12";
			label12.Size = new Size(149, 27);
			label12.TabIndex = 28;
			label12.Text = "Kunde Navn:";
			// 
			// CustomerNameLabel
			// 
			CustomerNameLabel.AutoSize = true;
			CustomerNameLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			CustomerNameLabel.Location = new Point(199, 287);
			CustomerNameLabel.Margin = new Padding(4, 0, 4, 0);
			CustomerNameLabel.Name = "CustomerNameLabel";
			CustomerNameLabel.Size = new Size(166, 27);
			CustomerNameLabel.TabIndex = 29;
			CustomerNameLabel.Text = "###########";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label9.Location = new Point(500, 287);
			label9.Margin = new Padding(4, 0, 4, 0);
			label9.Name = "label9";
			label9.Size = new Size(182, 27);
			label9.TabIndex = 32;
			label9.Text = "Dyrelæge Navn:";
			// 
			// EmployeeNameLabel
			// 
			EmployeeNameLabel.AutoSize = true;
			EmployeeNameLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			EmployeeNameLabel.Location = new Point(693, 287);
			EmployeeNameLabel.Margin = new Padding(4, 0, 4, 0);
			EmployeeNameLabel.Name = "EmployeeNameLabel";
			EmployeeNameLabel.Size = new Size(166, 27);
			EmployeeNameLabel.TabIndex = 33;
			EmployeeNameLabel.Text = "###########";
			// 
			// BirthdayLabel
			// 
			BirthdayLabel.AutoSize = true;
			BirthdayLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			BirthdayLabel.Location = new Point(258, 138);
			BirthdayLabel.Margin = new Padding(4, 0, 4, 0);
			BirthdayLabel.Name = "BirthdayLabel";
			BirthdayLabel.Size = new Size(144, 27);
			BirthdayLabel.TabIndex = 34;
			BirthdayLabel.Text = "##/##/####";
			BirthdayLabel.UseMnemonic = false;
			// 
			// ExaminationCard
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BorderStyle = BorderStyle.FixedSingle;
			Controls.Add(BirthdayLabel);
			Controls.Add(label9);
			Controls.Add(EmployeeNameLabel);
			Controls.Add(label8);
			Controls.Add(CustomerPhoneNumberLabel);
			Controls.Add(label12);
			Controls.Add(CustomerNameLabel);
			Controls.Add(label11);
			Controls.Add(label2);
			Controls.Add(StatusLabel);
			Controls.Add(CollapsePictureBox);
			Controls.Add(PetPicture);
			Controls.Add(ExaminationLabel);
			Controls.Add(label3);
			Controls.Add(label5);
			Controls.Add(label7);
			Controls.Add(label1);
			Controls.Add(PetSpeciesLabel);
			Controls.Add(DateLabel);
			Controls.Add(customerNumberLabel);
			Controls.Add(PetNameLabel);
			Margin = new Padding(0, 5, 0, 5);
			Name = "ExaminationCard";
			Size = new Size(980, 371);
			((System.ComponentModel.ISupportInitialize)PetPicture).EndInit();
			((System.ComponentModel.ISupportInitialize)CollapsePictureBox).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox PetPicture;
		private Label ExaminationLabel;
		private Label label3;
		private Label label5;
		private Label label7;
		private Label label1;
		private Label PetSpeciesLabel;
		private Label DateLabel;
		private Label customerNumberLabel;
		private Label PetNameLabel;
		private PictureBox CollapsePictureBox;
		private System.Windows.Forms.Timer collapseTimer;
		private Label label2;
		private Label StatusLabel;
		private Label label11;
		private Label label8;
		private Label CustomerPhoneNumberLabel;
		private Label label12;
		private Label CustomerNameLabel;
		private Label label9;
		private Label EmployeeNameLabel;
		private Label BirthdayLabel;
	}
}
