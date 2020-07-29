using System;
using System.Collections.Generic;
using customer_ratr.Models;
using customer_ratr.Repositories;

namespace customer_ratr.Services
{
    public class UsersService
    {
        private readonly UsersRepository _repo;

        public UsersService(UsersRepository repo)
        {
            _repo = repo;
        }

        internal User GetById(int id)
        {
            User foundUser = _repo.GetById(id);
            if (foundUser == null)
            {
                throw new Exception("I dunno what happened man");
            }
            return foundUser;
        }

        internal User Create(User newUser)
        {
            return _repo.Create(newUser);
        }
    }
}