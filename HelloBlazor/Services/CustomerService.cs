using HelloBlazor.DataContext;
using HelloBlazor.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloBlazor.Services
{
    public class CustomerService : ICustomerService
    {
		private readonly IRepository<Customer> repository;

		public CustomerService(BlazorDbContext blazorDbContext, IRepository<Customer> repository)
		{
			this.repository = repository;
		}
        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
			try
			{
				return await repository.GetAllAsync();
			}
			catch (Exception ex)
			{

				throw ex;
			}
        }

		public async Task<bool> SaveCustomer(Customer customer)
		{
			try
			{
				return await repository.AddAsync(customer);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
	}
}
