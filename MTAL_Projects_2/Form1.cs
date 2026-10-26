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
{   //Kolay örnek formu
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
           
            int yas = Convert.ToInt32(textBox1.Text);
            int sinavNotu = Convert.ToInt32(textBox2.Text);

            if (yas >= 18)
            {
                if (sinavNotu >= 70)
                {
                    MessageBox.Show("Tebrikler, ehliyet almaya hak kazandınız.");
                }
                else
                {
                    MessageBox.Show("Yaşınız tutuyor ancak sınav notunuz yetersiz.");
                }
            }
            else
            {
                MessageBox.Show("Ehliyet almak için yaşınız henüz tutmuyor.");
            }
        
    }
    }
}
