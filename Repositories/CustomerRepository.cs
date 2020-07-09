using System;
using System.Collections.Generic;
using System.Data;
using customer_ratr.Models;
using Dapper;

namespace customer_ratr.Repositories
{
    public class CustomerRepository
    {
        private readonly IDbConnection _db;

        public CustomerRepository(IDbConnection db)
        {
            _db = db;
        }

        internal IEnumerable<Customer> GetAll()
        {
            string sql = "SELECT * FROM Customers";
            return _db.Query<Customer>(sql);

        }
    }
}