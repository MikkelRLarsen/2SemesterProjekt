namespace _2SemesterProjekt.Pages.UserControls.ProductUserControl
{
    partial class InCartProductCard
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
            cardPanel = new Panel();
            quantityLabel = new Label();
            SuspendLayout();
            // 
            // cardPanel
            // 
            cardPanel.Location = new Point(0, 0);
            cardPanel.Name = "cardPanel";
            cardPanel.Size = new Size(660, 150);
            cardPanel.TabIndex = 70;
            // 
            // amountLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.BackColor = Color.Linen;
            quantityLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantityLabel.ForeColor = Color.SaddleBrown;
            quantityLabel.Location = new Point(672, 55);
            quantityLabel.Name = "amountLabel";
            quantityLabel.Size = new Size(36, 41);
            quantityLabel.TabIndex = 70;
            quantityLabel.Text = "#";
            // 
            // InCartProductCardUpdated
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(quantityLabel);
            Controls.Add(cardPanel);
            Margin = new Padding(30, 5, 5, 5);
            Name = "InCartProductCardUpdated";
            Size = new Size(720, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel cardPanel;
        private Label quantityLabel;
    }
}
