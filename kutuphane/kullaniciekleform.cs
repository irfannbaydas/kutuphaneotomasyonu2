using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane
{
    public partial class kullaniciekleform : Form
    {
        public kullaniciekleform()
        {
            InitializeComponent();
        }
        kutuphaneEntities db = new kutuphaneEntities();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kulveri kullanicilar=new kulveri();
            kullanicilar.kul_ad = kuladtxt.Text;
            kullanicilar.kul_soyad=kulsoyadtxt.Text;
            kullanicilar.kul_tc=kultctxt.Text;
            kullanicilar.kul_tel=kulteltxt.Text;

            db.kulveri.Add(kullanicilar);
            db.SaveChanges();
            Listele();
        }
        public void Listele()
        {
           
            var kulveri = db.kulveri.ToList();
            dataGridView1.DataSource = kulveri.ToList();

        }

        private void kullaniciekleform_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
