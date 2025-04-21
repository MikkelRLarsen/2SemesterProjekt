namespace _2SemesterProjekt.Pages.User_Controls.UpdateCustomerCardUserControls
{
	partial class AddPetToCustomerCard
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
			label5 = new Label();
			SpeciesLabel = new Label();
			petNameTextBox = new TextBox();
			petSpeciesTextBox = new TextBox();
			SuspendLayout();
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.Location = new Point(48, 21);
			label5.Name = "label5";
			label5.Size = new Size(50, 19);
			label5.TabIndex = 18;
			label5.Text = "Navn:";
			// 
			// SpeciesLabel
			// 
			SpeciesLabel.AutoSize = true;
			SpeciesLabel.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			SpeciesLabel.Location = new Point(48, 60);
			SpeciesLabel.Name = "SpeciesLabel";
			SpeciesLabel.Size = new Size(64, 19);
			SpeciesLabel.TabIndex = 19;
			SpeciesLabel.Text = "Species:";
			// 
			// petNameTextBox
			// 
			petNameTextBox.Location = new Point(118, 21);
			petNameTextBox.Name = "petNameTextBox";
			petNameTextBox.Size = new Size(202, 23);
			petNameTextBox.TabIndex = 20;
			// 
			// petSpeciesTextBox
			// 
			petSpeciesTextBox.Location = new Point(137, 56);
			petSpeciesTextBox.Name = "petSpeciesTextBox";
			petSpeciesTextBox.Size = new Size(181, 23);
			petSpeciesTextBox.TabIndex = 21;
			// 
			// AddPetToCustomerCard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ButtonFace;
			Controls.Add(petSpeciesTextBox);
			Controls.Add(petNameTextBox);
			Controls.Add(SpeciesLabel);
			Controls.Add(label5);
			Margin = new Padding(0);
			Name = "AddPetToCustomerCard";
			Size = new Size(350, 120);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label5;
		private Label SpeciesLabel;
		private TextBox petNameTextBox;
		private TextBox petSpeciesTextBox;
	}
}
