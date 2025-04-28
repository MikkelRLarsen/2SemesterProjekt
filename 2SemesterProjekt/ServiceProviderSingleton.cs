using _2SemesterProject.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProject.Domain.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt
{
	internal class ServiceProviderSingleton
	{
		private static ServiceProvider? _serviceProvider;

		private ServiceProviderSingleton()
		{
			var services = new ServiceCollection();

			// Register services
			// Bll Services
			//services.AddScoped<ICustomerService, CustomerService>(); 
			
			services.AddScoped<IEmployeeService, IEmployeeService>();

			services.AddScoped<IExaminationService, IExaminationService>();

			// Dal Services
			// services.AddTransient<ICustomerRepository, CustomerRepository>();


			_serviceProvider = services.BuildServiceProvider();
		}


		/// <summary>
		/// A singleton class which returns all services if they have Initalized otherwise create ServiceProdiver 
		/// and save it as a static field for later use to preserve state
		/// </summary>
		/// <returns>ServiceProdivder which contains all Services with Lifetime</returns>
		public static ServiceProvider GetServiceProvider()
		{
			if (_serviceProvider == null)
			{
				new ServiceProviderSingleton();
			}

			Debug.Assert(_serviceProvider != null, "_serviceProvider in ServiceProviderSingletong was null, somehow");
			return _serviceProvider;
		}
	}
}
