namespace _2SemesterProjekt.Pages.UserControls.ExaminationUserControl
{
    partial class CreateExaminationPage
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
            cancelButton = new PictureBox();
            submitButton = new PictureBox();
            customerSearchButton = new PictureBox();
            customerSearchTextBox = new TextBox();
            petDropdown = new ComboBox();
            ExaminationTypeDropdown = new ComboBox();
            DateTimePickerExamination = new DateTimePicker();
            employeeDropdown = new ComboBox();
            cageBookingCheckBox = new PictureBox();
            discountNumericUpDown = new NumericUpDown();
            numericUpDownCageBooking = new NumericUpDown();
            PriceExaminationDisplay = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            discountLabel = new Label();
            cageBookingLabel = new Label();
            cageBookingNumberOfDaysLabel = new Label();
            pictureBox9 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)cancelButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)submitButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerSearchButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cageBookingCheckBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)discountNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCageBooking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Image = Properties.Resources.CancelButton;
            cancelButton.Location = new Point(416, 751);
            cancelButton.Margin = new Padding(3, 4, 3, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(240, 55);
            cancelButton.SizeMode = PictureBoxSizeMode.StretchImage;
            cancelButton.TabIndex = 2;
            cancelButton.TabStop = false;
            cancelButton.Click += cancelButton_Click;
            cancelButton.MouseEnter += cancelButton_MouseEnter;
            cancelButton.MouseLeave += cancelButton_MouseLeave;
            // 
            // submitButton
            // 
            submitButton.Enabled = false;
            submitButton.Image = Properties.Resources.SaveButtonGreyedOut;
            submitButton.Location = new Point(945, 751);
            submitButton.Margin = new Padding(3, 4, 3, 4);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(240, 55);
            submitButton.SizeMode = PictureBoxSizeMode.StretchImage;
            submitButton.TabIndex = 3;
            submitButton.TabStop = false;
            submitButton.Click += submitButton_Click;
            submitButton.MouseEnter += submitButton_MouseEnter;
            submitButton.MouseLeave += submitButton_MouseLeave;
            // 
            // customerSearchButton
            // 
            customerSearchButton.BackColor = Color.AntiqueWhite;
            customerSearchButton.Image = Properties.Resources.SearchButton;
            customerSearchButton.Location = new Point(921, 197);
            customerSearchButton.Margin = new Padding(3, 4, 3, 4);
            customerSearchButton.Name = "customerSearchButton";
            customerSearchButton.Size = new Size(47, 21);
            customerSearchButton.SizeMode = PictureBoxSizeMode.StretchImage;
            customerSearchButton.TabIndex = 4;
            customerSearchButton.TabStop = false;
            customerSearchButton.Click += customerSearchButton_Click;
            customerSearchButton.MouseEnter += customerSearchButton_MouseEnter;
            customerSearchButton.MouseLeave += customerSearchButton_MouseLeave;
            // 
            // customerSearchTextBox
            // 
            customerSearchTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerSearchTextBox.Location = new Point(632, 194);
            customerSearchTextBox.Margin = new Padding(3, 4, 3, 4);
            customerSearchTextBox.MaxLength = 8;
            customerSearchTextBox.Name = "customerSearchTextBox";
            customerSearchTextBox.Size = new Size(274, 27);
            customerSearchTextBox.TabIndex = 5;
            customerSearchTextBox.Click += customerSearchTextBox_Click;
            customerSearchTextBox.KeyPress += customerSearchTextBox_KeyPress;
            // 
            // petDropdown
            // 
            petDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            petDropdown.Enabled = false;
            petDropdown.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            petDropdown.FormattingEnabled = true;
            petDropdown.Location = new Point(663, 294);
            petDropdown.Margin = new Padding(3, 4, 3, 4);
            petDropdown.Name = "petDropdown";
            petDropdown.Size = new Size(274, 28);
            petDropdown.TabIndex = 6;
            petDropdown.SelectionChangeCommitted += petDropdown_SelectionChangeCommitted;
            // 
            // ExaminationTypeDropdown
            // 
            ExaminationTypeDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            ExaminationTypeDropdown.Enabled = false;
            ExaminationTypeDropdown.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExaminationTypeDropdown.FormattingEnabled = true;
            ExaminationTypeDropdown.Location = new Point(663, 394);
            ExaminationTypeDropdown.Margin = new Padding(3, 4, 3, 4);
            ExaminationTypeDropdown.Name = "ExaminationTypeDropdown";
            ExaminationTypeDropdown.Size = new Size(274, 28);
            ExaminationTypeDropdown.TabIndex = 7;
            ExaminationTypeDropdown.SelectionChangeCommitted += ExaminationTypeDropdown_SelectionChangeCommitted;
            // 
            // DateTimePickerExamination
            // 
            DateTimePickerExamination.Enabled = false;
            DateTimePickerExamination.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateTimePickerExamination.Location = new Point(663, 494);
            DateTimePickerExamination.Margin = new Padding(3, 4, 3, 4);
            DateTimePickerExamination.Name = "DateTimePickerExamination";
            DateTimePickerExamination.Size = new Size(274, 27);
            DateTimePickerExamination.TabIndex = 8;
            DateTimePickerExamination.ValueChanged += DateTimePickerExamination_ValueChanged;
            // 
            // employeeDropdown
            // 
            employeeDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            employeeDropdown.Enabled = false;
            employeeDropdown.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeeDropdown.FormattingEnabled = true;
            employeeDropdown.Location = new Point(663, 594);
            employeeDropdown.Margin = new Padding(3, 4, 3, 4);
            employeeDropdown.Name = "employeeDropdown";
            employeeDropdown.Size = new Size(274, 28);
            employeeDropdown.TabIndex = 9;
            employeeDropdown.SelectionChangeCommitted += employeeDropdown_SelectionChangeCommitted;
            // 
            // cageBookingCheckBox
            // 
            cageBookingCheckBox.BackColor = Color.AntiqueWhite;
            cageBookingCheckBox.Image = Properties.Resources.CheckBox;
            cageBookingCheckBox.Location = new Point(905, 669);
            cageBookingCheckBox.Margin = new Padding(3, 4, 3, 4);
            cageBookingCheckBox.Name = "cageBookingCheckBox";
            cageBookingCheckBox.Size = new Size(21, 21);
            cageBookingCheckBox.SizeMode = PictureBoxSizeMode.StretchImage;
            cageBookingCheckBox.TabIndex = 11;
            cageBookingCheckBox.TabStop = false;
            cageBookingCheckBox.Visible = false;
            cageBookingCheckBox.Click += cageBookingCheckBox_Click;
            cageBookingCheckBox.MouseEnter += cageBookingCheckBox_MouseEnter;
            cageBookingCheckBox.MouseLeave += cageBookingCheckBox_MouseLeave;
            // 
            // discountNumericUpDown
            // 
            discountNumericUpDown.Enabled = false;
            discountNumericUpDown.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discountNumericUpDown.Location = new Point(512, 693);
            discountNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            discountNumericUpDown.Name = "discountNumericUpDown";
            discountNumericUpDown.Size = new Size(266, 27);
            discountNumericUpDown.TabIndex = 10;
            discountNumericUpDown.Visible = false;
            discountNumericUpDown.ValueChanged += discountNumericUpDown_ValueChanged;
            // 
            // numericUpDownCageBooking
            // 
            numericUpDownCageBooking.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownCageBooking.Location = new Point(1045, 693);
            numericUpDownCageBooking.Margin = new Padding(3, 4, 3, 4);
            numericUpDownCageBooking.Name = "numericUpDownCageBooking";
            numericUpDownCageBooking.Size = new Size(44, 27);
            numericUpDownCageBooking.TabIndex = 13;
            numericUpDownCageBooking.Visible = false;
            // 
            // PriceExaminationDisplay
            // 
            PriceExaminationDisplay.Enabled = false;
            PriceExaminationDisplay.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PriceExaminationDisplay.ForeColor = SystemColors.InactiveCaptionText;
            PriceExaminationDisplay.Location = new Point(943, 393);
            PriceExaminationDisplay.Margin = new Padding(3, 4, 3, 4);
            PriceExaminationDisplay.Name = "PriceExaminationDisplay";
            PriceExaminationDisplay.ReadOnly = true;
            PriceExaminationDisplay.Size = new Size(70, 27);
            PriceExaminationDisplay.TabIndex = 14;
            PriceExaminationDisplay.Text = "Pris";
            PriceExaminationDisplay.TextChanged += PriceExaminationDisplay_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(608, 169);
            label1.Name = "label1";
            label1.Size = new Size(384, 20);
            label1.TabIndex = 18;
            label1.Text = "S Ø G   P Å   K U N D E N S   T E L E F O N N U M M E R";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Linen;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(405, 38);
            label2.Name = "label2";
            label2.Size = new Size(791, 50);
            label2.TabIndex = 20;
            label2.Text = "O P R E T   N Y E   K O N S U L T A T I O N E R";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PageTitelBackground;
            pictureBox1.Location = new Point(101, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1399, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.PageBackground;
            pictureBox2.Location = new Point(101, 124);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1399, 705);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Linen;
            pictureBox3.Image = Properties.Resources.PageBox;
            pictureBox3.Location = new Point(416, 149);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(769, 88);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AntiqueWhite;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(618, 269);
            label3.Name = "label3";
            label3.Size = new Size(346, 20);
            label3.TabIndex = 25;
            label3.Text = "V Æ L G   E T   A F   K U N D E N S   K Æ L E D Y R";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.AntiqueWhite;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(676, 369);
            label4.Name = "label4";
            label4.Size = new Size(273, 20);
            label4.TabIndex = 27;
            label4.Text = "V Æ L G   E N   K O N S U L T A T I O N";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.AntiqueWhite;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.SaddleBrown;
            label5.Location = new Point(687, 469);
            label5.Name = "label5";
            label5.Size = new Size(225, 20);
            label5.TabIndex = 29;
            label5.Text = "V Æ L G   E T   T I D S P U N K T";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.AntiqueWhite;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.SaddleBrown;
            label6.Location = new Point(670, 569);
            label6.Name = "label6";
            label6.Size = new Size(260, 20);
            label6.TabIndex = 31;
            label6.Text = "V Æ L G   E N   M E D A R B E J D E R";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.BackColor = Color.AntiqueWhite;
            discountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            discountLabel.ForeColor = Color.SaddleBrown;
            discountLabel.Location = new Point(512, 669);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new Size(266, 20);
            discountLabel.TabIndex = 33;
            discountLabel.Text = "A N G I V   R A B A T  I  P R O C E N T";
            discountLabel.Visible = false;
            // 
            // cageBookingLabel
            // 
            cageBookingLabel.AutoSize = true;
            cageBookingLabel.BackColor = Color.AntiqueWhite;
            cageBookingLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cageBookingLabel.ForeColor = Color.SaddleBrown;
            cageBookingLabel.Location = new Point(937, 669);
            cageBookingLabel.Name = "cageBookingLabel";
            cageBookingLabel.Size = new Size(146, 20);
            cageBookingLabel.TabIndex = 34;
            cageBookingLabel.Text = "B U R B O O K I N G";
            cageBookingLabel.Visible = false;
            // 
            // cageBookingNumberOfDaysLabel
            // 
            cageBookingNumberOfDaysLabel.AutoSize = true;
            cageBookingNumberOfDaysLabel.BackColor = Color.AntiqueWhite;
            cageBookingNumberOfDaysLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cageBookingNumberOfDaysLabel.ForeColor = Color.SaddleBrown;
            cageBookingNumberOfDaysLabel.Location = new Point(898, 695);
            cageBookingNumberOfDaysLabel.Name = "cageBookingNumberOfDaysLabel";
            cageBookingNumberOfDaysLabel.Size = new Size(141, 20);
            cageBookingNumberOfDaysLabel.TabIndex = 35;
            cageBookingNumberOfDaysLabel.Text = "A N T A L   D A G E";
            cageBookingNumberOfDaysLabel.Visible = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Linen;
            pictureBox9.Image = Properties.Resources.PageBox;
            pictureBox9.Location = new Point(416, 249);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(769, 88);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 36;
            pictureBox9.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Linen;
            pictureBox4.Image = Properties.Resources.PageBox;
            pictureBox4.Location = new Point(416, 349);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(769, 88);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 37;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Linen;
            pictureBox5.Image = Properties.Resources.PageBox;
            pictureBox5.Location = new Point(416, 449);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(769, 88);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 38;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Linen;
            pictureBox6.Image = Properties.Resources.PageBox;
            pictureBox6.Location = new Point(416, 549);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(769, 88);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 39;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Linen;
            pictureBox7.Image = Properties.Resources.PageBox;
            pictureBox7.Location = new Point(416, 649);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(769, 88);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 40;
            pictureBox7.TabStop = false;
            // 
            // CreateExaminationPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(cageBookingNumberOfDaysLabel);
            Controls.Add(cageBookingLabel);
            Controls.Add(discountLabel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PriceExaminationDisplay);
            Controls.Add(numericUpDownCageBooking);
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
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox2);
            Margin = new Padding(0);
            Name = "CreateExaminationPage";
            Size = new Size(1600, 845);
            Load += CreateExaminationUserControlUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)cancelButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)submitButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerSearchButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)cageBookingCheckBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)discountNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCageBooking).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox cancelButton;
        private PictureBox submitButton;
        private PictureBox customerSearchButton;
        private TextBox customerSearchTextBox;
        private ComboBox petDropdown;
        private ComboBox ExaminationTypeDropdown;
        private DateTimePicker DateTimePickerExamination;
        private ComboBox employeeDropdown;
        private PictureBox cageBookingCheckBox;
        private NumericUpDown discountNumericUpDown;
        private NumericUpDown numericUpDownCageBooking;
        private TextBox PriceExaminationDisplay;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label discountLabel;
        private Label cageBookingLabel;
        private Label cageBookingNumberOfDaysLabel;
        private PictureBox pictureBox9;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
    }
}
