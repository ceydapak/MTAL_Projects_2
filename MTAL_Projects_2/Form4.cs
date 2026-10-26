using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTAL_Projects_2
{
    public partial class Form4 : Form
    {
        //Orta Seviye Form
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ay = comboBox1.Text;

            if(ay == "Ocak" || ay == "Aralık" || ay == "Şubat")
            {
                label2.Text = "Mevsim: Kış";
            }
            else if(ay == "Mart" || ay == "Mayıs" || ay == "Nisan" )
            {
                label2.Text = "Mevsim: Bahar";
            }
            else if( ay == "Haziran" || ay == "Temmuz" || ay == "Ağustos")
            {
                label2.Text = "Mevsim: Yaz";
            }
            else if (ay == "Eylül" || ay == "Ekim" || ay == "Kasım")
            {
                label2.Text = "Mevsim: Kış";
            }
            else
            {
                label2.Text = "Lütfen geçerli bir ay seçiniz.";
            }
        }
    }
}
