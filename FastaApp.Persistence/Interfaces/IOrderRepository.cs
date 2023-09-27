using FastaApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastaApp.Persistence.Interfaces
{
    public interface IOrderRepository
    {
        public Task<List<Order>> GetAllOrdersAsync();
        public Task<Order> GetSingleOrder(string orderId);
        public Task<int> AddOrderAsync(Order order);
        public Task<List<Order>> GetOrdersByUserId(string userId);
    }
}
