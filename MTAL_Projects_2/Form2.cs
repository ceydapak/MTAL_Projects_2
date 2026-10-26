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
    //Kolay Örnek Formu
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int saat = Convert.ToInt32(textBox1.Text);
            int ucret = 0;

            if (saat <= 1)
            {
                ucret = 50;
            }
            else if (saat > 1 && saat <= 4)
            {
                ucret = 50 + (saat - 1) * 40;
            }
            else
            {
                ucret = 150;
            }

            MessageBox.Show("Ödenecek Toplam Otopark Ücreti: " + ucret + " TL");
        }
    }
}
