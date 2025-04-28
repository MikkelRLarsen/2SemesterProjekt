namespace _2SemesterProjekt.Pages.UserControls.ExaminationUserControl
{
	partial class CreateExaminationUserControl
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
			label5 = new Label();
			label1 = new Label();
			CustomerExaminationDropdown = new ComboBox();
			PetExaminationDropdown = new ComboBox();
			label2 = new Label();
			ExaminationDropdown = new ComboBox();
			label3 = new Label();
			PriceExaminationDropdown = new ComboBox();
			label4 = new Label();
			label6 = new Label();
			EmployeeExaminationDropdown = new ComboBox();
			label7 = new Label();
			CreateExaminationButton = new Button();
			CancelExaminationButton = new Button();
			DateTimePickerExamination = new DateTimePicker();
			ErrorMessageExamination = new Label();
			SuspendLayout();
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.Location = new Point(204, 149);
			label5.Name = "label5";
			label5.Size = new Size(58, 19);
			label5.TabIndex = 4;
			label5.Text = "Kunde:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Gadugi", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(53, 31);
			label1.Name = "label1";
			label1.Size = new Size(610, 77);
			label1.TabIndex = 5;
			label1.Text = "Opret Konsultation";
			// 
			// CustomerExaminationDropdown
			// 
			CustomerExaminationDropdown.FormattingEnabled = true;
			CustomerExaminationDropdown.Location = new Point(260, 149);
			CustomerExaminationDropdown.Name = "CustomerExaminationDropdown";
			CustomerExaminationDropdown.Size = new Size(207, 23);
			CustomerExaminationDropdown.TabIndex = 6;
			CustomerExaminationDropdown.SelectedIndexChanged += CustomerExaminationDropdown_SelectedIndexChanged;
			// 
			// PetExaminationDropdown
			// 
			PetExaminationDropdown.Enabled = false;
			PetExaminationDropdown.FormattingEnabled = true;
			PetExaminationDropdown.Location = new Point(260, 189);
			PetExaminationDropdown.Name = "PetExaminationDropdown";
			PetExaminationDropdown.Size = new Size(207, 23);
			PetExaminationDropdown.TabIndex = 8;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(185, 189);
			label2.Name = "label2";
			label2.Size = new Size(70, 19);
			label2.TabIndex = 7;
			label2.Text = "Kæledyr:";
			// 
			// ExaminationDropdown
			// 
			ExaminationDropdown.Enabled = false;
			ExaminationDropdown.FormattingEnabled = true;
			ExaminationDropdown.Location = new Point(260, 230);
			ExaminationDropdown.Name = "ExaminationDropdown";
			ExaminationDropdown.Size = new Size(207, 23);
			ExaminationDropdown.TabIndex = 10;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(152, 230);
			label3.Name = "label3";
			label3.Size = new Size(103, 19);
			label3.TabIndex = 9;
			label3.Text = "Konsultation:";
			// 
			// PriceExaminationDropdown
			// 
			PriceExaminationDropdown.Enabled = false;
			PriceExaminationDropdown.FormattingEnabled = true;
			PriceExaminationDropdown.Location = new Point(260, 270);
			PriceExaminationDropdown.Name = "PriceExaminationDropdown";
			PriceExaminationDropdown.Size = new Size(207, 23);
			PriceExaminationDropdown.TabIndex = 12;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.Location = new Point(219, 270);
			label4.Name = "label4";
			label4.Size = new Size(39, 19);
			label4.TabIndex = 11;
			label4.Text = "Pris:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.Location = new Point(219, 316);
			label6.Name = "label6";
			label6.Size = new Size(35, 19);
			label6.TabIndex = 13;
			label6.Text = "Tid:";
			// 
			// EmployeeExaminationDropdown
			// 
			EmployeeExaminationDropdown.Enabled = false;
			EmployeeExaminationDropdown.FormattingEnabled = true;
			EmployeeExaminationDropdown.Location = new Point(260, 365);
			EmployeeExaminationDropdown.Name = "EmployeeExaminationDropdown";
			EmployeeExaminationDropdown.Size = new Size(207, 23);
			EmployeeExaminationDropdown.TabIndex = 16;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label7.Location = new Point(152, 365);
			label7.Name = "label7";
			label7.Size = new Size(102, 19);
			label7.TabIndex = 15;
			label7.Text = "Medarbejder:";
			// 
			// CreateExaminationButton
			// 
			CreateExaminationButton.BackColor = Color.MediumAquamarine;
			CreateExaminationButton.FlatStyle = FlatStyle.Popup;
			CreateExaminationButton.Location = new Point(410, 463);
			CreateExaminationButton.Name = "CreateExaminationButton";
			CreateExaminationButton.Size = new Size(170, 58);
			CreateExaminationButton.TabIndex = 18;
			CreateExaminationButton.Text = "Opret Konsultation";
			CreateExaminationButton.UseVisualStyleBackColor = false;
			// 
			// CancelExaminationButton
			// 
			CancelExaminationButton.BackColor = Color.IndianRed;
			CancelExaminationButton.FlatStyle = FlatStyle.Popup;
			CancelExaminationButton.Location = new Point(107, 463);
			CancelExaminationButton.Name = "CancelExaminationButton";
			CancelExaminationButton.Size = new Size(170, 58);
			CancelExaminationButton.TabIndex = 17;
			CancelExaminationButton.Text = "Annuller";
			CancelExaminationButton.UseVisualStyleBackColor = false;
			// 
			// DateTimePickerExamination
			// 
			DateTimePickerExamination.Enabled = false;
			DateTimePickerExamination.Location = new Point(260, 316);
			DateTimePickerExamination.Name = "DateTimePickerExamination";
			DateTimePickerExamination.Size = new Size(207, 23);
			DateTimePickerExamination.TabIndex = 19;
			// 
			// ErrorMessageExamination
			// 
			ErrorMessageExamination.AutoSize = true;
			ErrorMessageExamination.Location = new Point(311, 422);
			ErrorMessageExamination.Name = "ErrorMessageExamination";
			ErrorMessageExamination.Size = new Size(78, 15);
			ErrorMessageExamination.TabIndex = 20;
			ErrorMessageExamination.Text = "ErrorMessage";
			ErrorMessageExamination.Visible = false;
			// 
			// CreateExaminationUserControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(ErrorMessageExamination);
			Controls.Add(DateTimePickerExamination);
			Controls.Add(CreateExaminationButton);
			Controls.Add(CancelExaminationButton);
			Controls.Add(EmployeeExaminationDropdown);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(PriceExaminationDropdown);
			Controls.Add(label4);
			Controls.Add(ExaminationDropdown);
			Controls.Add(label3);
			Controls.Add(PetExaminationDropdown);
			Controls.Add(label2);
			Controls.Add(CustomerExaminationDropdown);
			Controls.Add(label1);
			Controls.Add(label5);
			Margin = new Padding(0);
			Name = "CreateExaminationUserControl";
			Size = new Size(709, 580);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label5;
		private Label label1;
		private ComboBox CustomerExaminationDropdown;
		private ComboBox PetExaminationDropdown;
		private Label label2;
		private ComboBox ExaminationDropdown;
		private Label label3;
		private ComboBox PriceExaminationDropdown;
		private Label label4;
		private ComboBox comboBox5;
		private Label label6;
		private ComboBox EmployeeExaminationDropdown;
		private Label label7;
		private Button CreateExaminationButton;
		private Button CancelExaminationButton;
		private DateTimePicker DateTimePickerExamination;
		private Label ErrorMessageExamination;
	}
}
