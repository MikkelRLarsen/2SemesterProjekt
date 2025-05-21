namespace _2SemesterProjekt
{
	partial class OldProductCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OldProductCard));
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
            productPicture.Location = new Point(6, 29);
            productPicture.Margin = new Padding(3, 4, 3, 4);
            productPicture.Name = "productPicture";
            productPicture.Size = new Size(114, 133);
            productPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            productPicture.TabIndex = 1;
            productPicture.TabStop = false;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(151, 23);
            label.Name = "label";
            label.Size = new Size(81, 21);
            label.TabIndex = 2;
            label.Text = "Varenr.:";
            // 
            // productEANLabel
            // 
            productEANLabel.AutoSize = true;
            productEANLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productEANLabel.Location = new Point(275, 23);
            productEANLabel.Name = "productEANLabel";
            productEANLabel.Size = new Size(32, 21);
            productEANLabel.TabIndex = 3;
            productEANLabel.Text = "##";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(151, 63);
            label5.Name = "label5";
            label5.Size = new Size(133, 21);
            label5.TabIndex = 4;
            label5.Text = "Produktnavn:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productNameLabel.Location = new Point(275, 63);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(134, 21);
            productNameLabel.TabIndex = 5;
            productNameLabel.Text = "ProductName";
            productNameLabel.UseMnemonic = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(151, 103);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 6;
            label1.Text = "Kategori:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoryLabel.Location = new Point(275, 103);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(163, 21);
            categoryLabel.TabIndex = 7;
            categoryLabel.Text = "ProductCategory";
            categoryLabel.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(491, 23);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 8;
            label2.Text = "Salgspris:";
            // 
            // productSalesPriceLabel
            // 
            productSalesPriceLabel.AutoSize = true;
            productSalesPriceLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productSalesPriceLabel.Location = new Point(584, 23);
            productSalesPriceLabel.Name = "productSalesPriceLabel";
            productSalesPriceLabel.Size = new Size(110, 21);
            productSalesPriceLabel.TabIndex = 9;
            productSalesPriceLabel.Text = "9999,99 kr.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(491, 63);
            label6.Name = "label6";
            label6.Size = new Size(117, 21);
            label6.TabIndex = 10;
            label6.Text = "Lagerstatus:";
            // 
            // inStockLabel
            // 
            inStockLabel.AutoSize = true;
            inStockLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inStockLabel.Location = new Point(607, 63);
            inStockLabel.Name = "inStockLabel";
            inStockLabel.Size = new Size(54, 21);
            inStockLabel.TabIndex = 9;
            inStockLabel.Text = "9999";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(491, 103);
            label7.Name = "label7";
            label7.Size = new Size(217, 21);
            label7.TabIndex = 11;
            label7.Text = "Minimumsbeholdning: ";
            // 
            // minStockLabel
            // 
            minStockLabel.AutoSize = true;
            minStockLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minStockLabel.Location = new Point(694, 103);
            minStockLabel.Name = "minStockLabel";
            minStockLabel.Size = new Size(54, 21);
            minStockLabel.TabIndex = 12;
            minStockLabel.Text = "9999";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(151, 144);
            label3.Name = "label3";
            label3.Size = new Size(121, 21);
            label3.TabIndex = 13;
            label3.Text = "Indkøbspris:";
            // 
            // productPurchasePriceLabel
            // 
            productPurchasePriceLabel.AutoSize = true;
            productPurchasePriceLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productPurchasePriceLabel.Location = new Point(275, 144);
            productPurchasePriceLabel.Name = "productPurchasePriceLabel";
            productPurchasePriceLabel.Size = new Size(110, 21);
            productPurchasePriceLabel.TabIndex = 14;
            productPurchasePriceLabel.Text = "9999,99 kr.";
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductCard";
            Size = new Size(800, 192);
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
