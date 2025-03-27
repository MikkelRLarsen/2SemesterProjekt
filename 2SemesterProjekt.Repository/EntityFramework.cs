using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2SemesterProject.Domain.Models;

namespace _2SemesterProjekt.Repository
{
	internal class EntityFramework : DbContext
	{
		DbSet<Customer> Customers { get; set;}
		DbSet<Order> Orders { get; set;}
		DbSet<ProductLine> ProductLines { get; set;}
		DbSet<Product> Products { get; set;}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(GetConnectionString());
		}

		protected static string GetConnectionString()
		{
			string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			string fullName = Path.Combine(desktopPath, "RecipeAppConnectionString");
			return File.ReadAllText(fullName);
		}
	}
}
