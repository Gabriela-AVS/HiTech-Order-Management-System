using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTechOrderManagementSystem.BLL;
using System.Data.SqlClient;

namespace HiTechOrderManagementSystem.DAL
{
    public static class CustomerDB
    {
        public static List<Customer> GetAllRecords()
        {
            List<Customer> listC = new List<Customer>();

            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {
                SqlCommand cmdSelectAll = new SqlCommand("SELECT * FROM Customers", conn);
                SqlDataReader dr = cmdSelectAll.ExecuteReader();

                while (dr.Read())
                {
                    Customer customer = new Customer
                    {
                        CustomerId = Convert.ToInt32(dr["CustomerId"]),
                        NameOfInstitution = dr["NameOfInstitution"].ToString(),
                        Street = dr["Street"].ToString(),
                        City = dr["City"].ToString(),
                        PostalCode = dr["PostalCode"].ToString(),
                        Telephone = dr["Telephone"].ToString(),
                        Fax = dr["Fax"].ToString(),
                        CreditLimit = Convert.ToDecimal(dr["CreditLimit"])
                    };

                    listC.Add(customer);
                }

                return listC;
            }
        }
    }
}


