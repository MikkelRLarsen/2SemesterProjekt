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
                existingCustomer = _db.Customers
                    .First(c => c.PhoneNumber == customer.PhoneNumber);
            }
            catch
            {
                existingCustomer = null!;
            }

            if (existingCustomer == null) // Add to DB
            {
                _db.Customers.Add(customer);
                _db.SaveChanges();
            }
            else // If hit return and dont add it to DB
            {
                throw new ArgumentException($"{customer.FirstName} {customer.LastName} findes allerde i databasen.");
            }
        }

        public void DeleteCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
        {
			return await _db.Customers
	            .Include(c => c.Pets)
	            .ToListAsync();
		}

        public Customer GetCustomerById(int customerID)
        {
            throw new NotImplementedException();
        }

		public void UpdateCustomer(Customer customer)
		{
			throw new NotImplementedException();
		}

		public int GetCustomerIDByPhoneNumber(int ownerPhoneNumber)
		{
			var owner = _db.Customers.FirstOrDefault(c => c.PhoneNumber == ownerPhoneNumber);
            /* owner will be set to null if there isn't a customer with
            the specific phone number in the DB. */
			if (owner != null){
                return owner.CustomerID;
            }
			else
			{
				return 0;
			}
		}
    }
}
