namespace _2SemesterProjekt.Pages
{
    partial class AddPetPage
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
            pageNameLabel = new Label();
            petNameTextbox = new TextBox();
            petSpeciesTextbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            cancelButton = new Button();
            createButton = new Button();
            petBirthdaySelector = new DateTimePicker();
            ownerPhoneNumberTextbox = new TextBox();
            SuspendLayout();
            // 
            // pageNameLabel
            // 
            pageNameLabel.AutoSize = true;
            pageNameLabel.Font = new Font("Gadugi", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pageNameLabel.Location = new Point(330, 48);
            pageNameLabel.Name = "pageNameLabel";
            pageNameLabel.Size = new Size(800, 95);
            pageNameLabel.TabIndex = 3;
            pageNameLabel.Text = "Tilføj et nyt kæledyr";
            pageNameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // petNameTextbox
            // 
            petNameTextbox.Location = new Point(330, 277);
            petNameTextbox.Margin = new Padding(3, 4, 3, 4);
            petNameTextbox.Name = "petNameTextbox";
            petNameTextbox.Size = new Size(271, 27);
            petNameTextbox.TabIndex = 4;
            // 
            // petSpeciesTextbox
            // 
            petSpeciesTextbox.Location = new Point(330, 340);
            petSpeciesTextbox.Margin = new Padding(3, 4, 3, 4);
            petSpeciesTextbox.Name = "petSpeciesTextbox";
            petSpeciesTextbox.Size = new Size(271, 27);
            petSpeciesTextbox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 281);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 7;
            label1.Text = "Navn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 344);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 8;
            label2.Text = "Art";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(243, 409);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 9;
            label3.Text = "Fødselsdato";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(672, 281);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 10;
            label4.Text = "Ejers tlf. nr.";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(753, 340);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(271, 28);
            comboBox1.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(681, 344);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 14;
            label5.Text = "Dyrelæge";
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.IndianRed;
            cancelButton.FlatStyle = FlatStyle.Popup;
            cancelButton.Location = new Point(407, 752);
            cancelButton.Margin = new Padding(3, 4, 3, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(194, 77);
            cancelButton.TabIndex = 15;
            cancelButton.Text = "Annuller";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // createButton
            // 
            createButton.BackColor = Color.MediumAquamarine;
            createButton.FlatStyle = FlatStyle.Popup;
            createButton.Location = new Point(753, 752);
            createButton.Margin = new Padding(3, 4, 3, 4);
            createButton.Name = "createButton";
            createButton.Size = new Size(194, 77);
            createButton.TabIndex = 16;
            createButton.Text = "Tilføj dette kæledyr";
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += createButton_Click;
            // 
            // petBirthdaySelector
            // 
            petBirthdaySelector.Location = new Point(330, 401);
            petBirthdaySelector.Margin = new Padding(3, 4, 3, 4);
            petBirthdaySelector.Name = "petBirthdaySelector";
            petBirthdaySelector.Size = new Size(270, 27);
            petBirthdaySelector.TabIndex = 17;
            // 
            // ownerPhoneNumberTextbox
            // 
            ownerPhoneNumberTextbox.Location = new Point(753, 277);
            ownerPhoneNumberTextbox.Margin = new Padding(3, 4, 3, 4);
            ownerPhoneNumberTextbox.MaxLength = 8;
            ownerPhoneNumberTextbox.Name = "ownerPhoneNumberTextbox";
            ownerPhoneNumberTextbox.Size = new Size(271, 27);
            ownerPhoneNumberTextbox.TabIndex = 18;
            ownerPhoneNumberTextbox.KeyPress += ownerPhoneNumberTextbox_KeyPress;
            // 
            // AddPetPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ownerPhoneNumberTextbox);
            Controls.Add(petBirthdaySelector);
            Controls.Add(createButton);
            Controls.Add(cancelButton);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(petSpeciesTextbox);
            Controls.Add(petNameTextbox);
            Controls.Add(pageNameLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddPetPage";
            Size = new Size(1371, 1100);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pageNameLabel;
        private TextBox petNameTextbox;
        private TextBox petSpeciesTextbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox petBirthdayTextbox;
        private ComboBox comboBox1;
        private Label label5;
        private Button cancelButton;
        private Button createButton;
        private DateTimePicker petBirthdaySelector;
        private TextBox ownerPhoneNumberTextbox;
    }
}
