namespace _2SemesterProjekt.Pages.User_Controls
{
	partial class UpdateCustomerCard
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
			profilePicture = new PictureBox();
			label3 = new Label();
			label2 = new Label();
			label5 = new Label();
			label7 = new Label();
			label1 = new Label();
			label = new Label();
			customerNameTextBox = new TextBox();
			customerAdressTextBox = new TextBox();
			customerTlfTextBox = new TextBox();
			customerEmailTextBox = new TextBox();
			DoneButton = new Button();
			AddPetButton = new Button();
			PrevButton = new Button();
			NextButton = new Button();
			PetPanal = new FlowLayoutPanel();
			((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
			SuspendLayout();
			// 
			// profilePicture
			// 
			profilePicture.Anchor = AnchorStyles.Left;
			profilePicture.Image = Properties.Resources.member;
			profilePicture.Location = new Point(20, 28);
			profilePicture.Margin = new Padding(4, 5, 4, 5);
			profilePicture.Name = "profilePicture";
			profilePicture.Size = new Size(141, 167);
			profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
			profilePicture.TabIndex = 11;
			profilePicture.TabStop = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(616, 78);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(47, 27);
			label3.TabIndex = 16;
			label3.Text = "Tlf:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(616, 28);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(225, 27);
			label2.TabIndex = 15;
			label2.Text = "Kontaktoplysninger";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.Location = new Point(190, 78);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(74, 27);
			label5.TabIndex = 13;
			label5.Text = "Navn:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label7.Location = new Point(616, 128);
			label7.Margin = new Padding(4, 0, 4, 0);
			label7.Name = "label7";
			label7.Size = new Size(77, 27);
			label7.TabIndex = 17;
			label7.Text = "Email:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(190, 128);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(101, 27);
			label1.TabIndex = 14;
			label1.Text = "Adresse:";
			// 
			// label
			// 
			label.AutoSize = true;
			label.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label.Location = new Point(190, 28);
			label.Margin = new Padding(4, 0, 4, 0);
			label.Name = "label";
			label.Size = new Size(110, 27);
			label.TabIndex = 12;
			label.Text = "Kundenr:";
			// 
			// customerNameTextBox
			// 
			customerNameTextBox.Location = new Point(274, 78);
			customerNameTextBox.Margin = new Padding(4, 5, 4, 5);
			customerNameTextBox.Name = "customerNameTextBox";
			customerNameTextBox.Size = new Size(284, 31);
			customerNameTextBox.TabIndex = 18;
			customerNameTextBox.TextChanged += customerNameTextBox_TextChanged;
			// 
			// customerAdressTextBox
			// 
			customerAdressTextBox.Location = new Point(297, 128);
			customerAdressTextBox.Margin = new Padding(4, 5, 4, 5);
			customerAdressTextBox.Name = "customerAdressTextBox";
			customerAdressTextBox.Size = new Size(261, 31);
			customerAdressTextBox.TabIndex = 19;
			customerAdressTextBox.TextChanged += customerAdressTextBox_TextChanged;
			// 
			// customerTlfTextBox
			// 
			customerTlfTextBox.Location = new Point(670, 78);
			customerTlfTextBox.Margin = new Padding(4, 5, 4, 5);
			customerTlfTextBox.Name = "customerTlfTextBox";
			customerTlfTextBox.Size = new Size(284, 31);
			customerTlfTextBox.TabIndex = 20;
			customerTlfTextBox.TextChanged += customerTlfTextBox_TextChanged;
			// 
			// customerEmailTextBox
			// 
			customerEmailTextBox.Location = new Point(697, 127);
			customerEmailTextBox.Margin = new Padding(4, 5, 4, 5);
			customerEmailTextBox.Name = "customerEmailTextBox";
			customerEmailTextBox.Size = new Size(257, 31);
			customerEmailTextBox.TabIndex = 21;
			customerEmailTextBox.TextChanged += customerEmailTextBox_TextChanged;
			// 
			// DoneButton
			// 
			DoneButton.Location = new Point(180, 462);
			DoneButton.Margin = new Padding(4, 5, 4, 5);
			DoneButton.Name = "DoneButton";
			DoneButton.Size = new Size(504, 58);
			DoneButton.TabIndex = 22;
			DoneButton.Text = "Click when done";
			DoneButton.UseVisualStyleBackColor = true;
			DoneButton.Click += DoneButton_Click;
			// 
			// AddPetButton
			// 
			AddPetButton.Location = new Point(723, 215);
			AddPetButton.Margin = new Padding(4, 5, 4, 5);
			AddPetButton.Name = "AddPetButton";
			AddPetButton.Size = new Size(233, 52);
			AddPetButton.TabIndex = 23;
			AddPetButton.Text = "Add Pet";
			AddPetButton.UseVisualStyleBackColor = true;
			AddPetButton.Click += AddPetButton_Click;
			// 
			// PrevButton
			// 
			PrevButton.Location = new Point(723, 277);
			PrevButton.Margin = new Padding(4, 5, 4, 5);
			PrevButton.Name = "PrevButton";
			PrevButton.Size = new Size(103, 38);
			PrevButton.TabIndex = 25;
			PrevButton.Text = "<-";
			PrevButton.UseVisualStyleBackColor = true;
			PrevButton.Click += PrevButton_Click;
			// 
			// NextButton
			// 
			NextButton.Location = new Point(853, 277);
			NextButton.Margin = new Padding(4, 5, 4, 5);
			NextButton.Name = "NextButton";
			NextButton.Size = new Size(103, 38);
			NextButton.TabIndex = 26;
			NextButton.Text = "->";
			NextButton.UseVisualStyleBackColor = true;
			NextButton.Click += NextButton_Click;
			// 
			// PetPanal
			// 
			PetPanal.BackColor = SystemColors.ButtonFace;
			PetPanal.Location = new Point(190, 215);
			PetPanal.Margin = new Padding(4, 5, 4, 5);
			PetPanal.Name = "PetPanal";
			PetPanal.Size = new Size(500, 200);
			PetPanal.TabIndex = 27;
			// 
			// UpdateCustomerCard
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(PetPanal);
			Controls.Add(NextButton);
			Controls.Add(PrevButton);
			Controls.Add(AddPetButton);
			Controls.Add(DoneButton);
			Controls.Add(customerEmailTextBox);
			Controls.Add(customerTlfTextBox);
			Controls.Add(customerAdressTextBox);
			Controls.Add(customerNameTextBox);
			Controls.Add(profilePicture);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label5);
			Controls.Add(label7);
			Controls.Add(label1);
			Controls.Add(label);
			Margin = new Padding(4, 5, 4, 5);
			Name = "UpdateCustomerCard";
			Size = new Size(1000, 553);
			((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox profilePicture;
		private Label label3;
		private Label label2;
		private Label label5;
		private Label label7;
		private Label label1;
		private Label label;
		private TextBox customerNameTextBox;
		private TextBox customerAdressTextBox;
		private TextBox customerTlfTextBox;
		private TextBox customerEmailTextBox;
		private Button DoneButton;
		private Button AddPetButton;
		private Button PrevButton;
		private Button NextButton;
		private FlowLayoutPanel PetPanal;
	}
}
