namespace _2SemesterProjekt.Pages.UserControls.PetUserControl
{
    partial class PetCard
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
            label = new Label();
            labelPetID = new Label();
            label5 = new Label();
            labelPetName = new Label();
            label1 = new Label();
            labelPetBirth = new Label();
            label3 = new Label();
            labelPetSpecies = new Label();
            label7 = new Label();
            labelPetOwner = new Label();
            label2 = new Label();
            labelPrimaryVet = new Label();
            profilePicture = new PictureBox();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.AntiqueWhite;
            label.Font = new Font("Gadugi", 7.8F, FontStyle.Bold);
            label.ForeColor = Color.SaddleBrown;
            label.Location = new Point(118, 15);
            label.Name = "label";
            label.Size = new Size(26, 17);
            label.TabIndex = 2;
            label.Text = "ID:";
            // 
            // labelPetID
            // 
            labelPetID.AutoSize = true;
            labelPetID.BackColor = Color.AntiqueWhite;
            labelPetID.Font = new Font("Gadugi", 7.8F, FontStyle.Bold);
            labelPetID.ForeColor = Color.SaddleBrown;
            labelPetID.Location = new Point(172, 15);
            labelPetID.Name = "labelPetID";
            labelPetID.Size = new Size(24, 17);
            labelPetID.TabIndex = 3;
            labelPetID.Text = "##";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.AntiqueWhite;
            label5.Font = new Font("Gadugi", 7.8F, FontStyle.Bold);
            label5.ForeColor = Color.SaddleBrown;
            label5.Location = new Point(118, 49);
            label5.Name = "label5";
            label5.Size = new Size(44, 17);
            label5.TabIndex = 4;
            label5.Text = "Navn:";
            // 
            // labelPetName
            // 
            labelPetName.AutoSize = true;
            labelPetName.BackColor = Color.AntiqueWhite;
            labelPetName.Font = new Font("Gadugi", 7.8F, FontStyle.Bold);
            labelPetName.ForeColor = Color.SaddleBrown;
            labelPetName.Location = new Point(170, 49);
            labelPetName.Name = "labelPetName";
            labelPetName.Size = new Size(64, 17);
            labelPetName.TabIndex = 5;
            labelPetName.Text = "PetName";
            labelPetName.UseMnemonic = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.Font = new Font("Gadugi", 7.8F, FontStyle.Bold);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(365, 49);
            label1.Name = "label1";
            label1.Size = new Size(86, 17);
            label1.TabIndex = 6;
            label1.Text = "Fødselsdato:";
            // 
            // labelPetBirth
            // 
            labelPetBirth.AutoSize = true;
            labelPetBirth.BackColor = Color.AntiqueWhite;
            labelPetBirth.Font = new Font("Gadugi", 7.8F, FontStyle.Bold);
            labelPetBirth.ForeColor = Color.SaddleBrown;
            labelPetBirth.Location = new Point(524, 49);
            labelPetBirth.Name = "labelPetBirth";
            labelPetBirth.Size = new Size(58, 17);
            labelPetBirth.TabIndex = 7;
            labelPetBirth.Text = "PetBirth";
            labelPetBirth.UseMnemonic = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AntiqueWhite;
            label3.Font = new Font("Gadugi", 7.8F, FontStyle.Bold);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(365, 79);
            label3.Name = "label3";
            label3.Size = new Size(31, 17);
            label3.TabIndex = 9;
            label3.Text = "Art:";
            // 
            // labelPetSpecies
            // 
            labelPetSpecies.AutoSize = true;
            labelPetSpecies.BackColor = Color.AntiqueWhite;
            labelPetSpecies.Font = new Font("Gadugi", 7.8F, FontStyle.Bold);
            labelPetSpecies.ForeColor = Color.SaddleBrown;
            labelPetSpecies.Location = new Point(524, 79);
            labelPetSpecies.Name = "labelPetSpecies";
            labelPetSpecies.Size = new Size(68, 17);
            labelPetSpecies.TabIndex = 10;
            labelPetSpecies.Text = "Hund/Kat";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.AntiqueWhite;
            label7.Font = new Font("Gadugi", 7.8F, FontStyle.Bold);
            label7.ForeColor = Color.SaddleBrown;
            label7.Location = new Point(118, 79);
            label7.Name = "label7";
            label7.Size = new Size(35, 17);
            label7.TabIndex = 11;
            label7.Text = "Ejer:";
            // 
            // labelPetOwner
            // 
            labelPetOwner.AutoSize = true;
            labelPetOwner.BackColor = Color.AntiqueWhite;
            labelPetOwner.Font = new Font("Gadugi", 7.8F, FontStyle.Bold);
            labelPetOwner.ForeColor = Color.SaddleBrown;
            labelPetOwner.Location = new Point(172, 79);
            labelPetOwner.Name = "labelPetOwner";
            labelPetOwner.Size = new Size(68, 17);
            labelPetOwner.TabIndex = 12;
            labelPetOwner.Text = "PetOwner";
            labelPetOwner.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AntiqueWhite;
            label2.Font = new Font("Gadugi", 7.8F, FontStyle.Bold);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(365, 15);
            label2.Name = "label2";
            label2.Size = new Size(111, 17);
            label2.TabIndex = 13;
            label2.Text = "Primær dyrlæge:";
            // 
            // labelPrimaryVet
            // 
            labelPrimaryVet.AutoSize = true;
            labelPrimaryVet.BackColor = Color.AntiqueWhite;
            labelPrimaryVet.Font = new Font("Gadugi", 7.8F, FontStyle.Bold);
            labelPrimaryVet.ForeColor = Color.SaddleBrown;
            labelPrimaryVet.Location = new Point(524, 15);
            labelPrimaryVet.Name = "labelPrimaryVet";
            labelPrimaryVet.Size = new Size(77, 17);
            labelPrimaryVet.TabIndex = 14;
            labelPrimaryVet.Text = "PrimaryVet";
            labelPrimaryVet.UseMnemonic = false;
            // 
            // profilePicture
            // 
            profilePicture.Anchor = AnchorStyles.Left;
            profilePicture.BackColor = Color.AntiqueWhite;
            profilePicture.Image = Properties.Resources.Marsvin;
            profilePicture.Location = new Point(15, 15);
            profilePicture.Margin = new Padding(3, 4, 3, 4);
            profilePicture.Name = "profilePicture";
            profilePicture.Size = new Size(81, 81);
            profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePicture.TabIndex = 15;
            profilePicture.TabStop = false;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = SystemColors.Control;
            pictureBox.Image = Properties.Resources.CardExamination;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(655, 110);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 41;
            pictureBox.TabStop = false;
            // 
            // PetCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(profilePicture);
            Controls.Add(labelPrimaryVet);
            Controls.Add(label2);
            Controls.Add(labelPetOwner);
            Controls.Add(label7);
            Controls.Add(labelPetSpecies);
            Controls.Add(label3);
            Controls.Add(labelPetBirth);
            Controls.Add(label1);
            Controls.Add(labelPetName);
            Controls.Add(label5);
            Controls.Add(labelPetID);
            Controls.Add(label);
            Controls.Add(pictureBox);
            Margin = new Padding(50, 10, 10, 10);
            Name = "PetCard";
            Size = new Size(655, 110);
            ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Label labelPetID;
        private Label label5;
        private Label labelPetName;
        private Label label1;
        private Label labelPetBirth;
        private Label label3;
        private Label labelPetSpecies;
        private Label label7;
        private Label labelPetOwner;
        private Label label2;
        private Label labelPrimaryVet;
        private PictureBox profilePicture;
        private PictureBox pictureBox;
    }
}
