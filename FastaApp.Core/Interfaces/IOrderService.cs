using FastaApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastaApp.Core.Interfaces
{
    public interface IOrderService
    {
        Task AddNewOrder(Order order);
        Task GetAllOrders();
        Task GetOrderById(string id);
    }
}
