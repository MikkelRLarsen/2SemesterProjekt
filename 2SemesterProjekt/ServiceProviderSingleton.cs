using _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using _2SemesterProjekt.Repository.EntityFrameworkRepository;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces;

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
			services.AddScoped<ICustomerService, CustomerService>();
			services.AddScoped<IEmployeeService, EmployeeService>();
			services.AddScoped<IPetService, PetService>();
			services.AddScoped<IExaminationService, ExaminationService>();
            services.AddScoped<IProductService, ProductService>();
			services.AddScoped<IExportService, ExportService>();
			services.AddScoped<IOrderService, OrderService>();
			services.AddScoped<IProductLineService, ProductLineService>();



            // Dal Services
            services.AddTransient<EntityFramework>();
			services.AddTransient<ICustomerRepository, CustomerRepositoryEF>();
			services.AddTransient<IEmployeeRepository,  EmployeeRepositoryEF>();
			services.AddTransient<IPetRepository, PetRepositoryEF>();
			services.AddTransient<IExaminationRepository, ExaminationRepositoryEF>();
			services.AddTransient<IProductRepository, ProductRepositoryEF>();
			services.AddTransient<IOrderRepository, OrderRepositoryEF>();
			services.AddTransient<IProductLineRepository, ProductLineRepositoryEF>();


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
