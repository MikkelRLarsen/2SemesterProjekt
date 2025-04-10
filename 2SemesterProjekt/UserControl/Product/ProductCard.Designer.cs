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
			profilePicture = new PictureBox();
			label = new Label();
			productIdLabel = new Label();
			label5 = new Label();
			productNameLabel = new Label();
			label1 = new Label();
			categoryLabel = new Label();
			label2 = new Label();
			productPriceLabel = new Label();
			label6 = new Label();
			inStockLabel = new Label();
			((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
			SuspendLayout();
			// 
			// profilePicture
			// 
			profilePicture.Anchor = AnchorStyles.Left;
			profilePicture.Image = (Image)resources.GetObject("profilePicture.Image");
			profilePicture.Location = new Point(5, 5);
			profilePicture.Name = "profilePicture";
			profilePicture.Size = new Size(100, 100);
			profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
			profilePicture.TabIndex = 1;
			profilePicture.TabStop = false;
			// 
			// label
			// 
			label.AutoSize = true;
			label.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label.Location = new Point(132, 17);
			label.Name = "label";
			label.Size = new Size(84, 19);
			label.TabIndex = 2;
			label.Text = "Produktnr:";
			// 
			// productIdLabel
			// 
			productIdLabel.AutoSize = true;
			productIdLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			productIdLabel.Location = new Point(241, 17);
			productIdLabel.Name = "productIdLabel";
			productIdLabel.Size = new Size(27, 19);
			productIdLabel.TabIndex = 3;
			productIdLabel.Text = "##";
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
			label2.Size = new Size(39, 19);
			label2.TabIndex = 8;
			label2.Text = "Pris:";
			// 
			// productPriceLabel
			// 
			productPriceLabel.AutoSize = true;
			productPriceLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			productPriceLabel.Location = new Point(475, 17);
			productPriceLabel.Name = "productPriceLabel";
			productPriceLabel.Size = new Size(89, 19);
			productPriceLabel.TabIndex = 9;
			productPriceLabel.Text = "9999,99 kr.";
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
			// ProductCard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(inStockLabel);
			Controls.Add(productPriceLabel);
			Controls.Add(label6);
			Controls.Add(label2);
			Controls.Add(categoryLabel);
			Controls.Add(label1);
			Controls.Add(productNameLabel);
			Controls.Add(label5);
			Controls.Add(productIdLabel);
			Controls.Add(label);
			Controls.Add(profilePicture);
			Name = "ProductCard";
			Size = new Size(700, 110);
			((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox profilePicture;
		private Label label;
		private Label productIdLabel;
		private Label label5;
		private Label productNameLabel;
		private Label label1;
		private Label categoryLabel;
		private Label label2;
		private Label productPriceLabel;
		private Label label6;
		private Label inStockLabel;
	}
}
