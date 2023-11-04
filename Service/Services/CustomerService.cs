using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.Entities;
using Service.Dtos;
using Service.Interfaces;

namespace Service.Services
{
    public class CustomerService : ICustomerService
    {
        CoffeShopDbContext _context;
        public CustomerService(CoffeShopDbContext context)
        {
            _context = context;
        }

        public async Task CreateCustomer(CreateCustomerDto request)
        {
            var _customer = new Customer()
            {
                FullName = request.fullName
            };
            await _context.customer.AddAsync(_customer);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveCustomer(RemoveCustomerDto request)
        {
            _context.customer.Remove(await _context.customer.FindAsync(request.id));
            await _context.SaveChangesAsync();
        }
    }
}