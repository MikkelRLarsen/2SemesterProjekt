using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt
{
	internal class ServiceProviderSingleton
	{
		public static ServiceProvider? _serviceProvider { get; private set; }

		public ServiceProviderSingleton(ServiceProvider serviceProvider)
		{
			_serviceProvider = serviceProvider;
		}
	}
}
