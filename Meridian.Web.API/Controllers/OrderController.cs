using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using M4PL.Web.Core.Order.Interface;
using Meridian.Web.Core.Order.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Meridian.Web.API.Controllers
{
    [ApiController]
    [Route("api/order")]
    public class OrderController : ControllerBase
    {
        /// <summary>
        /// Initialize the variable for logger.
        /// </summary>
        private readonly ILogger<OrderController> _logger;

        /// <summary>
        /// Property to access the Business Repository Methods
        /// </summary>
        public IOrderBusinessRepository OrderBusinessRepository { get; private set; }

        /// <summary>
        /// Order controller constructor with logger and Business Repository variables as input.
        /// </summary>
        /// <param name="logger">logger</param>
        /// <param name="orderBusinessRepository">orderBusinessRepository</param>
        public OrderController(ILogger<OrderController> logger, IOrderBusinessRepository orderBusinessRepository)
        {
            _logger = logger;
            OrderBusinessRepository = orderBusinessRepository;
        }

        /// <summary>
        /// This API is test to get the Order information.
        /// </summary>
        /// <returns>It will return the specific order information</returns>
        [HttpGet]
        public OrderDetail Get()
        {
            var orderData = OrderBusinessRepository.GetOrder();
            return orderData;
        }
    }
}
