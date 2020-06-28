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
    public class Questions
    {
        public Datas getRandomQuestion()
        {
            Datas data = null;
            Provider prv = new Provider();
            SqlConnection con = prv.getSqlConnection();

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM BilgiDB order by NEWID()", con);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Datas> dataList = new List<Datas>();

            if (reader != null)
            {
                while (reader.Read())
                {
                    data = new Datas()
                    {
                        ChA = (reader["a"].ToString()),
                        ChB = (reader["b"].ToString()),
                        ChC = (reader["c"].ToString()),
                        ChD = (reader["d"].ToString()),
                        Question = (reader["Soru"].ToString()),
                        ExSentence = (reader["OrnekCumle"].ToString()),
                        correctAnswer = (reader["dogruCevap"].ToString()),
                        Id=(reader["ID"].ToString())
                };
             
                }
            }
            con.Close();

            return data;

        }

        public Datas getRandomQuestionId()
        {
            Datas data = null;
            Provider prv = new Provider();
            SqlConnection con = prv.getSqlConnection();

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM BilgiDB  Where sayi=@sayii order by NEWID()", con);
            cmd.Parameters.AddWithValue("@sayii", 1);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Datas> dataList = new List<Datas>();

            if (reader != null)
            {
                while (reader.Read())
                {
                    data = new Datas()
                    {
                        ChA = (reader["a"].ToString()),
                        ChB = (reader["b"].ToString()),
                        ChC = (reader["c"].ToString()),
                        ChD = (reader["d"].ToString()),
                        Question = (reader["Soru"].ToString()),
                        ExSentence = (reader["OrnekCumle"].ToString()),
                        correctAnswer = (reader["dogruCevap"].ToString()),
                        Id = (reader["ID"].ToString())
                    };

                }
            }
            con.Close();

            return data;

        }
    }
}
