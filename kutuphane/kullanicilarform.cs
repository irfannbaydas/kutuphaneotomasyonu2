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
    public partial class kullanicilarform : Form
    {
        public kullanicilarform()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            kutuphaneEntities db = new kutuphaneEntities();
            var kulveri = db.kulveri.ToList();
            dataGridView1.DataSource = kulveri.ToList();

        }

        private void kullanicilarform_Load(object sender, EventArgs e)
        {
            Listele();
        }
       
    }
}
