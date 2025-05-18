namespace _2SemesterProjekt.Pages.UserControls.ExaminationUserControl
{
    partial class CreateExaminationUserControlUpdate
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
            Titel = new PictureBox();
            pictureBox1 = new PictureBox();
            cancelButton = new PictureBox();
            submitButton = new PictureBox();
            customerSearchButton = new PictureBox();
            customerSearchTextBox = new TextBox();
            petDropdown = new ComboBox();
            ExaminationTypeDropdown = new ComboBox();
            DateTimePickerExamination = new DateTimePicker();
            employeeDropdown = new ComboBox();
            cageBookingCheckBox = new PictureBox();
            cageBookingNumberOfDaysLabel = new PictureBox();
            discountNumericUpDown = new NumericUpDown();
            numericUpDownCageBooking = new NumericUpDown();
            PriceExaminationDisplay = new TextBox();
            DiscountOrCageBookingSection = new PictureBox();
            discountLabel = new PictureBox();
            cageBookingLabel = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Titel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cancelButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)submitButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerSearchButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cageBookingCheckBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cageBookingNumberOfDaysLabel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)discountNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCageBooking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DiscountOrCageBookingSection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)discountLabel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cageBookingLabel).BeginInit();
            SuspendLayout();
            // 
            // Titel
            // 
            Titel.Image = Properties.Resources.OpretNyeKonsultationer;
            Titel.Location = new Point(84, 77);
            Titel.Name = "Titel";
            Titel.Size = new Size(2332, 131);
            Titel.TabIndex = 0;
            Titel.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.CreateExaminationInput;
            pictureBox1.Location = new Point(84, 257);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(2342, 1117);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // cancelButton
            // 
            cancelButton.Image = Properties.Resources.CancelButton;
            cancelButton.Location = new Point(413, 1422);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(401, 93);
            cancelButton.TabIndex = 2;
            cancelButton.TabStop = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // submitButton
            // 
            submitButton.Enabled = false;
            submitButton.Image = Properties.Resources.SaveButton;
            submitButton.Location = new Point(1695, 1422);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(401, 93);
            submitButton.TabIndex = 3;
            submitButton.TabStop = false;
            submitButton.Click += submitButton_Click;
            // 
            // customerSearchButton
            // 
            customerSearchButton.Image = Properties.Resources.SearchButton;
            customerSearchButton.Location = new Point(1463, 382);
            customerSearchButton.Name = "customerSearchButton";
            customerSearchButton.Size = new Size(79, 35);
            customerSearchButton.TabIndex = 4;
            customerSearchButton.TabStop = false;
            customerSearchButton.Click += customerSearchButton_Click;
            customerSearchButton.MouseEnter += customerSearchButton_MouseEnter;
            customerSearchButton.MouseLeave += customerSearchButton_MouseLeave;
            // 
            // customerSearchTextBox
            // 
            customerSearchTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerSearchTextBox.Location = new Point(1057, 382);
            customerSearchTextBox.Name = "customerSearchTextBox";
            customerSearchTextBox.Size = new Size(400, 35);
            customerSearchTextBox.TabIndex = 5;
            // 
            // petDropdown
            // 
            petDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            petDropdown.Enabled = false;
            petDropdown.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            petDropdown.FormattingEnabled = true;
            petDropdown.Location = new Point(1057, 554);
            petDropdown.Name = "petDropdown";
            petDropdown.Size = new Size(400, 38);
            petDropdown.TabIndex = 6;
            petDropdown.SelectionChangeCommitted += petDropdown_SelectionChangeCommitted;
            // 
            // ExaminationTypeDropdown
            // 
            ExaminationTypeDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            ExaminationTypeDropdown.Enabled = false;
            ExaminationTypeDropdown.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExaminationTypeDropdown.FormattingEnabled = true;
            ExaminationTypeDropdown.Location = new Point(1057, 725);
            ExaminationTypeDropdown.Name = "ExaminationTypeDropdown";
            ExaminationTypeDropdown.Size = new Size(400, 38);
            ExaminationTypeDropdown.TabIndex = 7;
            ExaminationTypeDropdown.SelectionChangeCommitted += ExaminationTypeDropdown_SelectionChangeCommitted;
            // 
            // DateTimePickerExamination
            // 
            DateTimePickerExamination.Enabled = false;
            DateTimePickerExamination.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateTimePickerExamination.Location = new Point(1057, 901);
            DateTimePickerExamination.Name = "DateTimePickerExamination";
            DateTimePickerExamination.Size = new Size(400, 35);
            DateTimePickerExamination.TabIndex = 8;
            DateTimePickerExamination.ValueChanged += DateTimePickerExamination_ValueChanged;
            // 
            // employeeDropdown
            // 
            employeeDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            employeeDropdown.Enabled = false;
            employeeDropdown.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeeDropdown.FormattingEnabled = true;
            employeeDropdown.Location = new Point(1057, 1071);
            employeeDropdown.Name = "employeeDropdown";
            employeeDropdown.Size = new Size(400, 38);
            employeeDropdown.TabIndex = 9;
            employeeDropdown.SelectionChangeCommitted += employeeDropdown_SelectionChangeCommitted;
            // 
            // cageBookingCheckBox
            // 
            cageBookingCheckBox.Image = Properties.Resources.CheckBox;
            cageBookingCheckBox.Location = new Point(1390, 1186);
            cageBookingCheckBox.Name = "cageBookingCheckBox";
            cageBookingCheckBox.Size = new Size(35, 35);
            cageBookingCheckBox.TabIndex = 11;
            cageBookingCheckBox.TabStop = false;
            cageBookingCheckBox.Visible = false;
            // 
            // cageBookingNumberOfDaysLabel
            // 
            cageBookingNumberOfDaysLabel.BackColor = SystemColors.ActiveBorder;
            cageBookingNumberOfDaysLabel.Image = Properties.Resources.NumberOfDaysLabel;
            cageBookingNumberOfDaysLabel.Location = new Point(1390, 1233);
            cageBookingNumberOfDaysLabel.Name = "cageBookingNumberOfDaysLabel";
            cageBookingNumberOfDaysLabel.Size = new Size(227, 26);
            cageBookingNumberOfDaysLabel.TabIndex = 12;
            cageBookingNumberOfDaysLabel.TabStop = false;
            cageBookingNumberOfDaysLabel.Visible = false;
            // 
            // discountNumericUpDown
            // 
            discountNumericUpDown.Enabled = false;
            discountNumericUpDown.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discountNumericUpDown.Location = new Point(844, 1228);
            discountNumericUpDown.Name = "discountNumericUpDown";
            discountNumericUpDown.Size = new Size(400, 35);
            discountNumericUpDown.TabIndex = 10;
            discountNumericUpDown.Visible = false;
            discountNumericUpDown.ValueChanged += discountNumericUpDown_ValueChanged;
            // 
            // numericUpDownCageBooking
            // 
            numericUpDownCageBooking.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownCageBooking.Location = new Point(1633, 1228);
            numericUpDownCageBooking.Name = "numericUpDownCageBooking";
            numericUpDownCageBooking.Size = new Size(46, 35);
            numericUpDownCageBooking.TabIndex = 13;
            numericUpDownCageBooking.Visible = false;
            // 
            // PriceExaminationDisplay
            // 
            PriceExaminationDisplay.Enabled = false;
            PriceExaminationDisplay.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PriceExaminationDisplay.Location = new Point(1474, 726);
            PriceExaminationDisplay.Name = "PriceExaminationDisplay";
            PriceExaminationDisplay.ReadOnly = true;
            PriceExaminationDisplay.Size = new Size(136, 35);
            PriceExaminationDisplay.TabIndex = 14;
            PriceExaminationDisplay.TextChanged += PriceExaminationDisplay_TextChanged;
            // 
            // DiscountOrCageBookingSection
            // 
            DiscountOrCageBookingSection.Image = Properties.Resources.ExaminationBox;
            DiscountOrCageBookingSection.Location = new Point(625, 1158);
            DiscountOrCageBookingSection.Name = "DiscountOrCageBookingSection";
            DiscountOrCageBookingSection.Size = new Size(1283, 149);
            DiscountOrCageBookingSection.TabIndex = 15;
            DiscountOrCageBookingSection.TabStop = false;
            // 
            // discountLabel
            // 
            discountLabel.Image = Properties.Resources.DiscountLabel;
            discountLabel.Location = new Point(930, 1186);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new Size(246, 25);
            discountLabel.TabIndex = 16;
            discountLabel.TabStop = false;
            discountLabel.Visible = false;
            // 
            // cageBookingLabel
            // 
            cageBookingLabel.Image = Properties.Resources.CageBookingLabel;
            cageBookingLabel.Location = new Point(1445, 1191);
            cageBookingLabel.Name = "cageBookingLabel";
            cageBookingLabel.Size = new Size(234, 25);
            cageBookingLabel.TabIndex = 17;
            cageBookingLabel.TabStop = false;
            cageBookingLabel.Visible = false;
            // 
            // CreateExaminationUserControlUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cageBookingLabel);
            Controls.Add(discountLabel);
            Controls.Add(PriceExaminationDisplay);
            Controls.Add(numericUpDownCageBooking);
            Controls.Add(cageBookingNumberOfDaysLabel);
            Controls.Add(cageBookingCheckBox);
            Controls.Add(discountNumericUpDown);
            Controls.Add(employeeDropdown);
            Controls.Add(DateTimePickerExamination);
            Controls.Add(ExaminationTypeDropdown);
            Controls.Add(petDropdown);
            Controls.Add(customerSearchTextBox);
            Controls.Add(customerSearchButton);
            Controls.Add(submitButton);
            Controls.Add(cancelButton);
            Controls.Add(Titel);
            Controls.Add(DiscountOrCageBookingSection);
            Controls.Add(pictureBox1);
            Name = "CreateExaminationUserControlUpdate";
            Size = new Size(2500, 1580);
            Load += CreateExaminationUserControlUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)Titel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cancelButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)submitButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerSearchButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)cageBookingCheckBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cageBookingNumberOfDaysLabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)discountNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCageBooking).EndInit();
            ((System.ComponentModel.ISupportInitialize)DiscountOrCageBookingSection).EndInit();
            ((System.ComponentModel.ISupportInitialize)discountLabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)cageBookingLabel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Titel;
        private PictureBox pictureBox1;
        private PictureBox cancelButton;
        private PictureBox submitButton;
        private PictureBox customerSearchButton;
        private TextBox customerSearchTextBox;
        private ComboBox petDropdown;
        private ComboBox ExaminationTypeDropdown;
        private DateTimePicker DateTimePickerExamination;
        private ComboBox employeeDropdown;
        private PictureBox cageBookingCheckBox;
        private PictureBox cageBookingNumberOfDaysLabel;
        private NumericUpDown discountNumericUpDown;
        private NumericUpDown numericUpDownCageBooking;
        private TextBox PriceExaminationDisplay;
        private PictureBox DiscountOrCageBookingSection;
        private PictureBox discountLabel;
        private PictureBox cageBookingLabel;
    }
}
