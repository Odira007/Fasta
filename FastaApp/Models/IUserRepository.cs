using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastaApp.Models
{
    public interface IUserRepository
    {
        void CreateUser(User user);
    }
}
