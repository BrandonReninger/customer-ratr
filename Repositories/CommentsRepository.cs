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
    }
}