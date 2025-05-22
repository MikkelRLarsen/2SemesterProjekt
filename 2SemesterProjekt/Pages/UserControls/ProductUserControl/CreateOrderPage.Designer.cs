namespace _2SemesterProjekt.Pages.UserControls.ProductUserControl
{
    partial class CreateOrderPage
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
            customerSearchButton = new PictureBox();
            findAllButton = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            goToCartButton = new PictureBox();
            cancelButton = new PictureBox();
            pictureBox2 = new PictureBox();
            itemsInCart = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerSearchButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)findAllButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goToCartButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cancelButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            label2.Size = new Size(372, 50);
            label2.TabIndex = 22;
            label2.Text = "O P R E T   O R D R E";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PageTitelBackground;
            pictureBox1.Location = new Point(101, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1399, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
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
            flowPanel.TabIndex = 49;
            // 
            // textBoxProduct
            // 
            textBoxProduct.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxProduct.ForeColor = SystemColors.InactiveCaption;
            textBoxProduct.Location = new Point(570, 194);
            textBoxProduct.Margin = new Padding(3, 4, 3, 4);
            textBoxProduct.MaxLength = 8;
            textBoxProduct.Name = "textBoxProduct";
            textBoxProduct.Size = new Size(274, 27);
            textBoxProduct.TabIndex = 48;
            textBoxProduct.Text = "Søg på produktnavn";
            textBoxProduct.Enter += textBoxProduct_Enter;
            textBoxProduct.Leave += textBoxProduct_Leave;
            // 
            // customerSearchButton
            // 
            customerSearchButton.BackColor = Color.AntiqueWhite;
            customerSearchButton.Image = Properties.Resources.SearchButton;
            customerSearchButton.Location = new Point(850, 197);
            customerSearchButton.Margin = new Padding(3, 4, 3, 4);
            customerSearchButton.Name = "customerSearchButton";
            customerSearchButton.Size = new Size(47, 21);
            customerSearchButton.SizeMode = PictureBoxSizeMode.StretchImage;
            customerSearchButton.TabIndex = 47;
            customerSearchButton.TabStop = false;
            customerSearchButton.Click += customerSearchButton_Click;
            customerSearchButton.MouseEnter += customerSearchButton_MouseEnter;
            customerSearchButton.MouseLeave += customerSearchButton_MouseLeave;
            // 
            // findAllButton
            // 
            findAllButton.Image = Properties.Resources.FindAllButtonGreyedOut;
            findAllButton.Location = new Point(931, 197);
            findAllButton.Name = "findAllButton";
            findAllButton.Size = new Size(99, 21);
            findAllButton.TabIndex = 46;
            findAllButton.TabStop = false;
            findAllButton.Click += findAllButton_Click;
            findAllButton.MouseEnter += findAllButton_MouseEnter;
            findAllButton.MouseLeave += findAllButton_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(549, 169);
            label1.Name = "label1";
            label1.Size = new Size(502, 20);
            label1.TabIndex = 45;
            label1.Text = "T R Y K   F I N D   A L L E   E L L E R   S Ø G   P Å   P R O D U K T N A V N";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Linen;
            pictureBox3.Image = Properties.Resources.PageBox;
            pictureBox3.Location = new Point(416, 149);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(769, 88);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 44;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.PageBackground;
            pictureBox4.Location = new Point(101, 124);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1399, 705);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 50;
            pictureBox4.TabStop = false;
            // 
            // goToCartButton
            // 
            goToCartButton.Image = Properties.Resources.GoToCartButton;
            goToCartButton.Location = new Point(945, 751);
            goToCartButton.Margin = new Padding(3, 4, 3, 4);
            goToCartButton.Name = "goToCartButton";
            goToCartButton.Size = new Size(240, 55);
            goToCartButton.SizeMode = PictureBoxSizeMode.StretchImage;
            goToCartButton.TabIndex = 52;
            goToCartButton.TabStop = false;
            goToCartButton.Click += goToCartButton_Click;
            goToCartButton.MouseEnter += goToCartButton_MouseEnter;
            goToCartButton.MouseLeave += goToCartButton_MouseLeave;
            // 
            // cancelButton
            // 
            cancelButton.Image = Properties.Resources.CancelButton;
            cancelButton.Location = new Point(416, 751);
            cancelButton.Margin = new Padding(3, 4, 3, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(240, 55);
            cancelButton.SizeMode = PictureBoxSizeMode.StretchImage;
            cancelButton.TabIndex = 51;
            cancelButton.TabStop = false;
            cancelButton.Click += cancelButton_Click;
            cancelButton.MouseEnter += cancelButton_MouseEnter;
            cancelButton.MouseLeave += cancelButton_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Linen;
            pictureBox2.Image = Properties.Resources.ShoppingCart;
            pictureBox2.Location = new Point(1203, 243);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(95, 83);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 53;
            pictureBox2.TabStop = false;
            // 
            // itemsInCart
            // 
            itemsInCart.AutoSize = true;
            itemsInCart.BackColor = Color.SaddleBrown;
            itemsInCart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemsInCart.ForeColor = Color.Linen;
            itemsInCart.Location = new Point(1271, 296);
            itemsInCart.Name = "itemsInCart";
            itemsInCart.Size = new Size(18, 20);
            itemsInCart.TabIndex = 54;
            itemsInCart.Text = "0";
            // 
            // CreateOrderPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(itemsInCart);
            Controls.Add(pictureBox2);
            Controls.Add(goToCartButton);
            Controls.Add(cancelButton);
            Controls.Add(flowPanel);
            Controls.Add(textBoxProduct);
            Controls.Add(customerSearchButton);
            Controls.Add(findAllButton);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Margin = new Padding(0);
            Name = "CreateOrderPage";
            Size = new Size(1600, 845);
            Load += CreateOrderPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerSearchButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)findAllButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)goToCartButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)cancelButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowPanel;
        private TextBox textBoxProduct;
        private PictureBox customerSearchButton;
        private PictureBox findAllButton;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox goToCartButton;
        private PictureBox cancelButton;
        private PictureBox pictureBox2;
        private Label itemsInCart;
    }
}
