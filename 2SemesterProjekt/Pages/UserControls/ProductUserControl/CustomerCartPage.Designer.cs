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
            textBoxCustomerPhoneNumberOrName = new TextBox();
            customerSearchButton = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)customerSearchButton).BeginInit();
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
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(934, 108);
            label2.Name = "label2";
            label2.Size = new Size(632, 81);
            label2.TabIndex = 24;
            label2.Text = "I N D K Ø B S K U R V";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PageTitelBackground;
            pictureBox1.Location = new Point(84, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(2332, 144);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // flowPanel
            // 
            flowPanel.AutoScroll = true;
            flowPanel.BackColor = Color.Linen;
            flowPanel.BorderStyle = BorderStyle.FixedSingle;
            flowPanel.Location = new Point(409, 452);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(1282, 867);
            flowPanel.TabIndex = 56;
            // 
            // textBoxCustomerPhoneNumberOrName
            // 
            textBoxCustomerPhoneNumberOrName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCustomerPhoneNumberOrName.Location = new Point(772, 355);
            textBoxCustomerPhoneNumberOrName.Margin = new Padding(3, 4, 3, 4);
            textBoxCustomerPhoneNumberOrName.MaxLength = 8;
            textBoxCustomerPhoneNumberOrName.Name = "textBoxCustomerPhoneNumberOrName";
            textBoxCustomerPhoneNumberOrName.Size = new Size(457, 42);
            textBoxCustomerPhoneNumberOrName.TabIndex = 55;
            // 
            // customerSearchButton
            // 
            customerSearchButton.BackColor = Color.AntiqueWhite;
            customerSearchButton.Image = Properties.Resources.SearchButton;
            customerSearchButton.Location = new Point(1250, 359);
            customerSearchButton.Margin = new Padding(3, 4, 3, 4);
            customerSearchButton.Name = "customerSearchButton";
            customerSearchButton.Size = new Size(79, 35);
            customerSearchButton.TabIndex = 54;
            customerSearchButton.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(858, 307);
            label1.Name = "label1";
            label1.Size = new Size(385, 31);
            label1.TabIndex = 52;
            label1.Text = " S Ø G   P Å   P R O D U K T N A V N";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Linen;
            pictureBox3.Image = Properties.Resources.PageBox;
            pictureBox3.Location = new Point(409, 277);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1282, 148);
            pictureBox3.TabIndex = 51;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.PageBackground;
            pictureBox4.Location = new Point(84, 242);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(2332, 1116);
            pictureBox4.TabIndex = 57;
            pictureBox4.TabStop = false;
            // 
            // createOrderButton
            // 
            createOrderButton.Enabled = false;
            createOrderButton.Image = Properties.Resources.CreateOrderButton;
            createOrderButton.Location = new Point(1691, 1422);
            createOrderButton.Margin = new Padding(3, 4, 3, 4);
            createOrderButton.Name = "createOrderButton";
            createOrderButton.Size = new Size(400, 92);
            createOrderButton.TabIndex = 58;
            createOrderButton.TabStop = false;
            createOrderButton.Click += createOrderButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Image = Properties.Resources.CancelButton;
            cancelButton.Location = new Point(409, 1422);
            cancelButton.Margin = new Padding(3, 4, 3, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(400, 92);
            cancelButton.TabIndex = 59;
            cancelButton.TabStop = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Linen;
            pictureBox2.Image = Properties.Resources.CartBox;
            pictureBox2.Location = new Point(1717, 277);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(374, 1042);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 60;
            pictureBox2.TabStop = false;
            // 
            // totalPriceTextBox
            // 
            totalPriceTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalPriceTextBox.Location = new Point(1734, 1264);
            totalPriceTextBox.Margin = new Padding(3, 4, 3, 4);
            totalPriceTextBox.MaxLength = 8;
            totalPriceTextBox.Name = "totalPriceTextBox";
            totalPriceTextBox.ReadOnly = true;
            totalPriceTextBox.Size = new Size(340, 42);
            totalPriceTextBox.TabIndex = 61;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AntiqueWhite;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(1734, 1229);
            label3.Name = "label3";
            label3.Size = new Size(188, 31);
            label3.TabIndex = 62;
            label3.Text = "T O T A L  P R I S";
            // 
            // customerPhoneNumberTextbox
            // 
            customerPhoneNumberTextbox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerPhoneNumberTextbox.Location = new Point(1734, 355);
            customerPhoneNumberTextbox.Margin = new Padding(3, 4, 3, 4);
            customerPhoneNumberTextbox.MaxLength = 8;
            customerPhoneNumberTextbox.Name = "customerPhoneNumberTextbox";
            customerPhoneNumberTextbox.Size = new Size(255, 42);
            customerPhoneNumberTextbox.TabIndex = 63;
            customerPhoneNumberTextbox.KeyPress += customerPhoneNumberTextbox_KeyPress;
            // 
            // searchForCustomerButton
            // 
            searchForCustomerButton.BackColor = Color.AntiqueWhite;
            searchForCustomerButton.Image = Properties.Resources.SearchButton;
            searchForCustomerButton.Location = new Point(1995, 359);
            searchForCustomerButton.Margin = new Padding(3, 4, 3, 4);
            searchForCustomerButton.Name = "searchForCustomerButton";
            searchForCustomerButton.Size = new Size(79, 35);
            searchForCustomerButton.TabIndex = 64;
            searchForCustomerButton.TabStop = false;
            searchForCustomerButton.Click += searchForCustomerButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.AntiqueWhite;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(1734, 307);
            label4.Name = "label4";
            label4.Size = new Size(236, 31);
            label4.TabIndex = 65;
            label4.Text = "T I L F Ø J   K U N D E";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.BackColor = Color.AntiqueWhite;
            customerNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerNameLabel.ForeColor = Color.SaddleBrown;
            customerNameLabel.Location = new Point(1734, 413);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new Size(135, 31);
            customerNameLabel.TabIndex = 66;
            customerNameLabel.Text = "Kundenavn";
            customerNameLabel.Visible = false;
            // 
            // customerAddressLabel
            // 
            customerAddressLabel.AutoSize = true;
            customerAddressLabel.BackColor = Color.AntiqueWhite;
            customerAddressLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerAddressLabel.ForeColor = Color.SaddleBrown;
            customerAddressLabel.Location = new Point(1734, 452);
            customerAddressLabel.Name = "customerAddressLabel";
            customerAddressLabel.Size = new Size(166, 31);
            customerAddressLabel.TabIndex = 67;
            customerAddressLabel.Text = "KundeAdresse";
            customerAddressLabel.Visible = false;
            // 
            // customerEmailLabel
            // 
            customerEmailLabel.AutoSize = true;
            customerEmailLabel.BackColor = Color.AntiqueWhite;
            customerEmailLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerEmailLabel.ForeColor = Color.SaddleBrown;
            customerEmailLabel.Location = new Point(1734, 491);
            customerEmailLabel.Name = "customerEmailLabel";
            customerEmailLabel.Size = new Size(142, 31);
            customerEmailLabel.TabIndex = 68;
            customerEmailLabel.Text = "KundeEmail";
            customerEmailLabel.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.AntiqueWhite;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SaddleBrown;
            label6.Location = new Point(1734, 1045);
            label6.Name = "label6";
            label6.Size = new Size(232, 31);
            label6.TabIndex = 69;
            label6.Text = "T I L F Ø J   R A B A T";
            // 
            // discountNumericUpDown
            // 
            discountNumericUpDown.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discountNumericUpDown.Location = new Point(1734, 1088);
            discountNumericUpDown.Name = "discountNumericUpDown";
            discountNumericUpDown.Size = new Size(340, 43);
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
            Controls.Add(textBoxCustomerPhoneNumberOrName);
            Controls.Add(customerSearchButton);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Margin = new Padding(0);
            Name = "CustomerCartPage";
            Size = new Size(2500, 1580);
            Load += CustomerCartPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerSearchButton).EndInit();
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
        private TextBox textBoxCustomerPhoneNumberOrName;
        private PictureBox customerSearchButton;
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
