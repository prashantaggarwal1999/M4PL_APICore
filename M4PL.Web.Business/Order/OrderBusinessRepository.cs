using M4PL.Web.Core.Order.Interface;
using Meridian.Web.Core.Order.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace M4PL.Web.Business.Order
{
    public class OrderBusinessRepository : IOrderBusinessRepository
    {
        public OrderDetail GetOrder()
        {
            return new OrderDetail() { OrderId = 123, Origin = "Scottsdale", Desstination = "Chicago", DeliveryDate = DateTime.Now };
        }
    }
}
