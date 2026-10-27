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
    //Zor Seviye Form
    //Yeni commit
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Alanlar boş bırakılamaz!");
            }
            else
            {
                double bakiye = Convert.ToDouble(textBox1.Text);
                double cekilecekTutar = Convert.ToDouble(textBox2.Text);
               

                if (cekilecekTutar <= bakiye && cekilecekTutar <= 5000)
                {
                    MessageBox.Show("İşlem Başarılı! Paranızı alabilirsiniz.");
                }
                else
                {
                    MessageBox.Show("Yetersiz bakiye veya limit aşıldı.");
                }
            }
        
    }
    }
}
