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
            (name, password, image,)
            VALUES
            (@Name, @Password, @Image);
            SELECT LAST_INSERT_ID()";
            newUser.Id = _db.ExecuteScalar<int>(sql, newUser);
            return newUser;
        }

        internal bool Delete(int id)
        {
            string sql = "DELETE FROM user WHERE id = @Id LIMIT 1";
            int affectedRows = _db.Execute(sql, new { id });
            return affectedRows == 1;
        }

        internal User Edit(User foundUser)
        {
            string sql = @"
            UPDATE user 
            SET
            name = @Name,
            password = @Password,
            image = @Image
            WHERE id = @Id LIMIT 1";
            _db.Execute(sql, foundUser);
            return foundUser;
        }
    }
}