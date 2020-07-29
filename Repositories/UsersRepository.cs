using System;
using System.Collections.Generic;
using System.Data;
using customer_ratr.Models;
using Dapper;

namespace customer_ratr.Repositories
{
    public class UsersRepository
    {
        private readonly IDbConnection _db;

        public UsersRepository(IDbConnection db)
        {
            _db = db;
        }

        internal User GetById(int id)
        {
            string sql = "SELECT * FROM user WHERE id = @Id";
            return _db.QueryFirstOrDefault<User>(sql, new { id });
        }

        internal User Create(User newUser)
        {
            string sql = @"
            INSERT INTO user
            (name, image)
            VALUES
            (@Name, @Image);
            SELECT LAST_INSERT_ID()";
            newUser.Id = _db.ExecuteScalar<int>(sql, newUser);
            return newUser;
        }
    }
}