namespace _2SemesterProjekt.Pages
{
    partial class Page
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
            NavPanel = new Panel();
            MainPanel = new Panel();
            ExaminationNav = new UserControls.NavigationButtons.NavigationButton();
            MedicinNavn = new UserControls.NavigationButtons.NavigationButton();
            panel2 = new Panel();
            exitButton = new Button();
            SalesNav = new UserControls.NavigationButtons.NavigationButton();
            CustomerNav = new UserControls.NavigationButtons.NavigationButton();
            AdministrationNav = new UserControls.NavigationButtons.NavigationButton();
            panel3 = new Panel();
            PetNav = new UserControls.NavigationButtons.NavigationButton();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // NavPanel
            // 
            NavPanel.BackColor = Color.Moccasin;
            NavPanel.Location = new Point(1236, 0);
            NavPanel.Margin = new Padding(0);
            NavPanel.Name = "NavPanel";
            NavPanel.Size = new Size(364, 35);
            NavPanel.TabIndex = 0;
            // 
            // MainPanel
            // 
            MainPanel.Location = new Point(0, 35);
            MainPanel.Margin = new Padding(0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1600, 845);
            MainPanel.TabIndex = 2;
            // 
            // ExaminationNav
            // 
            ExaminationNav.BackColor = Color.Moccasin;
            ExaminationNav.Location = new Point(36, 0);
            ExaminationNav.Margin = new Padding(0);
            ExaminationNav.Name = "ExaminationNav";
            ExaminationNav.Size = new Size(200, 35);
            ExaminationNav.TabIndex = 3;
            // 
            // MedicinNavn
            // 
            MedicinNavn.BackColor = Color.Moccasin;
            MedicinNavn.Location = new Point(236, 0);
            MedicinNavn.Margin = new Padding(0);
            MedicinNavn.Name = "MedicinNavn";
            MedicinNavn.Size = new Size(200, 35);
            MedicinNavn.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Moccasin;
            panel2.Controls.Add(exitButton);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(37, 35);
            panel2.TabIndex = 5;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.IndianRed;
            exitButton.BackgroundImageLayout = ImageLayout.Center;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Location = new Point(3, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(30, 30);
            exitButton.TabIndex = 0;
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // SalesNav
            // 
            SalesNav.BackColor = Color.Moccasin;
            SalesNav.Location = new Point(436, 0);
            SalesNav.Margin = new Padding(0);
            SalesNav.Name = "SalesNav";
            SalesNav.Size = new Size(200, 35);
            SalesNav.TabIndex = 6;
            // 
            // CustomerNav
            // 
            CustomerNav.BackColor = Color.Moccasin;
            CustomerNav.Location = new Point(636, 0);
            CustomerNav.Margin = new Padding(0);
            CustomerNav.Name = "CustomerNav";
            CustomerNav.Size = new Size(200, 35);
            CustomerNav.TabIndex = 7;
            // 
            // AdministrationNav
            // 
            AdministrationNav.BackColor = Color.Moccasin;
            AdministrationNav.Location = new Point(1036, 0);
            AdministrationNav.Margin = new Padding(0);
            AdministrationNav.Name = "AdministrationNav";
            AdministrationNav.Size = new Size(200, 35);
            AdministrationNav.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(2200, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(299, 69);
            panel3.TabIndex = 6;
            // 
            // PetNav
            // 
            PetNav.BackColor = Color.Moccasin;
            PetNav.Location = new Point(836, 0);
            PetNav.Margin = new Padding(0);
            PetNav.Name = "PetNav";
            PetNav.Size = new Size(200, 35);
            PetNav.TabIndex = 8;
            // 
            // Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 880);
            Controls.Add(PetNav);
            Controls.Add(panel3);
            Controls.Add(AdministrationNav);
            Controls.Add(CustomerNav);
            Controls.Add(SalesNav);
            Controls.Add(panel2);
            Controls.Add(MedicinNavn);
            Controls.Add(ExaminationNav);
            Controls.Add(MainPanel);
            Controls.Add(NavPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Page";
            Text = "Page";
            Load += Page_Load;
            MouseDown += Page_MouseDown;
            MouseMove += Page_MouseMove;
            MouseUp += Page_MouseUp;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel NavPanel;
		private Panel MainPanel;
		private UserControls.NavigationButtons.NavigationButton ExaminationNav;
		private UserControls.NavigationButtons.NavigationButton MedicinNavn;
		private Panel panel2;
		private UserControls.NavigationButtons.NavigationButton SalesNav;
		private UserControls.NavigationButtons.NavigationButton CustomerNav;
		private UserControls.NavigationButtons.NavigationButton AdministrationNav;
		private Panel panel3;
		private UserControls.NavigationButtons.NavigationButton PetNav;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button exitButton;
    }
}