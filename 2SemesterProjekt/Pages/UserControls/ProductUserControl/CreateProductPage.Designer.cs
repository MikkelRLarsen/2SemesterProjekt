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
            label4 = new Label();
            textBoxProductType = new TextBox();
            pictureBox7 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            textBoxEAN = new TextBox();
            submitButton = new PictureBox();
            cancelButton = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            textBoxProductName = new TextBox();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            numericNumberInStock = new NumericUpDown();
            numericMinInStock = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            pictureBox8 = new PictureBox();
            textBoxPurchasePrice = new TextBox();
            textBoxSalesPrice = new TextBox();
            label8 = new Label();
            pictureBox9 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)submitButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cancelButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericNumberInStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericMinInStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.AntiqueWhite;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(674, 367);
            label4.Name = "label4";
            label4.Size = new Size(232, 20);
            label4.TabIndex = 71;
            label4.Text = "A N G I V   P R O D U K T T Y P E";
            // 
            // textBoxProductType
            // 
            textBoxProductType.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxProductType.Location = new Point(660, 391);
            textBoxProductType.Margin = new Padding(3, 4, 3, 4);
            textBoxProductType.MaxLength = 0;
            textBoxProductType.Name = "textBoxProductType";
            textBoxProductType.Size = new Size(278, 27);
            textBoxProductType.TabIndex = 70;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Linen;
            pictureBox7.Image = Properties.Resources.PageBox;
            pictureBox7.Location = new Point(416, 346);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(769, 88);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 72;
            pictureBox7.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Linen;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(578, 34);
            label2.Name = "label2";
            label2.Size = new Size(444, 50);
            label2.TabIndex = 66;
            label2.Text = "O P R E T   P R O D U K T";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(685, 167);
            label1.Name = "label1";
            label1.Size = new Size(230, 20);
            label1.TabIndex = 65;
            label1.Text = "A N G I V   V A R E N U M M E R";
            // 
            // textBoxEAN
            // 
            textBoxEAN.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEAN.Location = new Point(663, 191);
            textBoxEAN.Margin = new Padding(3, 4, 3, 4);
            textBoxEAN.MaxLength = 13;
            textBoxEAN.Name = "textBoxEAN";
            textBoxEAN.Size = new Size(274, 27);
            textBoxEAN.TabIndex = 64;
            textBoxEAN.TextChanged += textBoxEAN_TextChanged;
            // 
            // submitButton
            // 
            submitButton.Image = Properties.Resources.SaveButtonGreyedOut;
            submitButton.Location = new Point(945, 749);
            submitButton.Margin = new Padding(3, 4, 3, 4);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(240, 55);
            submitButton.SizeMode = PictureBoxSizeMode.StretchImage;
            submitButton.TabIndex = 63;
            submitButton.TabStop = false;
            submitButton.Click += submitButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Image = Properties.Resources.CancelButton;
            cancelButton.Location = new Point(416, 749);
            cancelButton.Margin = new Padding(3, 4, 3, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(240, 55);
            cancelButton.SizeMode = PictureBoxSizeMode.StretchImage;
            cancelButton.TabIndex = 62;
            cancelButton.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PageTitelBackground;
            pictureBox1.Location = new Point(101, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1399, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Linen;
            pictureBox3.Image = Properties.Resources.PageBox;
            pictureBox3.Location = new Point(416, 147);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(769, 88);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 69;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.PageBackground;
            pictureBox2.Location = new Point(101, 122);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1399, 705);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 68;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AntiqueWhite;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(685, 264);
            label3.Name = "label3";
            label3.Size = new Size(242, 20);
            label3.TabIndex = 74;
            label3.Text = "A N G I V   P R O D U K T N A V N";
            // 
            // textBoxProductName
            // 
            textBoxProductName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxProductName.Location = new Point(663, 288);
            textBoxProductName.Margin = new Padding(3, 4, 3, 4);
            textBoxProductName.MaxLength = 0;
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(274, 27);
            textBoxProductName.TabIndex = 73;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Linen;
            pictureBox4.Image = Properties.Resources.PageBox;
            pictureBox4.Location = new Point(416, 245);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(769, 88);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 75;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.AntiqueWhite;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.SaddleBrown;
            label5.Location = new Point(492, 469);
            label5.Name = "label5";
            label5.Size = new Size(221, 20);
            label5.TabIndex = 77;
            label5.Text = "A N G I V   L A G E R A N T A L";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Linen;
            pictureBox5.Image = Properties.Resources.PageBox;
            pictureBox5.Location = new Point(416, 448);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(372, 88);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 78;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Linen;
            pictureBox6.Image = Properties.Resources.PageBox;
            pictureBox6.Location = new Point(813, 448);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(372, 88);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 79;
            pictureBox6.TabStop = false;
            // 
            // numericNumberInStock
            // 
            numericNumberInStock.Location = new Point(556, 492);
            numericNumberInStock.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            numericNumberInStock.Name = "numericNumberInStock";
            numericNumberInStock.Size = new Size(92, 27);
            numericNumberInStock.TabIndex = 80;
            // 
            // numericMinInStock
            // 
            numericMinInStock.Location = new Point(953, 492);
            numericMinInStock.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            numericMinInStock.Name = "numericMinInStock";
            numericMinInStock.Size = new Size(92, 27);
            numericMinInStock.TabIndex = 81;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.AntiqueWhite;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.SaddleBrown;
            label6.Location = new Point(857, 469);
            label6.Name = "label6";
            label6.Size = new Size(284, 20);
            label6.TabIndex = 82;
            label6.Text = "A N G I V   M I N I M U M S G R Æ N S E";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.AntiqueWhite;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.SaddleBrown;
            label7.Location = new Point(490, 574);
            label7.Name = "label7";
            label7.Size = new Size(225, 20);
            label7.TabIndex = 83;
            label7.Text = "A N G I V   I N D K Ø B S P R I S";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Linen;
            pictureBox8.Image = Properties.Resources.PageBox;
            pictureBox8.Location = new Point(416, 553);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(372, 88);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 84;
            pictureBox8.TabStop = false;
            // 
            // textBoxPurchasePrice
            // 
            textBoxPurchasePrice.Location = new Point(556, 597);
            textBoxPurchasePrice.Name = "textBoxPurchasePrice";
            textBoxPurchasePrice.Size = new Size(92, 27);
            textBoxPurchasePrice.TabIndex = 86;
            // 
            // textBoxSalesPrice
            // 
            textBoxSalesPrice.Location = new Point(953, 597);
            textBoxSalesPrice.Name = "textBoxSalesPrice";
            textBoxSalesPrice.Size = new Size(92, 27);
            textBoxSalesPrice.TabIndex = 89;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.AntiqueWhite;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.SaddleBrown;
            label8.Location = new Point(901, 574);
            label8.Name = "label8";
            label8.Size = new Size(196, 20);
            label8.TabIndex = 87;
            label8.Text = "A N G I V   S A L G S P R I S";
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Linen;
            pictureBox9.Image = Properties.Resources.PageBox;
            pictureBox9.Location = new Point(813, 553);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(372, 88);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 88;
            pictureBox9.TabStop = false;
            // 
            // CreateProductPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxSalesPrice);
            Controls.Add(label8);
            Controls.Add(pictureBox9);
            Controls.Add(textBoxPurchasePrice);
            Controls.Add(label7);
            Controls.Add(pictureBox8);
            Controls.Add(label6);
            Controls.Add(numericMinInStock);
            Controls.Add(numericNumberInStock);
            Controls.Add(pictureBox6);
            Controls.Add(label5);
            Controls.Add(pictureBox5);
            Controls.Add(label3);
            Controls.Add(textBoxProductName);
            Controls.Add(pictureBox4);
            Controls.Add(label4);
            Controls.Add(textBoxProductType);
            Controls.Add(pictureBox7);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxEAN);
            Controls.Add(submitButton);
            Controls.Add(cancelButton);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Name = "CreateProductPage";
            Size = new Size(1600, 845);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)submitButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)cancelButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericNumberInStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericMinInStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox textBoxProductType;
        private PictureBox pictureBox7;
        private Label label2;
        private Label label1;
        private TextBox textBoxEAN;
        private PictureBox submitButton;
        private PictureBox cancelButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label3;
        private TextBox textBoxProductName;
        private PictureBox pictureBox4;
        private Label label5;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private NumericUpDown numericNumberInStock;
        private NumericUpDown numericMinInStock;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox8;
        private TextBox textBoxPurchasePrice;
        private TextBox textBoxSalesPrice;
        private Label label8;
        private PictureBox pictureBox9;
    }
}
