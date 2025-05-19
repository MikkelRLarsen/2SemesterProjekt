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
            submitButton = new PictureBox();
            cancelButton = new PictureBox();
            textBoxPhoneNumber = new TextBox();
            textBoxEmail = new TextBox();
            textBoxAddress = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBoxLastName = new TextBox();
            label3 = new Label();
            textBoxFirstName = new TextBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)submitButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cancelButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Linen;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(690, 81);
            label2.Name = "label2";
            label2.Size = new Size(729, 65);
            label2.TabIndex = 22;
            label2.Text = "O P R E T   N Y T   K Æ L E D Y R";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PageTitelBackground;
            pictureBox1.Location = new Point(74, 58);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(2040, 108);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // submitButton
            // 
            submitButton.Enabled = false;
            submitButton.Image = Properties.Resources.CreateButtonGreyedOut;
            submitButton.Location = new Point(1480, 1066);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(350, 69);
            submitButton.TabIndex = 30;
            submitButton.TabStop = false;
            submitButton.Click += submitButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Image = Properties.Resources.CancelButton;
            cancelButton.Location = new Point(358, 1066);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(350, 69);
            cancelButton.TabIndex = 29;
            cancelButton.TabStop = false;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPhoneNumber.Location = new Point(1171, 642);
            textBoxPhoneNumber.MaxLength = 8;
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(311, 35);
            textBoxPhoneNumber.TabIndex = 48;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.Location = new Point(1169, 568);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(311, 35);
            textBoxEmail.TabIndex = 47;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAddress.Location = new Point(1171, 495);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(311, 35);
            textBoxAddress.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.AntiqueWhite;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SaddleBrown;
            label6.Location = new Point(708, 647);
            label6.Name = "label6";
            label6.Size = new Size(239, 25);
            label6.TabIndex = 43;
            label6.Text = "T E L E F O N N U M M E R";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.AntiqueWhite;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SaddleBrown;
            label5.Location = new Point(708, 574);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 42;
            label5.Text = "E M A I L";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.AntiqueWhite;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(708, 500);
            label4.Name = "label4";
            label4.Size = new Size(123, 25);
            label4.TabIndex = 41;
            label4.Text = "A D R E S S E";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLastName.Location = new Point(1169, 422);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(311, 35);
            textBoxLastName.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AntiqueWhite;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(708, 427);
            label3.Name = "label3";
            label3.Size = new Size(161, 25);
            label3.TabIndex = 40;
            label3.Text = "E F T E R N A V N";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFirstName.Location = new Point(1169, 348);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(311, 35);
            textBoxFirstName.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(708, 353);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 39;
            label1.Text = "F O R N A V N";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Linen;
            pictureBox3.Image = Properties.Resources.PageCreateBox;
            pictureBox3.Location = new Point(533, 208);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1122, 785);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.PageBackground;
            pictureBox2.Location = new Point(74, 182);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(2040, 837);
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // CreatePetPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
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
            Size = new Size(2188, 1185);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)submitButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)cancelButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox submitButton;
        private PictureBox cancelButton;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxEmail;
        private TextBox textBoxAddress;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBoxLastName;
        private Label label3;
        private TextBox textBoxFirstName;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}
