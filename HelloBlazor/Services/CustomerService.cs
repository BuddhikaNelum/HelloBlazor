using HelloBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloBlazor.Services
{
    public class CustomerService : ICustomerService
    {
        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            var customerList = new List<Customer>
            {
                new Customer
                {
                    Id = 001,
                    Name = "Buddhika Nelum",
                    Address = "Galle",
                    Mobile = "0769880279"
                },
                new Customer
                {
                    Id = 002,
                    Name = "Vimukthi Sandaruwan",
                    Address = "Colombo",
                    Mobile = "0769880279"
                },
                new Customer
                {
                    Id = 003,
                    Name = "Nishedha SriLak",
                    Address = "Imaduwa",
                    Mobile = "0769880279"
                }
            };

            return await Task.FromResult(customerList);
        }


    }
}
