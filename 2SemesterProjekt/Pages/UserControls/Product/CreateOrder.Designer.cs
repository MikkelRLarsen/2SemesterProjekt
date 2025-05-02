namespace _2SemesterProjekt.Pages.UserControls.Product
{
    partial class CreateOrder
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label7 = new Label();
            listBox2 = new ListBox();
            button1 = new Button();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(154, 35);
            label1.Name = "label1";
            label1.Size = new Size(399, 77);
            label1.TabIndex = 6;
            label1.Text = "Opret Ordre";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(114, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 23);
            textBox1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 148);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 8;
            label2.Text = "Kundes tlf. nr.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 180);
            label3.Name = "label3";
            label3.Size = new Size(228, 15);
            label3.TabIndex = 9;
            label3.Text = "customerFirstName + customerLastName";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 195);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 10;
            label4.Text = "customerAddress";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(114, 210);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 11;
            label5.Text = "customerEmail";
            label5.Visible = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(114, 259);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(210, 139);
            listBox1.TabIndex = 12;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(114, 404);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(210, 23);
            numericUpDown1.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(52, 406);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 15;
            label6.Text = "Rabat i %";
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(244, 145);
            button2.Name = "button2";
            button2.Size = new Size(80, 23);
            button2.TabIndex = 16;
            button2.Text = "Find kunde";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGray;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(383, 470);
            button3.Name = "button3";
            button3.Size = new Size(170, 58);
            button3.TabIndex = 17;
            button3.Text = "Opret ordre";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(154, 470);
            button4.Name = "button4";
            button4.Size = new Size(170, 58);
            button4.TabIndex = 18;
            button4.Text = "Annuller";
            button4.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(114, 241);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 19;
            label7.Text = "Ordreliste";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(383, 184);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(210, 244);
            listBox2.TabIndex = 20;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(599, 405);
            button1.Name = "button1";
            button1.Size = new Size(86, 23);
            button1.TabIndex = 21;
            button1.Text = "Tilføj til ordre";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(383, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(210, 23);
            textBox2.TabIndex = 22;
            // 
            // CreateOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(numericUpDown1);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "CreateOrder";
            Size = new Size(709, 580);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox listBox1;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label7;
        private ListBox listBox2;
        private Button button1;
        private TextBox textBox2;
    }
}
