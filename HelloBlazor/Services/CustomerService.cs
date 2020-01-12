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
		private readonly BlazorDbContext blazorDbContext;

		public CustomerService(BlazorDbContext blazorDbContext)
		{
			this.blazorDbContext = blazorDbContext;
		}
        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
			try
			{
				return await blazorDbContext.Customers.ToListAsync();
			}
			catch (Exception ex)
			{

				throw ex;
			}
        }
    }
}
