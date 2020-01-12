using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloBlazor.Models;
using HelloBlazor.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloBlazor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet]
        [Route("GetAllCustomers")]
        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await customerService.GetAllCustomers();
        }

        [HttpPost]
        [Route("SaveCustomer")]
        public async Task<bool> SaveCustomer(Customer customer)
        {
            return await customerService.SaveCustomer(customer);
        }
    }
}