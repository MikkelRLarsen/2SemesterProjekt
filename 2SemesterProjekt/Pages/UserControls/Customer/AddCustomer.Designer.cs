namespace _2SemesterProjekt
{
	partial class AddCustomer
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
            labelFirstName = new Label();
            labelLastName = new Label();
            labelEmail = new Label();
            labelAddress = new Label();
            labelPhoneNumber = new Label();
            labelType = new Label();
            comboBoxType = new ComboBox();
            textBoxAddress = new TextBox();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPhoneNumber = new TextBox();
            panelCancel = new Panel();
            panelCreate = new Panel();
            SuspendLayout();
            // 
            // pageNameLabel
            // 
            pageNameLabel.AutoSize = true;
            pageNameLabel.Font = new Font("Gadugi", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pageNameLabel.Location = new Point(509, 60);
            pageNameLabel.Margin = new Padding(4, 0, 4, 0);
            pageNameLabel.Name = "pageNameLabel";
            pageNameLabel.Size = new Size(725, 115);
            pageNameLabel.TabIndex = 0;
            pageNameLabel.Text = "Tilføj ny kunde";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Gadugi", 19F, FontStyle.Bold);
            labelFirstName.Location = new Point(249, 477);
            labelFirstName.Margin = new Padding(4, 0, 4, 0);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(165, 45);
            labelFirstName.TabIndex = 2;
            labelFirstName.Text = "Fornavn";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Gadugi", 19F, FontStyle.Bold);
            labelLastName.Location = new Point(911, 477);
            labelLastName.Margin = new Padding(4, 0, 4, 0);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(193, 45);
            labelLastName.TabIndex = 3;
            labelLastName.Text = "Efternavn";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Gadugi", 19F, FontStyle.Bold);
            labelEmail.Location = new Point(297, 638);
            labelEmail.Margin = new Padding(4, 0, 4, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(117, 45);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Gadugi", 19F, FontStyle.Bold);
            labelAddress.Location = new Point(911, 635);
            labelAddress.Margin = new Padding(4, 0, 4, 0);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(162, 45);
            labelAddress.TabIndex = 5;
            labelAddress.Text = "Adresse";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Font = new Font("Gadugi", 19F, FontStyle.Bold);
            labelPhoneNumber.Location = new Point(111, 793);
            labelPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(308, 45);
            labelPhoneNumber.TabIndex = 5;
            labelPhoneNumber.Text = "Telefonnummer";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Gadugi", 19F, FontStyle.Bold);
            labelType.Location = new Point(911, 793);
            labelType.Margin = new Padding(4, 0, 4, 0);
            labelType.Name = "labelType";
            labelType.Size = new Size(216, 45);
            labelType.TabIndex = 5;
            labelType.Text = "Kundetype";
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.Font = new Font("Gadugi", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(1203, 793);
            comboBoxType.Margin = new Padding(4, 5, 4, 5);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(341, 53);
            comboBoxType.TabIndex = 6;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Gadugi", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAddress.Location = new Point(1203, 635);
            textBoxAddress.Margin = new Padding(4, 5, 4, 5);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(327, 57);
            textBoxAddress.TabIndex = 4;
            textBoxAddress.KeyPress += textBoxAddress_KeyPress;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new Font("Gadugi", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLastName.Location = new Point(1203, 473);
            textBoxLastName.Margin = new Padding(4, 5, 4, 5);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(327, 57);
            textBoxLastName.TabIndex = 2;
            textBoxLastName.KeyPress += textBoxLastName_KeyPress;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new Font("Gadugi", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFirstName.Location = new Point(486, 477);
            textBoxFirstName.Margin = new Padding(4, 5, 4, 5);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(327, 57);
            textBoxFirstName.TabIndex = 1;
            textBoxFirstName.KeyPress += textBoxFirstName_KeyPress;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Gadugi", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.Location = new Point(486, 635);
            textBoxEmail.Margin = new Padding(4, 5, 4, 5);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(327, 57);
            textBoxEmail.TabIndex = 3;
            textBoxEmail.KeyPress += textBoxEmail_KeyPress;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Font = new Font("Gadugi", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPhoneNumber.Location = new Point(486, 790);
            textBoxPhoneNumber.Margin = new Padding(4, 5, 4, 5);
            textBoxPhoneNumber.MaxLength = 8;
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(327, 57);
            textBoxPhoneNumber.TabIndex = 5;
            textBoxPhoneNumber.KeyPress += textBoxPhoneNumber_KeyPress;
            // 
            // panelCancel
            // 
            panelCancel.Location = new Point(487, 1140);
            panelCancel.Margin = new Padding(4, 5, 4, 5);
            panelCancel.Name = "panelCancel";
            panelCancel.Size = new Size(299, 98);
            panelCancel.TabIndex = 7;
            // 
            // panelCreate
            // 
            panelCreate.Location = new Point(929, 1140);
            panelCreate.Margin = new Padding(4, 5, 4, 5);
            panelCreate.Name = "panelCreate";
            panelCreate.Size = new Size(299, 98);
            panelCreate.TabIndex = 8;
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelCreate);
            Controls.Add(panelCancel);
            Controls.Add(comboBoxType);
            Controls.Add(labelType);
            Controls.Add(labelPhoneNumber);
            Controls.Add(labelAddress);
            Controls.Add(labelEmail);
            Controls.Add(labelLastName);
            Controls.Add(labelFirstName);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxAddress);
            Controls.Add(pageNameLabel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddCustomer";
            Size = new Size(1714, 1375);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pageNameLabel;
		private Label labelFirstName;
		private Label labelLastName;
		private Label labelEmail;
		private Label labelAddress;
		private Label labelPhoneNumber;
		private Label labelType;
		private ComboBox comboBoxType;
		private TextBox textBoxAddress;
		private TextBox textBoxLastName;
		private TextBox textBoxFirstName;
		private TextBox textBoxEmail;
		private TextBox textBoxPhoneNumber;
		private Panel panelCancel;
		private Panel panelCreate;
	}
}
