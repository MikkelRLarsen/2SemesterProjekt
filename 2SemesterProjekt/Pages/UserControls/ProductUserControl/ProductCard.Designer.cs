namespace _2SemesterProjekt.Pages.UserControls.ProductUserControl
{
    partial class ProductCard
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
            pictureBox = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            productEANLabel = new Label();
            inStockLabel = new Label();
            productNameLabel = new Label();
            categoryLabel = new Label();
            productPurchasePriceLabel = new Label();
            minStockLabel = new Label();
            productSalesPriceLabel = new Label();
            cardButton = new PictureBox();
            amountUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amountUpDown).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Image = Properties.Resources.ProductCard;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Margin = new Padding(0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(660, 150);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 40;
            pictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.AntiqueWhite;
            pictureBox1.Image = Properties.Resources.Product;
            pictureBox1.Location = new Point(14, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(117, 37);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 42;
            label1.Text = "Varenummer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AntiqueWhite;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(344, 37);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 44;
            label3.Text = "Kategori:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.AntiqueWhite;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(117, 87);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 45;
            label4.Text = "Indkøbspris:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.AntiqueWhite;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.SaddleBrown;
            label5.Location = new Point(117, 62);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 46;
            label5.Text = "Salgspris:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.AntiqueWhite;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.SaddleBrown;
            label6.Location = new Point(344, 62);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 47;
            label6.Text = "Lagerstatus:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.AntiqueWhite;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.SaddleBrown;
            label7.Location = new Point(344, 87);
            label7.Name = "label7";
            label7.Size = new Size(167, 20);
            label7.TabIndex = 48;
            label7.Text = "Minimumsbeholdning:";
            // 
            // productEANLabel
            // 
            productEANLabel.AutoSize = true;
            productEANLabel.BackColor = Color.AntiqueWhite;
            productEANLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productEANLabel.ForeColor = Color.SaddleBrown;
            productEANLabel.Location = new Point(228, 37);
            productEANLabel.Name = "productEANLabel";
            productEANLabel.Size = new Size(27, 20);
            productEANLabel.TabIndex = 49;
            productEANLabel.Text = "##";
            // 
            // inStockLabel
            // 
            inStockLabel.AutoSize = true;
            inStockLabel.BackColor = Color.AntiqueWhite;
            inStockLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            inStockLabel.ForeColor = Color.SaddleBrown;
            inStockLabel.Location = new Point(517, 62);
            inStockLabel.Name = "inStockLabel";
            inStockLabel.Size = new Size(27, 20);
            inStockLabel.TabIndex = 50;
            inStockLabel.Text = "##";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.BackColor = Color.AntiqueWhite;
            productNameLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productNameLabel.ForeColor = Color.Black;
            productNameLabel.Location = new Point(315, 5);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(34, 25);
            productNameLabel.TabIndex = 50;
            productNameLabel.Text = "##";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.BackColor = Color.AntiqueWhite;
            categoryLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            categoryLabel.ForeColor = Color.SaddleBrown;
            categoryLabel.Location = new Point(517, 37);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(27, 20);
            categoryLabel.TabIndex = 51;
            categoryLabel.Text = "##";
            // 
            // productPurchasePriceLabel
            // 
            productPurchasePriceLabel.AutoSize = true;
            productPurchasePriceLabel.BackColor = Color.AntiqueWhite;
            productPurchasePriceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            productPurchasePriceLabel.ForeColor = Color.SaddleBrown;
            productPurchasePriceLabel.Location = new Point(228, 87);
            productPurchasePriceLabel.Name = "productPurchasePriceLabel";
            productPurchasePriceLabel.Size = new Size(27, 20);
            productPurchasePriceLabel.TabIndex = 52;
            productPurchasePriceLabel.Text = "##";
            // 
            // minStockLabel
            // 
            minStockLabel.AutoSize = true;
            minStockLabel.BackColor = Color.AntiqueWhite;
            minStockLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            minStockLabel.ForeColor = Color.SaddleBrown;
            minStockLabel.Location = new Point(517, 87);
            minStockLabel.Name = "minStockLabel";
            minStockLabel.Size = new Size(27, 20);
            minStockLabel.TabIndex = 53;
            minStockLabel.Text = "##";
            // 
            // productSalesPriceLabel
            // 
            productSalesPriceLabel.AutoSize = true;
            productSalesPriceLabel.BackColor = Color.AntiqueWhite;
            productSalesPriceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            productSalesPriceLabel.ForeColor = Color.SaddleBrown;
            productSalesPriceLabel.Location = new Point(228, 62);
            productSalesPriceLabel.Name = "productSalesPriceLabel";
            productSalesPriceLabel.Size = new Size(27, 20);
            productSalesPriceLabel.TabIndex = 54;
            productSalesPriceLabel.Text = "##";
            // 
            // cardButton
            // 
            cardButton.Image = Properties.Resources.AddToCartButton;
            cardButton.Location = new Point(509, 123);
            cardButton.Name = "cardButton";
            cardButton.Size = new Size(145, 21);
            cardButton.TabIndex = 55;
            cardButton.TabStop = false;
            cardButton.Click += cardButton_Click;
            cardButton.MouseEnter += cardButton_MouseEnter;
            cardButton.MouseLeave += cardButton_MouseLeave;
            // 
            // amountUpDown
            // 
            amountUpDown.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountUpDown.Location = new Point(459, 120);
            amountUpDown.Name = "amountUpDown";
            amountUpDown.ReadOnly = true;
            amountUpDown.Size = new Size(44, 27);
            amountUpDown.TabIndex = 56;
            // 
            // ProductCardUpdated
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(amountUpDown);
            Controls.Add(cardButton);
            Controls.Add(productSalesPriceLabel);
            Controls.Add(minStockLabel);
            Controls.Add(productPurchasePriceLabel);
            Controls.Add(categoryLabel);
            Controls.Add(productNameLabel);
            Controls.Add(inStockLabel);
            Controls.Add(productEANLabel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox);
            Margin = new Padding(60, 5, 5, 5);
            Name = "ProductCardUpdated";
            Size = new Size(660, 150);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)amountUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label productEANLabel;
        private Label inStockLabel;
        private Label productNameLabel;
        private Label categoryLabel;
        private Label productPurchasePriceLabel;
        private Label minStockLabel;
        private Label productSalesPriceLabel;
        private PictureBox cardButton;
        private NumericUpDown amountUpDown;
    }
}
