using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using HiTechOrderManagementSystem.BLL;
using System.Data.SqlTypes;

namespace HiTechOrderManagementSystem.DAL
{
    public static class EmployeeDB
    {
      
        public static void AddEmployee(Employee emp)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();


            string sql = @"
                        SELECT e.EmployeeId, e.FirstName, e.LastName, e.JobId
                         FROM Employees e
                         INNER JOIN [User] u ON e.EmployeeId = u.EmployeeId
                         WHERE u.UserName = @UserName AND u.Password = @Password";


            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmd.Parameters.AddWithValue("@LastName", emp.LastName);
            cmd.Parameters.AddWithValue("@JobId", emp.JobId);


            cmd.ExecuteNonQuery();
            conn.Close();
        }

      
        public static void UpdateEmployee(Employee emp)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();


            string sql = "UPDATE Employees " +
                         "SET FirstName = @FirstName, LastName = @LastName, JobId = @JobId " +
                         "WHERE EmployeeId = @EmployeeId";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
            cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmd.Parameters.AddWithValue("@LastName", emp.LastName);
            cmd.Parameters.AddWithValue("@JobId", emp.JobId);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void DeleteEmployee(int empId)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();


            string sql = "DELETE FROM Employees WHERE EmployeeId = @EmployeeId";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@EmployeeId", empId);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        
        public static Employee SearchEmployee(int empId)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();


            string sql = "SELECT * FROM Employees WHERE EmployeeId = @EmployeeId";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@EmployeeId", empId);

            SqlDataReader reader = cmd.ExecuteReader();

            Employee emp = null;

            if (reader.Read())
            {
                emp = new Employee
                {
                    EmployeeId = Convert.ToInt32(reader["EmployeeId"]),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    JobId = Convert.ToInt32(reader["JobId"])
                };
            }

            conn.Close();
            return emp;
        }

    
        public static List<Employee> GetAllEmployees()
        {
            List<Employee> list = new List<Employee>();

            SqlConnection conn = UtilityDB.GetDBConnection();

            string sql = "SELECT * FROM Employees";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Employee emp = new Employee
                {
                    EmployeeId = Convert.ToInt32(reader["EmployeeId"]),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    JobId = Convert.ToInt32(reader["JobId"])
                };

                list.Add(emp);
            }

            conn.Close();
            return list;
        }

        public static Employee GetEmployeeByLogin(string userName, string password)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();

            string sql = @"
        SELECT e.EmployeeId, e.FirstName, e.LastName, e.JobId
        FROM Employees e
        INNER JOIN Users u ON e.EmployeeId = u.EmployeeId
        WHERE u.UserName = @UserName AND u.Password = @Password";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@UserName", userName);
            cmd.Parameters.AddWithValue("@Password", password);

            SqlDataReader reader = cmd.ExecuteReader();

            Employee emp = null;

            if (reader.Read())
            {
                emp = new Employee
                {
                    EmployeeId = Convert.ToInt32(reader["EmployeeId"]),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    JobId = Convert.ToInt32(reader["JobId"])
                };
            }

            conn.Close();
            return emp;
        }

    }
}

