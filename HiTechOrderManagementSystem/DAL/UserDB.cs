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
    public static class UserDB
    {

        public static void SaveRecord(User user)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();

            string sql = "INSERT INTO Users (UserName, Password, EmployeeId, StatusId) " +
                         "VALUES (@UserName, @Password, @EmployeeId, @StatusId)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@UserName", user.UserName);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@EmployeeId", user.EmployeeId);
            cmd.Parameters.AddWithValue("@StatusId", user.StatusId);

            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public static void UpdateRecord(User user)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();

            string sql = "UPDATE Users SET Password=@Password, EmployeeId=@EmployeeId, StatusId=@StatusId " +
                         "WHERE UserName=@UserName";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@UserName", user.UserName);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@EmployeeId", user.EmployeeId);
            cmd.Parameters.AddWithValue("@StatusId", user.StatusId);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void DeleteRecord(string userName)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();

            string sql = "DELETE FROM Users WHERE UserName=@UserName";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@UserName", userName);

            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public static User SearchRecord(string userName)
        {
            User user = null;

            SqlConnection conn = UtilityDB.GetDBConnection();

            string sql = "SELECT * FROM Users WHERE UserName=@UserName";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@UserName", userName);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                user = new User
                {
                    UserName = reader["UserName"].ToString(),
                    Password = reader["Password"].ToString(),
                    EmployeeId = Convert.ToInt32(reader["EmployeeId"]),
                    StatusId = Convert.ToInt32(reader["StatusId"])
                };
            }

            conn.Close();
            return user;
        }


        public static List<User> GetAllRecords()
        {
            List<User> list = new List<User>();

            SqlConnection conn = UtilityDB.GetDBConnection();

            string sql = "SELECT * FROM Users";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                User user = new User
                {
                    UserName = reader["UserName"].ToString(),
                    Password = reader["Password"].ToString(),
                    EmployeeId = Convert.ToInt32(reader["EmployeeId"]),
                    StatusId = Convert.ToInt32(reader["StatusId"])
                };

                list.Add(user);
            }

            conn.Close();
            return list;
        }
    }
}