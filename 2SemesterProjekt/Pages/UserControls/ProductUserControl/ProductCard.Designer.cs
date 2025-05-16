namespace _2SemesterProjekt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCard));
            productPicture = new PictureBox();
            label = new Label();
            productEANLabel = new Label();
            label5 = new Label();
            productNameLabel = new Label();
            label1 = new Label();
            categoryLabel = new Label();
            label2 = new Label();
            productSalesPriceLabel = new Label();
            label6 = new Label();
            inStockLabel = new Label();
            label7 = new Label();
            minStockLabel = new Label();
            label3 = new Label();
            productPurchasePriceLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)productPicture).BeginInit();
            SuspendLayout();
            // 
            // productPicture
            // 
            productPicture.Anchor = AnchorStyles.Left;
            productPicture.Image = (Image)resources.GetObject("productPicture.Image");
            productPicture.Location = new Point(5, 22);
            productPicture.Name = "productPicture";
            productPicture.Size = new Size(100, 100);
            productPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            productPicture.TabIndex = 1;
            productPicture.TabStop = false;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(132, 17);
            label.Name = "label";
            label.Size = new Size(64, 19);
            label.TabIndex = 2;
            label.Text = "Varenr.:";
            // 
            // productEANLabel
            // 
            productEANLabel.AutoSize = true;
            productEANLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productEANLabel.Location = new Point(241, 17);
            productEANLabel.Name = "productEANLabel";
            productEANLabel.Size = new Size(27, 19);
            productEANLabel.TabIndex = 3;
            productEANLabel.Text = "##";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(132, 47);
            label5.Name = "label5";
            label5.Size = new Size(103, 19);
            label5.TabIndex = 4;
            label5.Text = "Produktnavn:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productNameLabel.Location = new Point(241, 47);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(106, 19);
            productNameLabel.TabIndex = 5;
            productNameLabel.Text = "ProductName";
            productNameLabel.UseMnemonic = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(132, 77);
            label1.Name = "label1";
            label1.Size = new Size(73, 19);
            label1.TabIndex = 6;
            label1.Text = "Kategori:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoryLabel.Location = new Point(241, 77);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(127, 19);
            categoryLabel.TabIndex = 7;
            categoryLabel.Text = "ProductCategory";
            categoryLabel.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(430, 17);
            label2.Name = "label2";
            label2.Size = new Size(75, 19);
            label2.TabIndex = 8;
            label2.Text = "Salgspris:";
            // 
            // productSalesPriceLabel
            // 
            productSalesPriceLabel.AutoSize = true;
            productSalesPriceLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productSalesPriceLabel.Location = new Point(511, 17);
            productSalesPriceLabel.Name = "productSalesPriceLabel";
            productSalesPriceLabel.Size = new Size(89, 19);
            productSalesPriceLabel.TabIndex = 9;
            productSalesPriceLabel.Text = "9999,99 kr.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(430, 47);
            label6.Name = "label6";
            label6.Size = new Size(95, 19);
            label6.TabIndex = 10;
            label6.Text = "Lagerstatus:";
            // 
            // inStockLabel
            // 
            inStockLabel.AutoSize = true;
            inStockLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inStockLabel.Location = new Point(531, 47);
            inStockLabel.Name = "inStockLabel";
            inStockLabel.Size = new Size(45, 19);
            inStockLabel.TabIndex = 9;
            inStockLabel.Text = "9999";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(430, 77);
            label7.Name = "label7";
            label7.Size = new Size(171, 19);
            label7.TabIndex = 11;
            label7.Text = "Minimumsbeholdning: ";
            // 
            // minStockLabel
            // 
            minStockLabel.AutoSize = true;
            minStockLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minStockLabel.Location = new Point(607, 77);
            minStockLabel.Name = "minStockLabel";
            minStockLabel.Size = new Size(45, 19);
            minStockLabel.TabIndex = 12;
            minStockLabel.Text = "9999";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(132, 108);
            label3.Name = "label3";
            label3.Size = new Size(95, 19);
            label3.TabIndex = 13;
            label3.Text = "Indkøbspris:";
            // 
            // productPurchasePriceLabel
            // 
            productPurchasePriceLabel.AutoSize = true;
            productPurchasePriceLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productPurchasePriceLabel.Location = new Point(241, 108);
            productPurchasePriceLabel.Name = "productPurchasePriceLabel";
            productPurchasePriceLabel.Size = new Size(89, 19);
            productPurchasePriceLabel.TabIndex = 14;
            productPurchasePriceLabel.Text = "9999,99 kr.";
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(productPurchasePriceLabel);
            Controls.Add(label3);
            Controls.Add(minStockLabel);
            Controls.Add(label7);
            Controls.Add(inStockLabel);
            Controls.Add(productSalesPriceLabel);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(categoryLabel);
            Controls.Add(label1);
            Controls.Add(productNameLabel);
            Controls.Add(label5);
            Controls.Add(productEANLabel);
            Controls.Add(label);
            Controls.Add(productPicture);
            Name = "ProductCard";
            Size = new Size(700, 144);
            ((System.ComponentModel.ISupportInitialize)productPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox productPicture;
		private Label label;
		private Label productEANLabel;
		private Label label5;
		private Label productNameLabel;
		private Label label1;
		private Label categoryLabel;
		private Label label2;
		private Label productSalesPriceLabel;
		private Label label6;
		private Label inStockLabel;
        private Label label7;
        private Label minStockLabel;
        private Label label3;
        private Label productPurchasePriceLabel;
    }
}
