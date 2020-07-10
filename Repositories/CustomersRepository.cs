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

        internal Customer Create(Customer newCustomer)
        {
            string sql = @"
                INSERT INTO customer
                (name, img, rating, unhinged, description)
                VALUES
                (@Name, @Img, @Rating, @Unhinged, @Description);
                SELECT LAST_INSERT_ID()";
            newCustomer.Id = _db.ExecuteScalar<int>(sql, newCustomer);
            return newCustomer;
        }

        internal Customer GetById(int id)
        {
            string sql = "SELECT * FROM customer WHERE id = @Id";
            return _db.QueryFirstOrDefault<Customer>(sql, new { id });
        }
    }
}