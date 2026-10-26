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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int parlaklik = trackBar1.Value;

            if (parlaklik == 0)
            {
                label1.Text = "Ekran Kapalı / Siyah Mod";
                label1.ForeColor = Color.Black;
            }
            else if (parlaklik > 0 && parlaklik <= 5)
            {
                label1.Text = "Normal Parlaklık Seviyesi";
                label1.ForeColor = Color.Green;
            }
            else
            {
                label1.Text = "Yüksek Parlaklık (Göz Yorabilir)";
                label1.ForeColor = Color.Red;
            }
        }
    }
}
