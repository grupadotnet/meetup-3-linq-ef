using System;
using System.Collections.Generic;
using meet_up_3.Models;
using meet_up_3.ViewModels.User;

namespace meet_up_3.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        
        User GetUser(Guid id);
        
        void AddUser(User user);

        void UpdateUser(UpdateUserViewModel user);

        void DeleteUser(Guid id);
        
        void DeleteUser(User user);
    }
}