using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastaApp.Entities;
using FastaApp.Core.Interfaces;
using FastaApp.Persistence;
using FastaApp.Helpers;

namespace FastaApp.Core.Implementations
{
    public class UserService : IUserService
    {
        public async Task CreateUser(User user)
        {
            DataStore.Users.Add(user);
            await FileOperations.SaveToFileDatabaseAync();
        }
    }
}
