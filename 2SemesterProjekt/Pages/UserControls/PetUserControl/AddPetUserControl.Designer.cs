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
            comboBoxSpecies = new ComboBox();
            SuspendLayout();
            // 
            // pageNameLabel
            // 
            pageNameLabel.AutoSize = true;
            pageNameLabel.Font = new Font("Gadugi", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pageNameLabel.Location = new Point(288, 36);
            pageNameLabel.Name = "pageNameLabel";
            pageNameLabel.Size = new Size(642, 77);
            pageNameLabel.TabIndex = 3;
            pageNameLabel.Text = "Tilføj et nyt kæledyr";
            pageNameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // petNameTextbox
            // 
            petNameTextbox.Location = new Point(288, 208);
            petNameTextbox.Name = "petNameTextbox";
            petNameTextbox.Size = new Size(238, 23);
            petNameTextbox.TabIndex = 4;
            petNameTextbox.KeyPress += petNameTextbox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 211);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 7;
            label1.Text = "Navn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 258);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 8;
            label2.Text = "Art";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 307);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 9;
            label3.Text = "Fødselsdato";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(588, 211);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 10;
            label4.Text = "Ejers tlf. nr.";
            // 
            // comboBoxPrimaryVeterinarian
            // 
            comboBoxPrimaryVeterinarian.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPrimaryVeterinarian.FormattingEnabled = true;
            comboBoxPrimaryVeterinarian.Location = new Point(659, 255);
            comboBoxPrimaryVeterinarian.Name = "comboBoxPrimaryVeterinarian";
            comboBoxPrimaryVeterinarian.Size = new Size(238, 23);
            comboBoxPrimaryVeterinarian.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(596, 258);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 14;
            label5.Text = "Dyrelæge";
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.IndianRed;
            cancelButton.FlatStyle = FlatStyle.Popup;
            cancelButton.Location = new Point(356, 564);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(169, 58);
            cancelButton.TabIndex = 15;
            cancelButton.Text = "Annuller";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // createButton
            // 
            createButton.BackColor = Color.MediumAquamarine;
            createButton.FlatStyle = FlatStyle.Popup;
            createButton.Location = new Point(659, 564);
            createButton.Name = "createButton";
            createButton.Size = new Size(169, 58);
            createButton.TabIndex = 16;
            createButton.Text = "Tilføj dette kæledyr";
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += createButton_Click;
            // 
            // petBirthdaySelector
            // 
            petBirthdaySelector.Location = new Point(288, 301);
            petBirthdaySelector.Name = "petBirthdaySelector";
            petBirthdaySelector.Size = new Size(236, 23);
            petBirthdaySelector.TabIndex = 17;
            // 
            // ownerPhoneNumberTextbox
            // 
            ownerPhoneNumberTextbox.Location = new Point(659, 208);
            ownerPhoneNumberTextbox.MaxLength = 8;
            ownerPhoneNumberTextbox.Name = "ownerPhoneNumberTextbox";
            ownerPhoneNumberTextbox.Size = new Size(238, 23);
            ownerPhoneNumberTextbox.TabIndex = 18;
            ownerPhoneNumberTextbox.KeyPress += ownerPhoneNumberTextbox_KeyPress;
            // 
            // comboBoxSpecies
            // 
            comboBoxSpecies.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSpecies.FormattingEnabled = true;
            comboBoxSpecies.Location = new Point(288, 255);
            comboBoxSpecies.Name = "comboBoxSpecies";
            comboBoxSpecies.Size = new Size(238, 23);
            comboBoxSpecies.TabIndex = 19;
            // 
            // AddPetUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBoxSpecies);
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
            Controls.Add(petNameTextbox);
            Controls.Add(pageNameLabel);
            Name = "AddPetUserControl";
            Size = new Size(1200, 825);
            Load += AddPetPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pageNameLabel;
        private TextBox petNameTextbox;
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
        private ComboBox comboBoxSpecies;
    }
}
