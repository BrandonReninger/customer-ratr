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

        internal string Delete(int id)
        {
            User foundUser = _repo.GetById(id);
            if (_repo.Delete(id))
            {
                return "Bye Bye!";
            }
            else
            {
                return "Something went wrong bro.";
            }
        }

        internal User Edit(int id, User updateUser)
        {
            User foundUser = GetById(id);
            foundUser.Name = updateUser.Name;
            foundUser.Image = updateUser.Image;

            return _repo.Edit(foundUser);
        }
    }
}