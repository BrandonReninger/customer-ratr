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

        internal Customer Create(Customer newCustomer)
        {
            return _repo.Create(newCustomer);
        }

        internal Customer GetById(int id)
        {
            Customer foundCustomer = _repo.GetById(id);
            if (foundCustomer == null)
            {
                throw new Exception("Invalid ID!");
            }
            return foundCustomer;
        }

        internal string Delete(int id)
        {
            Customer foundCustomer = GetById(id);
            if (_repo.Delete(id))
            {
                return "Deleted!";
            }
            else
            {
                return "I dunno man, something went wrong";
            }
        }

        internal Customer Edit(int id, Customer updateCustomer)
        {
            Customer foundCustomer = GetById(id);
            foundCustomer.Name = updateCustomer.Name;
            foundCustomer.Img = updateCustomer.Img;
            foundCustomer.Rating = updateCustomer.Rating;
            foundCustomer.Unhinged = updateCustomer.Unhinged;
            foundCustomer.Description = updateCustomer.Description;

            return _repo.Edit(foundCustomer);
        }
    }
}