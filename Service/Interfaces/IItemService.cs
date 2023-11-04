using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IItemService
    {
        public Task CreateNewItem(CreateNewItemRequestDto request);
        //todo :public Task RemoveNewItem(RmoveNewItemRequestDto request);
    }
}