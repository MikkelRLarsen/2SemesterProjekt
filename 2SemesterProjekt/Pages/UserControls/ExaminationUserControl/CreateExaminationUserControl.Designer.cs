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
			ExaminationTypeDropdown = new ComboBox();
			label3 = new Label();
			label4 = new Label();
			label6 = new Label();
			EmployeeExaminationDropdown = new ComboBox();
			label7 = new Label();
			CreateExaminationButton = new Button();
			CancelExaminationButton = new Button();
			DateTimePickerExamination = new DateTimePicker();
			ErrorMessageExamination = new Label();
			PriceExaminationDisplay = new TextBox();
			DiscountLabel = new Label();
			DiscountNummericUpDown = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)DiscountNummericUpDown).BeginInit();
			SuspendLayout();
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.Location = new Point(281, 250);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(87, 27);
			label5.TabIndex = 4;
			label5.Text = "Kunde:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Gadugi", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(76, 52);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(911, 115);
			label1.TabIndex = 5;
			label1.Text = "Opret Konsultation";
			// 
			// CustomerExaminationDropdown
			// 
			CustomerExaminationDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
			CustomerExaminationDropdown.FormattingEnabled = true;
			CustomerExaminationDropdown.Location = new Point(371, 248);
			CustomerExaminationDropdown.Margin = new Padding(4, 5, 4, 5);
			CustomerExaminationDropdown.Name = "CustomerExaminationDropdown";
			CustomerExaminationDropdown.Size = new Size(294, 33);
			CustomerExaminationDropdown.TabIndex = 6;
			CustomerExaminationDropdown.SelectionChangeCommitted += CustomerExaminationDropdown_SelectionChangeCommitted;
			// 
			// PetExaminationDropdown
			// 
			PetExaminationDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
			PetExaminationDropdown.Enabled = false;
			PetExaminationDropdown.FormattingEnabled = true;
			PetExaminationDropdown.Location = new Point(371, 315);
			PetExaminationDropdown.Margin = new Padding(4, 5, 4, 5);
			PetExaminationDropdown.Name = "PetExaminationDropdown";
			PetExaminationDropdown.Size = new Size(294, 33);
			PetExaminationDropdown.TabIndex = 8;
			PetExaminationDropdown.SelectionChangeCommitted += PetExaminationDropdown_SelectionChangeCommitted;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(264, 315);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(106, 27);
			label2.TabIndex = 7;
			label2.Text = "Kæledyr:";
			// 
			// ExaminationTypeDropdown
			// 
			ExaminationTypeDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
			ExaminationTypeDropdown.Enabled = false;
			ExaminationTypeDropdown.FormattingEnabled = true;
			ExaminationTypeDropdown.Location = new Point(371, 383);
			ExaminationTypeDropdown.Margin = new Padding(4, 5, 4, 5);
			ExaminationTypeDropdown.Name = "ExaminationTypeDropdown";
			ExaminationTypeDropdown.Size = new Size(294, 33);
			ExaminationTypeDropdown.TabIndex = 10;
			ExaminationTypeDropdown.SelectionChangeCommitted += ExaminationDropdown_SelectionChangeCommitted;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(217, 383);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(157, 27);
			label3.TabIndex = 9;
			label3.Text = "Konsultation:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.Location = new Point(313, 450);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(58, 27);
			label4.TabIndex = 11;
			label4.Text = "Pris:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.Location = new Point(313, 527);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(52, 27);
			label6.TabIndex = 13;
			label6.Text = "Tid:";
			// 
			// EmployeeExaminationDropdown
			// 
			EmployeeExaminationDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
			EmployeeExaminationDropdown.Enabled = false;
			EmployeeExaminationDropdown.FormattingEnabled = true;
			EmployeeExaminationDropdown.Location = new Point(371, 608);
			EmployeeExaminationDropdown.Margin = new Padding(4, 5, 4, 5);
			EmployeeExaminationDropdown.Name = "EmployeeExaminationDropdown";
			EmployeeExaminationDropdown.Size = new Size(294, 33);
			EmployeeExaminationDropdown.TabIndex = 16;
			EmployeeExaminationDropdown.SelectionChangeCommitted += EmployeeExaminationDropdown_SelectionChangeCommitted;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label7.Location = new Point(217, 608);
			label7.Margin = new Padding(4, 0, 4, 0);
			label7.Name = "label7";
			label7.Size = new Size(155, 27);
			label7.TabIndex = 15;
			label7.Text = "Medarbejder:";
			// 
			// CreateExaminationButton
			// 
			CreateExaminationButton.BackColor = Color.DarkGray;
			CreateExaminationButton.Enabled = false;
			CreateExaminationButton.FlatStyle = FlatStyle.Popup;
			CreateExaminationButton.Location = new Point(586, 772);
			CreateExaminationButton.Margin = new Padding(4, 5, 4, 5);
			CreateExaminationButton.Name = "CreateExaminationButton";
			CreateExaminationButton.Size = new Size(243, 97);
			CreateExaminationButton.TabIndex = 18;
			CreateExaminationButton.Text = "Opret Konsultation";
			CreateExaminationButton.UseVisualStyleBackColor = false;
			CreateExaminationButton.Click += CreateExaminationButton_Click;
			// 
			// CancelExaminationButton
			// 
			CancelExaminationButton.BackColor = Color.IndianRed;
			CancelExaminationButton.FlatStyle = FlatStyle.Popup;
			CancelExaminationButton.Location = new Point(153, 772);
			CancelExaminationButton.Margin = new Padding(4, 5, 4, 5);
			CancelExaminationButton.Name = "CancelExaminationButton";
			CancelExaminationButton.Size = new Size(243, 97);
			CancelExaminationButton.TabIndex = 17;
			CancelExaminationButton.Text = "Annuller";
			CancelExaminationButton.UseVisualStyleBackColor = false;
			CancelExaminationButton.Click += CancelExaminationButton_Click;
			// 
			// DateTimePickerExamination
			// 
			DateTimePickerExamination.Enabled = false;
			DateTimePickerExamination.Location = new Point(371, 527);
			DateTimePickerExamination.Margin = new Padding(4, 5, 4, 5);
			DateTimePickerExamination.Name = "DateTimePickerExamination";
			DateTimePickerExamination.Size = new Size(294, 31);
			DateTimePickerExamination.TabIndex = 19;
			DateTimePickerExamination.ValueChanged += DateTimePickerExamination_ValueChanged;
			// 
			// ErrorMessageExamination
			// 
			ErrorMessageExamination.AutoSize = true;
			ErrorMessageExamination.Location = new Point(440, 728);
			ErrorMessageExamination.Margin = new Padding(4, 0, 4, 0);
			ErrorMessageExamination.Name = "ErrorMessageExamination";
			ErrorMessageExamination.Size = new Size(120, 25);
			ErrorMessageExamination.TabIndex = 20;
			ErrorMessageExamination.Text = "ErrorMessage";
			ErrorMessageExamination.TextAlign = ContentAlignment.MiddleCenter;
			ErrorMessageExamination.Visible = false;
			// 
			// PriceExaminationDisplay
			// 
			PriceExaminationDisplay.BorderStyle = BorderStyle.FixedSingle;
			PriceExaminationDisplay.Enabled = false;
			PriceExaminationDisplay.ForeColor = Color.Black;
			PriceExaminationDisplay.Location = new Point(371, 450);
			PriceExaminationDisplay.Margin = new Padding(4, 5, 4, 5);
			PriceExaminationDisplay.Name = "PriceExaminationDisplay";
			PriceExaminationDisplay.Size = new Size(295, 31);
			PriceExaminationDisplay.TabIndex = 21;
			PriceExaminationDisplay.TextChanged += PriceExaminationDisplay_TextChanged;
			// 
			// DiscountLabel
			// 
			DiscountLabel.AutoSize = true;
			DiscountLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			DiscountLabel.Location = new Point(250, 674);
			DiscountLabel.Margin = new Padding(4, 0, 4, 0);
			DiscountLabel.Name = "DiscountLabel";
			DiscountLabel.Size = new Size(113, 27);
			DiscountLabel.TabIndex = 22;
			DiscountLabel.Text = "Rabat i %";
			DiscountLabel.Visible = false;
			// 
			// DiscountNummericUpDown
			// 
			DiscountNummericUpDown.Increment = new decimal(new int[] { 5, 0, 0, 0 });
			DiscountNummericUpDown.Location = new Point(371, 672);
			DiscountNummericUpDown.Name = "DiscountNummericUpDown";
			DiscountNummericUpDown.Size = new Size(295, 31);
			DiscountNummericUpDown.TabIndex = 24;
			DiscountNummericUpDown.Visible = false;
			DiscountNummericUpDown.ValueChanged += DiscountNummericUpDown_ValueChanged;
			// 
			// CreateExaminationUserControl
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(DiscountNummericUpDown);
			Controls.Add(DiscountLabel);
			Controls.Add(PriceExaminationDisplay);
			Controls.Add(ErrorMessageExamination);
			Controls.Add(DateTimePickerExamination);
			Controls.Add(CreateExaminationButton);
			Controls.Add(CancelExaminationButton);
			Controls.Add(EmployeeExaminationDropdown);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label4);
			Controls.Add(ExaminationTypeDropdown);
			Controls.Add(label3);
			Controls.Add(PetExaminationDropdown);
			Controls.Add(label2);
			Controls.Add(CustomerExaminationDropdown);
			Controls.Add(label1);
			Controls.Add(label5);
			Margin = new Padding(0);
			Name = "CreateExaminationUserControl";
			Size = new Size(1013, 967);
			Load += CreateExaminationUserControl_Load;
			((System.ComponentModel.ISupportInitialize)DiscountNummericUpDown).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label5;
		private Label label1;
		private ComboBox CustomerExaminationDropdown;
		private ComboBox PetExaminationDropdown;
		private Label label2;
		private ComboBox ExaminationTypeDropdown;
		private Label label3;
		private Label label4;
		private ComboBox comboBox5;
		private Label label6;
		private ComboBox EmployeeExaminationDropdown;
		private Label label7;
		private Button CreateExaminationButton;
		private Button CancelExaminationButton;
		private DateTimePicker DateTimePickerExamination;
		private Label ErrorMessageExamination;
		private TextBox PriceExaminationDisplay;
		private Label DiscountLabel;
		private NumericUpDown DiscountNummericUpDown;
	}
}
