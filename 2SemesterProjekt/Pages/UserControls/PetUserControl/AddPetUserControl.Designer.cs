namespace _2SemesterProjekt.Pages
{
    partial class AddPetUserControl
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
            comboBoxPrimaryVeterinarian = new ComboBox();
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
            pageNameLabel.Location = new Point(412, 60);
            pageNameLabel.Margin = new Padding(4, 0, 4, 0);
            pageNameLabel.Name = "pageNameLabel";
            pageNameLabel.Size = new Size(958, 115);
            pageNameLabel.TabIndex = 3;
            pageNameLabel.Text = "Tilføj et nyt kæledyr";
            pageNameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // petNameTextbox
            // 
            petNameTextbox.Location = new Point(412, 346);
            petNameTextbox.Margin = new Padding(4, 5, 4, 5);
            petNameTextbox.Name = "petNameTextbox";
            petNameTextbox.Size = new Size(338, 31);
            petNameTextbox.TabIndex = 4;
            // 
            // petSpeciesTextbox
            // 
            petSpeciesTextbox.Location = new Point(412, 425);
            petSpeciesTextbox.Margin = new Padding(4, 5, 4, 5);
            petSpeciesTextbox.Name = "petSpeciesTextbox";
            petSpeciesTextbox.Size = new Size(338, 31);
            petSpeciesTextbox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(354, 351);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 7;
            label1.Text = "Navn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(371, 430);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(36, 25);
            label2.TabIndex = 8;
            label2.Text = "Art";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(304, 511);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 9;
            label3.Text = "Fødselsdato";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(840, 351);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 10;
            label4.Text = "Ejers tlf. nr.";
            // 
            // comboBoxPrimaryVeterinarian
            // 
            comboBoxPrimaryVeterinarian.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPrimaryVeterinarian.FormattingEnabled = true;
            comboBoxPrimaryVeterinarian.Location = new Point(941, 425);
            comboBoxPrimaryVeterinarian.Margin = new Padding(4, 5, 4, 5);
            comboBoxPrimaryVeterinarian.Name = "comboBoxPrimaryVeterinarian";
            comboBoxPrimaryVeterinarian.Size = new Size(338, 33);
            comboBoxPrimaryVeterinarian.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(851, 430);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 14;
            label5.Text = "Dyrelæge";
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.IndianRed;
            cancelButton.FlatStyle = FlatStyle.Popup;
            cancelButton.Location = new Point(509, 940);
            cancelButton.Margin = new Padding(4, 5, 4, 5);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(242, 96);
            cancelButton.TabIndex = 15;
            cancelButton.Text = "Annuller";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // createButton
            // 
            createButton.BackColor = Color.MediumAquamarine;
            createButton.FlatStyle = FlatStyle.Popup;
            createButton.Location = new Point(941, 940);
            createButton.Margin = new Padding(4, 5, 4, 5);
            createButton.Name = "createButton";
            createButton.Size = new Size(242, 96);
            createButton.TabIndex = 16;
            createButton.Text = "Tilføj dette kæledyr";
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += createButton_Click;
            // 
            // petBirthdaySelector
            // 
            petBirthdaySelector.Location = new Point(412, 501);
            petBirthdaySelector.Margin = new Padding(4, 5, 4, 5);
            petBirthdaySelector.Name = "petBirthdaySelector";
            petBirthdaySelector.Size = new Size(336, 31);
            petBirthdaySelector.TabIndex = 17;
            // 
            // ownerPhoneNumberTextbox
            // 
            ownerPhoneNumberTextbox.Location = new Point(941, 346);
            ownerPhoneNumberTextbox.Margin = new Padding(4, 5, 4, 5);
            ownerPhoneNumberTextbox.MaxLength = 8;
            ownerPhoneNumberTextbox.Name = "ownerPhoneNumberTextbox";
            ownerPhoneNumberTextbox.Size = new Size(338, 31);
            ownerPhoneNumberTextbox.TabIndex = 18;
            ownerPhoneNumberTextbox.KeyPress += ownerPhoneNumberTextbox_KeyPress;
            // 
            // AddPetPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ownerPhoneNumberTextbox);
            Controls.Add(petBirthdaySelector);
            Controls.Add(createButton);
            Controls.Add(cancelButton);
            Controls.Add(label5);
            Controls.Add(comboBoxPrimaryVeterinarian);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(petSpeciesTextbox);
            Controls.Add(petNameTextbox);
            Controls.Add(pageNameLabel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddPetPage";
            Size = new Size(1714, 1375);
            Load += AddPetPage_Load;
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
        private ComboBox comboBoxPrimaryVeterinarian;
        private Label label5;
        private Button cancelButton;
        private Button createButton;
        private DateTimePicker petBirthdaySelector;
        private TextBox ownerPhoneNumberTextbox;
    }
}
