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
            pictureBox4 = new PictureBox();
            label3 = new Label();
            pictureBox5 = new PictureBox();
            label4 = new Label();
            pictureBox6 = new PictureBox();
            label5 = new Label();
            pictureBox7 = new PictureBox();
            label6 = new Label();
            pictureBox8 = new PictureBox();
            discountLabel = new Label();
            cageBookingLabel = new Label();
            cageBookingNumberOfDaysLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)cancelButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)submitButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerSearchButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cageBookingCheckBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)discountNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCageBooking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Image = Properties.Resources.CancelButton;
            cancelButton.Location = new Point(409, 1422);
            cancelButton.Margin = new Padding(3, 4, 3, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(400, 92);
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
            submitButton.Location = new Point(1691, 1422);
            submitButton.Margin = new Padding(3, 4, 3, 4);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(400, 92);
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
            customerSearchButton.Location = new Point(1500, 362);
            customerSearchButton.Margin = new Padding(3, 4, 3, 4);
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
            customerSearchTextBox.Location = new Point(1022, 358);
            customerSearchTextBox.Margin = new Padding(3, 4, 3, 4);
            customerSearchTextBox.MaxLength = 8;
            customerSearchTextBox.Name = "customerSearchTextBox";
            customerSearchTextBox.Size = new Size(457, 42);
            customerSearchTextBox.TabIndex = 5;
            customerSearchTextBox.Click += customerSearchTextBox_Click;
            customerSearchTextBox.KeyPress += customerSearchTextBox_KeyPress;
            // 
            // petDropdown
            // 
            petDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            petDropdown.Enabled = false;
            petDropdown.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            petDropdown.FormattingEnabled = true;
            petDropdown.Location = new Point(1022, 530);
            petDropdown.Margin = new Padding(3, 4, 3, 4);
            petDropdown.Name = "petDropdown";
            petDropdown.Size = new Size(457, 44);
            petDropdown.TabIndex = 6;
            petDropdown.SelectionChangeCommitted += petDropdown_SelectionChangeCommitted;
            // 
            // ExaminationTypeDropdown
            // 
            ExaminationTypeDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            ExaminationTypeDropdown.Enabled = false;
            ExaminationTypeDropdown.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExaminationTypeDropdown.FormattingEnabled = true;
            ExaminationTypeDropdown.Location = new Point(1022, 705);
            ExaminationTypeDropdown.Margin = new Padding(3, 4, 3, 4);
            ExaminationTypeDropdown.Name = "ExaminationTypeDropdown";
            ExaminationTypeDropdown.Size = new Size(457, 44);
            ExaminationTypeDropdown.TabIndex = 7;
            ExaminationTypeDropdown.SelectionChangeCommitted += ExaminationTypeDropdown_SelectionChangeCommitted;
            // 
            // DateTimePickerExamination
            // 
            DateTimePickerExamination.Enabled = false;
            DateTimePickerExamination.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateTimePickerExamination.Location = new Point(1022, 890);
            DateTimePickerExamination.Margin = new Padding(3, 4, 3, 4);
            DateTimePickerExamination.Name = "DateTimePickerExamination";
            DateTimePickerExamination.Size = new Size(457, 42);
            DateTimePickerExamination.TabIndex = 8;
            DateTimePickerExamination.ValueChanged += DateTimePickerExamination_ValueChanged;
            // 
            // employeeDropdown
            // 
            employeeDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            employeeDropdown.Enabled = false;
            employeeDropdown.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeeDropdown.FormattingEnabled = true;
            employeeDropdown.Location = new Point(1022, 1063);
            employeeDropdown.Margin = new Padding(3, 4, 3, 4);
            employeeDropdown.Name = "employeeDropdown";
            employeeDropdown.Size = new Size(457, 44);
            employeeDropdown.TabIndex = 9;
            employeeDropdown.SelectionChangeCommitted += employeeDropdown_SelectionChangeCommitted;
            // 
            // cageBookingCheckBox
            // 
            cageBookingCheckBox.BackColor = Color.AntiqueWhite;
            cageBookingCheckBox.Image = Properties.Resources.CheckBox;
            cageBookingCheckBox.Location = new Point(1422, 1193);
            cageBookingCheckBox.Margin = new Padding(3, 4, 3, 4);
            cageBookingCheckBox.Name = "cageBookingCheckBox";
            cageBookingCheckBox.Size = new Size(35, 35);
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
            discountNumericUpDown.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discountNumericUpDown.Location = new Point(809, 1245);
            discountNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            discountNumericUpDown.Name = "discountNumericUpDown";
            discountNumericUpDown.Size = new Size(457, 42);
            discountNumericUpDown.TabIndex = 10;
            discountNumericUpDown.Visible = false;
            discountNumericUpDown.ValueChanged += discountNumericUpDown_ValueChanged;
            // 
            // numericUpDownCageBooking
            // 
            numericUpDownCageBooking.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownCageBooking.Location = new Point(1638, 1243);
            numericUpDownCageBooking.Margin = new Padding(3, 4, 3, 4);
            numericUpDownCageBooking.Name = "numericUpDownCageBooking";
            numericUpDownCageBooking.Size = new Size(53, 42);
            numericUpDownCageBooking.TabIndex = 13;
            numericUpDownCageBooking.Visible = false;
            // 
            // PriceExaminationDisplay
            // 
            PriceExaminationDisplay.Enabled = false;
            PriceExaminationDisplay.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PriceExaminationDisplay.ForeColor = SystemColors.InactiveCaptionText;
            PriceExaminationDisplay.Location = new Point(1509, 706);
            PriceExaminationDisplay.Margin = new Padding(3, 4, 3, 4);
            PriceExaminationDisplay.Name = "PriceExaminationDisplay";
            PriceExaminationDisplay.ReadOnly = true;
            PriceExaminationDisplay.Size = new Size(155, 42);
            PriceExaminationDisplay.TabIndex = 14;
            PriceExaminationDisplay.Text = "Pris";
            PriceExaminationDisplay.TextChanged += PriceExaminationDisplay_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(959, 307);
            label1.Name = "label1";
            label1.Size = new Size(582, 31);
            label1.TabIndex = 18;
            label1.Text = "S Ø G   P Å   K U N D E N S   T E L E F O N N U M M E R";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Linen;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(635, 108);
            label2.Name = "label2";
            label2.Size = new Size(1296, 81);
            label2.TabIndex = 20;
            label2.Text = "O P R E T   N Y E   K O N S U L T A T I O N E R";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PageTitelBackground;
            pictureBox1.Location = new Point(84, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(2332, 144);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.PageBackground;
            pictureBox2.Location = new Point(84, 242);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(2332, 1116);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Linen;
            pictureBox3.Image = Properties.Resources.PageBox;
            pictureBox3.Location = new Point(609, 277);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1282, 148);
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Linen;
            pictureBox4.Image = Properties.Resources.PageBox;
            pictureBox4.Location = new Point(609, 455);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1282, 148);
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AntiqueWhite;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(989, 482);
            label3.Name = "label3";
            label3.Size = new Size(523, 31);
            label3.TabIndex = 25;
            label3.Text = "V Æ L G   E T   A F   K U N D E N S   K Æ L E D Y R";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Linen;
            pictureBox5.Image = Properties.Resources.PageBox;
            pictureBox5.Location = new Point(609, 632);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1282, 148);
            pictureBox5.TabIndex = 26;
            pictureBox5.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.AntiqueWhite;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(1045, 654);
            label4.Name = "label4";
            label4.Size = new Size(411, 31);
            label4.TabIndex = 27;
            label4.Text = "V Æ L G   E N   K O N S U L T A T I O N";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Linen;
            pictureBox6.Image = Properties.Resources.PageBox;
            pictureBox6.Location = new Point(609, 811);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(1282, 148);
            pictureBox6.TabIndex = 28;
            pictureBox6.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.AntiqueWhite;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SaddleBrown;
            label5.Location = new Point(1081, 833);
            label5.Name = "label5";
            label5.Size = new Size(339, 31);
            label5.TabIndex = 29;
            label5.Text = "V Æ L G   E T   T I D S P U N K T";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Linen;
            pictureBox7.Image = Properties.Resources.PageBox;
            pictureBox7.Location = new Point(609, 989);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(1282, 148);
            pictureBox7.TabIndex = 30;
            pictureBox7.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.AntiqueWhite;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SaddleBrown;
            label6.Location = new Point(1054, 1009);
            label6.Name = "label6";
            label6.Size = new Size(392, 31);
            label6.TabIndex = 31;
            label6.Text = "V Æ L G   E N   M E D A R B E J D E R";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Linen;
            pictureBox8.Image = Properties.Resources.PageBox;
            pictureBox8.Location = new Point(609, 1167);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(1282, 148);
            pictureBox8.TabIndex = 32;
            pictureBox8.TabStop = false;
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.BackColor = Color.AntiqueWhite;
            discountLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discountLabel.ForeColor = Color.SaddleBrown;
            discountLabel.Location = new Point(838, 1193);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new Size(397, 31);
            discountLabel.TabIndex = 33;
            discountLabel.Text = "A N G I V   R A B A T  I  P R O C E N T";
            discountLabel.Visible = false;
            // 
            // cageBookingLabel
            // 
            cageBookingLabel.AutoSize = true;
            cageBookingLabel.BackColor = Color.AntiqueWhite;
            cageBookingLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cageBookingLabel.ForeColor = Color.SaddleBrown;
            cageBookingLabel.Location = new Point(1463, 1193);
            cageBookingLabel.Name = "cageBookingLabel";
            cageBookingLabel.Size = new Size(220, 31);
            cageBookingLabel.TabIndex = 34;
            cageBookingLabel.Text = "B U R B O O K I N G";
            cageBookingLabel.Visible = false;
            // 
            // cageBookingNumberOfDaysLabel
            // 
            cageBookingNumberOfDaysLabel.AutoSize = true;
            cageBookingNumberOfDaysLabel.BackColor = Color.AntiqueWhite;
            cageBookingNumberOfDaysLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cageBookingNumberOfDaysLabel.ForeColor = Color.SaddleBrown;
            cageBookingNumberOfDaysLabel.Location = new Point(1419, 1249);
            cageBookingNumberOfDaysLabel.Name = "cageBookingNumberOfDaysLabel";
            cageBookingNumberOfDaysLabel.Size = new Size(210, 31);
            cageBookingNumberOfDaysLabel.TabIndex = 35;
            cageBookingNumberOfDaysLabel.Text = "A N T A L   D A G E";
            cageBookingNumberOfDaysLabel.Visible = false;
            // 
            // CreateExaminationUserControlUpdate
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
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox2);
            Margin = new Padding(0);
            Name = "CreateExaminationUserControlUpdate";
            Size = new Size(2500, 1580);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
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
        private PictureBox pictureBox4;
        private Label label3;
        private PictureBox pictureBox5;
        private Label label4;
        private PictureBox pictureBox6;
        private Label label5;
        private PictureBox pictureBox7;
        private Label label6;
        private PictureBox pictureBox8;
        private Label discountLabel;
        private Label cageBookingLabel;
        private Label cageBookingNumberOfDaysLabel;
    }
}
