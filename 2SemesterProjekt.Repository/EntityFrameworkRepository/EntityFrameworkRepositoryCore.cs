using _2SemesterProject.Domain.Models.Core;
using _2SemesterProject.Domain.Models.Core.Pets;
using _2SemesterProject.Domain.Models.ExaminationSection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Repository.EntityFrameworkRepository
{
	internal class EntityFrameworkRepositoryCore : DbContext
	{
		DbSet<Customer> Customers { get; set; }
		DbSet<Employee> Employees { get; set; }
		DbSet<Pet> Pets { get; set; }
		DbSet<Examination> Examinations { get; set; }
		DbSet<ExaminationType> ExaminationType { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);

		}
	}
}
