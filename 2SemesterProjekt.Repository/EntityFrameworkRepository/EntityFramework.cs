﻿using _2SemesterProjekt.Domain.Models;
using Microsoft.EntityFrameworkCore;


namespace _2SemesterProjekt.Repository.EntityFrameworkRepository
{
	public class EntityFramework : DbContext
	{
		public DbSet<Customer> Customers { get; set;}
		public DbSet<Pet> Pets { get; set;}
		public DbSet<Examination> Examinations { get; set;}
		public DbSet<Employee> Employees { get; set;}
		public DbSet<ExaminationType> ExaminationTypes { get; set;}
		public DbSet<ExaminationTag> ExaminationTags { get; set;}
		public DbSet<Product> Products { get; set;}
		public DbSet<Order> Orders { get; set;}
		public DbSet<ProductLine> ProductLines { get; set;}
        public DbSet<CageBooking> CageBookings { get; set; }
        public DbSet<Cage> Cages { get; set; }
        public DbSet<Species> Species { get; set; }
        public DbSet<MedicinePrescription> MedicinePrescriptions { get; set;}
        public DbSet<MedicineDetails> MedicineDetails { get; set; }
        public DbSet<MedicineType> MedicineTypes { get; set; }
        public DbSet<MedicineFormat> MedicineFormats { get; set; }


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
            string fullName = Path.Combine(desktopPath, "RecipeAppConnectionString.txt");
            return File.ReadAllText(fullName);
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Customer>().ToTable("Customer");
			modelBuilder.Entity<Pet>().ToTable("Pet");
			modelBuilder.Entity<Examination>().ToTable("Examination");
			modelBuilder.Entity<Employee>().ToTable("Employee");
			modelBuilder.Entity<ExaminationType>().ToTable("ExaminationType");
			modelBuilder.Entity<ExaminationTag>().ToTable("ExaminationTag");
			modelBuilder.Entity<Product>().ToTable("Product");
			modelBuilder.Entity<Order>().ToTable("Order");
			modelBuilder.Entity<ProductLine>().ToTable("ProductLine");
            modelBuilder.Entity<CageBooking>().ToTable("CageBooking");
            modelBuilder.Entity<Cage>().ToTable("Cage");
            modelBuilder.Entity<Species>().ToTable("Species");
            modelBuilder.Entity<MedicinePrescription>().ToTable("MedicinePrescription");
            modelBuilder.Entity<MedicineDetails>().ToTable("MedicineDetails");
            modelBuilder.Entity<MedicineType>().ToTable("MedicineType");
            modelBuilder.Entity<MedicineFormat>().ToTable("MedicineFormat");

            //Relations
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Pets)
                .WithOne(p => p.Customer)
                .HasForeignKey(p => p.CustomerID);

			modelBuilder.Entity<Customer>()
				.HasMany(c => c.Orders)
				.WithOne(o => o.Customer)
				.HasForeignKey(o => o.CustomerID);

			modelBuilder.Entity<Employee>()
				.HasMany(em => em.Pets)
				.WithOne(p => p.Employee)
				.HasForeignKey(p => p.EmployeeID);

            modelBuilder.Entity<Examination>()
                .HasOne(ex => ex.Pet)
                .WithMany(p => p.Examinations)
                .HasForeignKey(ex => ex.PetID);

            modelBuilder.Entity<Examination>()
                .HasOne(ex => ex.Employee)
                .WithMany(em => em.Examinations)
                .HasForeignKey(ex => ex.EmployeeID);

            modelBuilder.Entity<Examination>()
                .HasOne(ex => ex.CageBooking)
                .WithOne(ca => ca.Examination)
                .HasForeignKey<Examination>(ex => ex.CageBookingID);

            modelBuilder.Entity<ExaminationType>()
                .HasMany(eType => eType.Examinations)
                .WithOne(ex => ex.ExaminationType)
                .HasForeignKey(ex => ex.ExaminationTypeID);

			modelBuilder.Entity<Order>()
				.HasMany(o => o.ProductLines)
				.WithOne(prLine => prLine.Order)
				.HasForeignKey(prLine => prLine.OrderID);

