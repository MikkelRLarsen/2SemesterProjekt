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
            label.Location = new Point(189, 28);
            label.Margin = new Padding(4, 0, 4, 0);
            label.Name = "label";
            label.Size = new Size(42, 27);
            label.TabIndex = 2;
            label.Text = "ID:";
            // 
            // labelPetID
            // 
            labelPetID.AutoSize = true;
            labelPetID.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPetID.Location = new Point(269, 28);
            labelPetID.Margin = new Padding(4, 0, 4, 0);
            labelPetID.Name = "labelPetID";
            labelPetID.Size = new Size(40, 27);
            labelPetID.TabIndex = 3;
            labelPetID.Text = "##";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(189, 78);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 27);
            label5.TabIndex = 4;
            label5.Text = "Navn:";
            // 
            // labelPetName
            // 
            labelPetName.AutoSize = true;
            labelPetName.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPetName.Location = new Point(269, 78);
            labelPetName.Margin = new Padding(4, 0, 4, 0);
            labelPetName.Name = "labelPetName";
            labelPetName.Size = new Size(110, 27);
            labelPetName.TabIndex = 5;
            labelPetName.Text = "PetName";
            labelPetName.UseMnemonic = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(542, 78);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 27);
            label1.TabIndex = 6;
            label1.Text = "Fødselsdato:";
            // 
            // labelPetBirth
            // 
            labelPetBirth.AutoSize = true;
            labelPetBirth.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPetBirth.Location = new Point(740, 78);
            labelPetBirth.Margin = new Padding(4, 0, 4, 0);
            labelPetBirth.Name = "labelPetBirth";
            labelPetBirth.Size = new Size(101, 27);
            labelPetBirth.TabIndex = 7;
            labelPetBirth.Text = "PetBirth";
            labelPetBirth.UseMnemonic = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(542, 128);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(52, 27);
            label3.TabIndex = 9;
            label3.Text = "Art:";
            // 
            // labelPetSpecies
            // 
            labelPetSpecies.AutoSize = true;
            labelPetSpecies.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPetSpecies.Location = new Point(740, 128);
            labelPetSpecies.Margin = new Padding(4, 0, 4, 0);
            labelPetSpecies.Name = "labelPetSpecies";
            labelPetSpecies.Size = new Size(118, 27);
            labelPetSpecies.TabIndex = 10;
            labelPetSpecies.Text = "Hund/Kat";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(189, 128);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(58, 27);
            label7.TabIndex = 11;
            label7.Text = "Ejer:";
            // 
            // labelPetOwner
            // 
            labelPetOwner.AutoSize = true;
            labelPetOwner.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPetOwner.Location = new Point(269, 128);
            labelPetOwner.Margin = new Padding(4, 0, 4, 0);
            labelPetOwner.Name = "labelPetOwner";
            labelPetOwner.Size = new Size(117, 27);
            labelPetOwner.TabIndex = 12;
            labelPetOwner.Text = "PetOwner";
            labelPetOwner.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(542, 28);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(190, 27);
            label2.TabIndex = 13;
            label2.Text = "Primær dyrlæge:";
            // 
            // labelPrimaryVet
            // 
            labelPrimaryVet.AutoSize = true;
            labelPrimaryVet.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrimaryVet.Location = new Point(740, 28);
            labelPrimaryVet.Margin = new Padding(4, 0, 4, 0);
            labelPrimaryVet.Name = "labelPrimaryVet";
            labelPrimaryVet.Size = new Size(132, 27);
            labelPrimaryVet.TabIndex = 14;
            labelPrimaryVet.Text = "PrimaryVet";
            labelPrimaryVet.UseMnemonic = false;
            // 
            // profilePicture
            // 
            profilePicture.Anchor = AnchorStyles.Left;
            profilePicture.Image = Properties.Resources.member;
            profilePicture.Location = new Point(7, 8);
            profilePicture.Margin = new Padding(4, 5, 4, 5);
            profilePicture.Name = "profilePicture";
            profilePicture.Size = new Size(143, 167);
            profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePicture.TabIndex = 15;
            profilePicture.TabStop = false;
            // 
            // PetCard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "PetCard";
            Size = new Size(1000, 183);
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
