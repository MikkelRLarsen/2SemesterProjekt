using _2SemesterProject.Domain.Models.Core;
using _2SemesterProject.Domain.Models.Core.Pets;
using _2SemesterProject.Domain.Models.ExaminationSection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Repository.EntityFrameworkRepository
{
	public class EntityFrameworkRepositoryCore : DbContext
	{
		internal DbSet<Customer> Customers { get; set; }
		internal DbSet<Employee> Employees { get; set; }
		internal DbSet<Pet> Pets { get; set; }
		internal DbSet<Examination> Examinations { get; set; }
		internal DbSet<ExaminationType> ExaminationType { get; set; }

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
			modelBuilder.Entity<Customer>().ToTable("Customer");
			modelBuilder.Entity<Employee>().ToTable("Employee");
			modelBuilder.Entity<Pet>().ToTable("Pet");
			modelBuilder.Entity<Examination>().ToTable("Examination");
			modelBuilder.Entity<ExaminationType>().ToTable("ExaminationType");

			// Relations
			modelBuilder.Entity<Pet>()
				.HasOne(pet => pet.Employee)
				.WithMany(cu => cu.Pets)
				.HasForeignKey(pet => pet.CustomerID);

			modelBuilder.Entity<Pet>()
				.HasOne(pet => pet.Employee)
				.WithMany(em => em.Pets)
				.HasForeignKey(pet => pet.EmployeeID);

			modelBuilder.Entity<Pet>()
				.HasMany(pet => pet.Examinations)
				.WithOne(ex => ex.Pet)
				.HasForeignKey(pet => pet.ExaminationID);

			modelBuilder.Entity<Examination>()
				.HasOne(ex => ex.ExaminationType)
				.WithMany(ext => ext.Examination)
				.HasForeignKey(ex => ex.ExaminationTypeID);


			// Primary Keys
			modelBuilder.Entity<Customer>().HasKey(c => c.CustomerID);
			modelBuilder.Entity<Employee>().HasKey(em => em.EmployeeID);
			modelBuilder.Entity<Pet>().HasKey(p => p.PetID);
			modelBuilder.Entity<Examination>().HasKey(ex => ex.ExaminationID);
			modelBuilder.Entity<ExaminationType>().HasKey(ext => ext.ExaminationTypeID);
		}
	}
}
