using System;
using System.Collections.Generic;
using customer_ratr.Models;
using customer_ratr.Repositories;

namespace customer_ratr.Services
{
    public class CustomerService
    {
        private readonly CustomerRepository _repo;

        public CustomerService(CustomerRepository repo)
        {
            _repo = repo;
        }

        internal IEnumerable<Customer> GetAll()
        {
            return _repo.GetAll();
        }
    }
}