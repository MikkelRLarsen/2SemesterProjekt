using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2SemesterProject.Domain.Models;

namespace _2SemesterProjekt.Repository.EntityFrameworkRepository
{
	public class EntityFramework : DbContext
	{
		public DbSet<Customer> Customers { get; set;}
		DbSet<Pet> Pets { get; set;}
		DbSet<Examination> Examinations { get; set;}
		DbSet<Employee> Employees { get; set;}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(GetConnectionString());
		}

		/// <summary>
		/// Gets Connectionstring from local folder on Desktop
		/// </summary>
		/// <returns></returns>
		protected static string GetConnectionString()
		{
			string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			string fullName = Path.Combine(desktopPath, "RecipeAppConnectionString");
			return File.ReadAllText(fullName);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Customer>().ToTable("Customers");
			modelBuilder.Entity<Pet>().ToTable("Pet");
			modelBuilder.Entity<Examination>().ToTable("Examination");
			modelBuilder.Entity<Employee>().ToTable("Employee");

			//Relations
			modelBuilder.Entity<Customer>()
				.HasMany(c => c.Pets)
				.WithOne(p => p.Customer)
				.HasForeignKey(p => p.CustomerID);

			modelBuilder.Entity<Examination>()
				.HasOne(e => e.Pet)
				.WithMany(p => p.Examinations)
				.HasForeignKey(e => e.ExaminationID);

			modelBuilder.Entity<Examination>()
				.HasOne(e => e.Employee)
				.WithMany(em => em.Examinations)
				.HasForeignKey(e => e.ExaminationID);

			// Primary Keys
			modelBuilder.Entity<Customer>().HasKey(c => c.CustomerID);
			modelBuilder.Entity<Pet>().HasKey(p => p.PetID);
			modelBuilder.Entity<Examination>().HasKey(e => e.ExaminationID);
			modelBuilder.Entity<Employee>().HasKey(em => em.EmployeeID);
		}
	}
}
