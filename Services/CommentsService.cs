using System;
using System.Collections.Generic;
using customer_ratr.Models;
using customer_ratr.Repositories;

namespace customer_ratr.Services
{
    public class CommentsService
    {
        private readonly CommentsRepository _repo;

        public CommentsService(CommentsRepository repo)
        {
            _repo = repo;
        }

        internal IEnumerable<Comment> Getall()
        {
            return _repo.GetAll();
        }

        internal IEnumerable<Comment> GetCommentsByCustomerId(int customerId)
        {
            return _repo.GetCommentsByCustomerId(customerId);
        }

        internal Comment Create(Comment newComment)
        {
            return _repo.Create(newComment);
        }

    }
}