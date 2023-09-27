using FastaApp.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastaApp.Persistence.Interfaces;

namespace FastaApp.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string _conStr; 

        public UserRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _conStr = _configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<int> AddUserAsync(User user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_conStr))
                {
                    SqlCommand command = new SqlCommand("AddNewUser", connection) { CommandType = CommandType.StoredProcedure };
                    
                    command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value = user.Id;
                    command.Parameters.AddWithValue("@FirstName", user.FirstName);
                    command.Parameters.AddWithValue("@LastName", user.LastName);
                    command.Parameters.AddWithValue("@Email", user.Email);
                    command.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                    command.Parameters.AddWithValue("@UserName", user.UserName);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    command.Parameters.AddWithValue("@ConfirmPassword", user.ConfirmPassword);
                    command.Parameters.AddWithValue("@ProfileColor", user.ProfileColor);
                    command.Parameters.AddWithValue("@DateRegistered", user.DateRegistered);
                    command.Parameters.AddWithValue("@Roles", user.Role);

                    connection.Open();
                    return await command.ExecuteNonQueryAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task<int> DeleteUserAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetSingleUserAsync(string userId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_conStr))
                {
                    SqlCommand command = new SqlCommand("GetUserDetails", connection) { CommandType = CommandType.StoredProcedure };
                    command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value = userId;

                    connection.Open();

                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    User user = new User();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            user.Id = reader["Id"].ToString();
                            user.FirstName = reader["FirstName"].ToString();
                            user.LastName = reader["LastName"].ToString();
                            user.UserName = reader["UserName"].ToString();
                            user.Email = reader["Email"].ToString();
                            user.PhoneNumber = reader["PhoneNumber"].ToString();
                            user.Password = reader["Password"].ToString();
                            user.ConfirmPassword = reader["ConfirmPassword"].ToString();
                            user.ProfileColor = reader["ProfileColor"].ToString();
                            user.DateRegistered = DateTime.Parse(reader["DateRegistered"].ToString());
                            user.Role = reader["Role"].ToString();
                        }
                    }
                    return user;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_conStr))
                {
                    SqlCommand command = new SqlCommand("GetAllUsersDetails", connection) { CommandType = CommandType.StoredProcedure };
                    connection.Open();

                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    List<User> users = new List<User>();

                    if (reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            var user = new User();
                            user.Id = reader["Id"].ToString();
                            user.FirstName = reader["FirstName"].ToString();
                            user.LastName = reader["LastName"].ToString();
                            user.UserName = reader["UserName"].ToString();
                            user.Email = reader["Email"].ToString();
                            user.PhoneNumber = reader["PhoneNumber"].ToString();
                            user.Password = reader["Password"].ToString();
                            user.ConfirmPassword = reader["ConfirmPassword"].ToString();
                            user.ProfileColor = reader["ProfileColor"].ToString();
                            user.DateRegistered = DateTime.Parse(reader["DateRegistered"].ToString());
                            user.Role = reader["Role"].ToString();

                            users.Add(user);
                        }
                    }
                    return users;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
