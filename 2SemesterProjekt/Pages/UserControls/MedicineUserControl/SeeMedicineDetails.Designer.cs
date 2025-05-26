namespace _2SemesterProjekt.Pages.UserControls.MedicineUserControl
{
	partial class SeeMedicineDetails
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
            cancelButton = new PictureBox();
            flowPanel = new FlowLayoutPanel();
            SearchMedicineTextBox = new TextBox();
            customerSearchButton = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            findAllButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)cancelButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerSearchButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)findAllButton).BeginInit();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Image = Properties.Resources.CancelButton;
            cancelButton.Location = new Point(157, 747);
            cancelButton.Margin = new Padding(3, 4, 3, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(240, 55);
            cancelButton.SizeMode = PictureBoxSizeMode.StretchImage;
            cancelButton.TabIndex = 62;
            cancelButton.TabStop = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // flowPanel
            // 
            flowPanel.AutoScroll = true;
            flowPanel.BackColor = Color.Linen;
            flowPanel.BorderStyle = BorderStyle.FixedSingle;
            flowPanel.Location = new Point(416, 240);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(769, 562);
            flowPanel.TabIndex = 71;
            // 
            // SearchMedicineTextBox
            // 
            SearchMedicineTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchMedicineTextBox.ForeColor = SystemColors.InactiveCaption;
            SearchMedicineTextBox.Location = new Point(570, 191);
            SearchMedicineTextBox.Margin = new Padding(3, 4, 3, 4);
            SearchMedicineTextBox.MaxLength = 55;
            SearchMedicineTextBox.Name = "SearchMedicineTextBox";
            SearchMedicineTextBox.Size = new Size(274, 27);
            SearchMedicineTextBox.TabIndex = 70;
            SearchMedicineTextBox.Text = "Søg på medicin navn";
            SearchMedicineTextBox.Click += SearchMedicineTextBox_Click;
            // 
            // customerSearchButton
            // 
            customerSearchButton.BackColor = Color.AntiqueWhite;
            customerSearchButton.Image = Properties.Resources.SearchButton;
            customerSearchButton.Location = new Point(850, 194);
            customerSearchButton.Margin = new Padding(3, 4, 3, 4);
            customerSearchButton.Name = "customerSearchButton";
            customerSearchButton.Size = new Size(47, 21);
            customerSearchButton.SizeMode = PictureBoxSizeMode.StretchImage;
            customerSearchButton.TabIndex = 69;
            customerSearchButton.TabStop = false;
            customerSearchButton.Click += MedicineSearchButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(555, 167);
            label1.Name = "label1";
            label1.Size = new Size(475, 20);
            label1.TabIndex = 67;
            label1.Text = "T R Y K   S E   A L L E   E L L E R   S Ø G   P Å   M E D I C I N   N A V N";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Linen;
            pictureBox3.Image = Properties.Resources.PageBox;
            pictureBox3.Location = new Point(416, 146);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(769, 88);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 66;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.PageBackground;
            pictureBox2.Location = new Point(101, 122);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1399, 705);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 65;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Linen;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(523, 33);
            label2.Name = "label2";
            label2.Size = new Size(595, 50);
            label2.TabIndex = 63;
            label2.Text = "S E   M E D I C I N   D E T A L J E R";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PageTitelBackground;
            pictureBox1.Location = new Point(101, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1399, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 64;
            pictureBox1.TabStop = false;
            // 
            // findAllButton
            // 
            findAllButton.Image = Properties.Resources.FindAllButton;
            findAllButton.Location = new Point(931, 194);
            findAllButton.Name = "findAllButton";
            findAllButton.Size = new Size(99, 21);
            findAllButton.SizeMode = PictureBoxSizeMode.StretchImage;
            findAllButton.TabIndex = 68;
            findAllButton.TabStop = false;
            findAllButton.Click += findAllButton_Click;
            // 
            // SeeMedicineDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cancelButton);
            Controls.Add(flowPanel);
            Controls.Add(SearchMedicineTextBox);
            Controls.Add(customerSearchButton);
            Controls.Add(findAllButton);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "SeeMedicineDetails";
            Size = new Size(1600, 845);
            Load += SeeMedicineDetails_Load;
            ((System.ComponentModel.ISupportInitialize)cancelButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerSearchButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)findAllButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox cancelButton;
		private FlowLayoutPanel flowPanel;
		private TextBox SearchMedicineTextBox;
		private PictureBox customerSearchButton;
		private Label label1;
		private PictureBox pictureBox3;
		private PictureBox pictureBox2;
		private Label label2;
		private PictureBox pictureBox1;
		private PictureBox findAllButton;
	}
}
