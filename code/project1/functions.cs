using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class DatabaseHelper
    {
        private string connectionString; // Replace with your actual connection string

        public DatabaseHelper(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error executing query: {ex.Message}");
                // You might want to handle the exception according to your application's needs
            }

            return dataTable;
        }
    }

    internal class functions
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader rdr;
        private string conString;

        public string MyConnection()
        {
            conString = "Data Source=HUZAIFA_MALIK\\SQLEXPRESS;Initial Catalog=TAManagmentSys;Integrated Security=True";
            return conString;
        }
        public int insertIntoDB(string query)
        {
            string connectionString = "Data Source=HUZAIFA_MALIK\\SQLEXPRESS;Initial Catalog=TAManagmentSys;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdd = new SqlCommand(query, conn);
            int res = cmdd.ExecuteNonQuery();
            conn.Close();

            return res;

            //    con=new SqlConnection(MyConnection());
            //    cmd = new SqlCommand(query,con);
            //    con.Open();
            //    int check=cmd.ExecuteNonQuery();
            //    return check;


        }

        public void changePassword(string username, string newPassword)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE credential SET password = @NewPassword WHERE username = @Username";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Use parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@NewPassword", newPassword);
                        command.Parameters.AddWithValue("@Username", username);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Password updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("User not found or password not updated.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the update process
                Console.WriteLine($"Error: {ex.Message}");
            }
        }


        public bool isValidLogin(string query)
        {
            return false;

        }
        public string getOneValue(string query, string ColumnName)
        {
            string connectionString = "Data Source=HUZAIFA_MALIK\\SQLEXPRESS;Initial Catalog=TAManagmentSys;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            string data = "";
            if (dr.HasRows)
            {
                dr.Read();
                if (dr.GetOrdinal(ColumnName) != -1)
                {
                    data = dr[ColumnName].ToString();
                }
                else
                {
                    // Handle the case where the column doesn't exist
                    MessageBox.Show($"Column '{ColumnName}' not found in the result set.");
                    data = string.Empty; // Or handle it according to your requirements
                }
                
            }
            else
            {
                MessageBox.Show("NO data");
            }
            return data;


        }

        //public string GetOneValue(string query, string columnName)
        //{
        //    string connectionString = "Data Source=HUZAIFA_MALIK\\SQLEXPRESS;Initial Catalog=TAManagmentSys;Integrated Security=True";

        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {
        //        con.Open();

        //        using (SqlCommand cmd = new SqlCommand(query, con))
        //        {
        //            using (SqlDataReader dr = cmd.ExecuteReader())
        //            {
        //                if (dr.HasRows)
        //                {
        //                    dr.Read();
        //                    return dr[columnName].ToString();
        //                }
        //                else
        //                {
        //                    MessageBox.Show("No data");
        //                    // Consider throwing an exception or handling the lack of data in a different way.
        //                    return string.Empty; // Return an appropriate default value.
        //                }
        //            }
        //        }
        //    }
        //}


        public string getcourseCode(string query)
        {
            string connectionString = "Data Source=HUZAIFA_MALIK\\SQLEXPRESS;Initial Catalog=TAManagmentSys;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            string data = "";
            if (dr.HasRows)
            {
                dr.Read();
                data = dr["course_code"].ToString();
            }
            else
            {
                MessageBox.Show("NO data");
            }
            return data;

        }
    }
}
