namespace _2SemesterProjekt.Pages.UserControls.MedicineUserControl
{
    partial class MedicineUserControl
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
            MedicineLabel = new Label();
            OrdineretLabel = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            PetLabel = new Label();
            MedicineNameLabel = new Label();
            MedicineTypeLabel = new Label();
            MedicineMiligramLabel = new Label();
            MedicineDosesPerDayLabel = new Label();
            MedicineNumberOfDaysLabel = new Label();
            OrdineretDropdownBox = new ComboBox();
            PetNameTextBox = new TextBox();
            MedicineDropdownBox = new ComboBox();
            MedicineTypeTextBox = new TextBox();
            MedicineMiligramTextBox = new TextBox();
            MedicineDosesPerDayTextBox = new TextBox();
            MedicineNumberOfDaysTextBox = new TextBox();
            ErrorMessageLabel = new Label();
            CancelMedicineButton = new Button();
            CreateMedicineButton = new Button();
            SuspendLayout();
            // 
            // MedicineLabel
            // 
            MedicineLabel.AutoSize = true;
            MedicineLabel.Font = new Font("Gadugi", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MedicineLabel.Location = new Point(200, 31);
            MedicineLabel.Name = "MedicineLabel";
            MedicineLabel.Size = new Size(275, 77);
            MedicineLabel.TabIndex = 6;
            MedicineLabel.Text = "Medicin";
            // 
            // OrdineretLabel
            // 
            OrdineretLabel.AutoSize = true;
            OrdineretLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrdineretLabel.Location = new Point(200, 150);
            OrdineretLabel.Name = "OrdineretLabel";
            OrdineretLabel.Size = new Size(177, 19);
            OrdineretLabel.TabIndex = 7;
            OrdineretLabel.Text = "Medicin ordineret ja/nej";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 190);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 270);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(200, 310);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 11;
            // 
            // PetLabel
            // 
            PetLabel.AutoSize = true;
            PetLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PetLabel.Location = new Point(200, 190);
            PetLabel.Name = "PetLabel";
            PetLabel.Size = new Size(66, 19);
            PetLabel.TabIndex = 14;
            PetLabel.Text = "Kæledyr";
            // 
            // MedicineNameLabel
            // 
            MedicineNameLabel.AutoSize = true;
            MedicineNameLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MedicineNameLabel.Location = new Point(200, 230);
            MedicineNameLabel.Name = "MedicineNameLabel";
            MedicineNameLabel.Size = new Size(64, 19);
            MedicineNameLabel.TabIndex = 15;
            MedicineNameLabel.Text = "Medicin";
            // 
            // MedicineTypeLabel
            // 
            MedicineTypeLabel.AutoSize = true;
            MedicineTypeLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MedicineTypeLabel.Location = new Point(200, 270);
            MedicineTypeLabel.Name = "MedicineTypeLabel";
            MedicineTypeLabel.Size = new Size(43, 19);
            MedicineTypeLabel.TabIndex = 16;
            MedicineTypeLabel.Text = "Type";
            // 
            // MedicineMiligramLabel
            // 
            MedicineMiligramLabel.AutoSize = true;
            MedicineMiligramLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MedicineMiligramLabel.Location = new Point(200, 310);
            MedicineMiligramLabel.Name = "MedicineMiligramLabel";
            MedicineMiligramLabel.Size = new Size(72, 19);
            MedicineMiligramLabel.TabIndex = 17;
            MedicineMiligramLabel.Text = "Miligram";
            // 
            // MedicineDosesPerDayLabel
            // 
            MedicineDosesPerDayLabel.AutoSize = true;
            MedicineDosesPerDayLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MedicineDosesPerDayLabel.Location = new Point(200, 350);
            MedicineDosesPerDayLabel.Name = "MedicineDosesPerDayLabel";
            MedicineDosesPerDayLabel.Size = new Size(147, 19);
            MedicineDosesPerDayLabel.TabIndex = 18;
            MedicineDosesPerDayLabel.Text = "Antal doser per dag";
            // 
            // MedicineNumberOfDaysLabel
            // 
            MedicineNumberOfDaysLabel.AutoSize = true;
            MedicineNumberOfDaysLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MedicineNumberOfDaysLabel.Location = new Point(200, 390);
            MedicineNumberOfDaysLabel.Name = "MedicineNumberOfDaysLabel";
            MedicineNumberOfDaysLabel.Size = new Size(87, 19);
            MedicineNumberOfDaysLabel.TabIndex = 19;
            MedicineNumberOfDaysLabel.Text = "Antal Dage";
            // 
            // OrdineretDropdownBox
            // 
            OrdineretDropdownBox.FormattingEnabled = true;
            OrdineretDropdownBox.Location = new Point(400, 150);
            OrdineretDropdownBox.Name = "OrdineretDropdownBox";
            OrdineretDropdownBox.Size = new Size(121, 23);
            OrdineretDropdownBox.TabIndex = 20;
            // 
            // PetNameTextBox
            // 
            PetNameTextBox.Location = new Point(400, 190);
            PetNameTextBox.Name = "PetNameTextBox";
            PetNameTextBox.Size = new Size(100, 23);
            PetNameTextBox.TabIndex = 21;
            // 
            // MedicineDropdownBox
            // 
            MedicineDropdownBox.FormattingEnabled = true;
            MedicineDropdownBox.Location = new Point(400, 230);
            MedicineDropdownBox.Name = "MedicineDropdownBox";
            MedicineDropdownBox.Size = new Size(121, 23);
            MedicineDropdownBox.TabIndex = 22;
            // 
            // MedicineTypeTextBox
            // 
            MedicineTypeTextBox.Location = new Point(400, 270);
            MedicineTypeTextBox.Name = "MedicineTypeTextBox";
            MedicineTypeTextBox.Size = new Size(100, 23);
            MedicineTypeTextBox.TabIndex = 23;
            // 
            // MedicineMiligramTextBox
            // 
            MedicineMiligramTextBox.Location = new Point(400, 310);
            MedicineMiligramTextBox.Name = "MedicineMiligramTextBox";
            MedicineMiligramTextBox.Size = new Size(100, 23);
            MedicineMiligramTextBox.TabIndex = 24;
            // 
            // MedicineDosesPerDayTextBox
            // 
            MedicineDosesPerDayTextBox.Location = new Point(400, 350);
            MedicineDosesPerDayTextBox.Name = "MedicineDosesPerDayTextBox";
            MedicineDosesPerDayTextBox.Size = new Size(100, 23);
            MedicineDosesPerDayTextBox.TabIndex = 25;
            // 
            // MedicineNumberOfDaysTextBox
            // 
            MedicineNumberOfDaysTextBox.Location = new Point(400, 390);
            MedicineNumberOfDaysTextBox.Name = "MedicineNumberOfDaysTextBox";
            MedicineNumberOfDaysTextBox.Size = new Size(100, 23);
            MedicineNumberOfDaysTextBox.TabIndex = 26;
            // 
            // ErrorMessageLabel
            // 
            ErrorMessageLabel.AutoSize = true;
            ErrorMessageLabel.Location = new Point(328, 423);
            ErrorMessageLabel.Name = "ErrorMessageLabel";
            ErrorMessageLabel.Size = new Size(28, 15);
            ErrorMessageLabel.TabIndex = 27;
            ErrorMessageLabel.Text = "Fejl!";
            // 
            // CancelMedicineButton
            // 
            CancelMedicineButton.BackColor = Color.IndianRed;
            CancelMedicineButton.FlatStyle = FlatStyle.Popup;
            CancelMedicineButton.Location = new Point(200, 461);
            CancelMedicineButton.Name = "CancelMedicineButton";
            CancelMedicineButton.Size = new Size(170, 58);
            CancelMedicineButton.TabIndex = 28;
            CancelMedicineButton.Text = "Annuller";
            CancelMedicineButton.UseVisualStyleBackColor = false;
            // 
            // CreateMedicineButton
            // 
            CreateMedicineButton.BackColor = Color.DarkGray;
            CreateMedicineButton.Enabled = false;
            CreateMedicineButton.FlatStyle = FlatStyle.Popup;
            CreateMedicineButton.Location = new Point(400, 461);
            CreateMedicineButton.Name = "CreateMedicineButton";
            CreateMedicineButton.Size = new Size(170, 58);
            CreateMedicineButton.TabIndex = 29;
            CreateMedicineButton.Text = "Ordinér medcin";
            CreateMedicineButton.UseVisualStyleBackColor = false;
            // 
            // MedicineUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CreateMedicineButton);
            Controls.Add(CancelMedicineButton);
            Controls.Add(ErrorMessageLabel);
            Controls.Add(MedicineNumberOfDaysTextBox);
            Controls.Add(MedicineDosesPerDayTextBox);
            Controls.Add(MedicineMiligramTextBox);
            Controls.Add(MedicineTypeTextBox);
            Controls.Add(MedicineDropdownBox);
            Controls.Add(PetNameTextBox);
            Controls.Add(OrdineretDropdownBox);
            Controls.Add(MedicineNumberOfDaysLabel);
            Controls.Add(MedicineDosesPerDayLabel);
            Controls.Add(MedicineMiligramLabel);
            Controls.Add(MedicineTypeLabel);
            Controls.Add(MedicineNameLabel);
            Controls.Add(PetLabel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(OrdineretLabel);
            Controls.Add(MedicineLabel);
            Name = "MedicineUserControl";
            Size = new Size(709, 580);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MedicineLabel;
        private Label OrdineretLabel;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label PetLabel;
        private Label MedicineNameLabel;
        private Label MedicineTypeLabel;
        private Label MedicineMiligramLabel;
        private Label MedicineDosesPerDayLabel;
        private Label MedicineNumberOfDaysLabel;
        private ComboBox OrdineretDropdownBox;
        private TextBox PetNameTextBox;
        private ComboBox MedicineDropdownBox;
        private TextBox MedicineTypeTextBox;
        private TextBox MedicineMiligramTextBox;
        private TextBox MedicineDosesPerDayTextBox;
        private TextBox MedicineNumberOfDaysTextBox;
        private Label ErrorMessageLabel;
        private Button CancelMedicineButton;
        private Button CreateMedicineButton;
    }
}
