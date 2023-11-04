using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Dtos
{
<<<<<<< HEAD:Service/Interfaces/ICustomerOrderListService.cs
    public class ICustomerOrderListService
    {
        public void AddToOrderList(AddToOrderListDto request) { }
    }
=======
    public record OrderItemDto(Guid ItemId, int Quantity);
>>>>>>> behind:Service/Dtos/OrderItemDto.cs
}