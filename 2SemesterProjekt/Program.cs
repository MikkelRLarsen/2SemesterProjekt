using _2SemesterProjekt.Pages;
using System;
using System.Drawing;
using System.Windows.Forms;

internal static class Program
{
	[STAThread]
	static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);

		Application.Run(new Page());
	}

}
