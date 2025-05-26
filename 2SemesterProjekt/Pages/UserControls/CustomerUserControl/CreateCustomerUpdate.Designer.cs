namespace _2SemesterProjekt.Pages.UserControls.CustomerUserControl
{
    partial class CreateCustomerUpdate
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
            label6 = new Label();
            label7 = new Label();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxFirstName = new TextBox();
            submitButton = new PictureBox();
            cancelButton = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            label8 = new Label();
            pictureBox7 = new PictureBox();
            label9 = new Label();
            textBoxLastName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxAddress = new TextBox();
            textBoxPhoneNumber = new TextBox();
            comboBoxType = new ComboBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)submitButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cancelButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.AntiqueWhite;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SaddleBrown;
            label6.Location = new Point(809, 863);
            label6.Name = "label6";
            label6.Size = new Size(288, 31);
            label6.TabIndex = 32;
            label6.Text = "T E L E F O N N U M M E R";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.AntiqueWhite;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SaddleBrown;
            label7.Location = new Point(809, 961);
            label7.Name = "label7";
            label7.Size = new Size(194, 31);
            label7.TabIndex = 33;
            label7.Text = "K U N D E T Y P E";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Linen;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(705, 569);
            label1.Name = "label1";
            label1.Size = new Size(190, 20);
            label1.TabIndex = 51;
            label1.Text = "T E L E F O N N U M M E R";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Linen;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.SaddleBrown;
            label5.Location = new Point(757, 469);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 50;
            label5.Text = "A D R E S S E";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Linen;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(728, 369);
            label4.Name = "label4";
            label4.Size = new Size(163, 20);
            label4.TabIndex = 49;
            label4.Text = "E M A I L A D R E S S E";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Linen;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(744, 269);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 48;
            label3.Text = "E F T E R N A V N";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Linen;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(753, 169);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 44;
            label2.Text = "F O R N A V N";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFirstName.Location = new Point(663, 195);
            textBoxFirstName.Margin = new Padding(3, 4, 3, 4);
            textBoxFirstName.MaxLength = 0;
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(274, 27);
            textBoxFirstName.TabIndex = 43;
            textBoxFirstName.KeyPress += textBoxFirstName_KeyPress;
            // 
            // submitButton
            // 
            submitButton.BackgroundImage = Properties.Resources.SaveButton;
            submitButton.BackgroundImageLayout = ImageLayout.Stretch;
            submitButton.Image = Properties.Resources.SaveButtonGreyedOut;
            submitButton.Location = new Point(945, 759);
            submitButton.Margin = new Padding(3, 4, 3, 4);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(240, 55);
            submitButton.SizeMode = PictureBoxSizeMode.StretchImage;
            submitButton.TabIndex = 41;
            submitButton.TabStop = false;
            submitButton.Click += submitButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackgroundImage = Properties.Resources.CancelButton;
            cancelButton.BackgroundImageLayout = ImageLayout.Stretch;
            cancelButton.Location = new Point(416, 759);
            cancelButton.Margin = new Padding(3, 4, 3, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(240, 55);
            cancelButton.TabIndex = 40;
            cancelButton.TabStop = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Linen;
            pictureBox3.Location = new Point(416, 149);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(769, 88);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 47;
            pictureBox3.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Linen;
            pictureBox9.Location = new Point(416, 249);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(769, 88);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 52;
            pictureBox9.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Linen;
            pictureBox4.Location = new Point(416, 349);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(769, 88);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 53;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Linen;
            pictureBox5.Location = new Point(416, 449);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(769, 88);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 54;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Linen;
            pictureBox6.Location = new Point(416, 549);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(769, 88);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 55;
            pictureBox6.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Linen;
            label8.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SaddleBrown;
            label8.Location = new Point(584, 36);
            label8.Name = "label8";
            label8.Size = new Size(467, 50);
            label8.TabIndex = 56;
            label8.Text = "O P R E T   N Y   K U N D E";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Linen;
            pictureBox7.Location = new Point(416, 649);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(769, 88);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 57;
            pictureBox7.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Linen;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.SaddleBrown;
            label9.Location = new Point(744, 664);
            label9.Name = "label9";
            label9.Size = new Size(128, 20);
            label9.TabIndex = 58;
            label9.Text = "K U N D E T Y P E";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLastName.Location = new Point(663, 293);
            textBoxLastName.Margin = new Padding(3, 4, 3, 4);
            textBoxLastName.MaxLength = 0;
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(274, 27);
            textBoxLastName.TabIndex = 59;
            textBoxLastName.KeyPress += textBoxLastName_KeyPress;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.Location = new Point(663, 393);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.MaxLength = 0;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(274, 27);
            textBoxEmail.TabIndex = 60;
            textBoxEmail.KeyPress += textBoxEmail_KeyPress;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAddress.Location = new Point(663, 493);
            textBoxAddress.Margin = new Padding(3, 4, 3, 4);
            textBoxAddress.MaxLength = 0;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(274, 27);
            textBoxAddress.TabIndex = 61;
            textBoxAddress.KeyPress += textBoxAddress_KeyPress;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPhoneNumber.Location = new Point(663, 593);
            textBoxPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            textBoxPhoneNumber.MaxLength = 8;
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(274, 27);
            textBoxPhoneNumber.TabIndex = 62;
            textBoxPhoneNumber.TextChanged += textBoxPhoneNumber_TextChanged;
            textBoxPhoneNumber.KeyPress += textBoxPhoneNumber_KeyPress;
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(663, 688);
            comboBoxType.Margin = new Padding(3, 4, 3, 4);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(274, 28);
            comboBoxType.TabIndex = 64;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PageTitelBackground;
            pictureBox1.Location = new Point(101, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1399, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 65;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.PageBackground;
            pictureBox2.Location = new Point(101, 122);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1399, 705);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 66;
            pictureBox2.TabStop = false;
            // 
            // CreateCustomerUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBoxType);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxLastName);
            Controls.Add(label9);
            Controls.Add(pictureBox7);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxFirstName);
            Controls.Add(submitButton);
            Controls.Add(cancelButton);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Margin = new Padding(0);
            Name = "CreateCustomerUpdate";
            Size = new Size(1600, 845);
            ((System.ComponentModel.ISupportInitialize)submitButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)cancelButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label7;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxFirstName;
        private PictureBox submitButton;
        private PictureBox cancelButton;
        private PictureBox pictureBox3;
        private PictureBox pictureBox9;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label8;
        private PictureBox pictureBox7;
        private Label label9;
        private TextBox textBoxLastName;
        private TextBox textBoxEmail;
        private TextBox textBoxAddress;
        private TextBox textBoxPhoneNumber;
        private ComboBox comboBoxType;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
