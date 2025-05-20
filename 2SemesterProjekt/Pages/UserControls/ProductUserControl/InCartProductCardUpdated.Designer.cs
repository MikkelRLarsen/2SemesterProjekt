namespace _2SemesterProjekt.Pages.UserControls.ProductUserControl
{
    partial class InCartProductCardUpdated
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
            amountLabel = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.BackColor = Color.Linen;
            amountLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amountLabel.ForeColor = Color.SaddleBrown;
            amountLabel.Location = new Point(12, 37);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(36, 41);
            amountLabel.TabIndex = 69;
            amountLabel.Text = "#";
            // 
            // panel1
            // 
            panel1.Location = new Point(60, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 114);
            panel1.TabIndex = 70;
            // 
            // InCartProductCardUpdated
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(amountLabel);
            Name = "InCartProductCardUpdated";
            Size = new Size(720, 114);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label amountLabel;
        private Panel panel1;
    }
}
