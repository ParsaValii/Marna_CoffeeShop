using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Service.Dtos;

namespace Service.Interfaces
{
    public interface ICustomerService 
    {
        public Task CreateCustomer(CreateCustomerDto request);
        public Task RemoveCustomer(RemoveCustomerDto request);
    }
}