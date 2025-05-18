namespace _2SemesterProjekt.Pages.UserControls.ProductUserControl
{
    partial class ProductCardUpdated
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
            label2 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Image = Properties.Resources.CardExamination;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Margin = new Padding(0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1100, 190);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 40;
            pictureBox.TabStop = false;
            pictureBox.DoubleClick += pictureBox_DoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.AntiqueWhite;
            pictureBox1.Image = Properties.Resources.Product;
            pictureBox1.Location = new Point(23, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 137);
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(195, 20);
            label1.Name = "label1";
            label1.Size = new Size(158, 31);
            label1.TabIndex = 42;
            label1.Text = "Varenummer:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AntiqueWhite;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(195, 58);
            label2.Name = "label2";
            label2.Size = new Size(159, 31);
            label2.TabIndex = 43;
            label2.Text = "Produktnavn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AntiqueWhite;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(195, 96);
            label3.Name = "label3";
            label3.Size = new Size(112, 31);
            label3.TabIndex = 44;
            label3.Text = "Kategori:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.AntiqueWhite;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(195, 134);
            label4.Name = "label4";
            label4.Size = new Size(146, 31);
            label4.TabIndex = 45;
            label4.Text = "Indkøbspris:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.AntiqueWhite;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SaddleBrown;
            label5.Location = new Point(574, 20);
            label5.Name = "label5";
            label5.Size = new Size(116, 31);
            label5.TabIndex = 46;
            label5.Text = "Salgspris:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.AntiqueWhite;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SaddleBrown;
            label6.Location = new Point(574, 58);
            label6.Name = "label6";
            label6.Size = new Size(143, 31);
            label6.TabIndex = 47;
            label6.Text = "Lagerstatus:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.AntiqueWhite;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SaddleBrown;
            label7.Location = new Point(574, 96);
            label7.Name = "label7";
            label7.Size = new Size(260, 31);
            label7.TabIndex = 48;
            label7.Text = "Minimumsbeholdning:";
            // 
            // productEANLabel
            // 
            productEANLabel.AutoSize = true;
            productEANLabel.BackColor = Color.AntiqueWhite;
            productEANLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productEANLabel.ForeColor = Color.SaddleBrown;
            productEANLabel.Location = new Point(369, 23);
            productEANLabel.Name = "productEANLabel";
            productEANLabel.Size = new Size(42, 31);
            productEANLabel.TabIndex = 49;
            productEANLabel.Text = "##";
            // 
            // inStockLabel
            // 
            inStockLabel.AutoSize = true;
            inStockLabel.BackColor = Color.AntiqueWhite;
            inStockLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inStockLabel.ForeColor = Color.SaddleBrown;
            inStockLabel.Location = new Point(845, 58);
            inStockLabel.Name = "inStockLabel";
            inStockLabel.Size = new Size(42, 31);
            inStockLabel.TabIndex = 50;
            inStockLabel.Text = "##";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.BackColor = Color.AntiqueWhite;
            productNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productNameLabel.ForeColor = Color.SaddleBrown;
            productNameLabel.Location = new Point(369, 58);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(42, 31);
            productNameLabel.TabIndex = 50;
            productNameLabel.Text = "##";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.BackColor = Color.AntiqueWhite;
            categoryLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoryLabel.ForeColor = Color.SaddleBrown;
            categoryLabel.Location = new Point(369, 96);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(42, 31);
            categoryLabel.TabIndex = 51;
            categoryLabel.Text = "##";
            // 
            // productPurchasePriceLabel
            // 
            productPurchasePriceLabel.AutoSize = true;
            productPurchasePriceLabel.BackColor = Color.AntiqueWhite;
            productPurchasePriceLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productPurchasePriceLabel.ForeColor = Color.SaddleBrown;
            productPurchasePriceLabel.Location = new Point(369, 134);
            productPurchasePriceLabel.Name = "productPurchasePriceLabel";
            productPurchasePriceLabel.Size = new Size(42, 31);
            productPurchasePriceLabel.TabIndex = 52;
            productPurchasePriceLabel.Text = "##";
            // 
            // minStockLabel
            // 
            minStockLabel.AutoSize = true;
            minStockLabel.BackColor = Color.AntiqueWhite;
            minStockLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minStockLabel.ForeColor = Color.SaddleBrown;
            minStockLabel.Location = new Point(845, 96);
            minStockLabel.Name = "minStockLabel";
            minStockLabel.Size = new Size(42, 31);
            minStockLabel.TabIndex = 53;
            minStockLabel.Text = "##";
            // 
            // productSalesPriceLabel
            // 
            productSalesPriceLabel.AutoSize = true;
            productSalesPriceLabel.BackColor = Color.AntiqueWhite;
            productSalesPriceLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productSalesPriceLabel.ForeColor = Color.SaddleBrown;
            productSalesPriceLabel.Location = new Point(845, 20);
            productSalesPriceLabel.Name = "productSalesPriceLabel";
            productSalesPriceLabel.Size = new Size(42, 31);
            productSalesPriceLabel.TabIndex = 54;
            productSalesPriceLabel.Text = "##";
            // 
            // ProductCardUpdated
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox);
            Margin = new Padding(80, 10, 10, 10);
            Name = "ProductCardUpdated";
            Size = new Size(1100, 190);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
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
    }
}
