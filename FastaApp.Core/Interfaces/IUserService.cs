﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastaApp.Entities;

namespace FastaApp.Core.Interfaces
{
    public interface IUserService
    {
        Task CreateUser(User user);
    }
}
