namespace _2SemesterProjekt.Pages.UserControls.MedicineUserControl
{
	partial class FindMedicinPage
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
			flowPanel = new FlowLayoutPanel();
			textBoxCustomerPhoneNumberOrName = new TextBox();
			customerSearchButton = new PictureBox();
			findAllButton = new PictureBox();
			label1 = new Label();
			pictureBox3 = new PictureBox();
			pictureBox2 = new PictureBox();
			label2 = new Label();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)customerSearchButton).BeginInit();
			((System.ComponentModel.ISupportInitialize)findAllButton).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// flowPanel
			// 
			flowPanel.AutoScroll = true;
			flowPanel.BackColor = Color.Linen;
			flowPanel.BorderStyle = BorderStyle.FixedSingle;
			flowPanel.Location = new Point(416, 240);
			flowPanel.Name = "flowPanel";
			flowPanel.Size = new Size(769, 562);
			flowPanel.TabIndex = 39;
			// 
			// textBoxCustomerPhoneNumberOrName
			// 
			textBoxCustomerPhoneNumberOrName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBoxCustomerPhoneNumberOrName.Location = new Point(570, 191);
			textBoxCustomerPhoneNumberOrName.Margin = new Padding(3, 4, 3, 4);
			textBoxCustomerPhoneNumberOrName.MaxLength = 8;
			textBoxCustomerPhoneNumberOrName.Name = "textBoxCustomerPhoneNumberOrName";
			textBoxCustomerPhoneNumberOrName.Size = new Size(274, 27);
			textBoxCustomerPhoneNumberOrName.TabIndex = 38;
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
			customerSearchButton.TabIndex = 37;
			customerSearchButton.TabStop = false;
			customerSearchButton.Click += customerSearchButton_Click;
			// 
			// findAllButton
			// 
			findAllButton.Image = Properties.Resources.FindAllButton;
			findAllButton.Location = new Point(931, 194);
			findAllButton.Name = "findAllButton";
			findAllButton.Size = new Size(99, 21);
			findAllButton.SizeMode = PictureBoxSizeMode.StretchImage;
			findAllButton.TabIndex = 36;
			findAllButton.TabStop = false;
			findAllButton.Click += findAllButton_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.AntiqueWhite;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.SaddleBrown;
			label1.Location = new Point(483, 166);
			label1.Name = "label1";
			label1.Size = new Size(635, 20);
			label1.TabIndex = 35;
			label1.Text = "T R Y K   F I N D   A L L E   E L L E R   S Ø G   P Å   K U N D E N S   T E L E F O N N U M M E R";
			// 
			// pictureBox3
			// 
			pictureBox3.BackColor = Color.Linen;
			pictureBox3.Image = Properties.Resources.PageBox;
			pictureBox3.Location = new Point(416, 146);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(769, 88);
			pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox3.TabIndex = 34;
			pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources.PageBackground;
			pictureBox2.Location = new Point(101, 122);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(1399, 705);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 33;
			pictureBox2.TabStop = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Linen;
			label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.SaddleBrown;
			label2.Location = new Point(339, 34);
			label2.Name = "label2";
			label2.Size = new Size(935, 50);
			label2.TabIndex = 31;
			label2.Text = "F I N D   M E D I C I N   F O R   K O N S U L T A T I O N";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.PageTitelBackground;
			pictureBox1.Location = new Point(101, 17);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(1399, 86);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 32;
			pictureBox1.TabStop = false;
			// 
			// FindMedicinPage
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(flowPanel);
			Controls.Add(textBoxCustomerPhoneNumberOrName);
			Controls.Add(customerSearchButton);
			Controls.Add(findAllButton);
			Controls.Add(label1);
			Controls.Add(pictureBox3);
			Controls.Add(pictureBox2);
			Controls.Add(label2);
			Controls.Add(pictureBox1);
			Name = "FindMedicinPage";
			Size = new Size(1600, 845);
			Load += FindMedicinPage_Load;
			((System.ComponentModel.ISupportInitialize)customerSearchButton).EndInit();
			((System.ComponentModel.ISupportInitialize)findAllButton).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private FlowLayoutPanel flowPanel;
		private TextBox textBoxCustomerPhoneNumberOrName;
		private PictureBox customerSearchButton;
		private PictureBox findAllButton;
		private Label label1;
		private PictureBox pictureBox3;
		private PictureBox pictureBox2;
		private Label label2;
		private PictureBox pictureBox1;
	}
}
