using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarismasi
{
    public partial class KelimeGecis : Form
    {
        public KelimeGecis()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        int time = 6;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            btnBasla.Text = time.ToString();
           
            if(time==0)
            {
                timer1.Enabled = false;
                Form1 frm = new Form1();
                frm.Show();
                this.Close();
            }
            
        }
    }
}
