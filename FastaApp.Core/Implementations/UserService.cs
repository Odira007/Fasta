using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastaApp.Entities;
using FastaApp.Core.Interfaces;
using FastaApp.Persistence;
using FastaApp.Helpers;
using FastaApp.Persistence.Interfaces;
using Microsoft.Extensions.Logging;

namespace FastaApp.Core.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ILogger<UserService> _logger;

        public UserService(IUserRepository userRepository, ILogger<UserService> logger)
        {
            _userRepository = userRepository;
            _logger = logger;
        }

        public async Task AddNewUser(User user)
        {
            int affectedRows = await _userRepository.AddUserAsync(user);
            string en = affectedRows <= 1 ? "row was" : "rows were";
            try
            {
                await _userRepository.AddUserAsync(user);
                _logger.LogInformation($"{affectedRows} {en} affected");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task DeleteUser(string id)
        {
            throw new NotImplementedException();
        }

        public async Task GetAllUsers()
        {
            try
            {
                await _userRepository.GetAllUsersAsync();
                _logger.LogInformation($"All users' data have been fetched");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task GetUserById(string id)
        {
            try
            {
                await _userRepository.GetSingleUserAsync(id);
                _logger.LogInformation($"A single user with the id: {id} was fetched");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
