using _2SemesterProjekt.Pages;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace _2SemesterProjektWinForms
{
    internal static class Program
    {
		private static ServiceProvider _serviceProvider;

		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Initialize();
            Application.Run(new Page());
        }

		private static void Initialize()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.SetHighDpiMode(HighDpiMode.SystemAware);

			var services = new ServiceCollection();

			// Register services
			// services.AddSingleton<Interface1, Class1>();


			_serviceProvider = services.BuildServiceProvider();
		}
	}
}