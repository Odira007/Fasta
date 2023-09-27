using FastaApp.Core.Interfaces;
using FastaApp.Entities;
using FastaApp.Persistence.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastaApp.Core.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ILogger<OrderService> _logger;
        public OrderService(IOrderRepository orderRepository, ILogger<OrderService> logger)
        {
            _orderRepository = orderRepository;
            _logger = logger;
        }

        public async Task AddNewOrder(Order order)
        {
            int affectedRows = await _orderRepository.AddOrderAsync(order);
            string en = affectedRows <= 1 ? "row was" : "rows were";
            try
            {
                await _orderRepository.AddOrderAsync(order);
                _logger.LogInformation($"{affectedRows} {en} affected");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task GetAllOrders()
        {
            try
            {
                await _orderRepository.GetAllOrdersAsync();
                _logger.LogInformation($"All user orders have been fetched");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task GetOrderById(string id)
        {
            try
            {
                await _orderRepository.GetSingleOrder(id);
                _logger.LogInformation($"All single order with id: {id} has been fetched");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
