using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2SemesterProject.Domain.Models;

namespace _2SemesterProjekt.Repository.EntityFrameworkRepository
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
			modelBuilder.Entity<Product>().ToTable("Product");
			modelBuilder.Entity<Order>().ToTable("Order");
			modelBuilder.Entity<ProductLine>().ToTable("ProductLine");
			modelBuilder.Entity<Customer>().ToTable("Customer");

			// Relations
			modelBuilder.Entity<ProductLine>()
				.HasOne(pl => pl.Order)
				.WithMany(o => o.ProductLines)
				.HasForeignKey(pl => pl.OrderID);

			modelBuilder.Entity<Product>()
				.HasMany(p => p.ProductLines)
				.WithOne(pl => pl.Product)
				.HasForeignKey(p => p.ProductID);

			modelBuilder.Entity<Order>()
				.HasOne(o => o.Customer)
				.WithMany(c => c.Order)
				.HasForeignKey(o => o.CustomerID);

			// Primary Keys
			modelBuilder.Entity<Product>().HasKey(p => p.ProductID);
			modelBuilder.Entity<Order>().HasKey(o => o.OrderID);
			modelBuilder.Entity<ProductLine>().HasKey(pl => pl.ProductLineID);
			modelBuilder.Entity<Customer>().HasKey(c => c.CustomerID);
		}
	}
}
