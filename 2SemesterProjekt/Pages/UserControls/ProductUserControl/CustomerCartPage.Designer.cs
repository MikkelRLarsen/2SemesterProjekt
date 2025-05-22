namespace _2SemesterProjekt.Pages.UserControls.ProductUserControl
{
    partial class CustomerCartPage
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
            label2 = new Label();
            pictureBox1 = new PictureBox();
            flowPanel = new FlowLayoutPanel();
            textBoxProduct = new TextBox();
            productSearchButton = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            createOrderButton = new PictureBox();
            cancelButton = new PictureBox();
            pictureBox2 = new PictureBox();
            totalPriceTextBox = new TextBox();
            label3 = new Label();
            customerPhoneNumberTextbox = new TextBox();
            searchForCustomerButton = new PictureBox();
            label4 = new Label();
            customerNameLabel = new Label();
            customerAddressLabel = new Label();
            customerEmailLabel = new Label();
            label6 = new Label();
            discountNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productSearchButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)createOrderButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cancelButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchForCustomerButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)discountNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Linen;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(614, 38);
            label2.Name = "label2";
            label2.Size = new Size(387, 50);
            label2.TabIndex = 24;
            label2.Text = "I N D K Ø B S K U R V";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PageTitelBackground;
            pictureBox1.Location = new Point(101, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1399, 86);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // flowPanel
            // 
            flowPanel.AutoScroll = true;
            flowPanel.BackColor = Color.Linen;
            flowPanel.BorderStyle = BorderStyle.FixedSingle;
            flowPanel.Location = new Point(416, 243);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(769, 501);
            flowPanel.TabIndex = 56;
            // 
            // textBoxProduct
            // 
            textBoxProduct.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxProduct.ForeColor = SystemColors.InactiveCaption;
            textBoxProduct.Location = new Point(637, 194);
            textBoxProduct.Margin = new Padding(3, 4, 3, 4);
            textBoxProduct.MaxLength = 8;
            textBoxProduct.Name = "textBoxProduct";
            textBoxProduct.Size = new Size(274, 27);
            textBoxProduct.TabIndex = 55;
            textBoxProduct.Text = "Søg på produktnavn";
            textBoxProduct.Enter += textBoxProduct_Enter;
            textBoxProduct.KeyPress += textBoxProduct_KeyPress;
            textBoxProduct.Leave += textBoxProduct_Leave;
            // 
            // productSearchButton
            // 
            productSearchButton.BackColor = Color.AntiqueWhite;
            productSearchButton.Image = Properties.Resources.SearchButton;
            productSearchButton.Location = new Point(917, 197);
            productSearchButton.Margin = new Padding(3, 4, 3, 4);
            productSearchButton.Name = "productSearchButton";
            productSearchButton.Size = new Size(47, 21);
            productSearchButton.SizeMode = PictureBoxSizeMode.StretchImage;
            productSearchButton.TabIndex = 54;
            productSearchButton.TabStop = false;
            productSearchButton.Click += productSearchButton_Click;
            productSearchButton.MouseEnter += productSearchButton_MouseEnter;
            productSearchButton.MouseLeave += productSearchButton_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(673, 169);
            label1.Name = "label1";
            label1.Size = new Size(255, 20);
            label1.TabIndex = 52;
            label1.Text = " S Ø G   P Å   P R O D U K T N A V N";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Linen;
            pictureBox3.Image = Properties.Resources.PageBox;
            pictureBox3.Location = new Point(416, 149);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(769, 88);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 51;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.PageBackground;
            pictureBox4.Location = new Point(101, 124);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1399, 705);
            pictureBox4.TabIndex = 57;
            pictureBox4.TabStop = false;
            // 
            // createOrderButton
            // 
            createOrderButton.Image = Properties.Resources.CreateOrderButton;
            createOrderButton.Location = new Point(945, 751);
            createOrderButton.Margin = new Padding(3, 4, 3, 4);
            createOrderButton.Name = "createOrderButton";
            createOrderButton.Size = new Size(240, 55);
            createOrderButton.SizeMode = PictureBoxSizeMode.StretchImage;
            createOrderButton.TabIndex = 58;
            createOrderButton.TabStop = false;
            createOrderButton.Click += createOrderButton_Click;
            createOrderButton.MouseEnter += createOrderButton_MouseEnter;
            createOrderButton.MouseLeave += createOrderButton_MouseLeave;
            // 
            // cancelButton
            // 
            cancelButton.Image = Properties.Resources.CancelButton;
            cancelButton.Location = new Point(416, 751);
            cancelButton.Margin = new Padding(3, 4, 3, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(240, 55);
            cancelButton.SizeMode = PictureBoxSizeMode.StretchImage;
            cancelButton.TabIndex = 59;
            cancelButton.TabStop = false;
            cancelButton.Click += cancelButton_Click;
            cancelButton.MouseEnter += cancelButton_MouseEnter;
            cancelButton.MouseLeave += cancelButton_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Linen;
            pictureBox2.Image = Properties.Resources.CartBox;
            pictureBox2.Location = new Point(1191, 149);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(244, 595);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 60;
            pictureBox2.TabStop = false;
            // 
            // totalPriceTextBox
            // 
            totalPriceTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalPriceTextBox.Location = new Point(1199, 708);
            totalPriceTextBox.Margin = new Padding(3, 4, 3, 4);
            totalPriceTextBox.MaxLength = 8;
            totalPriceTextBox.Name = "totalPriceTextBox";
            totalPriceTextBox.ReadOnly = true;
            totalPriceTextBox.Size = new Size(204, 27);
            totalPriceTextBox.TabIndex = 61;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AntiqueWhite;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(1199, 684);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 62;
            label3.Text = "T O T A L  P R I S";
            // 
            // customerPhoneNumberTextbox
            // 
            customerPhoneNumberTextbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerPhoneNumberTextbox.Location = new Point(1199, 193);
            customerPhoneNumberTextbox.Margin = new Padding(3, 4, 3, 4);
            customerPhoneNumberTextbox.MaxLength = 8;
            customerPhoneNumberTextbox.Name = "customerPhoneNumberTextbox";
            customerPhoneNumberTextbox.Size = new Size(153, 27);
            customerPhoneNumberTextbox.TabIndex = 63;
            customerPhoneNumberTextbox.KeyPress += customerPhoneNumberTextbox_KeyPress;
            // 
            // searchForCustomerButton
            // 
            searchForCustomerButton.BackColor = Color.AntiqueWhite;
            searchForCustomerButton.Image = Properties.Resources.SearchButton;
            searchForCustomerButton.Location = new Point(1356, 197);
            searchForCustomerButton.Margin = new Padding(3, 4, 3, 4);
            searchForCustomerButton.Name = "searchForCustomerButton";
            searchForCustomerButton.Size = new Size(47, 21);
            searchForCustomerButton.SizeMode = PictureBoxSizeMode.StretchImage;
            searchForCustomerButton.TabIndex = 64;
            searchForCustomerButton.TabStop = false;
            searchForCustomerButton.Click += searchForCustomerButton_Click;
            searchForCustomerButton.MouseEnter += searchForCustomerButton_MouseEnter;
            searchForCustomerButton.MouseLeave += searchForCustomerButton_MouseLeave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.AntiqueWhite;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(1199, 169);
            label4.Name = "label4";
            label4.Size = new Size(157, 20);
            label4.TabIndex = 65;
            label4.Text = "T I L F Ø J   K U N D E";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.BackColor = Color.AntiqueWhite;
            customerNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerNameLabel.ForeColor = Color.SaddleBrown;
            customerNameLabel.Location = new Point(1199, 243);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new Size(88, 20);
            customerNameLabel.TabIndex = 66;
            customerNameLabel.Text = "Kundenavn";
            customerNameLabel.Visible = false;
            // 
            // customerAddressLabel
            // 
            customerAddressLabel.AutoSize = true;
            customerAddressLabel.BackColor = Color.AntiqueWhite;
            customerAddressLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerAddressLabel.ForeColor = Color.SaddleBrown;
            customerAddressLabel.Location = new Point(1199, 266);
            customerAddressLabel.Name = "customerAddressLabel";
            customerAddressLabel.Size = new Size(110, 20);
            customerAddressLabel.TabIndex = 67;
            customerAddressLabel.Text = "KundeAdresse";
            customerAddressLabel.Visible = false;
            // 
            // customerEmailLabel
            // 
            customerEmailLabel.AutoSize = true;
            customerEmailLabel.BackColor = Color.AntiqueWhite;
            customerEmailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerEmailLabel.ForeColor = Color.SaddleBrown;
            customerEmailLabel.Location = new Point(1199, 289);
            customerEmailLabel.Name = "customerEmailLabel";
            customerEmailLabel.Size = new Size(92, 20);
            customerEmailLabel.TabIndex = 68;
            customerEmailLabel.Text = "KundeEmail";
            customerEmailLabel.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.AntiqueWhite;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SaddleBrown;
            label6.Location = new Point(1199, 570);
            label6.Name = "label6";
            label6.Size = new Size(190, 20);
            label6.TabIndex = 69;
            label6.Text = "T I L F Ø J   R A B A T  I  %";
            // 
            // discountNumericUpDown
            // 
            discountNumericUpDown.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discountNumericUpDown.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            discountNumericUpDown.Location = new Point(1199, 593);
            discountNumericUpDown.Name = "discountNumericUpDown";
            discountNumericUpDown.Size = new Size(204, 27);
            discountNumericUpDown.TabIndex = 70;
            discountNumericUpDown.ValueChanged += discountNumericUpDown_ValueChanged;
            // 
            // CustomerCartPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(discountNumericUpDown);
            Controls.Add(label6);
            Controls.Add(customerEmailLabel);
            Controls.Add(customerAddressLabel);
            Controls.Add(customerNameLabel);
            Controls.Add(label4);
            Controls.Add(searchForCustomerButton);
            Controls.Add(customerPhoneNumberTextbox);
            Controls.Add(label3);
            Controls.Add(totalPriceTextBox);
            Controls.Add(pictureBox2);
            Controls.Add(cancelButton);
            Controls.Add(createOrderButton);
            Controls.Add(flowPanel);
            Controls.Add(textBoxProduct);
            Controls.Add(productSearchButton);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Margin = new Padding(0);
            Name = "CustomerCartPage";
            Size = new Size(1600, 845);
            Load += CustomerCartPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productSearchButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)createOrderButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)cancelButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchForCustomerButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)discountNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowPanel;
        private TextBox textBoxProduct;
        private PictureBox productSearchButton;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox createOrderButton;
        private PictureBox cancelButton;
        private PictureBox pictureBox2;
        private TextBox totalPriceTextBox;
        private Label label3;
        private TextBox customerPhoneNumberTextbox;
        private PictureBox searchForCustomerButton;
        private Label label4;
        private Label customerNameLabel;
        private Label customerAddressLabel;
        private Label customerEmailLabel;
        private Label label6;
        private NumericUpDown discountNumericUpDown;
    }
}
