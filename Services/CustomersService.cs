using System;
using System.Collections.Generic;
using customer_ratr.Models;
using customer_ratr.Repositories;

namespace customer_ratr.Services
{
    public class CustomersService
    {
        private readonly CustomersRepository _repo;

        public CustomersService(CustomersRepository repo)
        {
            _repo = repo;
        }

        internal IEnumerable<Customer> GetAll()
        {
            return _repo.GetAll();
        }
    }
}