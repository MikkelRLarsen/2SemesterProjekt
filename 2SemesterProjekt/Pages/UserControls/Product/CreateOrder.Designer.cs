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
            discountNumericUpDown = new NumericUpDown();
            label6 = new Label();
            getCustomerButton = new Button();
            createOrderButton = new Button();
            cancelButton = new Button();
            label7 = new Label();
            productsListBox = new ListBox();
            addToOrderButton = new Button();
            productSearchTextbox = new TextBox();
            productSearchButton = new Button();
            ((System.ComponentModel.ISupportInitialize)discountNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(176, 47);
            label1.Name = "label1";
            label1.Size = new Size(497, 95);
            label1.TabIndex = 6;
            label1.Text = "Opret Ordre";
            // 
            // customerPhoneNumberTextbox
            // 
            customerPhoneNumberTextbox.BorderStyle = BorderStyle.FixedSingle;
            customerPhoneNumberTextbox.Location = new Point(130, 193);
            customerPhoneNumberTextbox.Margin = new Padding(3, 4, 3, 4);
            customerPhoneNumberTextbox.Name = "customerPhoneNumberTextbox";
            customerPhoneNumberTextbox.Size = new Size(135, 27);
            customerPhoneNumberTextbox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 197);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 8;
            label2.Text = "Kundes tlf. nr.";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new Point(130, 240);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new Size(282, 20);
            customerNameLabel.TabIndex = 9;
            customerNameLabel.Text = "customerFirstName + customerLastName";
            customerNameLabel.Visible = false;
            // 
            // customerAddressLabel
            // 
            customerAddressLabel.AutoSize = true;
            customerAddressLabel.Location = new Point(130, 260);
            customerAddressLabel.Name = "customerAddressLabel";
            customerAddressLabel.Size = new Size(123, 20);
            customerAddressLabel.TabIndex = 10;
            customerAddressLabel.Text = "customerAddress";
            customerAddressLabel.Visible = false;
            // 
            // customerEmailLabel
            // 
            customerEmailLabel.AutoSize = true;
            customerEmailLabel.Location = new Point(130, 280);
            customerEmailLabel.Name = "customerEmailLabel";
            customerEmailLabel.Size = new Size(107, 20);
            customerEmailLabel.TabIndex = 11;
            customerEmailLabel.Text = "customerEmail";
            customerEmailLabel.Visible = false;
            // 
            // orderListBox
            // 
            orderListBox.Enabled = false;
            orderListBox.FormattingEnabled = true;
            orderListBox.Location = new Point(130, 345);
            orderListBox.Margin = new Padding(3, 4, 3, 4);
            orderListBox.Name = "orderListBox";
            orderListBox.Size = new Size(239, 184);
            orderListBox.TabIndex = 12;
            // 
            // discountNumericUpDown
            // 
            discountNumericUpDown.Enabled = false;
            discountNumericUpDown.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            discountNumericUpDown.Location = new Point(130, 539);
            discountNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            discountNumericUpDown.Name = "discountNumericUpDown";
            discountNumericUpDown.Size = new Size(240, 27);
            discountNumericUpDown.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(57, 541);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 15;
            label6.Text = "Rabat i %";
            // 
            // getCustomerButton
            // 
            getCustomerButton.FlatStyle = FlatStyle.Popup;
            getCustomerButton.Location = new Point(279, 193);
            getCustomerButton.Margin = new Padding(3, 4, 3, 4);
            getCustomerButton.Name = "getCustomerButton";
            getCustomerButton.Size = new Size(91, 31);
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
            createOrderButton.Location = new Point(438, 627);
            createOrderButton.Margin = new Padding(3, 4, 3, 4);
            createOrderButton.Name = "createOrderButton";
            createOrderButton.Size = new Size(194, 77);
            createOrderButton.TabIndex = 17;
            createOrderButton.Text = "Opret ordre";
            createOrderButton.UseVisualStyleBackColor = false;
            createOrderButton.Click += createOrderButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.IndianRed;
            cancelButton.FlatStyle = FlatStyle.Popup;
            cancelButton.Location = new Point(176, 627);
            cancelButton.Margin = new Padding(3, 4, 3, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(194, 77);
            cancelButton.TabIndex = 18;
            cancelButton.Text = "Annuller";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(130, 321);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 19;
            label7.Text = "Ordreliste";
            // 
            // productsListBox
            // 
            productsListBox.Enabled = false;
            productsListBox.FormattingEnabled = true;
            productsListBox.Location = new Point(438, 245);
            productsListBox.Margin = new Padding(3, 4, 3, 4);
            productsListBox.Name = "productsListBox";
            productsListBox.Size = new Size(239, 324);
            productsListBox.TabIndex = 20;
            // 
            // addToOrderButton
            // 
            addToOrderButton.Enabled = false;
            addToOrderButton.FlatStyle = FlatStyle.Popup;
            addToOrderButton.Location = new Point(685, 540);
            addToOrderButton.Margin = new Padding(3, 4, 3, 4);
            addToOrderButton.Name = "addToOrderButton";
            addToOrderButton.Size = new Size(98, 31);
            addToOrderButton.TabIndex = 21;
            addToOrderButton.Text = "Tilføj til ordre";
            addToOrderButton.UseVisualStyleBackColor = true;
            // 
            // productSearchTextbox
            // 
            productSearchTextbox.BorderStyle = BorderStyle.FixedSingle;
            productSearchTextbox.Enabled = false;
            productSearchTextbox.Location = new Point(438, 195);
            productSearchTextbox.Margin = new Padding(3, 4, 3, 4);
            productSearchTextbox.Name = "productSearchTextbox";
            productSearchTextbox.Size = new Size(240, 27);
            productSearchTextbox.TabIndex = 22;
            // 
            // productSearchButton
            // 
            productSearchButton.Enabled = false;
            productSearchButton.FlatStyle = FlatStyle.Popup;
            productSearchButton.Location = new Point(685, 195);
            productSearchButton.Margin = new Padding(3, 4, 3, 4);
            productSearchButton.Name = "productSearchButton";
            productSearchButton.Size = new Size(59, 31);
            productSearchButton.TabIndex = 23;
            productSearchButton.Text = "Søg";
            productSearchButton.UseVisualStyleBackColor = true;
            // 
            // CreateOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            Controls.Add(discountNumericUpDown);
            Controls.Add(orderListBox);
            Controls.Add(customerEmailLabel);
            Controls.Add(customerAddressLabel);
            Controls.Add(customerNameLabel);
            Controls.Add(label2);
            Controls.Add(customerPhoneNumberTextbox);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateOrder";
            Size = new Size(810, 773);
            ((System.ComponentModel.ISupportInitialize)discountNumericUpDown).EndInit();
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
        private NumericUpDown discountNumericUpDown;
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
