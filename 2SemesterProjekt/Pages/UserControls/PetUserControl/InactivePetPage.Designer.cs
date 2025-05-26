namespace _2SemesterProjekt.Pages.UserControls.PetUserControl
{
    partial class InactivePetPage
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
            findAllButton = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)findAllButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            flowPanel.TabIndex = 60;
            // 
            // findAllButton
            // 
            findAllButton.Image = Properties.Resources.FindAllButton;
            findAllButton.Location = new Point(751, 194);
            findAllButton.Name = "findAllButton";
            findAllButton.Size = new Size(99, 21);
            findAllButton.SizeMode = PictureBoxSizeMode.StretchImage;
            findAllButton.TabIndex = 59;
            findAllButton.TabStop = false;
            findAllButton.Click += findAllButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(515, 166);
            label1.Name = "label1";
            label1.Size = new Size(570, 20);
            label1.TabIndex = 58;
            label1.Text = "T R Y K   F I N D   A L L E   F O R   A T   S E   A L L E   I N A K T I V E   K Æ L E D Y R";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Linen;
            pictureBox3.Image = Properties.Resources.PageBox;
            pictureBox3.Location = new Point(416, 146);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(769, 88);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 57;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PageTitelBackground;
            pictureBox1.Location = new Point(101, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1399, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.PageBackground;
            pictureBox4.Location = new Point(101, 122);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1399, 705);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 61;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Linen;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(544, 35);
            label2.Name = "label2";
            label2.Size = new Size(523, 50);
            label2.TabIndex = 62;
            label2.Text = "I N A K T I V E   K Æ L E D Y R";
            // 
            // InactivePetPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(flowPanel);
            Controls.Add(findAllButton);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Name = "InactivePetPage";
            Size = new Size(1600, 845);
            ((System.ComponentModel.ISupportInitialize)findAllButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowPanel;
        private PictureBox findAllButton;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private Label label2;
    }
}
