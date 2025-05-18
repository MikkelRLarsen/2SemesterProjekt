namespace _2SemesterProjekt.Pages.UserControls.CustomerUserControl
{
    partial class UpdateCustomerUserControl
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
            textBoxFirstName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxLastName = new TextBox();
            label3 = new Label();
            textBoxEmail = new TextBox();
            textBoxAddress = new TextBox();
            label4 = new Label();
            label5 = new Label();
            panelCancel = new Panel();
            panelCreate = new Panel();
            textBoxPhoneNumber = new TextBox();
            comboBoxCustomerType = new ComboBox();
            SuspendLayout();
            // 
            // pageNameLabel
            // 
            pageNameLabel.AutoSize = true;
            pageNameLabel.Font = new Font("Gadugi", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pageNameLabel.Location = new Point(356, 36);
            pageNameLabel.Name = "pageNameLabel";
            pageNameLabel.Size = new Size(439, 77);
            pageNameLabel.TabIndex = 1;
            pageNameLabel.Text = "Ændre kunde";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Gadugi", 19F, FontStyle.Bold);
            labelFirstName.Location = new Point(174, 286);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(114, 31);
            labelFirstName.TabIndex = 3;
            labelFirstName.Text = "Fornavn";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new Font("Gadugi", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFirstName.Location = new Point(340, 286);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(230, 41);
            textBoxFirstName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 19F, FontStyle.Bold);
            label1.Location = new Point(208, 383);
            label1.Name = "label1";
            label1.Size = new Size(80, 31);
            label1.TabIndex = 5;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 19F, FontStyle.Bold);
            label2.Location = new Point(638, 286);
            label2.Name = "label2";
            label2.Size = new Size(132, 31);
            label2.TabIndex = 6;
            label2.Text = "Efternavn";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new Font("Gadugi", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLastName.Location = new Point(842, 284);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(230, 41);
            textBoxLastName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 19F, FontStyle.Bold);
            label3.Location = new Point(638, 381);
            label3.Name = "label3";
            label3.Size = new Size(108, 31);
            label3.TabIndex = 8;
            label3.Text = "Adresse";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Gadugi", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.Location = new Point(340, 381);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(230, 41);
            textBoxEmail.TabIndex = 9;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Gadugi", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAddress.Location = new Point(842, 381);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(230, 41);
            textBoxAddress.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gadugi", 19F, FontStyle.Bold);
            label4.Location = new Point(78, 476);
            label4.Name = "label4";
            label4.Size = new Size(210, 31);
            label4.TabIndex = 11;
            label4.Text = "Telefonnummer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 19F, FontStyle.Bold);
            label5.Location = new Point(638, 476);
            label5.Name = "label5";
            label5.Size = new Size(147, 31);
            label5.TabIndex = 12;
            label5.Text = "Kundetype";
            // 
            // panelCancel
            // 
            panelCancel.Location = new Point(341, 684);
            panelCancel.Name = "panelCancel";
            panelCancel.Size = new Size(209, 59);
            panelCancel.TabIndex = 13;
            // 
            // panelCreate
            // 
            panelCreate.Location = new Point(650, 684);
            panelCreate.Name = "panelCreate";
            panelCreate.Size = new Size(209, 59);
            panelCreate.TabIndex = 8;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Font = new Font("Gadugi", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPhoneNumber.Location = new Point(340, 474);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(230, 41);
            textBoxPhoneNumber.TabIndex = 14;
            textBoxPhoneNumber.KeyPress += textBoxPhoneNumber_KeyPress;
            // 
            // comboBoxCustomerType
            // 
            comboBoxCustomerType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCustomerType.Font = new Font("Gadugi", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxCustomerType.FormattingEnabled = true;
            comboBoxCustomerType.Location = new Point(842, 476);
            comboBoxCustomerType.Name = "comboBoxCustomerType";
            comboBoxCustomerType.Size = new Size(240, 37);
            comboBoxCustomerType.TabIndex = 15;
            // 
            // UpdateCustomerUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBoxCustomerType);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(panelCreate);
            Controls.Add(panelCancel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxEmail);
            Controls.Add(label3);
            Controls.Add(textBoxLastName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelFirstName);
            Controls.Add(pageNameLabel);
            Name = "UpdateCustomerUserControl";
            Size = new Size(1200, 825);
            Load += UpdateCustomerUserControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pageNameLabel;
        private Label labelFirstName;
        private TextBox textBoxFirstName;
        private Label label1;
        private Label label2;
        private TextBox textBoxLastName;
        private Label label3;
        private TextBox textBoxEmail;
        private TextBox textBoxAddress;
        private Label label4;
        private Label label5;
        private Panel panelCancel;
        private Panel panelCreate;
        private TextBox textBoxPhoneNumber;
        private ComboBox comboBoxCustomerType;
    }
}
