using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciDersKayitProgrami
{
    public partial class frmBul : Form
    {
        public frmBul()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-SINNOVD9;Initial Catalog=dbOgrKayit;Integrated Security=True");
        void listele()
        {
            SqlCommand komut = new SqlCommand("select OgrNo as 'NUMARA', ad as 'AD' ,soyad as 'SOYAD', dtarih as 'D.TARİH', adres as 'ADRES', tel as 'TELEFON', dersAdi as 'Ders ADI', ortalama as'ORTALAMA' from  tblOgrenci", con); //kayıtlı öğrencileri listeleyeceğiz 
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void frmBul_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numara = Convert.ToInt32(textBox1.Text);

            SqlCommand komut = new SqlCommand("select OgrNo as 'NUMARA', ad as 'AD' ,soyad as 'SOYAD', dtarih as 'D.TARİH', adres as 'ADRES', tel as 'TELEFON', dersAdi as 'Ders ADI', ortalama as'ORTALAMA' from  tblOgrenci where ogrNo='"+ numara + "'", con); //kayıtlı öğrencileri listeleyeceğiz 
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }
    }
}
