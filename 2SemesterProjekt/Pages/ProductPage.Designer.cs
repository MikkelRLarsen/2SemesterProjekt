namespace _2SemesterProjekt.Pages
{
    partial class ProductPage
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
            pageNameLabel = new Label();
            productFlowPanel = new FlowLayoutPanel();
            buttonFlowPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // pageNameLabel
            // 
            pageNameLabel.AutoSize = true;
            pageNameLabel.Font = new Font("Gadugi", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pageNameLabel.Location = new Point(435, 44);
            pageNameLabel.Name = "pageNameLabel";
            pageNameLabel.Size = new Size(336, 77);
            pageNameLabel.TabIndex = 2;
            pageNameLabel.Text = "Produkter";
            // 
            // productFlowPanel
            // 
            productFlowPanel.BackColor = SystemColors.ControlLightLight;
            productFlowPanel.BorderStyle = BorderStyle.FixedSingle;
            productFlowPanel.FlowDirection = FlowDirection.TopDown;
            productFlowPanel.Location = new Point(250, 150);
            productFlowPanel.Name = "productFlowPanel";
            productFlowPanel.Size = new Size(709, 580);
            productFlowPanel.TabIndex = 3;
            // 
            // buttonFlowPanel
            // 
            buttonFlowPanel.Location = new Point(976, 429);
            buttonFlowPanel.Name = "buttonFlowPanel";
            buttonFlowPanel.Size = new Size(209, 301);
            buttonFlowPanel.TabIndex = 4;
            // 
            // ProductPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonFlowPanel);
            Controls.Add(productFlowPanel);
            Controls.Add(pageNameLabel);
            Name = "ProductPage";
            Size = new Size(1200, 825);
            Load += this.ProductPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pageNameLabel;
        private FlowLayoutPanel productFlowPanel;
        private FlowLayoutPanel buttonFlowPanel;
    }
}
