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
            label5.Location = new Point(233, 199);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 4;
            label5.Text = "Kunde:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 41);
            label1.Name = "label1";
            label1.Size = new Size(759, 95);
            label1.TabIndex = 5;
            label1.Text = "Opret Konsultation";
            // 
            // CustomerExaminationDropdown
            // 
            CustomerExaminationDropdown.FormattingEnabled = true;
            CustomerExaminationDropdown.Location = new Point(297, 199);
            CustomerExaminationDropdown.Margin = new Padding(3, 4, 3, 4);
            CustomerExaminationDropdown.Name = "CustomerExaminationDropdown";
            CustomerExaminationDropdown.Size = new Size(236, 28);
            CustomerExaminationDropdown.TabIndex = 6;
            CustomerExaminationDropdown.SelectionChangeCommitted += CustomerExaminationDropdown_SelectionChangeCommitted;
            // 
            // PetExaminationDropdown
            // 
            PetExaminationDropdown.FormattingEnabled = true;
            PetExaminationDropdown.Location = new Point(297, 252);
            PetExaminationDropdown.Margin = new Padding(3, 4, 3, 4);
            PetExaminationDropdown.Name = "PetExaminationDropdown";
            PetExaminationDropdown.Size = new Size(236, 28);
            PetExaminationDropdown.TabIndex = 8;
            PetExaminationDropdown.SelectionChangeCommitted += PetExaminationDropdown_SelectionChangeCommitted;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(211, 252);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 7;
            label2.Text = "Kæledyr:";
            // 
            // ExaminationDropdown
            // 
            ExaminationDropdown.FormattingEnabled = true;
            ExaminationDropdown.Location = new Point(297, 307);
            ExaminationDropdown.Margin = new Padding(3, 4, 3, 4);
            ExaminationDropdown.Name = "ExaminationDropdown";
            ExaminationDropdown.Size = new Size(236, 28);
            ExaminationDropdown.TabIndex = 10;
            ExaminationDropdown.SelectionChangeCommitted += ExaminationDropdown_SelectionChangeCommitted;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(174, 307);
            label3.Name = "label3";
            label3.Size = new Size(129, 21);
            label3.TabIndex = 9;
            label3.Text = "Konsultation:";
            // 
            // PriceExaminationDropdown
            // 
            PriceExaminationDropdown.FormattingEnabled = true;
            PriceExaminationDropdown.Location = new Point(297, 360);
            PriceExaminationDropdown.Margin = new Padding(3, 4, 3, 4);
            PriceExaminationDropdown.Name = "PriceExaminationDropdown";
            PriceExaminationDropdown.Size = new Size(236, 28);
            PriceExaminationDropdown.TabIndex = 12;
            PriceExaminationDropdown.SelectionChangeCommitted += PriceExaminationDropdown_SelectionChangeCommitted;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(250, 360);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 11;
            label4.Text = "Pris:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(250, 421);
            label6.Name = "label6";
            label6.Size = new Size(43, 21);
            label6.TabIndex = 13;
            label6.Text = "Tid:";
            // 
            // EmployeeExaminationDropdown
            // 
            EmployeeExaminationDropdown.FormattingEnabled = true;
            EmployeeExaminationDropdown.Location = new Point(297, 487);
            EmployeeExaminationDropdown.Margin = new Padding(3, 4, 3, 4);
            EmployeeExaminationDropdown.Name = "EmployeeExaminationDropdown";
            EmployeeExaminationDropdown.Size = new Size(236, 28);
            EmployeeExaminationDropdown.TabIndex = 16;
            EmployeeExaminationDropdown.SelectionChangeCommitted += EmployeeExaminationDropdown_SelectionChangeCommitted;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(174, 487);
            label7.Name = "label7";
            label7.Size = new Size(130, 21);
            label7.TabIndex = 15;
            label7.Text = "Medarbejder:";
            // 
            // CreateExaminationButton
            // 
            CreateExaminationButton.BackColor = Color.MediumAquamarine;
            CreateExaminationButton.FlatStyle = FlatStyle.Popup;
            CreateExaminationButton.Location = new Point(469, 617);
            CreateExaminationButton.Margin = new Padding(3, 4, 3, 4);
            CreateExaminationButton.Name = "CreateExaminationButton";
            CreateExaminationButton.Size = new Size(194, 77);
            CreateExaminationButton.TabIndex = 18;
            CreateExaminationButton.Text = "Opret Konsultation";
            CreateExaminationButton.UseVisualStyleBackColor = false;
            // 
            // CancelExaminationButton
            // 
            CancelExaminationButton.BackColor = Color.IndianRed;
            CancelExaminationButton.FlatStyle = FlatStyle.Popup;
            CancelExaminationButton.Location = new Point(122, 617);
            CancelExaminationButton.Margin = new Padding(3, 4, 3, 4);
            CancelExaminationButton.Name = "CancelExaminationButton";
            CancelExaminationButton.Size = new Size(194, 77);
            CancelExaminationButton.TabIndex = 17;
            CancelExaminationButton.Text = "Annuller";
            CancelExaminationButton.UseVisualStyleBackColor = false;
            // 
            // DateTimePickerExamination
            // 
            DateTimePickerExamination.Location = new Point(297, 421);
            DateTimePickerExamination.Margin = new Padding(3, 4, 3, 4);
            DateTimePickerExamination.Name = "DateTimePickerExamination";
            DateTimePickerExamination.Size = new Size(236, 27);
            DateTimePickerExamination.TabIndex = 19;
            DateTimePickerExamination.ValueChanged += DateTimePickerExamination_ValueChanged;
            // 
            // ErrorMessageExamination
            // 
            ErrorMessageExamination.AutoSize = true;
            ErrorMessageExamination.Location = new Point(355, 563);
            ErrorMessageExamination.Name = "ErrorMessageExamination";
            ErrorMessageExamination.Size = new Size(99, 20);
            ErrorMessageExamination.TabIndex = 20;
            ErrorMessageExamination.Text = "ErrorMessage";
            ErrorMessageExamination.Visible = false;
            // 
            // CreateExaminationUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            Size = new Size(810, 773);
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
