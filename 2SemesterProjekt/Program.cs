using _2SemesterProject.Domain.Interfaces.RepositoryInterfaces.Core;
using _2SemesterProject.Domain.Interfaces.RepositoryInterfaces.ExaminationSection;
using _2SemesterProject.Domain.Interfaces.ServiceInterfaces.Core;
using _2SemesterProject.Domain.Interfaces.ServiceInterfaces.ExaminationSection;
using _2SemesterProjekt.Repository.EntityFrameworkRepository.Core;
using _2SemesterProjekt.Repository.EntityFrameworkRepository.ExaminationSection;
using _2SemesterProjekt.Services.Core;
using _2SemesterProjekt.Services.ExaminationSection;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace _2SemesterProjektWinForms
{
    internal static class Program
    {

		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Initialize();
            Application.Run(new FrontPage());
        }

		private static void Initialize()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.SetHighDpiMode(HighDpiMode.SystemAware);

		}
	}
}