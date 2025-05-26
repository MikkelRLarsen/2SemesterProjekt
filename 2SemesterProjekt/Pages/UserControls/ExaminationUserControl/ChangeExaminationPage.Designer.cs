namespace _2SemesterProjekt.Pages.UserControls.ExaminationUserControl
{
    partial class ChangeExaminationPage
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
            textBoxCustomerPhoneNumberOrName = new TextBox();
            customerSearchButton = new PictureBox();
            findAllButton = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            flowPanel = new FlowLayoutPanel();
            pictureBox4 = new PictureBox();
            changeButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerSearchButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)findAllButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)changeButton).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Linen;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(429, 37);
            label2.Name = "label2";
            label2.Size = new Size(743, 50);
            label2.TabIndex = 24;
            label2.Text = "O P D A T E R   K O N S U L T A T I O N E R";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PageTitelBackground;
            pictureBox1.Location = new Point(101, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1399, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // textBoxCustomerPhoneNumberOrName
            // 
            textBoxCustomerPhoneNumberOrName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCustomerPhoneNumberOrName.Location = new Point(570, 194);
            textBoxCustomerPhoneNumberOrName.Margin = new Padding(3, 4, 3, 4);
            textBoxCustomerPhoneNumberOrName.MaxLength = 8;
            textBoxCustomerPhoneNumberOrName.Name = "textBoxCustomerPhoneNumberOrName";
            textBoxCustomerPhoneNumberOrName.Size = new Size(274, 27);
            textBoxCustomerPhoneNumberOrName.TabIndex = 34;
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
            customerSearchButton.TabIndex = 33;
            customerSearchButton.TabStop = false;
            customerSearchButton.Click += customerSearchButton_Click;
            // 
            // findAllButton
            // 
            findAllButton.Image = Properties.Resources.FindAllButtonGreyedOut;
            findAllButton.Location = new Point(931, 197);
            findAllButton.Name = "findAllButton";
            findAllButton.Size = new Size(99, 21);
            findAllButton.SizeMode = PictureBoxSizeMode.StretchImage;
            findAllButton.TabIndex = 32;
            findAllButton.TabStop = false;
            findAllButton.Click += findAllButton_Click;
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
            label1.TabIndex = 31;
            label1.Text = "T R Y K   F I N D   A L L E   E L L E R   S Ø G   P Å   K U N D E N S   T E L E F O N N U M M E R";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Linen;
            pictureBox3.Image = Properties.Resources.PageBox;
            pictureBox3.Location = new Point(416, 149);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(769, 88);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            // 
            // flowPanel
            // 
            flowPanel.AutoScroll = true;
            flowPanel.BackColor = Color.Linen;
            flowPanel.BorderStyle = BorderStyle.FixedSingle;
            flowPanel.Location = new Point(416, 243);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(769, 562);
            flowPanel.TabIndex = 35;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.PageBackground;
            pictureBox4.Location = new Point(101, 125);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1399, 705);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 36;
            pictureBox4.TabStop = false;
            // 
            // changeButton
            // 
            changeButton.Image = Properties.Resources.ChangeButtonGreyedOut;
            changeButton.Location = new Point(1221, 750);
            changeButton.Margin = new Padding(3, 4, 3, 4);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(240, 55);
            changeButton.SizeMode = PictureBoxSizeMode.StretchImage;
            changeButton.TabIndex = 37;
            changeButton.TabStop = false;
            changeButton.Click += changeButton_Click;
            // 
            // ChangeExaminationPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(changeButton);
            Controls.Add(flowPanel);
            Controls.Add(textBoxCustomerPhoneNumberOrName);
            Controls.Add(customerSearchButton);
            Controls.Add(findAllButton);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Margin = new Padding(0);
            Name = "ChangeExaminationPage";
            Size = new Size(1600, 845);
            Load += UpdateExaminationPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerSearchButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)findAllButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)changeButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private TextBox textBoxCustomerPhoneNumberOrName;
        private PictureBox customerSearchButton;
        private PictureBox findAllButton;
        private Label label1;
        private PictureBox pictureBox3;
        private FlowLayoutPanel flowPanel;
        private PictureBox pictureBox4;
        private PictureBox changeButton;
    }
}
