namespace _2SemesterProjekt.Pages.UserControls.PetUserControl
{
    partial class UpdatePetUserControl
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
            petSpeciesTextbox = new TextBox();
            label2 = new Label();
            petBirthdaySelector = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            ownerPhoneNumberTextbox = new TextBox();
            label5 = new Label();
            comboBoxPrimaryVeterinarian = new ComboBox();
            cancelButton = new Button();
            updateButton = new Button();
            SuspendLayout();
            // 
            // pageNameLabel
            // 
            pageNameLabel.AutoSize = true;
            pageNameLabel.Font = new Font("Gadugi", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pageNameLabel.Location = new Point(336, 39);
            pageNameLabel.Name = "pageNameLabel";
            pageNameLabel.Size = new Size(527, 77);
            pageNameLabel.TabIndex = 4;
            pageNameLabel.Text = "Redigér kæledyr";
            pageNameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // petNameTextbox
            // 
            petNameTextbox.Location = new Point(288, 208);
            petNameTextbox.Name = "petNameTextbox";
            petNameTextbox.Size = new Size(238, 23);
            petNameTextbox.TabIndex = 5;
            petNameTextbox.KeyPress += petNameTextbox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 211);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 8;
            label1.Text = "Navn";
            // 
            // petSpeciesTextbox
            // 
            petSpeciesTextbox.Location = new Point(288, 255);
            petSpeciesTextbox.Name = "petSpeciesTextbox";
            petSpeciesTextbox.Size = new Size(238, 23);
            petSpeciesTextbox.TabIndex = 9;
            petSpeciesTextbox.KeyPress += petSpeciesTextbox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 258);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 10;
            label2.Text = "Art";
            // 
            // petBirthdaySelector
            // 
            petBirthdaySelector.Location = new Point(288, 301);
            petBirthdaySelector.Name = "petBirthdaySelector";
            petBirthdaySelector.Size = new Size(236, 23);
            petBirthdaySelector.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 307);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 19;
            label3.Text = "Fødselsdato";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(588, 211);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 20;
            label4.Text = "Ejers tlf. nr.";
            // 
            // ownerPhoneNumberTextbox
            // 
            ownerPhoneNumberTextbox.Location = new Point(659, 208);
            ownerPhoneNumberTextbox.MaxLength = 8;
            ownerPhoneNumberTextbox.Name = "ownerPhoneNumberTextbox";
            ownerPhoneNumberTextbox.Size = new Size(238, 23);
            ownerPhoneNumberTextbox.TabIndex = 21;
            ownerPhoneNumberTextbox.KeyPress += ownerPhoneNumberTextbox_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(596, 258);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 22;
            label5.Text = "Dyrelæge";
            // 
            // comboBoxPrimaryVeterinarian
            // 
            comboBoxPrimaryVeterinarian.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPrimaryVeterinarian.FormattingEnabled = true;
            comboBoxPrimaryVeterinarian.Location = new Point(659, 255);
            comboBoxPrimaryVeterinarian.Name = "comboBoxPrimaryVeterinarian";
            comboBoxPrimaryVeterinarian.Size = new Size(238, 23);
            comboBoxPrimaryVeterinarian.TabIndex = 23;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.IndianRed;
            cancelButton.FlatStyle = FlatStyle.Popup;
            cancelButton.Location = new Point(356, 564);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(169, 58);
            cancelButton.TabIndex = 24;
            cancelButton.Text = "Annuller";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.MediumAquamarine;
            updateButton.FlatStyle = FlatStyle.Popup;
            updateButton.Location = new Point(659, 564);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(169, 58);
            updateButton.TabIndex = 25;
            updateButton.Text = "Redigér kæledyr";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // UpdatePetUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(updateButton);
            Controls.Add(cancelButton);
            Controls.Add(comboBoxPrimaryVeterinarian);
            Controls.Add(label5);
            Controls.Add(ownerPhoneNumberTextbox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(petBirthdaySelector);
            Controls.Add(label2);
            Controls.Add(petSpeciesTextbox);
            Controls.Add(label1);
            Controls.Add(petNameTextbox);
            Controls.Add(pageNameLabel);
            Name = "UpdatePetUserControl";
            Size = new Size(1200, 825);
            Load += UpdatePetUserControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pageNameLabel;
        private TextBox petNameTextbox;
        private Label label1;
        private TextBox petSpeciesTextbox;
        private Label label2;
        private DateTimePicker petBirthdaySelector;
        private Label label3;
        private Label label4;
        private TextBox ownerPhoneNumberTextbox;
        private Label label5;
        private ComboBox comboBoxPrimaryVeterinarian;
        private Button cancelButton;
        private Button updateButton;
    }
}
