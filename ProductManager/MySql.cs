using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager
{
    class MySql : IDatabase
    {
        MySqlConnection _connection = new MySqlConnection("Server=localhost;user=root;pwd=root;database=etradeproject");
        void ConnectionControl(MySqlConnection _connection)
        {
            if (_connection.State==ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public List<Product> GetProducts()
        {
            using (_connection)
            {
                ConnectionControl(_connection);
                MySqlCommand command = new MySqlCommand("Select * from product", _connection);
                MySqlDataReader reader = command.ExecuteReader();
                List<Product> products = new List<Product> { };
                while (reader.Read())
                {
                    Product product = new Product
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Name = reader["name"].ToString(),
                        Price = Convert.ToDecimal(reader["price"]),
                        StockAmount = Convert.ToInt32(reader["stockamount"])
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
            using (_connection)
            {
                ConnectionControl(_connection);
                MySqlCommand command = new MySqlCommand("Insert into product values(@id,@name,@price,@stockamount)", _connection);
                command.Parameters.AddWithValue("@id", product.Id);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
                command.ExecuteNonQuery();
                _connection.Close();
            }
            
        }
        public void Delete(int id)
        {
            using (_connection)
            {
                ConnectionControl(_connection);
                MySqlCommand command = new MySqlCommand("Delete from product where Id=@id", _connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                _connection.Close();
            }
            
        }
        public void Update(Product product)
        {
            using (_connection)
            {
                ConnectionControl(_connection);
                MySqlCommand command = new MySqlCommand("Update product set Name=@name,Price=@price,StockAmount=@stockamount where Id=@id", _connection);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@stockamount", product.StockAmount);
                command.Parameters.AddWithValue("@id", product.Id);
                command.ExecuteNonQuery();
                _connection.Close();
            }   
        }
    }
}
