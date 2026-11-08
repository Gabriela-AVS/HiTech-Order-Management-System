using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace HiTechOrderManagementSystem.DAL
{
    public static class UtilityDB
    {
        /// <summary>
        /// This method returns an active database connection
        /// Version 1: Working but not good
        /// </summary>
        /// <returns>Object of SqlConnection</returns>

        public static SqlConnection GetDBConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
            conn.Open();
            return conn;
        }

    }
}
