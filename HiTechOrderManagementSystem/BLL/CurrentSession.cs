using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechOrderManagementSystem.BLL
{
    public static class CurrentSession
    {
        public static int EmployeeId { get; set; }
        public static int JobId { get; set; }
        public static string UserName { get; set; }
    }
}
