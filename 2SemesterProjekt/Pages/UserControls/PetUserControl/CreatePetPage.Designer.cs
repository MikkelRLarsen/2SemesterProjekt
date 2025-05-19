namespace _2SemesterProjekt.Pages.UserControls.PetUserControl
{
    partial class CreatePetPage
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
			pictureBox3 = new PictureBox();
			submitButton = new PictureBox();
			cancelButton = new PictureBox();
			pictureBox2 = new PictureBox();
			textBoxPhoneNumber = new TextBox();
			textBoxPetName = new TextBox();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label1 = new Label();
			ComboBoxPetDoctor = new ComboBox();
			DateTimePickerBirthday = new DateTimePicker();
			ComboBoxPetSpecies = new ComboBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)submitButton).BeginInit();
			((System.ComponentModel.ISupportInitialize)cancelButton).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Linen;
			label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.SaddleBrown;
			label2.Location = new Point(788, 108);
			label2.Name = "label2";
			label2.Size = new Size(924, 81);
			label2.TabIndex = 22;
			label2.Text = "O P R E T   N Y T   K Æ L E D Y R";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.PageTitelBackground;
			pictureBox1.Location = new Point(84, 77);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(2332, 144);
			pictureBox1.TabIndex = 23;
			pictureBox1.TabStop = false;
			// 
			// pictureBox3
			// 
			pictureBox3.BackColor = Color.Linen;
			pictureBox3.Image = Properties.Resources.PageCreateBox;
			pictureBox3.Location = new Point(609, 277);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(1282, 1047);
			pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox3.TabIndex = 31;
			pictureBox3.TabStop = false;
			// 
			// submitButton
			// 
			submitButton.Enabled = false;
			submitButton.Image = Properties.Resources.CreateButtonGreyedOut;
			submitButton.Location = new Point(1691, 1422);
			submitButton.Margin = new Padding(3, 4, 3, 4);
			submitButton.Name = "submitButton";
			submitButton.Size = new Size(400, 92);
			submitButton.TabIndex = 30;
			submitButton.TabStop = false;
			submitButton.Click += submitButton_Click;
			// 
			// cancelButton
			// 
			cancelButton.Image = Properties.Resources.CancelButton;
			cancelButton.Location = new Point(409, 1422);
			cancelButton.Margin = new Padding(3, 4, 3, 4);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(400, 92);
			cancelButton.TabIndex = 29;
			cancelButton.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources.PageBackground;
			pictureBox2.Location = new Point(84, 242);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(2332, 1116);
			pictureBox2.TabIndex = 28;
			pictureBox2.TabStop = false;
			// 
			// textBoxPhoneNumber
			// 
			textBoxPhoneNumber.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBoxPhoneNumber.Location = new Point(1336, 758);
			textBoxPhoneNumber.Margin = new Padding(3, 4, 3, 4);
			textBoxPhoneNumber.Name = "textBoxPhoneNumber";
			textBoxPhoneNumber.Size = new Size(355, 42);
			textBoxPhoneNumber.TabIndex = 47;
			textBoxPhoneNumber.KeyPress += textBoxPhoneNumber_KeyPress;
			// 
			// textBoxPetName
			// 
			textBoxPetName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBoxPetName.Location = new Point(1336, 464);
			textBoxPetName.Margin = new Padding(3, 4, 3, 4);
			textBoxPetName.Name = "textBoxPetName";
			textBoxPetName.Size = new Size(355, 42);
			textBoxPetName.TabIndex = 44;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = Color.AntiqueWhite;
			label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.SaddleBrown;
			label6.Location = new Point(809, 863);
			label6.Name = "label6";
			label6.Size = new Size(176, 31);
			label6.TabIndex = 43;
			label6.Text = "D Y R E L Æ G E";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.AntiqueWhite;
			label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.ForeColor = Color.SaddleBrown;
			label5.Location = new Point(809, 765);
			label5.Name = "label5";
			label5.Size = new Size(248, 31);
			label5.TabIndex = 42;
			label5.Text = "E J E R N S   T L F   N R";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.AntiqueWhite;
			label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.SaddleBrown;
			label4.Location = new Point(809, 667);
			label4.Name = "label4";
			label4.Size = new Size(239, 31);
			label4.TabIndex = 41;
			label4.Text = "F Ø D S E L S D A T O ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.AntiqueWhite;
			label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.SaddleBrown;
			label3.Location = new Point(809, 569);
			label3.Name = "label3";
			label3.Size = new Size(70, 31);
			label3.TabIndex = 40;
			label3.Text = "A R T";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.AntiqueWhite;
			label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.SaddleBrown;
			label1.Location = new Point(809, 471);
			label1.Name = "label1";
			label1.Size = new Size(99, 31);
			label1.TabIndex = 39;
			label1.Text = "N A V N";
			// 
			// ComboBoxPetDoctor
			// 
			ComboBoxPetDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBoxPetDoctor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ComboBoxPetDoctor.FormattingEnabled = true;
			ComboBoxPetDoctor.Location = new Point(1338, 856);
			ComboBoxPetDoctor.Margin = new Padding(3, 4, 3, 4);
			ComboBoxPetDoctor.Name = "ComboBoxPetDoctor";
			ComboBoxPetDoctor.Size = new Size(355, 44);
			ComboBoxPetDoctor.TabIndex = 50;
			ComboBoxPetDoctor.SelectionChangeCommitted += ComboBoxPetDoctor_SelectionChangeCommitted;
			// 
			// DateTimePickerBirthday
			// 
			DateTimePickerBirthday.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			DateTimePickerBirthday.Location = new Point(1338, 660);
			DateTimePickerBirthday.Margin = new Padding(3, 4, 3, 4);
			DateTimePickerBirthday.Name = "DateTimePickerBirthday";
			DateTimePickerBirthday.Size = new Size(355, 42);
			DateTimePickerBirthday.TabIndex = 51;
			// 
			// ComboBoxPetSpecies
			// 
			ComboBoxPetSpecies.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBoxPetSpecies.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ComboBoxPetSpecies.FormattingEnabled = true;
			ComboBoxPetSpecies.Location = new Point(1336, 562);
			ComboBoxPetSpecies.Margin = new Padding(3, 4, 3, 4);
			ComboBoxPetSpecies.Name = "ComboBoxPetSpecies";
			ComboBoxPetSpecies.Size = new Size(355, 44);
			ComboBoxPetSpecies.TabIndex = 52;
			// 
			// CreatePetPage
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(ComboBoxPetSpecies);
			Controls.Add(DateTimePickerBirthday);
			Controls.Add(ComboBoxPetDoctor);
			Controls.Add(textBoxPhoneNumber);
			Controls.Add(textBoxPetName);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label1);
			Controls.Add(pictureBox3);
			Controls.Add(submitButton);
			Controls.Add(cancelButton);
			Controls.Add(pictureBox2);
			Controls.Add(label2);
			Controls.Add(pictureBox1);
			Margin = new Padding(0);
			Name = "CreatePetPage";
			Size = new Size(2500, 1580);
			Load += CreatePetPage_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)submitButton).EndInit();
			((System.ComponentModel.ISupportInitialize)cancelButton).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox submitButton;
        private PictureBox cancelButton;
        private PictureBox pictureBox2;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxAddress;
        private TextBox textBoxPetName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
		private ComboBox ComboBoxPetDoctor;
		private DateTimePicker DateTimePickerBirthday;
		private ComboBox ComboBoxPetSpecies;
	}
}
