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
            ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(132, 17);
            label.Name = "label";
            label.Size = new Size(29, 19);
            label.TabIndex = 2;
            label.Text = "ID:";
            // 
            // labelPetID
            // 
            labelPetID.AutoSize = true;
            labelPetID.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPetID.Location = new Point(188, 17);
            labelPetID.Name = "labelPetID";
            labelPetID.Size = new Size(27, 19);
            labelPetID.TabIndex = 3;
            labelPetID.Text = "##";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(132, 47);
            label5.Name = "label5";
            label5.Size = new Size(50, 19);
            label5.TabIndex = 4;
            label5.Text = "Navn:";
            // 
            // labelPetName
            // 
            labelPetName.AutoSize = true;
            labelPetName.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPetName.Location = new Point(188, 47);
            labelPetName.Name = "labelPetName";
            labelPetName.Size = new Size(74, 19);
            labelPetName.TabIndex = 5;
            labelPetName.Text = "PetName";
            labelPetName.UseMnemonic = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(379, 47);
            label1.Name = "label1";
            label1.Size = new Size(97, 19);
            label1.TabIndex = 6;
            label1.Text = "Fødselsdato:";
            // 
            // labelPetBirth
            // 
            labelPetBirth.AutoSize = true;
            labelPetBirth.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPetBirth.Location = new Point(518, 47);
            labelPetBirth.Name = "labelPetBirth";
            labelPetBirth.Size = new Size(67, 19);
            labelPetBirth.TabIndex = 7;
            labelPetBirth.Text = "PetBirth";
            labelPetBirth.UseMnemonic = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(379, 77);
            label3.Name = "label3";
            label3.Size = new Size(36, 19);
            label3.TabIndex = 9;
            label3.Text = "Art:";
            // 
            // labelPetSpecies
            // 
            labelPetSpecies.AutoSize = true;
            labelPetSpecies.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPetSpecies.Location = new Point(518, 77);
            labelPetSpecies.Name = "labelPetSpecies";
            labelPetSpecies.Size = new Size(78, 19);
            labelPetSpecies.TabIndex = 10;
            labelPetSpecies.Text = "Hund/Kat";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(132, 77);
            label7.Name = "label7";
            label7.Size = new Size(39, 19);
            label7.TabIndex = 11;
            label7.Text = "Ejer:";
            // 
            // labelPetOwner
            // 
            labelPetOwner.AutoSize = true;
            labelPetOwner.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPetOwner.Location = new Point(188, 77);
            labelPetOwner.Name = "labelPetOwner";
            labelPetOwner.Size = new Size(78, 19);
            labelPetOwner.TabIndex = 12;
            labelPetOwner.Text = "PetOwner";
            labelPetOwner.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(379, 17);
            label2.Name = "label2";
            label2.Size = new Size(124, 19);
            label2.TabIndex = 13;
            label2.Text = "Primær dyrlæge:";
            // 
            // labelPrimaryVet
            // 
            labelPrimaryVet.AutoSize = true;
            labelPrimaryVet.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrimaryVet.Location = new Point(518, 17);
            labelPrimaryVet.Name = "labelPrimaryVet";
            labelPrimaryVet.Size = new Size(88, 19);
            labelPrimaryVet.TabIndex = 14;
            labelPrimaryVet.Text = "PrimaryVet";
            labelPrimaryVet.UseMnemonic = false;
            // 
            // profilePicture
            // 
            profilePicture.Anchor = AnchorStyles.Left;
            profilePicture.Image = Properties.Resources.member;
            profilePicture.Location = new Point(5, 5);
            profilePicture.Name = "profilePicture";
            profilePicture.Size = new Size(100, 100);
            profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePicture.TabIndex = 15;
            profilePicture.TabStop = false;
            // 
            // PetCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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
            Name = "PetCard";
            Size = new Size(680, 110);
            Click += PetCard_Click;
            ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
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
    }
}
