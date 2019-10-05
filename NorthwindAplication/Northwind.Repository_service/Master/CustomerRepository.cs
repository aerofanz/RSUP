using Northwind.Repository_api;

namespace Northwind.Repository_service
{
    public class CustomerRepository : ICustomerRepository
    {
        private IDapperContext _context;

        public CustomerRepository(IDapperContext context)
        {
            _context = context;
        }
    }
}