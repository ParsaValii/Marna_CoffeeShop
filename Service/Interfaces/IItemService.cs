using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Service.Dtos;

namespace Service.Interfaces
{
    public interface IItemService
    {
        public Task CreateNewItem(CreateNewItemRequestDto request);
        public Task RemoveItem(RemoveItemRequestDto request);
    }
}