			modelBuilder.Entity<Product>()
				.HasMany(p => p.ProductLines)
				.WithOne(prLine => prLine.Product)
				.HasForeignKey(prLine => prLine.ProductID);

            modelBuilder.Entity<ExaminationTag>()
                .HasMany(eTag => eTag.ExaminationTypes)
                .WithOne(eType => eType.ExaminationTag)
                .HasForeignKey(eType => eType.ExaminationTagID);

            modelBuilder.Entity<Cage>()
                .HasMany(ca => ca.Bookings)
                .WithOne(cBooking => cBooking.Cage)
                .HasForeignKey(cBooking => cBooking.CageID);

            modelBuilder.Entity<CageBooking>()
                .HasOne(ca => ca.Examination)
                .WithOne(ex => ex.CageBooking)
                .HasForeignKey<Examination>(ex => ex.CageBookingID);

			modelBuilder.Entity<Cage>()
				.HasOne(ca => ca.Species)
				.WithMany(p => p.Cages)
				.HasForeignKey(p => p.CageID);

            modelBuilder.Entity<Examination>()
                .HasMany(ex => ex.MedicinePrescriptions)
                .WithOne(mp => mp.Examination)
                .HasForeignKey(mp => mp.ExaminationID);

            modelBuilder.Entity<MedicinePrescription>()
                .HasOne(mp => mp.MedicineDetails)
                .WithMany(md => md.MedicinePrescriptions)
                .HasForeignKey(mp => mp.MedicineDetailsID);

            modelBuilder.Entity<MedicineDetails>()
                .HasOne(md => md.MedicineType)
                .WithMany(mt => mt.MedicineDetails)
                .HasForeignKey(md => md.MedicineTypeID);

			modelBuilder.Entity<MedicineDetails>()
				.HasOne(md => md.MedicineFormat)
				.WithMany(mf => mf.MedicineDetails)
				.HasForeignKey(md => md.MedicineFormatID);


			modelBuilder.Entity<Species>()
                .HasMany(s => s.Pets)
                .WithOne(p => p.Species)
                .HasForeignKey(p => p.SpeciesID);

			// Primary Keys
			modelBuilder.Entity<Customer>().HasKey(c => c.CustomerID);
			modelBuilder.Entity<Pet>().HasKey(p => p.PetID);
			modelBuilder.Entity<Examination>().HasKey(ex => ex.ExaminationID);
			modelBuilder.Entity<Employee>().HasKey(em => em.EmployeeID);
			modelBuilder.Entity<ExaminationType>().HasKey(eType => eType.ExaminationTypeID);
			modelBuilder.Entity<ExaminationTag>().HasKey(eTag => eTag.ExaminationTagID);
			modelBuilder.Entity<Product>().HasKey(pr => pr.ProductID);
			modelBuilder.Entity<Order>().HasKey(o => o.OrderID);
			modelBuilder.Entity<ProductLine>().HasKey(prLine => prLine.ProductLineID);
            modelBuilder.Entity<CageBooking>().HasKey(cBooking => cBooking.CageBookingID);
            modelBuilder.Entity<Cage>().HasKey(ca => ca.CageID);
            modelBuilder.Entity<Species>().HasKey(s => s.SpeciesID);
            modelBuilder.Entity<MedicinePrescription>().HasKey(mp => mp.MedicinePrescriptionID);
            modelBuilder.Entity<MedicineDetails>().HasKey(md => md.MedicineDetailsID);
            modelBuilder.Entity<MedicineFormat>().HasKey(mf => mf.MedicineFormatID);
            modelBuilder.Entity<MedicineType>().HasKey(mt => mt.MedicineTypeID);

            // Ignoring properties that don't exist in the DB
            modelBuilder.Entity<Product>().Ignore(pr => pr.QuantityInOrder);
            modelBuilder.Entity<Product>().Ignore(pr => pr.TotalPrice);
            modelBuilder.Entity<Product>().Ignore(pr => pr.NumberInStockOrderPage);
		}
	}
}
