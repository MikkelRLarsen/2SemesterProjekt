namespace _2SemesterProjekt.Pages.UserControls.ExaminationUserControl
{
	partial class UpdateExaminationUserControl
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
			DateTimePickerExamination = new DateTimePicker();
			GemExaminationButton = new Button();
			CancelExaminationButton = new Button();
			EmployeeExaminationDropdown = new ComboBox();
			label7 = new Label();
			label6 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			label5 = new Label();
			CustomerTextBox = new TextBox();
			PetTextBox = new TextBox();
			ExaminationTextBox = new TextBox();
			PriceTextBox = new TextBox();
			SuspendLayout();
			// 
			// DateTimePickerExamination
			// 
			DateTimePickerExamination.Location = new Point(256, 325);
			DateTimePickerExamination.Name = "DateTimePickerExamination";
			DateTimePickerExamination.Size = new Size(207, 23);
			DateTimePickerExamination.TabIndex = 30;
			// 
			// GemExaminationButton
			// 
			GemExaminationButton.BackColor = Color.MediumSeaGreen;
			GemExaminationButton.FlatStyle = FlatStyle.Popup;
			GemExaminationButton.Location = new Point(406, 486);
			GemExaminationButton.Name = "GemExaminationButton";
			GemExaminationButton.Size = new Size(170, 58);
			GemExaminationButton.TabIndex = 29;
			GemExaminationButton.Text = "Gem";
			GemExaminationButton.UseVisualStyleBackColor = false;
			GemExaminationButton.Click += GemExaminationButton_Click;
			// 
			// CancelExaminationButton
			// 
			CancelExaminationButton.BackColor = Color.IndianRed;
			CancelExaminationButton.FlatStyle = FlatStyle.Popup;
			CancelExaminationButton.Location = new Point(103, 486);
			CancelExaminationButton.Name = "CancelExaminationButton";
			CancelExaminationButton.Size = new Size(170, 58);
			CancelExaminationButton.TabIndex = 28;
			CancelExaminationButton.Text = "Annuller";
			CancelExaminationButton.UseVisualStyleBackColor = false;
			CancelExaminationButton.Click += CancelExaminationButton_Click;
			// 
			// EmployeeExaminationDropdown
			// 
			EmployeeExaminationDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
			EmployeeExaminationDropdown.FormattingEnabled = true;
			EmployeeExaminationDropdown.Location = new Point(256, 374);
			EmployeeExaminationDropdown.Name = "EmployeeExaminationDropdown";
			EmployeeExaminationDropdown.Size = new Size(207, 23);
			EmployeeExaminationDropdown.TabIndex = 27;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label7.Location = new Point(148, 374);
			label7.Name = "label7";
			label7.Size = new Size(102, 19);
			label7.TabIndex = 26;
			label7.Text = "Medarbejder:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.Location = new Point(215, 325);
			label6.Name = "label6";
			label6.Size = new Size(35, 19);
			label6.TabIndex = 25;
			label6.Text = "Tid:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.Location = new Point(215, 279);
			label4.Name = "label4";
			label4.Size = new Size(39, 19);
			label4.TabIndex = 24;
			label4.Text = "Pris:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(148, 235);
			label3.Name = "label3";
			label3.Size = new Size(103, 19);
			label3.TabIndex = 23;
			label3.Text = "Konsultation:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(181, 194);
			label2.Name = "label2";
			label2.Size = new Size(70, 19);
			label2.TabIndex = 22;
			label2.Text = "Kæledyr:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Gadugi", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(49, 36);
			label1.Name = "label1";
			label1.Size = new Size(635, 77);
			label1.TabIndex = 21;
			label1.Text = "Ændre Konsultation";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.Location = new Point(193, 155);
			label5.Name = "label5";
			label5.Size = new Size(58, 19);
			label5.TabIndex = 20;
			label5.Text = "Kunde:";
			// 
			// CustomerTextBox
			// 
			CustomerTextBox.Enabled = false;
			CustomerTextBox.Location = new Point(257, 155);
			CustomerTextBox.Name = "CustomerTextBox";
			CustomerTextBox.Size = new Size(206, 23);
			CustomerTextBox.TabIndex = 35;
			// 
			// PetTextBox
			// 
			PetTextBox.Enabled = false;
			PetTextBox.Location = new Point(258, 194);
			PetTextBox.Name = "PetTextBox";
			PetTextBox.Size = new Size(206, 23);
			PetTextBox.TabIndex = 36;
			// 
			// ExaminationTextBox
			// 
			ExaminationTextBox.Enabled = false;
			ExaminationTextBox.Location = new Point(258, 235);
			ExaminationTextBox.Name = "ExaminationTextBox";
			ExaminationTextBox.Size = new Size(206, 23);
			ExaminationTextBox.TabIndex = 37;
			// 
			// PriceTextBox
			// 
			PriceTextBox.Enabled = false;
			PriceTextBox.Location = new Point(258, 279);
			PriceTextBox.Name = "PriceTextBox";
			PriceTextBox.Size = new Size(206, 23);
			PriceTextBox.TabIndex = 38;
			// 
			// UpdateExaminationUserControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(PriceTextBox);
			Controls.Add(ExaminationTextBox);
			Controls.Add(PetTextBox);
			Controls.Add(CustomerTextBox);
			Controls.Add(DateTimePickerExamination);
			Controls.Add(GemExaminationButton);
			Controls.Add(CancelExaminationButton);
			Controls.Add(EmployeeExaminationDropdown);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(label5);
			Name = "UpdateExaminationUserControl";
			Size = new Size(709, 580);
			Load += UpdateExaminationUserControl_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DateTimePicker DateTimePickerExamination;
		private Button GemExaminationButton;
		private Button CancelExaminationButton;
		private ComboBox EmployeeExaminationDropdown;
		private Label label7;
		private Label label6;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private Label label5;
		private TextBox CustomerTextBox;
		private TextBox PetTextBox;
		private TextBox ExaminationTextBox;
		private TextBox PriceTextBox;
	}
}
