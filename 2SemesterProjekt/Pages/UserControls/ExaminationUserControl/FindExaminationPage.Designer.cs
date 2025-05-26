namespace _2SemesterProjekt.Pages.UserControls.ExaminationUserControl
{
    partial class FindExaminationPage
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
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            findAllButton = new PictureBox();
            textBoxCustomerPhoneNumberOrName = new TextBox();
            customerSearchButton = new PictureBox();
            flowPanel = new FlowLayoutPanel();
            exportToTxtButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)findAllButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerSearchButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exportToTxtButton).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Linen;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(485, 38);
            label2.Name = "label2";
            label2.Size = new Size(630, 50);
            label2.TabIndex = 22;
            label2.Text = "F I N D   K O N S U L T A T I O N E R";
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
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.PageBackground;
            pictureBox2.Location = new Point(101, 125);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1399, 705);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Linen;
            pictureBox3.Image = Properties.Resources.PageBox;
            pictureBox3.Location = new Point(416, 149);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(769, 88);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(483, 169);
            label1.Name = "label1";
            label1.Size = new Size(635, 20);
            label1.TabIndex = 26;
            label1.Text = "T R Y K   F I N D   A L L E   E L L E R   S Ø G   P Å   K U N D E N S   T E L E F O N N U M M E R";
            // 
            // findAllButton
            // 
            findAllButton.Image = Properties.Resources.FindAllButtonGreyedOut;
            findAllButton.Location = new Point(931, 197);
            findAllButton.Name = "findAllButton";
            findAllButton.Size = new Size(99, 21);
            findAllButton.SizeMode = PictureBoxSizeMode.StretchImage;
            findAllButton.TabIndex = 27;
            findAllButton.TabStop = false;
            findAllButton.Click += findAllButton_Click;
            // 
            // textBoxCustomerPhoneNumberOrName
            // 
            textBoxCustomerPhoneNumberOrName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCustomerPhoneNumberOrName.ForeColor = SystemColors.InactiveCaption;
            textBoxCustomerPhoneNumberOrName.Location = new Point(570, 194);
            textBoxCustomerPhoneNumberOrName.Margin = new Padding(3, 4, 3, 4);
            textBoxCustomerPhoneNumberOrName.MaxLength = 8;
            textBoxCustomerPhoneNumberOrName.Name = "textBoxCustomerPhoneNumberOrName";
            textBoxCustomerPhoneNumberOrName.Size = new Size(274, 27);
            textBoxCustomerPhoneNumberOrName.TabIndex = 29;
            textBoxCustomerPhoneNumberOrName.Text = "Søg på navn eller telefonnummer";
            textBoxCustomerPhoneNumberOrName.Click += textBoxCustomerPhoneNumberOrName_Click;
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
            customerSearchButton.TabIndex = 28;
            customerSearchButton.TabStop = false;
            customerSearchButton.Click += customerSearchButton_Click;
            // 
            // flowPanel
            // 
            flowPanel.AutoScroll = true;
            flowPanel.BackColor = Color.Linen;
            flowPanel.BorderStyle = BorderStyle.FixedSingle;
            flowPanel.Location = new Point(416, 243);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(769, 562);
            flowPanel.TabIndex = 30;
            // 
            // exportToTxtButton
            // 
            exportToTxtButton.BackColor = Color.Linen;
            exportToTxtButton.Image = Properties.Resources.CreateInvoice;
            exportToTxtButton.Location = new Point(1191, 784);
            exportToTxtButton.Name = "exportToTxtButton";
            exportToTxtButton.Size = new Size(139, 21);
            exportToTxtButton.TabIndex = 55;
            exportToTxtButton.TabStop = false;
            exportToTxtButton.Click += exportToTxtButton_Click;
            // 
            // FindExaminationPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(exportToTxtButton);
            Controls.Add(flowPanel);
            Controls.Add(textBoxCustomerPhoneNumberOrName);
            Controls.Add(customerSearchButton);
            Controls.Add(findAllButton);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Margin = new Padding(0);
            Name = "FindExaminationPage";
            Size = new Size(1600, 845);
            Load += FindExaminationPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)findAllButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerSearchButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)exportToTxtButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox findAllButton;
        private TextBox textBoxCustomerPhoneNumberOrName;
        private PictureBox customerSearchButton;
        private FlowLayoutPanel flowPanel;
		private PictureBox exportToTxtButton;
	}
}
