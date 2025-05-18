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
            ExaminationNav = new _2SemesterProjekt.Pages.UserControls.NavigationButtons.NavigationButton();
            MedicinNavn = new _2SemesterProjekt.Pages.UserControls.NavigationButtons.NavigationButton();
            panel2 = new Panel();
            SalesNav = new _2SemesterProjekt.Pages.UserControls.NavigationButtons.NavigationButton();
            CustomerNav = new _2SemesterProjekt.Pages.UserControls.NavigationButtons.NavigationButton();
            AdministrationNav = new _2SemesterProjekt.Pages.UserControls.NavigationButtons.NavigationButton();
            panel3 = new Panel();
            PetNav = new _2SemesterProjekt.Pages.UserControls.NavigationButtons.NavigationButton();
            SuspendLayout();
            // 
            // NavPanel
            // 
            NavPanel.BackColor = Color.DodgerBlue;
            NavPanel.Location = new Point(1900, 0);
            NavPanel.Margin = new Padding(0);
            NavPanel.Name = "NavPanel";
            NavPanel.Size = new Size(300, 70);
            NavPanel.TabIndex = 0;
            // 
            // MainPanel
            // 
            MainPanel.Location = new Point(0, 70);
            MainPanel.Margin = new Padding(0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(2500, 1580);
            MainPanel.TabIndex = 2;
            // 
            // ExaminationNav
            // 
            ExaminationNav.BackColor = Color.DodgerBlue;
            ExaminationNav.Location = new Point(100, 0);
            ExaminationNav.Margin = new Padding(0);
            ExaminationNav.Name = "ExaminationNav";
            ExaminationNav.Size = new Size(300, 70);
            ExaminationNav.TabIndex = 3;
            // 
            // MedicinNavn
            // 
            MedicinNavn.BackColor = Color.DodgerBlue;
            MedicinNavn.Location = new Point(400, 0);
            MedicinNavn.Margin = new Padding(0);
            MedicinNavn.Name = "MedicinNavn";
            MedicinNavn.Size = new Size(300, 70);
            MedicinNavn.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(100, 70);
            panel2.TabIndex = 5;
            // 
            // SalesNav
            // 
            SalesNav.BackColor = Color.DodgerBlue;
            SalesNav.Location = new Point(700, 0);
            SalesNav.Margin = new Padding(0);
            SalesNav.Name = "SalesNav";
            SalesNav.Size = new Size(300, 70);
            SalesNav.TabIndex = 6;
            // 
            // CustomerNav
            // 
            CustomerNav.BackColor = Color.DodgerBlue;
            CustomerNav.Location = new Point(1000, 0);
            CustomerNav.Margin = new Padding(0);
            CustomerNav.Name = "CustomerNav";
            CustomerNav.Size = new Size(300, 70);
            CustomerNav.TabIndex = 7;
            // 
            // AdministrationNav
            // 
            AdministrationNav.BackColor = Color.DodgerBlue;
            AdministrationNav.Location = new Point(1600, 0);
            AdministrationNav.Margin = new Padding(0);
            AdministrationNav.Name = "AdministrationNav";
            AdministrationNav.Size = new Size(300, 70);
            AdministrationNav.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(2200, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 70);
            panel3.TabIndex = 6;
            // 
            // PetNav
            // 
            PetNav.BackColor = Color.DodgerBlue;
            PetNav.Location = new Point(1300, 0);
            PetNav.Margin = new Padding(0);
            PetNav.Name = "PetNav";
            PetNav.Size = new Size(300, 70);
            PetNav.TabIndex = 8;
            // 
            // Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2500, 1650);
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
	}
}