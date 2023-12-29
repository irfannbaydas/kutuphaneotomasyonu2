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
            Kullanicieklebtn.Visible = false;
            Kullaniciguncellebtn.Visible = false;
            Kullanicisilbtn.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Kullanicieklebtn.Visible == false)
            {
                Kullanicieklebtn.Visible = true;
                Kullaniciguncellebtn.Visible = true;
                Kullanicisilbtn.Visible = true;
            }

            else
            {
                Kullanicieklebtn.Visible = false;
                Kullaniciguncellebtn.Visible = false;
                Kullanicisilbtn.Visible = false;
            }
        }

       
        }
    }

