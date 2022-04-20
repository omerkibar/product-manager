using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager
{
    static class Utilities
    {
        public static bool ProductValidation(string Name,string Price,string StockAmount)
        {
            try
            {
                if (Convert.ToDecimal(Price)>0 && Convert.ToInt32(StockAmount)>0 && Name.Length>0)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }
        public static IDatabase GetDatabase(string databaseType)
        {
            if (databaseType == "MySQL")
            {
                return new MySql();
            }
            else if (databaseType == "MSSQL")
            {
                return new MsSql();
            }
            return null;
        }
    }
}
