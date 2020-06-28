using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiYarismasi.DataProvider
{
   public class Provider
    {
        public SqlConnection con { get; set; }
        public SqlConnection getSqlConnection()
        {
            con = new SqlConnection(@"Server=DESKTOP-M3RNR2G;Database=bilgiYarismasiDB;Trusted_Connection=True");
            return con;
        }
    }
}
