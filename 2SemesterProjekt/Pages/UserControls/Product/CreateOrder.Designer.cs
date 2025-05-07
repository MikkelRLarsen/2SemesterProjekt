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
            discountNumericUpDown = new NumericUpDown();
            label6 = new Label();
            getCustomerButton = new Button();
            createOrderButton = new Button();
            cancelButton = new Button();
            label7 = new Label();
            addToOrderButton = new Button();
            productSearchTextbox = new TextBox();
            productSearchButton = new Button();
            totalPriceLabel = new Label();
            totalPriceInfoLabel = new Label();
            allProductsListBox = new ListBox();
            orderProductsListBox = new ListBox();
            AddMoreButton = new Button();
            ((System.ComponentModel.ISupportInitialize)discountNumericUpDown).BeginInit();
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
            // discountNumericUpDown
            // 
            discountNumericUpDown.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            discountNumericUpDown.Location = new Point(114, 404);
            discountNumericUpDown.Name = "discountNumericUpDown";
            discountNumericUpDown.Size = new Size(210, 23);
            discountNumericUpDown.TabIndex = 14;
            discountNumericUpDown.ValueChanged += discountNumericUpDown_ValueChanged;
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
            createOrderButton.FlatStyle = FlatStyle.Popup;
            createOrderButton.Location = new Point(383, 470);
            createOrderButton.Name = "createOrderButton";
            createOrderButton.Size = new Size(170, 58);
            createOrderButton.TabIndex = 17;
            createOrderButton.Text = "Opret ordre";
            createOrderButton.UseVisualStyleBackColor = false;
            createOrderButton.Click += createOrderButton_Click;
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
            cancelButton.Click += cancelButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(114, 225);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 19;
            label7.Text = "Ordreliste";
            // 
            // addToOrderButton
            // 
            addToOrderButton.FlatStyle = FlatStyle.Popup;
            addToOrderButton.Location = new Point(565, 404);
            addToOrderButton.Name = "addToOrderButton";
            addToOrderButton.Size = new Size(86, 23);
            addToOrderButton.TabIndex = 21;
            addToOrderButton.Text = "Tilføj til ordre";
            addToOrderButton.UseVisualStyleBackColor = true;
            addToOrderButton.Click += addToOrderButton_Click;
            // 
            // productSearchTextbox
            // 
            productSearchTextbox.BorderStyle = BorderStyle.FixedSingle;
            productSearchTextbox.Location = new Point(383, 146);
            productSearchTextbox.Name = "productSearchTextbox";
            productSearchTextbox.Size = new Size(210, 23);
            productSearchTextbox.TabIndex = 22;
            // 
            // productSearchButton
            // 
            productSearchButton.FlatStyle = FlatStyle.Popup;
            productSearchButton.Location = new Point(599, 146);
            productSearchButton.Name = "productSearchButton";
            productSearchButton.Size = new Size(52, 23);
            productSearchButton.TabIndex = 23;
            productSearchButton.Text = "Søg";
            productSearchButton.UseVisualStyleBackColor = true;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalPriceLabel.Location = new Point(114, 385);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(60, 15);
            totalPriceLabel.TabIndex = 24;
            totalPriceLabel.Text = "Total pris:";
            // 
            // totalPriceInfoLabel
            // 
            totalPriceInfoLabel.AutoSize = true;
            totalPriceInfoLabel.Location = new Point(175, 385);
            totalPriceInfoLabel.Name = "totalPriceInfoLabel";
            totalPriceInfoLabel.Size = new Size(13, 15);
            totalPriceInfoLabel.TabIndex = 25;
            totalPriceInfoLabel.Text = "0";
            // 
            // allProductsListBox
            // 
            allProductsListBox.FormattingEnabled = true;
            allProductsListBox.ItemHeight = 15;
            allProductsListBox.Location = new Point(383, 195);
            allProductsListBox.Name = "allProductsListBox";
            allProductsListBox.Size = new Size(268, 199);
            allProductsListBox.TabIndex = 26;
            allProductsListBox.SelectedIndexChanged += allProductsListBox_SelectedIndexChanged;
            // 
            // orderProductsListBox
            // 
            orderProductsListBox.FormattingEnabled = true;
            orderProductsListBox.ItemHeight = 15;
            orderProductsListBox.Location = new Point(114, 243);
            orderProductsListBox.Name = "orderProductsListBox";
            orderProductsListBox.Size = new Size(210, 139);
            orderProductsListBox.TabIndex = 27;
            orderProductsListBox.SelectedIndexChanged += orderProductsListBox_SelectedIndexChanged;
            // 
            // AddMoreButton
            // 
            AddMoreButton.FlatStyle = FlatStyle.Popup;
            AddMoreButton.Location = new Point(33, 303);
            AddMoreButton.Name = "AddMoreButton";
            AddMoreButton.Size = new Size(75, 79);
            AddMoreButton.TabIndex = 28;
            AddMoreButton.Text = "Tilføj flere af det valgte produkt";
            AddMoreButton.UseVisualStyleBackColor = true;
            AddMoreButton.Click += AddMoreButton_Click;
            // 
            // CreateOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddMoreButton);
            Controls.Add(orderProductsListBox);
            Controls.Add(allProductsListBox);
            Controls.Add(totalPriceInfoLabel);
            Controls.Add(totalPriceLabel);
            Controls.Add(productSearchButton);
            Controls.Add(productSearchTextbox);
            Controls.Add(addToOrderButton);
            Controls.Add(label7);
            Controls.Add(cancelButton);
            Controls.Add(createOrderButton);
            Controls.Add(getCustomerButton);
            Controls.Add(label6);
            Controls.Add(discountNumericUpDown);
            Controls.Add(customerEmailLabel);
            Controls.Add(customerAddressLabel);
            Controls.Add(customerNameLabel);
            Controls.Add(label2);
            Controls.Add(customerPhoneNumberTextbox);
            Controls.Add(label1);
            Name = "CreateOrder";
            Size = new Size(709, 580);
            Load += CreateOrder_Load;
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
        private Label totalPriceLabel;
        private Label totalPriceInfoLabel;
        private ListBox allProductsListBox;
        private ListBox orderProductsListBox;
        private Button AddMoreButton;
    }
}
