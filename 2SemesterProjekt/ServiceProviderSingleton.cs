using _2SemesterProject.Domain.Interfaces.RepositoryInterfaces.Core;
using _2SemesterProject.Domain.Interfaces.RepositoryInterfaces.ExaminationSection;
using _2SemesterProject.Domain.Interfaces.ServiceInterfaces.Core;
using _2SemesterProject.Domain.Interfaces.ServiceInterfaces.ExaminationSection;
using _2SemesterProjekt.Repository.EntityFrameworkRepository.Core;
using _2SemesterProjekt.Repository.EntityFrameworkRepository.ExaminationSection;
using _2SemesterProjekt.Services.Core;
using _2SemesterProjekt.Services.ExaminationSection;
using Microsoft.Extensions.DependencyInjection;

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
			services.AddScoped<IExaminationTypeService, ExaminationTypeService>();

			// Dal Services
			services.AddTransient<ICustomerRepository, CustomerRepository>();
			services.AddTransient<IEmployeeRepository, EmployeeRepository>();
			services.AddTransient<IPetRepository, PetRepository>();
			services.AddTransient<IExaminationRepository, ExaminationRepository>();
			services.AddTransient<IExaminationTypeRepository, ExaminationTypeRepository>();

			_serviceProvider = services.BuildServiceProvider();
		}

		public static ServiceProvider GetServiceProvider()
		{
			if (_serviceProvider == null)
			{
				new ServiceProviderSingleton();
			}

			return _serviceProvider;
		}
	}
}
