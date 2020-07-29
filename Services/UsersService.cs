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
    }
}