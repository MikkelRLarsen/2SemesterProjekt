namespace _2SemesterProjekt.Pages.UserControls.Product
{
    partial class CreateOrder
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
            label1 = new Label();
            customerPhoneNumberTextbox = new TextBox();
            label2 = new Label();
            customerNameLabel = new Label();
            customerAddressLabel = new Label();
            customerEmailLabel = new Label();
            orderListBox = new ListBox();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            getCustomerButton = new Button();
            createOrderButton = new Button();
            cancelButton = new Button();
            label7 = new Label();
            productsListBox = new ListBox();
            addToOrderButton = new Button();
            productSearchTextbox = new TextBox();
            productSearchButton = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(154, 35);
            label1.Name = "label1";
            label1.Size = new Size(399, 77);
            label1.TabIndex = 6;
            label1.Text = "Opret Ordre";
            // 
            // customerPhoneNumberTextbox
            // 
            customerPhoneNumberTextbox.BorderStyle = BorderStyle.FixedSingle;
            customerPhoneNumberTextbox.Location = new Point(114, 145);
            customerPhoneNumberTextbox.Name = "customerPhoneNumberTextbox";
            customerPhoneNumberTextbox.Size = new Size(118, 23);
            customerPhoneNumberTextbox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 148);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 8;
            label2.Text = "Kundes tlf. nr.";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new Point(114, 180);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new Size(228, 15);
            customerNameLabel.TabIndex = 9;
            customerNameLabel.Text = "customerFirstName + customerLastName";
            customerNameLabel.Visible = false;
            // 
            // customerAddressLabel
            // 
            customerAddressLabel.AutoSize = true;
            customerAddressLabel.Location = new Point(114, 195);
            customerAddressLabel.Name = "customerAddressLabel";
            customerAddressLabel.Size = new Size(99, 15);
            customerAddressLabel.TabIndex = 10;
            customerAddressLabel.Text = "customerAddress";
            customerAddressLabel.Visible = false;
            // 
            // customerEmailLabel
            // 
            customerEmailLabel.AutoSize = true;
            customerEmailLabel.Location = new Point(114, 210);
            customerEmailLabel.Name = "customerEmailLabel";
            customerEmailLabel.Size = new Size(86, 15);
            customerEmailLabel.TabIndex = 11;
            customerEmailLabel.Text = "customerEmail";
            customerEmailLabel.Visible = false;
            // 
            // orderListBox
            // 
            orderListBox.Enabled = false;
            orderListBox.FormattingEnabled = true;
            orderListBox.ItemHeight = 15;
            orderListBox.Location = new Point(114, 259);
            orderListBox.Name = "orderListBox";
            orderListBox.Size = new Size(210, 139);
            orderListBox.TabIndex = 12;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Enabled = false;
            numericUpDown1.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Location = new Point(114, 404);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(210, 23);
            numericUpDown1.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(50, 406);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 15;
            label6.Text = "Rabat i %";
            // 
            // getCustomerButton
            // 
            getCustomerButton.FlatStyle = FlatStyle.Popup;
            getCustomerButton.Location = new Point(244, 145);
            getCustomerButton.Name = "getCustomerButton";
            getCustomerButton.Size = new Size(80, 23);
            getCustomerButton.TabIndex = 16;
            getCustomerButton.Text = "Find kunde";
            getCustomerButton.UseVisualStyleBackColor = true;
            getCustomerButton.Click += getCustomerButton_Click;
            // 
            // createOrderButton
            // 
            createOrderButton.BackColor = Color.DarkGray;
            createOrderButton.Enabled = false;
            createOrderButton.FlatStyle = FlatStyle.Popup;
            createOrderButton.Location = new Point(383, 470);
            createOrderButton.Name = "createOrderButton";
            createOrderButton.Size = new Size(170, 58);
            createOrderButton.TabIndex = 17;
            createOrderButton.Text = "Opret ordre";
            createOrderButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.IndianRed;
            cancelButton.FlatStyle = FlatStyle.Popup;
            cancelButton.Location = new Point(154, 470);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(170, 58);
            cancelButton.TabIndex = 18;
            cancelButton.Text = "Annuller";
            cancelButton.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(114, 241);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 19;
            label7.Text = "Ordreliste";
            // 
            // productsListBox
            // 
            productsListBox.Enabled = false;
            productsListBox.FormattingEnabled = true;
            productsListBox.ItemHeight = 15;
            productsListBox.Location = new Point(383, 184);
            productsListBox.Name = "productsListBox";
            productsListBox.Size = new Size(210, 244);
            productsListBox.TabIndex = 20;
            // 
            // addToOrderButton
            // 
            addToOrderButton.Enabled = false;
            addToOrderButton.FlatStyle = FlatStyle.Popup;
            addToOrderButton.Location = new Point(599, 405);
            addToOrderButton.Name = "addToOrderButton";
            addToOrderButton.Size = new Size(86, 23);
            addToOrderButton.TabIndex = 21;
            addToOrderButton.Text = "Tilføj til ordre";
            addToOrderButton.UseVisualStyleBackColor = true;
            // 
            // productSearchTextbox
            // 
            productSearchTextbox.BorderStyle = BorderStyle.FixedSingle;
            productSearchTextbox.Enabled = false;
            productSearchTextbox.Location = new Point(383, 146);
            productSearchTextbox.Name = "productSearchTextbox";
            productSearchTextbox.Size = new Size(210, 23);
            productSearchTextbox.TabIndex = 22;
            // 
            // productSearchButton
            // 
            productSearchButton.Enabled = false;
            productSearchButton.FlatStyle = FlatStyle.Popup;
            productSearchButton.Location = new Point(599, 146);
            productSearchButton.Name = "productSearchButton";
            productSearchButton.Size = new Size(52, 23);
            productSearchButton.TabIndex = 23;
            productSearchButton.Text = "Søg";
            productSearchButton.UseVisualStyleBackColor = true;
            // 
            // CreateOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(productSearchButton);
            Controls.Add(productSearchTextbox);
            Controls.Add(addToOrderButton);
            Controls.Add(productsListBox);
            Controls.Add(label7);
            Controls.Add(cancelButton);
            Controls.Add(createOrderButton);
            Controls.Add(getCustomerButton);
            Controls.Add(label6);
            Controls.Add(numericUpDown1);
            Controls.Add(orderListBox);
            Controls.Add(customerEmailLabel);
            Controls.Add(customerAddressLabel);
            Controls.Add(customerNameLabel);
            Controls.Add(label2);
            Controls.Add(customerPhoneNumberTextbox);
            Controls.Add(label1);
            Name = "CreateOrder";
            Size = new Size(709, 580);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox customerPhoneNumberTextbox;
        private Label label2;
        private Label customerNameLabel;
        private Label customerAddressLabel;
        private Label customerEmailLabel;
        private ListBox orderListBox;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private Button getCustomerButton;
        private Button createOrderButton;
        private Button cancelButton;
        private Label label7;
        private ListBox productsListBox;
        private Button addToOrderButton;
        private TextBox productSearchTextbox;
        private Button productSearchButton;
    }
}
