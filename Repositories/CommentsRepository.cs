using System;
using System.Collections.Generic;
using System.Data;
using customer_ratr.Models;
using Dapper;

namespace customer_ratr.Repositories
{
    public class CommentsRepository
    {
        private readonly IDbConnection _db;

        public CommentsRepository(IDbConnection db)
        {
            _db = db;
        }

        internal IEnumerable<Comment> GetAll()
        {
            string sql = "SELECT * FROM Comment";
            return _db.Query<Comment>(sql);
        }

        internal Comment Create(Comment newComment)
        {
            string sql = @"
                INSERT INTO comment
                (body)
                VALUES
                (@Body)
                SELECT LAST_INSERT_ID()";
            newComment.Id = _db.ExecuteScalar<int>(sql, newComment);
            return newComment;
        }

        ANCHOR // Start backup here, might need viewmodel
        internal IEnumerable<Comment> GetCommentsByCustomerId(int customerId)
        {
            string sql = ""
        }
    }
}