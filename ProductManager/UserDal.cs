using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager
{
    class UserDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=ETrade;integrated security=true");
        void ConnectionControl(SqlConnection connection)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public string Login(User user)
        {
            ConnectionControl(_connection);
            SqlCommand command = new SqlCommand("Select * from Users", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<User> users = new List<User> { };
            while (reader.Read())
            {
                User temp_user = new User { Username = reader["Username"].ToString(), Password = reader["Password"].ToString(), DatabaseType = reader["DatabaseType"].ToString() };
                users.Add(temp_user);
            }
            reader.Close();
            _connection.Close();
            User user1 = users.FirstOrDefault(p => p.Username == user.Username && p.Password == user.Password);
            if (user1 == null)
            {
                return "";
            }
            else
            {
                return user1.DatabaseType;
            }          
        }
        public void Register(User user)
        {
            ConnectionControl(_connection);
            SqlCommand command = new SqlCommand("Insert into Users values(@username,@password,@databaseType)", _connection);
            command.Parameters.AddWithValue("@username",user.Username);
            command.Parameters.AddWithValue("@password", user.Password);
            command.Parameters.AddWithValue("@databaseType", user.DatabaseType);
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
