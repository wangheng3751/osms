using System;
using System.Collections.Generic;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using OSMS.Reconcilia.SellOrders;

namespace OSMS.SellOrders
{
    public class SellOrderAppService : AsyncCrudAppService<SellOrder, Dto.SellOrderDto, int, Dto.SellOrderDto, Dto.SellOrderDto, Dto.SellOrderDto>, ISellOrderAppService
    {
        private readonly IRepository<SellOrder> _sellOrderRepository;
        public SellOrderAppService(IRepository<SellOrder> repository) : base(repository)
        {
            _sellOrderRepository = repository;
        }
        /*
        public List<Dto.SellOrderDto> GetAllSellOrders()
        {
            var list= _sellOrderRepository.GetAllList();
            var orders = new List<Dto.SellOrderDto>();
            foreach(var l in list)
            {
                var order = base.MapToEntityDto(l);
                orders.Add(order);
            }
            return orders;
        }*/
    }
}
