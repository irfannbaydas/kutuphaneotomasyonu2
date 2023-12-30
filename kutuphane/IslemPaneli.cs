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
    public partial class IslemPaneli : Form
    {
        public IslemPaneli()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }
        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            kuleklebtn.Visible = false;
            Kullaniciguncellebtn.Visible = false;
            Kullanicisilbtn.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (kuleklebtn.Visible == false)
            {
                kuleklebtn.Visible = true;
                Kullaniciguncellebtn.Visible = true;
                Kullanicisilbtn.Visible = true;
            }

            else
            {
                kuleklebtn.Visible = false;
                Kullaniciguncellebtn.Visible = false;
                Kullanicisilbtn.Visible = false;
            }
            kullanicilarform klisteform=new kullanicilarform();
            klisteform.MdiParent = this;
            klisteform.Show();
            }

        private void kuleklebtn_Click(object sender, EventArgs e)
        {
            kullaniciekleform ekleform = new kullaniciekleform();
            ekleform.MdiParent = this;
            ekleform.Show();
        }
    }
    }

