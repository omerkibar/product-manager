using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager
{
    class MsSql : IDatabase
    {
        string connString = @"server=(localdb)\MSSQLLocalDB;initial catalog=ETrade;integrated security=true";
        void ConnectionControl(SqlConnection connection)
        {
            if (connection.State==ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public List<Product> GetProducts()
        {
            using (SqlConnection _connection = new SqlConnection(connString))
            {
                ConnectionControl(_connection);
                SqlCommand command = new SqlCommand("Select * from Products", _connection);
                SqlDataReader reader = command.ExecuteReader();
                List<Product> products = new List<Product> { };
                while (reader.Read())
                {
                    Product product = new Product
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Price = Convert.ToDecimal(reader["Price"]),
                        StockAmount = Convert.ToInt32(reader["StockAmount"])
                    };
                    products.Add(product);
                }
                reader.Close();
                _connection.Close();
                return products;
            }  
        }
        public void Add(Product product)
        {
            using (SqlConnection _connection = new SqlConnection(connString))
            {
                ConnectionControl(_connection);
                SqlCommand command = new SqlCommand("Insert into Products values(@name,@price,@stockamount)", _connection);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@StockAmount", product.StockAmount);
                command.ExecuteNonQuery();
                _connection.Close();
            }
        }
        public void Update(Product product)
        {
            using (SqlConnection _connection = new SqlConnection(connString))
            {
                ConnectionControl(_connection);
                SqlCommand command = new SqlCommand("Update Products set Name=@name,Price=@price,StockAmount=@stockAmount where Id=@id", _connection);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
                command.Parameters.AddWithValue("@id", product.Id);
                command.ExecuteNonQuery();
                _connection.Close();
            }           
        }
        public void Delete(int id)
        {
            using (SqlConnection _connection = new SqlConnection(connString))
            {
                ConnectionControl(_connection);
                SqlCommand command = new SqlCommand("Delete from Products where Id=@id", _connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                _connection.Close();
            }      
        }       
    }
}
