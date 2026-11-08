using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTechOrderManagementSystem.DAL;

namespace HiTechOrderManagementSystem.BLL
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string NameOfInstitution { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Telephone { get; set; } = string.Empty;
        public string Fax { get; set; } = string.Empty;
        public decimal CreditLimit { get; set; }

       
        public List<Customer> GetAllCustomers() => CustomerDB.GetAllRecords();
    }
}


