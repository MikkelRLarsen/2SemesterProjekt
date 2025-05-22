namespace _2SemesterProjekt.Pages.UserControls.EmployeeUserControl
{
	partial class CreateEmployeePage
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
			pictureBox4 = new PictureBox();
			submitButton = new PictureBox();
			cancelButton = new PictureBox();
			comboBoxType = new ComboBox();
			textBoxLastName = new TextBox();
			textBoxFirstName = new TextBox();
			label7 = new Label();
			label3 = new Label();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)submitButton).BeginInit();
			((System.ComponentModel.ISupportInitialize)cancelButton).BeginInit();
			SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Linen;
			label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.SaddleBrown;
			label2.Location = new Point(608, 34);
			label2.Name = "label2";
			label2.Size = new Size(373, 50);
			label2.TabIndex = 47;
			label2.Text = "O P R E T   A N S A T";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.PageTitelBackground;
			pictureBox1.Location = new Point(101, 17);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(1399, 86);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 48;
			pictureBox1.TabStop = false;
			// 
			// pictureBox4
			// 
			pictureBox4.BackColor = Color.Linen;
			pictureBox4.Image = Properties.Resources.PageBackground;
			pictureBox4.Location = new Point(101, 125);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(1399, 705);
			pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox4.TabIndex = 49;
			pictureBox4.TabStop = false;
			// 
			// submitButton
			// 
			submitButton.Enabled = false;
			submitButton.Image = Properties.Resources.SaveButtonGreyedOut;
			submitButton.Location = new Point(945, 751);
			submitButton.Margin = new Padding(3, 4, 3, 4);
			submitButton.Name = "submitButton";
			submitButton.Size = new Size(240, 55);
			submitButton.SizeMode = PictureBoxSizeMode.StretchImage;
			submitButton.TabIndex = 51;
			submitButton.TabStop = false;
			submitButton.Click += submitButton_Click;
			// 
			// cancelButton
			// 
			cancelButton.Image = Properties.Resources.CancelButton;
			cancelButton.Location = new Point(416, 751);
			cancelButton.Margin = new Padding(3, 4, 3, 4);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(240, 55);
			cancelButton.SizeMode = PictureBoxSizeMode.StretchImage;
			cancelButton.TabIndex = 50;
			cancelButton.TabStop = false;
			cancelButton.Click += cancelButton_Click;
			// 
			// comboBoxType
			// 
			comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxType.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			comboBoxType.FormattingEnabled = true;
			comboBoxType.Location = new Point(886, 355);
			comboBoxType.Margin = new Padding(3, 4, 3, 4);
			comboBoxType.Name = "comboBoxType";
			comboBoxType.Size = new Size(355, 44);
			comboBoxType.TabIndex = 63;
			comboBoxType.SelectionChangeCommitted += comboBoxType_SelectionChangeCommitted;
			// 
			// textBoxLastName
			// 
			textBoxLastName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBoxLastName.Location = new Point(886, 255);
			textBoxLastName.Margin = new Padding(3, 4, 3, 4);
			textBoxLastName.Name = "textBoxLastName";
			textBoxLastName.Size = new Size(355, 42);
			textBoxLastName.TabIndex = 59;
			// 
			// textBoxFirstName
			// 
			textBoxFirstName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBoxFirstName.Location = new Point(886, 155);
			textBoxFirstName.Margin = new Padding(3, 4, 3, 4);
			textBoxFirstName.Name = "textBoxFirstName";
			textBoxFirstName.Size = new Size(355, 42);
			textBoxFirstName.TabIndex = 58;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.BackColor = Color.Linen;
			label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label7.ForeColor = Color.SaddleBrown;
			label7.Location = new Point(359, 362);
			label7.Name = "label7";
			label7.Size = new Size(272, 31);
			label7.TabIndex = 57;
			label7.Text = "A N S A T   S T I L L I N G";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Linen;
			label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.SaddleBrown;
			label3.Location = new Point(359, 262);
			label3.Name = "label3";
			label3.Size = new Size(193, 31);
			label3.TabIndex = 53;
			label3.Text = "E F T E R N A V N";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Linen;
			label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.SaddleBrown;
			label1.Location = new Point(359, 162);
			label1.Name = "label1";
			label1.Size = new Size(161, 31);
			label1.TabIndex = 52;
			label1.Text = "F O R N A V N";
			// 
			// CreateEmployeePage
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(comboBoxType);
			Controls.Add(textBoxLastName);
			Controls.Add(textBoxFirstName);
			Controls.Add(label7);
			Controls.Add(label3);
			Controls.Add(label1);
			Controls.Add(submitButton);
			Controls.Add(cancelButton);
			Controls.Add(label2);
			Controls.Add(pictureBox1);
			Controls.Add(pictureBox4);
			Name = "CreateEmployeePage";
			Size = new Size(1600, 845);
			Load += CreateEmployeePage_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)submitButton).EndInit();
			((System.ComponentModel.ISupportInitialize)cancelButton).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label2;
		private PictureBox pictureBox1;
		private PictureBox pictureBox4;
		private PictureBox submitButton;
		private PictureBox cancelButton;
		private ComboBox comboBoxType;
		private TextBox textBoxLastName;
		private TextBox textBoxFirstName;
		private Label label7;
		private Label label3;
		private Label label1;
	}
}
