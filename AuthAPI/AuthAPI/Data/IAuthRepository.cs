using AuthAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthAPI.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User username, string password);
        Task<User> Login(string userName, string password);
        Task<bool> UserExists(string userName);
    }
}
