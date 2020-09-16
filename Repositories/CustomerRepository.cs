using UnitOfShop.Data;
using UnitOfShop.Models;
using UnitOfShop.Repositories.Interfaces;

namespace UnitOfShop.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _context;

        public CustomerRepository(DataContext context)
        {
            _context = context;
        }

        void ICustomerRepository.Save(Customer custumer)
        {
            _context.Customers.Add(custumer);
        }
    }
}