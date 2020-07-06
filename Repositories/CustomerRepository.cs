using System.Data;

namespace customer_ratr.Repositories
{
    public class CustomerRepository
    {
        private readonly IDbConnection _db;

        public CustomerRepository(IDbConnection db)
        {
            _db = db;
        }
    }
}