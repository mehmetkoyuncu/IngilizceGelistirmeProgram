using BilgiYarismasi.DatasFolder;
using BilgiYarismasi.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string trueAnswer = null;
        int score = 0;
        int time;
        int question = 1;
        int chanceOfError = 3;


        private void Form1_Load(object sender, EventArgs e)
        {
            time = 20;
            question = 1;
            timer1.Enabled = true;

            //Soru Geçmeyi Engelle
            pictureBox1.Enabled = false;
            pictureBox1.Enabled = false;

            //Random Veri Getir
            Questions datas = new Questions();
            Datas gotData = datas.getRandomQuestion();
            btnA.Text = gotData.ChA;
            btnB.Text = gotData.ChB;
            btnC.Text = gotData.ChC;
            btnD.Text = gotData.ChD;
            lblSoru.Text = gotData.Question;
            lblOrnekCumle.Text = gotData.ExSentence;
            trueAnswer = gotData.correctAnswer;


            //En Yüksek Puanı Yazdırma
            Record record = new Record();
            BestScore bs = record.getBestScore();
            lblYuksekPuan.Text = bs.RecordPoint;



        }


        //Örnek Cümle Gösterilmesi
        private void label1_Click(object sender, EventArgs e)
        {
            lblOrnekCumle.Visible = true;
        }


        //A Şıkkı İçin Doğruluk Kontrolü
        private void btnA_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Enabled == false)
            {
                pictureBox1.Enabled = true;
            }
            if (trueAnswer == btnA.Text)
            {
                btnA.Image = null;
                btnA.BackColor = Color.Green;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                score += 10;
                lkgkgk.Text = score.ToString();
            }
            else
            {
                btnA.Image = null;
                btnA.BackColor = Color.Red;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                score -= 5;
                lkgkgk.Text = score.ToString();
                chanceOfError -= 1;
                lblHak.Text = chanceOfError.ToString();
            }




        }

        //B Şıkkı İçin Doğruluk Kontrolü
        private void btnB_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Enabled == false)
            {
                pictureBox1.Enabled = true;
            }
            if (trueAnswer == btnB.Text)
            {
                btnB.Image = null;
                btnB.BackColor = Color.Green;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                score += 10;
                lkgkgk.Text = score.ToString();

            }
            else
            {
                btnB.Image = null;
                btnB.BackColor = Color.Red;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                score -= 5;
                lkgkgk.Text = score.ToString();
                chanceOfError -= 1;
                lblHak.Text = chanceOfError.ToString();
            }


        }

        //C Şıkkı İçin Doğruluk Kontrolü
        private void btnC_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Enabled == false)
            {
                pictureBox1.Enabled = true;
            }
            if (trueAnswer == btnC.Text)
            {
                btnC.Image = null;
                btnC.BackColor = Color.Green;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                score += 10;
                lkgkgk.Text = score.ToString();
            }
            else
            {
                btnC.Image = null;
                btnC.BackColor = Color.Red;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                score -= 5;
                lkgkgk.Text = score.ToString();
                chanceOfError -= 1;
                lblHak.Text = chanceOfError.ToString();
            }
        }

        //D Şıkkı İçin Doğruluk Kontrolü
        private void btnD_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Enabled == false)
            {
                pictureBox1.Enabled = true;
            }

            if (trueAnswer == btnD.Text)
            {
                btnD.Image = null;
                btnD.BackColor = Color.Green;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                score += 10;
                lkgkgk.Text = score.ToString();
            }
            else
            {
                btnD.Image = null;
                btnD.BackColor = Color.Red;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                score -= 5;
                lkgkgk.Text = score.ToString();
                chanceOfError -= 1;
                lblHak.Text = chanceOfError.ToString();
            }

        }

        //Soru Geçilmesi Halinde
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                string idd = null;

                //10. soruya gelindiğinde extra hak kazanılır.
                if (question == 10)
                {
                    btnXhak.Visible = true;
                }

                //Gerekli işlemler yapılır.
                timer1.Start();
                pictureBox1.Enabled = false;
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnA.Image = btnOrtak.Image;
                btnB.Image = btnOrtak.Image;
                btnC.Image = btnOrtak.Image;
                btnD.Image = btnOrtak.Image;
                time = 20;


                //Random Veri Getir-Tekrarsız
                Questions datas = new Questions();
                Datas gotData = datas.getRandomQuestionId();
                btnA.Text = gotData.ChA;
                btnB.Text = gotData.ChB;
                btnC.Text = gotData.ChC;
                btnD.Text = gotData.ChD;
                lblSoru.Text = gotData.Question;
                lblOrnekCumle.Text = gotData.ExSentence;
                trueAnswer = gotData.correctAnswer;
                idd = gotData.Id;


                //Tekrar ile sayi degiskenini 0'a çevirme
                Repeat rpt = new Repeat();
                rpt.BlockRepeatWithId(idd);

                //Rekor kırıldı ise veriyi güncelleme
                Record rcd = new Record();
                rcd.ChangeRecord(score);

                //En Yüksek Puanı Yazdırma
                Record record = new Record();
                BestScore bs = record.getBestScore();
                lblYuksekPuan.Text = bs.RecordPoint;



                //Soruya Göre Zaman Değişkenini Arttırma
                question++;
                if (question >= 5 && question <= 10)
                {
                    time = 30;
                }
                if (question > 10 && question <= 20)
                {
                    time = 40;
                }
                if (question > 20 && question < 30)
                {
                    time = 50;
                }
                if (question > 30)
                {
                    time = 60;
                }

                lblSoruSiralama.Text = question.ToString();

            }


            catch (Exception)
            {
                MessageBox.Show("Sorularımız Bu Kadar :)");
                timer1.Enabled = false;
                this.Close();
                Giris grs = new Giris();
                grs.Show();

                //Tekrar ile sayi degiskenini 1'e çevirme
                Repeat repeat = new Repeat();
                repeat.RepeatFinishGame();
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            //Zaman bittiğinde yapılacak işlemler
            if (time == 1)
            {
                chanceOfError -= 1;
                lblHak.Text = chanceOfError.ToString();
                timer1.Stop();
                pictureBox1.Enabled = true;
            }

            //Zamanı Yazdırma
            time--;
            lblZaman.Text = time.ToString();


            //Hata Hakkı Bittiğinde Uygulanacak Olaylar
            if (chanceOfError == 0)
            {
                //Tekrar ile sayi degiskenini 1'e çevirme
                Repeat repeat = new Repeat();
                repeat.RepeatFinishGame();
                timer1.Enabled = false;
                Loose lose = new Loose();
                lose.ShowDialog();
                this.Close();
            }



        }

        private void btnJoker_Click(object sender, EventArgs e)
        {
            //Çifte Şans Hakkı
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            Random r = new Random();
            int rastgele = r.Next(2, 5);

            //A Şıkkı Doğru ise 
            if (btnA.Text == trueAnswer)
            {
                if (rastgele == 2)
                {
                    btnB.Enabled = true;
                }
                if (rastgele == 3)
                {
                    btnC.Enabled = true;
                }
                if (rastgele == 4)
                {
                    btnD.Enabled = true;
                }
                btnA.Enabled = true;
            }


            //B Şıkkı Doğru ise 
            if (btnB.Text == trueAnswer)
            {
                if (rastgele == 2)
                {
                    btnA.Enabled = true;
                }
                if (rastgele == 3)
                {
                    btnC.Enabled = true;
                }
                if (rastgele == 4)
                {
                    btnD.Enabled = true;
                }
                btnB.Enabled = true;
            }

            //C Şıkkı Doğru ise 
            if (btnC.Text == trueAnswer)
            {
                if (rastgele == 2)
                {
                    btnB.Enabled = true;
                }
                if (rastgele == 3)
                {
                    btnA.Enabled = true;
                }
                if (rastgele == 4)
                {
                    btnD.Enabled = true;
                }
                btnC.Enabled = true;
            }

            //D Şıkkı Doğru ise 
            if (btnD.Text == trueAnswer)
            {
                btnD.Enabled = true;

                if (rastgele == 2)
                {
                    btnB.Enabled = true;
                }
                if (rastgele == 3)
                {
                    btnC.Enabled = true;
                }
                if (rastgele == 4)
                {
                    btnA.Enabled = true;
                }
            }
            btnJoker.BackgroundImage = null;
            btnJoker.Enabled = false;
            btnJoker.BackColor = Color.Gray;
        }


        private void btnExtraZaman_Click(object sender, EventArgs e)
        {
            //Extra zaman hakkı için 20 saniye eklenir.
            time += 20;
            btnExtraZaman.BackgroundImage = null;
            btnExtraZaman.Enabled = false;
            btnExtraZaman.BackColor = Color.Gray;

        }

        private void btnXhak_Click(object sender, EventArgs e)
        {
            //Extra Hak Verilmesi
            chanceOfError += 1;
            lblHak.Text = chanceOfError.ToString();
            btnXhak.BackgroundImage = null;
            btnXhak.Enabled = false;
            btnXhak.BackColor = Color.Gray;
        }


    }
}
