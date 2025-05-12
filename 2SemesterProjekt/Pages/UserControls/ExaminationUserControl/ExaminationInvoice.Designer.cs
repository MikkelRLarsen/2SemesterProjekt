namespace _2SemesterProjekt.Pages.UserControls.ExaminationUserControl
{
    partial class ExaminationInvoice
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
            label1 = new Label();
            customerNameTextbox = new TextBox();
            label2 = new Label();
            petNameTextBox = new TextBox();
            label3 = new Label();
            dateTextBox = new TextBox();
            label4 = new Label();
            examinationTextBox = new TextBox();
            label5 = new Label();
            totalPriceTextBox = new TextBox();
            labelCageBooking = new Label();
            cageBookingTextBox = new TextBox();
            createButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // pageNameLabel
            // 
            pageNameLabel.AutoSize = true;
            pageNameLabel.Font = new Font("Gadugi", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pageNameLabel.Location = new Point(288, 36);
            pageNameLabel.Name = "pageNameLabel";
            pageNameLabel.Size = new Size(573, 77);
            pageNameLabel.TabIndex = 4;
            pageNameLabel.Text = "Faktura for kunde";
            pageNameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(393, 185);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 9;
            label1.Text = "Kundenavn:";
            // 
            // customerNameTextbox
            // 
            customerNameTextbox.Location = new Point(469, 182);
            customerNameTextbox.Name = "customerNameTextbox";
            customerNameTextbox.Size = new Size(238, 23);
            customerNameTextbox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(410, 238);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 11;
            label2.Text = "Kæledyr:";
            // 
            // petNameTextBox
            // 
            petNameTextBox.Location = new Point(469, 235);
            petNameTextBox.Name = "petNameTextBox";
            petNameTextBox.Size = new Size(238, 23);
            petNameTextBox.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(428, 303);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 13;
            label3.Text = "Dato:";
            // 
            // dateTextBox
            // 
            dateTextBox.Location = new Point(469, 300);
            dateTextBox.Name = "dateTextBox";
            dateTextBox.Size = new Size(238, 23);
            dateTextBox.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(356, 371);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 15;
            label4.Text = "Udført behandling:";
            // 
            // examinationTextBox
            // 
            examinationTextBox.Location = new Point(469, 368);
            examinationTextBox.Name = "examinationTextBox";
            examinationTextBox.Size = new Size(238, 23);
            examinationTextBox.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(405, 441);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 17;
            label5.Text = "Total pris:";
            // 
            // totalPriceTextBox
            // 
            totalPriceTextBox.Location = new Point(469, 438);
            totalPriceTextBox.Name = "totalPriceTextBox";
            totalPriceTextBox.Size = new Size(238, 23);
            totalPriceTextBox.TabIndex = 16;
            // 
            // labelCageBooking
            // 
            labelCageBooking.AutoSize = true;
            labelCageBooking.Location = new Point(391, 405);
            labelCageBooking.Name = "labelCageBooking";
            labelCageBooking.Size = new Size(72, 15);
            labelCageBooking.TabIndex = 18;
            labelCageBooking.Text = "Burbooking:";
            labelCageBooking.Visible = false;
            // 
            // cageBookingTextBox
            // 
            cageBookingTextBox.Location = new Point(469, 402);
            cageBookingTextBox.Name = "cageBookingTextBox";
            cageBookingTextBox.Size = new Size(238, 23);
            cageBookingTextBox.TabIndex = 19;
            cageBookingTextBox.Visible = false;
            // 
            // createButton
            // 
            createButton.BackColor = Color.MediumAquamarine;
            createButton.FlatStyle = FlatStyle.Popup;
            createButton.Location = new Point(707, 593);
            createButton.Name = "createButton";
            createButton.Size = new Size(169, 58);
            createButton.TabIndex = 20;
            createButton.Text = "Opret faktura";
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += createButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.IndianRed;
            cancelButton.FlatStyle = FlatStyle.Popup;
            cancelButton.Location = new Point(294, 593);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(169, 58);
            cancelButton.TabIndex = 21;
            cancelButton.Text = "Annuller";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // ExaminationInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cancelButton);
            Controls.Add(createButton);
            Controls.Add(cageBookingTextBox);
            Controls.Add(labelCageBooking);
            Controls.Add(label5);
            Controls.Add(totalPriceTextBox);
            Controls.Add(label4);
            Controls.Add(examinationTextBox);
            Controls.Add(label3);
            Controls.Add(dateTextBox);
            Controls.Add(label2);
            Controls.Add(petNameTextBox);
            Controls.Add(label1);
            Controls.Add(customerNameTextbox);
            Controls.Add(pageNameLabel);
            Name = "ExaminationInvoice";
            Size = new Size(1200, 825);
            Load += ExaminationInvoice_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pageNameLabel;
        private Label label1;
        private TextBox customerNameTextbox;
        private Label label2;
        private TextBox petNameTextBox;
        private Label label3;
        private TextBox dateTextBox;
        private Label label4;
        private TextBox examinationTextBox;
        private Label label5;
        private TextBox totalPriceTextBox;
        private Label labelCageBooking;
        private TextBox cageBookingTextBox;
        private Button createButton;
        private Button cancelButton;
    }
}
