using _2SemesterProjekt;
using _2SemesterProjekt.Pages;

namespace _2SemesterProjektWinForms
{
	public partial class FrontPage : Form
	{
		public FrontPage()
		{
			InitializeComponent();
			mainPanel.Controls.Add(new HomePage());
			navigationFlowPanel.Controls.Add(new NavigationButton("Kunder", mainPanel, new CustomerPage()));
			navigationFlowPanel.Controls.Add(new NavigationButton("Ordre", mainPanel, new OrderPage()));
			navigationFlowPanel.Controls.Add(new NavigationButton("K�ledyr", mainPanel, new PetPage()));
			navigationFlowPanel.Controls.Add(new NavigationButton("Afslut"));
		}
	}
}
