using FastaApp.Entities;
using FastaApp.Persistence.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastaApp.Persistence.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string _conStr;

        public OrderRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _conStr = _configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<int> AddOrderAsync(Order order)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_conStr))
                {
                    SqlCommand command = new SqlCommand("AddNewOrder", connection) { CommandType = CommandType.StoredProcedure };

                    command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value = order.Id;
                    command.Parameters.AddWithValue("@UserId", order.UserId);
                    command.Parameters.AddWithValue("@CarId", order.CarId);
                    command.Parameters.AddWithValue("@Cost", order.Cost);
                    command.Parameters.AddWithValue("@CreatedAt", order.CreatedAt);
                    command.Parameters.AddWithValue("@UpdatedAt", order.UpdatedAt);
                    command.Parameters.AddWithValue("@PickUpDate", order.PickUpDate);
                    command.Parameters.AddWithValue("@ReturnDate", order.ReturnDate);
                    command.Parameters.AddWithValue("@PickUpLocation", order.PickUpLocation);
                    command.Parameters.AddWithValue("@ReturnLocation", order.ReturnLocation);

                    connection.Open();
                    return await command.ExecuteNonQueryAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Order> GetSingleOrder(string orderId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_conStr))
                {
                    SqlCommand command = new SqlCommand("GetOrderDetails", connection) { CommandType = CommandType.StoredProcedure };
                    command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value = orderId;

                    connection.Open();

                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    Order order = new Order();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            order.Id = reader["Id"].ToString();
                            order.CarId = reader["CarId"].ToString();
                            order.UserId = reader["UserId"].ToString();
                            order.Cost = decimal.Parse(reader["Cost"].ToString());
                            order.PickUpDate = DateTime.Parse(reader["PickUpDate"].ToString());
                            order.ReturnDate = DateTime.Parse(reader["ReturnDate"].ToString());
                            order.PickUpLocation = reader["PickUpLocation"].ToString();
                            order.ReturnLocation = reader["ReturnLocation"].ToString();
                            order.CreatedAt = DateTime.Parse(reader["CreatedAt"].ToString());
                            order.UpdatedAt = DateTime.Parse(reader["UpdatedAt"].ToString());
                        }
                    }
                    return order;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<Order>> GetAllOrdersAsync()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_conStr))
                {
                    SqlCommand command = new SqlCommand("GetAllOrdersDetails", connection) { CommandType = CommandType.StoredProcedure };
                    connection.Open();

                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    List<Order> orders = new List<Order>();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var order = new Order();
                            order.Id = reader["Id"].ToString();
                            order.CarId = reader["CarId"].ToString();
                            order.UserId = reader["UserId"].ToString();
                            order.Cost = decimal.Parse(reader["Cost"].ToString());
                            order.PickUpDate = DateTime.Parse(reader["PickUpDate"].ToString());
                            order.ReturnDate = DateTime.Parse(reader["ReturnDate"].ToString());
                            order.PickUpLocation = reader["PickUpLocation"].ToString();
                            order.ReturnLocation = reader["ReturnLocation"].ToString();
                            order.CreatedAt = DateTime.Parse(reader["CreatedAt"].ToString());
                            order.UpdatedAt = DateTime.Parse(reader["UpdatedAt"].ToString());

                            orders.Add(order);
                        }
                    }
                    return orders;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<Order>> GetOrdersByUserId(string userId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_conStr))
                {
                    SqlCommand command = new SqlCommand("GetOrdersByUserId", connection) { CommandType = CommandType.StoredProcedure };
                    connection.Open();

                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    List<Order> orders = new List<Order>();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var order = new Order();
                            order.Id = reader["Id"].ToString();
                            order.CarId = reader["CarId"].ToString();
                            order.UserId = reader["UserId"].ToString();
                            order.Cost = decimal.Parse(reader["Cost"].ToString());
                            order.PickUpDate = DateTime.Parse(reader["PickUpDate"].ToString());
                            order.ReturnDate = DateTime.Parse(reader["ReturnDate"].ToString());
                            order.PickUpLocation = reader["PickUpLocation"].ToString();
                            order.ReturnLocation = reader["ReturnLocation"].ToString();
                            order.CreatedAt = DateTime.Parse(reader["CreatedAt"].ToString());
                            order.UpdatedAt = DateTime.Parse(reader["UpdatedAt"].ToString());

                            orders.Add(order);
                        }
                    }
                    return orders;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
