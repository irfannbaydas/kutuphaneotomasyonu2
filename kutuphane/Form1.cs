using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane
{
    public partial class Kütüphane : Form
    {
        kutuphaneEntities db = new kutuphaneEntities();
        public Kütüphane()
        {
            InitializeComponent();
        }

        private void personelGirisbtn_Click(object sender, EventArgs e)
        {
            string gelenAd = adGiristxt.Text;
            string gelenSifre = sifreGiristxt.Text;

            {
                if (gelenAd.Equals("admin"))
                {
                    
                    IslemPaneli panel = new IslemPaneli();
                    panel.Show();
                    this.Hide();

                }
                
            }

                }
                private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
