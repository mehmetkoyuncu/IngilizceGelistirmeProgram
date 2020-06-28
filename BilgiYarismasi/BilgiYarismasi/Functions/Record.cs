using BilgiYarismasi.DataProvider;
using BilgiYarismasi.DatasFolder;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiYarismasi.Functions
{
    public class Record
    {
        Provider prv = new Provider();
        public BestScore  getBestScore()
        {
            SqlConnection con = prv.getSqlConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select EnYuksekPuan From Puan", con);
            SqlDataReader reader = cmd.ExecuteReader();
            BestScore bestScore = null;
            if (reader != null)
            {
                while (reader.Read())
                {
                    bestScore = new BestScore();
                    bestScore.RecordPoint = (reader["EnYuksekPuan"].ToString());
                }
            }
            con.Close();

            return bestScore;

       
        }
        public void ChangeRecord(int score)
        {
            SqlConnection con = prv.getSqlConnection();
            SqlCommand cmdIns = new SqlCommand("UPDATE Puan SET EnYuksekPuan=@puan WHERE EnYuksekPuan<@puan", con);

            cmdIns.Parameters.AddWithValue("puan", score);
            con.Open();
            int KayitSayisi = cmdIns.ExecuteNonQuery();
        }
    }
}
