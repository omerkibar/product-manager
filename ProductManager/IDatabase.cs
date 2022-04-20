using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager
{
    interface IDatabase
    {
        List<Product> GetProducts();
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}
