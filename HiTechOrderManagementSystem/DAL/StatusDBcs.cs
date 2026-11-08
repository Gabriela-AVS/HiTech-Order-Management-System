using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using HiTechOrderManagementSystem.BLL;

namespace HiTechOrderManagementSystem.DAL
{
    public static class StatusDB
    {
       
        public static List<Status> GetAllStatuses()
        {
            List<Status> list = new List<Status>();

            SqlConnection conn = UtilityDB.GetDBConnection();

            string sql = "SELECT StatusId, Description FROM Status";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Status st = new Status
                {
                    StatusId = Convert.ToInt32(reader["StatusId"]),
                    Description = reader["Description"].ToString()
                };

                list.Add(st);
            }

            conn.Close();
            return list;
        }
    }
}

