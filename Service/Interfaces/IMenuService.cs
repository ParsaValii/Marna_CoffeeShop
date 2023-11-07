using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Service.Dtos;

namespace Service.Interfaces
{
    public interface IMenuService
    {
        public Task<Guid> CreateMenu(CreateMenuDto request);
    }
}