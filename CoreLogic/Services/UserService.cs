using CoreLogic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogic.UserService
{
    public class UserService
    {
        public List<User> GetAllUsers() 
        {
            var users = new List<User>
            {
                new User { Id = 1,Name = "karthik",Age = 23,Email = "karthikonu@gmail.com",Gender = "male"},
                 new User { Id = 2,Name = "ankit",Age = 22,Email = "ankit482@gmail.com",Gender = "male"}
            };

            return users;

        }
    }
}
