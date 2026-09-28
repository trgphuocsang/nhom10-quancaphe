using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace QuanLyCaPhe
{
    public class DataProvider
    {
        private static DataProvider? instance = null;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set => instance = value;
        }

        private DataProvider() { }

        // Chuỗi kết nối gắn chuẩn tên Server của bạn
        private string connectionString = @"Data Source=LAPTOP-913G3QCS;Initial Catalog=QuanLyCaPhe;Integrated Security=True;TrustServerCertificate=True";

        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }

            return data;
        }
    }
}