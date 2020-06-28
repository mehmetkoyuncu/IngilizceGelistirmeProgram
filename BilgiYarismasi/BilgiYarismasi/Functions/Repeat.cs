using BilgiYarismasi.DataProvider;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiYarismasi.Functions
{
    public class Repeat
    {
        Provider ptv = new Provider();

        //public void BlockRepeat()
        //{
        //    SqlConnection con = ptv.getSqlConnection();
        //    SqlCommand cmdInsert = new SqlCommand("UPDATE BilgiDB SET sayi=1 where sayi=@sifir ", con);
        //    con.Open();
        //    cmdInsert.Parameters.AddWithValue("sifir", 0);
        //    cmdInsert.ExecuteNonQuery();
        //    con.Close();
        //}
        public void BlockRepeatWithId(string id)
        {
            SqlConnection con = ptv.getSqlConnection();
            SqlCommand cmdInsert = new SqlCommand("UPDATE BilgiDB SET sayi=0 WHERE ID=@iddd ", con);
            con.Open();
            cmdInsert.Parameters.AddWithValue("iddd", id);
            cmdInsert.ExecuteNonQuery();
            con.Close();
        }
        public void RepeatFinishGame()
        {
            SqlConnection con = ptv.getSqlConnection();
            SqlCommand cmdInsert = new SqlCommand("UPDATE BilgiDB SET sayi=1 where sayi=@red ", con);
            con.Open();
            cmdInsert.Parameters.AddWithValue("red", 0);
            cmdInsert.ExecuteNonQuery();
            con.Close();

        }
    }
}

