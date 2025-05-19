namespace _2SemesterProjekt.Pages.UserControls.ProductUserControl
{
    partial class CreateProductPage
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
            textBoxProductName = new TextBox();
            textBoxEAN = new TextBox();
            label3 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            textBoxSalesPrice = new TextBox();
            textBoxPurchasePrice = new TextBox();
            textBoxProductType = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBoxMinInStock = new TextBox();
            textBoxNumberInStock = new TextBox();
            label7 = new Label();
            label8 = new Label();
            submitButton = new PictureBox();
            cancelButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)submitButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cancelButton).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Linen;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(690, 81);
            label2.Name = "label2";
            label2.Size = new Size(732, 65);
            label2.TabIndex = 24;
            label2.Text = "O P R E T   N Y T   P R O D U K T";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PageTitelBackground;
            pictureBox1.Location = new Point(36, 59);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(2040, 108);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // textBoxProductName
            // 
            textBoxProductName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxProductName.Location = new Point(1169, 422);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(311, 35);
            textBoxProductName.TabIndex = 51;
            // 
            // textBoxEAN
            // 
            textBoxEAN.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEAN.Location = new Point(1169, 348);
            textBoxEAN.Name = "textBoxEAN";
            textBoxEAN.Size = new Size(311, 35);
            textBoxEAN.TabIndex = 50;
            textBoxEAN.KeyPress += textBoxEAN_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AntiqueWhite;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(708, 427);
            label3.Name = "label3";
            label3.Size = new Size(207, 25);
            label3.TabIndex = 49;
            label3.Text = "P R O D U K T N A V N";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(708, 353);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 48;
            label1.Text = "V A R E N R .";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Linen;
            pictureBox3.Image = Properties.Resources.PageCreateBox;
            pictureBox3.Location = new Point(533, 208);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1122, 785);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 47;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.PageBackground;
            pictureBox2.Location = new Point(74, 182);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(2040, 837);
            pictureBox2.TabIndex = 46;
            pictureBox2.TabStop = false;
            // 
            // textBoxSalesPrice
            // 
            textBoxSalesPrice.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSalesPrice.Location = new Point(1169, 638);
            textBoxSalesPrice.MaxLength = 8;
            textBoxSalesPrice.Name = "textBoxSalesPrice";
            textBoxSalesPrice.Size = new Size(311, 35);
            textBoxSalesPrice.TabIndex = 57;
            textBoxSalesPrice.KeyPress += textBoxSalesPrice_KeyPress;
            // 
            // textBoxPurchasePrice
            // 
            textBoxPurchasePrice.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPurchasePrice.Location = new Point(1169, 567);
            textBoxPurchasePrice.Name = "textBoxPurchasePrice";
            textBoxPurchasePrice.Size = new Size(311, 35);
            textBoxPurchasePrice.TabIndex = 56;
            textBoxPurchasePrice.KeyPress += textBoxPurchasePrice_KeyPress;
            // 
            // textBoxProductType
            // 
            textBoxProductType.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxProductType.Location = new Point(1171, 495);
            textBoxProductType.Name = "textBoxProductType";
            textBoxProductType.Size = new Size(311, 35);
            textBoxProductType.TabIndex = 55;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.AntiqueWhite;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SaddleBrown;
            label6.Location = new Point(708, 645);
            label6.Name = "label6";
            label6.Size = new Size(152, 25);
            label6.TabIndex = 54;
            label6.Text = "S A L G S P R I S";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.AntiqueWhite;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SaddleBrown;
            label5.Location = new Point(708, 574);
            label5.Name = "label5";
            label5.Size = new Size(187, 25);
            label5.TabIndex = 53;
            label5.Text = "I N D K Ø B S P R I S";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.AntiqueWhite;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(708, 500);
            label4.Name = "label4";
            label4.Size = new Size(196, 25);
            label4.TabIndex = 52;
            label4.Text = "P R O D U K T T Y P E";
            // 
            // textBoxMinInStock
            // 
            textBoxMinInStock.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxMinInStock.Location = new Point(1163, 764);
            textBoxMinInStock.MaxLength = 8;
            textBoxMinInStock.Name = "textBoxMinInStock";
            textBoxMinInStock.Size = new Size(153, 35);
            textBoxMinInStock.TabIndex = 61;
            textBoxMinInStock.KeyPress += textBoxMinInStock_KeyPress;
            // 
            // textBoxNumberInStock
            // 
            textBoxNumberInStock.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNumberInStock.Location = new Point(821, 764);
            textBoxNumberInStock.Name = "textBoxNumberInStock";
            textBoxNumberInStock.Size = new Size(153, 35);
            textBoxNumberInStock.TabIndex = 60;
            textBoxNumberInStock.KeyPress += textBoxNumberInStock_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.AntiqueWhite;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SaddleBrown;
            label7.Location = new Point(1072, 736);
            label7.Name = "label7";
            label7.Size = new Size(335, 25);
            label7.TabIndex = 59;
            label7.Text = "M I N.   L A G E R B E H O L D N I N G";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.AntiqueWhite;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SaddleBrown;
            label8.Location = new Point(781, 736);
            label8.Name = "label8";
            label8.Size = new Size(233, 25);
            label8.TabIndex = 58;
            label8.Text = "A N T A L   P Å   L A G E R";
            // 
            // submitButton
            // 
            submitButton.Enabled = false;
            submitButton.Image = Properties.Resources.CreateButtonGreyedOut;
            submitButton.Location = new Point(1480, 1066);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(350, 69);
            submitButton.TabIndex = 63;
            submitButton.TabStop = false;
            submitButton.Click += submitButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Image = Properties.Resources.CancelButton;
            cancelButton.Location = new Point(358, 1066);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(350, 69);
            cancelButton.TabIndex = 62;
            cancelButton.TabStop = false;
            // 
            // CreateProductPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(submitButton);
            Controls.Add(cancelButton);
            Controls.Add(textBoxMinInStock);
            Controls.Add(textBoxNumberInStock);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(textBoxSalesPrice);
            Controls.Add(textBoxPurchasePrice);
            Controls.Add(textBoxProductType);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxProductName);
            Controls.Add(textBoxEAN);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "CreateProductPage";
            Size = new Size(2188, 1185);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)submitButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)cancelButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private TextBox textBoxProductName;
        private TextBox textBoxEAN;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private TextBox textBoxSalesPrice;
        private TextBox textBoxPurchasePrice;
        private TextBox textBoxProductType;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBoxMinInStock;
        private TextBox textBoxNumberInStock;
        private Label label7;
        private Label label8;
        private PictureBox submitButton;
        private PictureBox cancelButton;
    }
}
