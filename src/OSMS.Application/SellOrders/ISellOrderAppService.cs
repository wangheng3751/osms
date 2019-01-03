using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using OSMS.SellOrders.Dto;

namespace OSMS.SellOrders
{
    public interface ISellOrderAppService : IAsyncCrudAppService<SellOrderDto, int, SellOrderDto, SellOrderDto, SellOrderDto>
    {
        //List<SellOrderDto> GetAllSellOrders();
    }
}
