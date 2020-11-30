using System;
using System.Collections.Generic;
using System.Text;

namespace Meridian.Web.Core.Order.Model
{
    public class OrderDetail
    {
        public int OrderId { get; set; }

        public string Origin { get; set; }

        public string Desstination { get; set; }

        public DateTime DeliveryDate { get; set; }
    }
}
