using System;
using System.Collections.Generic;
using System.Data;
using customer_ratr.Models;
using Dapper;

namespace customer_ratr.Repositories
{
    public class CustomersRepository
    {
        private readonly IDbConnection _db;

        public CustomersRepository(IDbConnection db)
        {
            _db = db;
        }

        internal IEnumerable<Customer> GetAll()
        {
            string sql = "SELECT * FROM Customer";
            return _db.Query<Customer>(sql);

        }
    }
}