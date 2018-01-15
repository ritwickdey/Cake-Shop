using CakeShop.Core.Dto;
using System;
using System.Collections.Generic;

namespace CakeShop.Core.ViewModel
{
    public class MyOrderViewModel
    {
        public OrderDto OrderPlaceDetails { get; set; }
        public decimal OrderTotal { get; set; }
        public DateTime OrderPlacedTime { get; set; }
        public IEnumerable<MyCakeOrderInfo> CakeOrderInfos { get; set; }

    }

    public class MyCakeOrderInfo
    {
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
    }
}
