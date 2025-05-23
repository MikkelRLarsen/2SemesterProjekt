﻿namespace _2SemesterProjekt.Pages
{
	partial class KonsultationPage
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
			ExaminationFlowPanel = new FlowLayoutPanel();
			CRUDPanel = new FlowLayoutPanel();
			textBoxCustomerPhoneNumber = new TextBox();
			SuspendLayout();
			// 
			// pageNameLabel
			// 
			pageNameLabel.AutoSize = true;
			pageNameLabel.Font = new Font("Gadugi", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
			pageNameLabel.Location = new Point(396, 39);
			pageNameLabel.Name = "pageNameLabel";
			pageNameLabel.Size = new Size(418, 77);
			pageNameLabel.TabIndex = 2;
			pageNameLabel.Text = "Konsultation";
			// 
			// ExaminationFlowPanel
			// 
			ExaminationFlowPanel.AutoScroll = true;
			ExaminationFlowPanel.BackColor = SystemColors.ControlLightLight;
			ExaminationFlowPanel.BorderStyle = BorderStyle.FixedSingle;
			ExaminationFlowPanel.Location = new Point(250, 150);
			ExaminationFlowPanel.Name = "ExaminationFlowPanel";
			ExaminationFlowPanel.Size = new Size(709, 580);
			ExaminationFlowPanel.TabIndex = 3;
			// 
			// CRUDPanel
			// 
			CRUDPanel.Location = new Point(979, 351);
			CRUDPanel.Name = "CRUDPanel";
			CRUDPanel.Size = new Size(209, 379);
			CRUDPanel.TabIndex = 4;
			// 
			// textBoxCustomerPhoneNumber
			// 
			textBoxCustomerPhoneNumber.Location = new Point(979, 326);
			textBoxCustomerPhoneNumber.Margin = new Padding(2, 2, 2, 2);
			textBoxCustomerPhoneNumber.Name = "textBoxCustomerPhoneNumber";
			textBoxCustomerPhoneNumber.PlaceholderText = "Indtast tlf på kunde";
			textBoxCustomerPhoneNumber.Size = new Size(210, 23);
			textBoxCustomerPhoneNumber.TabIndex = 5;
			// 
			// KonsultationPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(textBoxCustomerPhoneNumber);
			Controls.Add(CRUDPanel);
			Controls.Add(ExaminationFlowPanel);
			Controls.Add(pageNameLabel);
			Name = "KonsultationPage";
			Size = new Size(1200, 825);
			Load += KonsultationPage_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label pageNameLabel;
		private FlowLayoutPanel ExaminationFlowPanel;
		private FlowLayoutPanel CRUDPanel;
		private TextBox textBoxCustomerPhoneNumber;
	}
}
