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
            get
            {
                if (instance == null)
                    instance = new DataProvider();

                return instance;
            }
            private set => instance = value;
        }

        private DataProvider() { }

        // Chuỗi kết nối SQL Server
        private string connectionString =
            @"Data Source=LAPTOP-913G3QCS;Initial Catalog=QuanLyCaPhe;Integrated Security=True;TrustServerCertificate=True";

        // Hàm lấy kết nối dùng chung
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Hàm truy vấn dữ liệu
        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }

            return data;
        }
    }
}