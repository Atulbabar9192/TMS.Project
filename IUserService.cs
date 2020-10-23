using System;
using System.Collections.Generic;
using System.Text;
using TMS.Project.Data;

namespace TMS.Service
{
    public interface IUserService 
    {
         IEnumerable<User> GetAllUsers();
         User GetByID(int id);
         User GetByEmail(string email);
         int AddUser(User user);

        

    }
}
