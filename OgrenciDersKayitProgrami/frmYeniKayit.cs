using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OgrenciDersKayitProgrami
{
    public partial class frmYeniKayit : Form
    {
        public frmYeniKayit()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-SINNOVD9;Initial Catalog=dbOgrKayit;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            //kayıt komutu
            SqlCommand komut = new SqlCommand("insert into tblOgrenci (ad,soyad,dtarih,adres,tel,dersAdi,ortalama) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", con);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", msDTarih.Text);
            komut.Parameters.AddWithValue("@p4", txtAdres.Text);
            komut.Parameters.AddWithValue("@p5", msTelefon.Text);
            komut.Parameters.AddWithValue("@p6", comboBox1.SelectedValue);
            komut.Parameters.AddWithValue("@p7", txtOrtalama.Text);

            komut.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Yeni Kayit Tamam", " Kayıt Ekranı");

            txtAd.Text = "";
            txtSoyad.Text = "";
            msDTarih.Text = "";
            txtAdres.Text = "";
            msTelefon.Text = "";
            comboBox1.Text = "";
            txtOrtalama.Text = "";
        }

        private void frmYeniKayit_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tblDers1", con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);

            comboBox1.DisplayMember = "dersAdi";
            comboBox1.ValueMember = "dersKodu";
            comboBox1.DataSource = tablo;
        }
    }
}
