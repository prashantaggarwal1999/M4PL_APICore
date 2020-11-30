using System;
using System.Collections.Generic;
using System.Text;
using Meridian.Web.Core.Order.Model;

namespace M4PL.Web.Core.Order.Interface
{
    public interface IOrderBusinessRepository
    {
        OrderDetail GetOrder();
    }
}
