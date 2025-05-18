namespace _2SemesterProjekt.Pages.UserControls.ProductUserControl
{
    partial class AmountDialogBox
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            amountUpDown = new NumericUpDown();
            addAmountButton = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)amountUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addAmountButton).BeginInit();
            SuspendLayout();
            // 
            // amountUpDown
            // 
            amountUpDown.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountUpDown.Location = new Point(324, 27);
            amountUpDown.Name = "amountUpDown";
            amountUpDown.ReadOnly = true;
            amountUpDown.Size = new Size(150, 43);
            amountUpDown.TabIndex = 0;
            // 
            // addAmountButton
            // 
            addAmountButton.Image = Properties.Resources.AddButton;
            addAmountButton.Location = new Point(354, 86);
            addAmountButton.Name = "addAmountButton";
            addAmountButton.Size = new Size(120, 35);
            addAmountButton.TabIndex = 1;
            addAmountButton.TabStop = false;
            addAmountButton.Click += addAmountButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Linen;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(22, 34);
            label1.Name = "label1";
            label1.Size = new Size(265, 31);
            label1.TabIndex = 46;
            label1.Text = "A N G I V   M Æ N G D E";
            // 
            // AmountDialogBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(486, 133);
            Controls.Add(label1);
            Controls.Add(addAmountButton);
            Controls.Add(amountUpDown);
            Name = "AmountDialogBox";
            Text = "AmountDialogBox";
            ((System.ComponentModel.ISupportInitialize)amountUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)addAmountButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown amountUpDown;
        private PictureBox addAmountButton;
        private Label label1;
    }
}