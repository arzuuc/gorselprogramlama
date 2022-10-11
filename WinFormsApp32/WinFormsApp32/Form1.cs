using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int vize, final, ortalama;
                vize = Convert.ToInt32(numericUpDown1.Value);
                final = Convert.ToInt32(numericUpDown2.Value);
                if (vize<=100 && final<=100)
                {
                    ortalama = Convert.ToInt32(vize * 0.4 + final * 0.6);
                    label4.Text = ortalama.ToString();
                    if (ortalama < 50 || final < 50)
                    {
                        label7.Text = "kaldı";
                        label7.ForeColor = Color.Red;
                    }
                    else
                    {
                        label7.Text = "geçti";
                        label7.ForeColor = Color.Green;
                    }
                    if (ortalama >= 0 && ortalama <= 49)
                    {
                        label6.Text = "FF";
                        label6.ForeColor = Color.Red;
                    }
                    else if (ortalama >= 50 && ortalama <= 54)
                    {
                        label6.Text = "DD";
                        label6.ForeColor = Color.Green;
                    }
                    else if (ortalama >= 55 && ortalama <= 59)
                    {
                        label6.Text = "DC";
                        label6.ForeColor = Color.Green;
                    }
                    else if (ortalama >= 60 && ortalama <= 69)
                    {
                        label6.Text = "CC";
                        label6.ForeColor = Color.Green;
                    }
                    else if (ortalama >= 70 && ortalama <= 74)
                    {
                        label6.Text = "CB";
                        label6.ForeColor = Color.Green;
                    }
                    else if (ortalama >= 75 && ortalama <= 79)
                    {
                        label6.Text = "BB";
                        label6.ForeColor = Color.Green;
                    }
                    else if (ortalama >= 80 && ortalama <= 84)
                    {
                        label6.Text = "BA";
                        label6.ForeColor = Color.Green;
                    }
                    else if (ortalama >= 85 && ortalama <= 100)
                    {
                        label6.Text = "AA";
                        label6.ForeColor = Color.Green;
                    }
                }
                
            }
            catch (Exception)
            {
                if (numericUpDown1.Value > 100 && numericUpDown2.Value > 100)
                {
                    MessageBox.Show("bir hata oluştu lütfen yeniden deneyiniz :D");
                }
            }
        }
    }
}
