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
    public partial class kulsilform : Form
    {
        public kulsilform()
        {
            InitializeComponent();
        }
        kutuphaneEntities db = new kutuphaneEntities();
        public void Listele()
        {

            var kulveri = db.kulveri.ToList();
            dataGridView1.DataSource = kulveri.ToList();

        }
        private void kulsilform_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
