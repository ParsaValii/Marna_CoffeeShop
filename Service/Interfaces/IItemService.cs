using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Service.Dtos;

namespace Service.Interfaces
{
    public interface IItemService
    {
        public Task<Guid> CreateNewItem(CreateNewItemRequestDto request);
        public Task RemoveItem(Guid Id);
        public Task EditItem(Guid Id, EditItemRequestDto request);
    }
}