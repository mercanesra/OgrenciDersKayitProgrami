using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciDersKayitProgrami
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmYeniKayit fr = new frmYeniKayit();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmListele frm = new frmListele();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSil sil = new frmSil();
            sil.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmBul frm = new frmBul();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmEnYuksekBul frm = new frmEnYuksekBul();
            frm.Show();
        }
    }
}
