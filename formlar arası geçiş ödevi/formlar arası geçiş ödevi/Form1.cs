using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formlar_arası_geçiş_ödevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string kullaniciadi = "arzu";
        string sifre = "2244";
        int sayac = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            if (textBox1.Text == kullaniciadi && textBox2.Text == sifre)
            {

                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }
            else
            {
                sayac++;
                MessageBox.Show("KULLANICI ADI VEYA ŞİFRE YANLIŞ","HATA ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (sayac==3)
                {
                    Application.Exit();
                }
            }
        }
    }
}
