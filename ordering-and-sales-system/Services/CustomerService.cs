using ordering_and_sales_system.Models;
using ordering_and_sales_system.Domain.Entities;
using ordering_and_sales_system.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace ordering_and_sales_system.Services
{
    public class CustomerService : IDisposable
    {
        private CustomerRepository customerRepository;

        
        public CustomerService()
        {
            customerRepository = new CustomerRepository();
            Model = new CustomerModel();
            Model = GetAllCustomerList();
        }

        public CustomerModel Model { get; set; }

        public CustomerModel GetAllCustomerList()
        {
            Model.CustomerList = customerRepository.GetAllCustomers();
            return Model;
        }

        public void Dispose()
        {
            customerRepository.Dispose();
        }

        public void AddCustomer(ICustomers customer)
        {
            customerRepository.AddCustomer(customer);
        }

        public void UpdateCustomer(ICustomers customer)
        {
            customerRepository.UpdateCustomer(customer);
        }
    }
}






