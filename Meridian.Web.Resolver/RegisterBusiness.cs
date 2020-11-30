using M4PL.Web.Business.Order;
using M4PL.Web.Core.Order.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Meridian.Web.Resolver
{
    public static class RegisterBusiness
    {
        public static void AddBusinessLayer(this IServiceCollection services)
        {
            services.AddTransient<IOrderBusinessRepository, OrderBusinessRepository>();
        }
    }
}
