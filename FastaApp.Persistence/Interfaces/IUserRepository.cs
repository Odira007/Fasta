using FastaApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastaApp.Persistence.Interfaces
{
    public interface IUserRepository
    {
        public Task<int> AddUserAsync(User user);
        public Task<User> GetSingleUserAsync(string userId);
        public Task<List<User>> GetAllUsersAsync();
        public Task<int> DeleteUserAsync(string userId);
    }
}
