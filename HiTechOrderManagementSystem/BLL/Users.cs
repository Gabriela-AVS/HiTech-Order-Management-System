using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechOrderManagementSystem.BLL
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int EmployeeId { get; set; }
        public int StatusId { get; set; }

        public User() { }

        public User(string userName, string password, int employeeId, int statusId)
        {
            UserName = userName;
            Password = password;
            EmployeeId = employeeId;
            StatusId = statusId;
        }
    }
}

