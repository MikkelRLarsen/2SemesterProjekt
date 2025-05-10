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
            label10 = new Label();
            MedicineStatusLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)PetPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CollapsePictureBox).BeginInit();
            SuspendLayout();
            // 
            // PetPicture
            // 
            PetPicture.Image = Properties.Resources.member;
            PetPicture.Location = new Point(9, 9);
            PetPicture.Name = "PetPicture";
            PetPicture.Size = new Size(97, 104);
            PetPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            PetPicture.TabIndex = 12;
            PetPicture.TabStop = false;
            // 
            // ExaminationLabel
            // 
            ExaminationLabel.AutoSize = true;
            ExaminationLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExaminationLabel.Location = new Point(454, 23);
            ExaminationLabel.Name = "ExaminationLabel";
            ExaminationLabel.Size = new Size(165, 19);
            ExaminationLabel.TabIndex = 21;
            ExaminationLabel.Text = "Behandling/Operation";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(350, 23);
            label3.Name = "label3";
            label3.Size = new Size(92, 19);
            label3.TabIndex = 20;
            label3.Text = "Behandling:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(113, 53);
            label5.Name = "label5";
            label5.Size = new Size(36, 19);
            label5.TabIndex = 15;
            label5.Text = "Art:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(350, 53);
            label7.Name = "label7";
            label7.Size = new Size(47, 19);
            label7.TabIndex = 22;
            label7.Text = "Dato:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(113, 83);
            label1.Name = "label1";
            label1.Size = new Size(45, 19);
            label1.TabIndex = 17;
            label1.Text = "Født:";
            // 
            // PetSpeciesLabel
            // 
            PetSpeciesLabel.AutoSize = true;
            PetSpeciesLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PetSpeciesLabel.Location = new Point(181, 53);
            PetSpeciesLabel.Name = "PetSpeciesLabel";
            PetSpeciesLabel.Size = new Size(78, 19);
            PetSpeciesLabel.TabIndex = 16;
            PetSpeciesLabel.Text = "Hund/Kat";
            PetSpeciesLabel.UseMnemonic = false;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateLabel.Location = new Point(454, 53);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(95, 19);
            DateLabel.TabIndex = 23;
            DateLabel.Text = "##/##/####";
            DateLabel.UseMnemonic = false;
            // 
            // customerNumberLabel
            // 
            customerNumberLabel.AutoSize = true;
            customerNumberLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerNumberLabel.Location = new Point(113, 23);
            customerNumberLabel.Name = "customerNumberLabel";
            customerNumberLabel.Size = new Size(50, 19);
            customerNumberLabel.TabIndex = 13;
            customerNumberLabel.Text = "Navn:";
            // 
            // PetNameLabel
            // 
            PetNameLabel.AutoSize = true;
            PetNameLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PetNameLabel.Location = new Point(181, 23);
            PetNameLabel.Name = "PetNameLabel";
            PetNameLabel.Size = new Size(27, 19);
            PetNameLabel.TabIndex = 14;
            PetNameLabel.Text = "##";
            // 
            // CollapsePictureBox
            // 
            CollapsePictureBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CollapsePictureBox.Location = new Point(626, 178);
            CollapsePictureBox.Margin = new Padding(2);
            CollapsePictureBox.Name = "CollapsePictureBox";
            CollapsePictureBox.Size = new Size(60, 45);
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
            label2.Location = new Point(350, 83);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 25;
            label2.Text = "Status:";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StatusLabel.Location = new Point(454, 83);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(154, 19);
            StatusLabel.TabIndex = 26;
            StatusLabel.Text = "Kommende/Afslutet";
            StatusLabel.UseMnemonic = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(28, 141);
            label11.Name = "label11";
            label11.Size = new Size(147, 19);
            label11.TabIndex = 27;
            label11.Text = "Kontaktoplysninger";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(28, 198);
            label8.Name = "label8";
            label8.Size = new Size(32, 19);
            label8.TabIndex = 30;
            label8.Text = "Tlf:";
            // 
            // CustomerPhoneNumberLabel
            // 
            CustomerPhoneNumberLabel.AutoSize = true;
            CustomerPhoneNumberLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerPhoneNumberLabel.Location = new Point(139, 198);
            CustomerPhoneNumberLabel.Name = "CustomerPhoneNumberLabel";
            CustomerPhoneNumberLabel.Size = new Size(81, 19);
            CustomerPhoneNumberLabel.TabIndex = 31;
            CustomerPhoneNumberLabel.Text = "########";
            CustomerPhoneNumberLabel.UseMnemonic = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(28, 172);
            label12.Name = "label12";
            label12.Size = new Size(99, 19);
            label12.TabIndex = 28;
            label12.Text = "Kunde Navn:";
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.AutoSize = true;
            CustomerNameLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerNameLabel.Location = new Point(139, 172);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(108, 19);
            CustomerNameLabel.TabIndex = 29;
            CustomerNameLabel.Text = "###########";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(350, 172);
            label9.Name = "label9";
            label9.Size = new Size(120, 19);
            label9.TabIndex = 32;
            label9.Text = "Dyrelæge Navn:";
            // 
            // EmployeeNameLabel
            // 
            EmployeeNameLabel.AutoSize = true;
            EmployeeNameLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmployeeNameLabel.Location = new Point(485, 172);
            EmployeeNameLabel.Name = "EmployeeNameLabel";
            EmployeeNameLabel.Size = new Size(108, 19);
            EmployeeNameLabel.TabIndex = 33;
            EmployeeNameLabel.Text = "###########";
            // 
            // BirthdayLabel
            // 
            BirthdayLabel.AutoSize = true;
            BirthdayLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BirthdayLabel.Location = new Point(181, 83);
            BirthdayLabel.Name = "BirthdayLabel";
            BirthdayLabel.Size = new Size(95, 19);
            BirthdayLabel.TabIndex = 34;
            BirthdayLabel.Text = "##/##/####";
            BirthdayLabel.UseMnemonic = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(350, 113);
            label10.Name = "label10";
            label10.Size = new Size(68, 19);
            label10.TabIndex = 35;
            label10.Text = "Medicin:";
            // 
            // MedicineStatusLabel
            // 
            MedicineStatusLabel.AutoSize = true;
            MedicineStatusLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MedicineStatusLabel.Location = new Point(454, 113);
            MedicineStatusLabel.Name = "MedicineStatusLabel";
            MedicineStatusLabel.Size = new Size(180, 19);
            MedicineStatusLabel.TabIndex = 36;
            MedicineStatusLabel.Text = "Ja/Nej/Vides ikke endnu";
            MedicineStatusLabel.UseMnemonic = false;
            // 
            // ExaminationCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(MedicineStatusLabel);
            Controls.Add(label10);
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
            Margin = new Padding(0, 3, 0, 3);
            Name = "ExaminationCard";
            Size = new Size(686, 223);
            Click += ExaminationCard_Click;
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
        private Label label10;
        private Label MedicineStatusLabel;
    }
}
