using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using OSMS.Reconcilia.SellOrders;

namespace OSMS.SellOrders.Dto
{
    [AutoMap(typeof(SellOrder))]
    public class SellOrderDto : EntityDto<int>
    {
        //时间
        public virtual DateTime TimeCreated { get; set; }
        //制作单位
        public virtual string OrgName { get; set; }
        //油库
        public virtual string Station { get; set; }
        //油品
        public virtual string Product { get; set; }
        //分公司
        public virtual string CompanyName { get; set; }
        //客户名称
        public virtual string CustomerName { get; set; }
        //出库数量
        public virtual decimal Count { get; set; }
        //单价
        public virtual decimal Price { get; set; }
        //金额
        public virtual decimal Amount { get; set; }
        //剩余数量
        public virtual decimal Remaining { get; set; }
        //余额
        public virtual decimal Balance { get; set; }
        //司机姓名
        public virtual string DriverName { get; set; }
        //卡号
        public virtual string CardNo { get; set; }
    }

}
