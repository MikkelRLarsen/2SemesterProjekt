using _2SemesterProjekt.Domain.Interfaces.RepositoryInterfaces;
using _2SemesterProjekt.Domain.Models;
using Microsoft.EntityFrameworkCore;


namespace _2SemesterProjekt.Repository.EntityFrameworkRepository
{
    public class CustomerRepositoryEF : ICustomerRepository
    {
        private readonly EntityFramework _db;

        public CustomerRepositoryEF(EntityFramework db)
        {
            _db = db;
        }

        public async Task CreateCustomerAsync(Customer customer)
        {
            Customer existingCustomer;
            
            try
            {
                // Check if the customer is already in DB
                existingCustomer = await _db.Customers
                    .FirstAsync(c => c.PhoneNumber == customer.PhoneNumber);
            }
            catch
            {
                existingCustomer = null!;
            }

            if (existingCustomer == null) // Add to DB
            {
                await _db.Customers.AddAsync(customer);
                await _db.SaveChangesAsync();
            }
            else // If hit return and dont add it to DB
            {
                throw new ArgumentException($"{customer.FirstName} {customer.LastName} findes allerde i databasen.");
            }
        }

        public async Task<Customer> GetCustomerByPhoneNumberAsync(int phoneNumber)
        {
            var customer = await _db.Customers
                .Include(c => c.Pets!)
                    .ThenInclude(p => p.Species)
                .FirstOrDefaultAsync(c => c.PhoneNumber == phoneNumber);

            if (customer != null)
            {
                return customer;
            }
            else
            {
                throw new ArgumentException($"Der findes ingen kunde i databasen med {phoneNumber}");
            }
        }

        public async Task<IEnumerable<Customer>> GetAllCustomersWithPetsAsync()
        {
            var customersWithPets = await _db.Customers
                .Where(c => c.Pets!.Any())
                .Include(c => c.Pets!)
                    .ThenInclude(p => p.Species)
                .ToListAsync();

            return customersWithPets;
        }
        public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
        {
            return await _db.Customers
                .ToListAsync();
        }
    }
}
