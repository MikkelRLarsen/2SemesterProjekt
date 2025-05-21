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
            panelCancel = new Panel();
            panelCreate = new Panel();
            textBoxPhoneNumber = new TextBox();
            SuspendLayout();
            // 
            // pageNameLabel
            // 
            pageNameLabel.AutoSize = true;
            pageNameLabel.Font = new Font("Gadugi", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pageNameLabel.Location = new Point(407, 48);
            pageNameLabel.Name = "pageNameLabel";
            pageNameLabel.Size = new Size(544, 95);
            pageNameLabel.TabIndex = 1;
            pageNameLabel.Text = "Ændre kunde";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Gadugi", 19F, FontStyle.Bold);
            labelFirstName.Location = new Point(199, 381);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(139, 38);
            labelFirstName.TabIndex = 3;
            labelFirstName.Text = "Fornavn";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new Font("Gadugi", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFirstName.Location = new Point(389, 381);
            textBoxFirstName.Margin = new Padding(3, 4, 3, 4);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(262, 49);
            textBoxFirstName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 19F, FontStyle.Bold);
            label1.Location = new Point(238, 511);
            label1.Name = "label1";
            label1.Size = new Size(98, 38);
            label1.TabIndex = 5;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 19F, FontStyle.Bold);
            label2.Location = new Point(729, 381);
            label2.Name = "label2";
            label2.Size = new Size(160, 38);
            label2.TabIndex = 6;
            label2.Text = "Efternavn";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new Font("Gadugi", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLastName.Location = new Point(962, 379);
            textBoxLastName.Margin = new Padding(3, 4, 3, 4);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(262, 49);
            textBoxLastName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 19F, FontStyle.Bold);
            label3.Location = new Point(729, 508);
            label3.Name = "label3";
            label3.Size = new Size(135, 38);
            label3.TabIndex = 8;
            label3.Text = "Adresse";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Gadugi", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.Location = new Point(389, 508);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(262, 49);
            textBoxEmail.TabIndex = 9;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Gadugi", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAddress.Location = new Point(962, 508);
            textBoxAddress.Margin = new Padding(3, 4, 3, 4);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(262, 49);
            textBoxAddress.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gadugi", 19F, FontStyle.Bold);
            label4.Location = new Point(89, 635);
            label4.Name = "label4";
            label4.Size = new Size(256, 38);
            label4.TabIndex = 11;
            label4.Text = "Telefonnummer";
            // 
            // panelCancel
            // 
            panelCancel.Location = new Point(390, 912);
            panelCancel.Margin = new Padding(3, 4, 3, 4);
            panelCancel.Name = "panelCancel";
            panelCancel.Size = new Size(239, 79);
            panelCancel.TabIndex = 13;
            // 
            // panelCreate
            // 
            panelCreate.Location = new Point(743, 912);
            panelCreate.Margin = new Padding(3, 4, 3, 4);
            panelCreate.Name = "panelCreate";
            panelCreate.Size = new Size(239, 79);
            panelCreate.TabIndex = 8;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Font = new Font("Gadugi", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPhoneNumber.Location = new Point(389, 632);
            textBoxPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(262, 49);
            textBoxPhoneNumber.TabIndex = 14;
            textBoxPhoneNumber.KeyPress += textBoxPhoneNumber_KeyPress;
            // 
            // UpdateCustomerUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(panelCreate);
            Controls.Add(panelCancel);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "UpdateCustomerUserControl";
            Size = new Size(1371, 1100);
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
        private Panel panelCancel;
        private Panel panelCreate;
        private TextBox textBoxPhoneNumber;
    }
}
