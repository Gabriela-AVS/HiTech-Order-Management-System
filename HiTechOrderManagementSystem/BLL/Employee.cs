using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechOrderManagementSystem.BLL
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int JobId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee() { }

        public Employee(int empId, string fName, string lName, int jobId)
        {
            EmployeeId = empId;
            FirstName = fName;
            LastName = lName;
            JobId = jobId;
        }
    }
}

