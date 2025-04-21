using _2SemesterProject.Domain.Models.Core;
using _2SemesterProject.Domain.Models.Core.Pets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.DTO
{
	public class CustomerDTO
	{
		public CustomerDTO()
		{
		}

		public CustomerDTO(Customer customer)
		{
			CustomerID = customer.CustomerID;
			CustomerName = customer.CustomerName;
			CustomerEmail = customer.CustomerEmail;
			CustomerAdress = customer.CustomerAdress;
			CustomerPhoneNumber = customer.CustomerPhoneNumber;			
		}

		public int? CustomerID { get; set; }
		public string? CustomerName { get; set; }
		public string? CustomerEmail { get; set; }
		public string? CustomerAdress { get; set; }
		public int? CustomerPhoneNumber { get; set; }

	}
}
