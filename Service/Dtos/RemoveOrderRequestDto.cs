using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Dtos
{
    public record RemoveOrderRequestDto(Guid CustomerId, OrderItemDto Items);
}