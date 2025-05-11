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
            DiscountNumericUpDown = new NumericUpDown();
            checkBoxCageBooking = new CheckBox();
            labelCageBookingDays = new Label();
            NumberOfDaysUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)DiscountNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumberOfDaysUpDown).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(197, 150);
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
            CustomerExaminationDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomerExaminationDropdown.FormattingEnabled = true;
            CustomerExaminationDropdown.Location = new Point(260, 149);
            CustomerExaminationDropdown.Name = "CustomerExaminationDropdown";
            CustomerExaminationDropdown.Size = new Size(207, 23);
            CustomerExaminationDropdown.TabIndex = 6;
            CustomerExaminationDropdown.SelectionChangeCommitted += CustomerExaminationDropdown_SelectionChangeCommitted;
            // 
            // PetExaminationDropdown
            // 
            PetExaminationDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            PetExaminationDropdown.Enabled = false;
            PetExaminationDropdown.FormattingEnabled = true;
            PetExaminationDropdown.Location = new Point(260, 189);
            PetExaminationDropdown.Name = "PetExaminationDropdown";
            PetExaminationDropdown.Size = new Size(207, 23);
            PetExaminationDropdown.TabIndex = 8;
            PetExaminationDropdown.SelectionChangeCommitted += PetExaminationDropdown_SelectionChangeCommitted;
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
            // ExaminationTypeDropdown
            // 
            ExaminationTypeDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            ExaminationTypeDropdown.Enabled = false;
            ExaminationTypeDropdown.FormattingEnabled = true;
            ExaminationTypeDropdown.Location = new Point(260, 230);
            ExaminationTypeDropdown.Name = "ExaminationTypeDropdown";
            ExaminationTypeDropdown.Size = new Size(207, 23);
            ExaminationTypeDropdown.TabIndex = 10;
            ExaminationTypeDropdown.SelectionChangeCommitted += ExaminationDropdown_SelectionChangeCommitted;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(219, 288);
            label4.Name = "label4";
            label4.Size = new Size(39, 19);
            label4.TabIndex = 11;
            label4.Text = "Pris:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(219, 334);
            label6.Name = "label6";
            label6.Size = new Size(35, 19);
            label6.TabIndex = 13;
            label6.Text = "Tid:";
            // 
            // EmployeeExaminationDropdown
            // 
            EmployeeExaminationDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            EmployeeExaminationDropdown.Enabled = false;
            EmployeeExaminationDropdown.FormattingEnabled = true;
            EmployeeExaminationDropdown.Location = new Point(260, 383);
            EmployeeExaminationDropdown.Name = "EmployeeExaminationDropdown";
            EmployeeExaminationDropdown.Size = new Size(207, 23);
            EmployeeExaminationDropdown.TabIndex = 16;
            EmployeeExaminationDropdown.SelectionChangeCommitted += EmployeeExaminationDropdown_SelectionChangeCommitted;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(152, 383);
            label7.Name = "label7";
            label7.Size = new Size(102, 19);
            label7.TabIndex = 15;
            label7.Text = "Medarbejder:";
            // 
            // CreateExaminationButton
            // 
            CreateExaminationButton.BackColor = Color.DarkGray;
            CreateExaminationButton.Enabled = false;
            CreateExaminationButton.FlatStyle = FlatStyle.Popup;
            CreateExaminationButton.Location = new Point(410, 481);
            CreateExaminationButton.Name = "CreateExaminationButton";
            CreateExaminationButton.Size = new Size(170, 58);
            CreateExaminationButton.TabIndex = 18;
            CreateExaminationButton.Text = "Opret Konsultation";
            CreateExaminationButton.UseVisualStyleBackColor = false;
            CreateExaminationButton.Click += CreateExaminationButton_Click;
            // 
            // CancelExaminationButton
            // 
            CancelExaminationButton.BackColor = Color.IndianRed;
            CancelExaminationButton.FlatStyle = FlatStyle.Popup;
            CancelExaminationButton.Location = new Point(107, 481);
            CancelExaminationButton.Name = "CancelExaminationButton";
            CancelExaminationButton.Size = new Size(170, 58);
            CancelExaminationButton.TabIndex = 17;
            CancelExaminationButton.Text = "Annuller";
            CancelExaminationButton.UseVisualStyleBackColor = false;
            CancelExaminationButton.Click += CancelExaminationButton_Click;
            // 
            // DateTimePickerExamination
            // 
            DateTimePickerExamination.Enabled = false;
            DateTimePickerExamination.Location = new Point(260, 334);
            DateTimePickerExamination.Name = "DateTimePickerExamination";
            DateTimePickerExamination.Size = new Size(207, 23);
            DateTimePickerExamination.TabIndex = 19;
            DateTimePickerExamination.ValueChanged += DateTimePickerExamination_ValueChanged;
            // 
            // ErrorMessageExamination
            // 
            ErrorMessageExamination.AutoSize = true;
            ErrorMessageExamination.Location = new Point(308, 455);
            ErrorMessageExamination.Name = "ErrorMessageExamination";
            ErrorMessageExamination.Size = new Size(78, 15);
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
            PriceExaminationDisplay.Location = new Point(260, 288);
            PriceExaminationDisplay.Name = "PriceExaminationDisplay";
            PriceExaminationDisplay.Size = new Size(207, 23);
            PriceExaminationDisplay.TabIndex = 21;
            PriceExaminationDisplay.TextChanged += PriceExaminationDisplay_TextChanged;
            // 
            // DiscountLabel
            // 
            DiscountLabel.AutoSize = true;
            DiscountLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DiscountLabel.Location = new Point(175, 422);
            DiscountLabel.Name = "DiscountLabel";
            DiscountLabel.Size = new Size(75, 19);
            DiscountLabel.TabIndex = 22;
            DiscountLabel.Text = "Rabat i %";
            DiscountLabel.Visible = false;
            // 
            // DiscountNumericUpDown
            // 
            DiscountNumericUpDown.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            DiscountNumericUpDown.Location = new Point(260, 421);
            DiscountNumericUpDown.Margin = new Padding(2);
            DiscountNumericUpDown.Name = "DiscountNumericUpDown";
            DiscountNumericUpDown.Size = new Size(206, 23);
            DiscountNumericUpDown.TabIndex = 24;
            DiscountNumericUpDown.Visible = false;
            DiscountNumericUpDown.ValueChanged += DiscountNumericUpDown_ValueChanged;
            // 
            // checkBoxCageBooking
            // 
            checkBoxCageBooking.AutoSize = true;
            checkBoxCageBooking.Location = new Point(260, 260);
            checkBoxCageBooking.Name = "checkBoxCageBooking";
            checkBoxCageBooking.RightToLeft = RightToLeft.No;
            checkBoxCageBooking.Size = new Size(121, 19);
            checkBoxCageBooking.TabIndex = 25;
            checkBoxCageBooking.Text = "Opret burbooking";
            checkBoxCageBooking.UseVisualStyleBackColor = true;
            checkBoxCageBooking.Visible = false;
            // 
            // labelCageBookingDays
            // 
            labelCageBookingDays.AutoSize = true;
            labelCageBookingDays.Location = new Point(396, 261);
            labelCageBookingDays.Name = "labelCageBookingDays";
            labelCageBookingDays.Size = new Size(67, 15);
            labelCageBookingDays.TabIndex = 27;
            labelCageBookingDays.Text = "Antal dage:";
            labelCageBookingDays.Visible = false;
            // 
            // NumberOfDaysUpDown
            // 
            NumberOfDaysUpDown.Location = new Point(469, 259);
            NumberOfDaysUpDown.Maximum = new decimal(new int[] { 14, 0, 0, 0 });
            NumberOfDaysUpDown.Name = "NumberOfDaysUpDown";
            NumberOfDaysUpDown.Size = new Size(35, 23);
            NumberOfDaysUpDown.TabIndex = 28;
            NumberOfDaysUpDown.Visible = false;
            // 
            // CreateExaminationUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(NumberOfDaysUpDown);
            Controls.Add(labelCageBookingDays);
            Controls.Add(checkBoxCageBooking);
            Controls.Add(DiscountNumericUpDown);
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
            Size = new Size(709, 580);
            Load += CreateExaminationUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)DiscountNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumberOfDaysUpDown).EndInit();
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
		private NumericUpDown DiscountNumericUpDown;
        private CheckBox checkBoxCageBooking;
        private Label labelCageBookingDays;
        private NumericUpDown NumberOfDaysUpDown;
    }
}
