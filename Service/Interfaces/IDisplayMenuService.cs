using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Service.Interfaces
{
    public interface IDisplayMenuService
    {
        public Task<Menu> DisplayMenu(Guid MeniId);
    }
}