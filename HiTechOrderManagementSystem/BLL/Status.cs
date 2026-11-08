using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechOrderManagementSystem.BLL
{
    public class Status
    {
        public int StatusId { get; set; }
        public string Description { get; set; }

        public Status() { }

        public Status(int statusId, string description)
        {
            StatusId = statusId;
            Description = description;
        }
    }
}
