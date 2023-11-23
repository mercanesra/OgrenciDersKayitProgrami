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
    public partial class frmSil : Form
    {
        public frmSil()
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
        private void frmSil_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numara = Convert.ToInt32(textBox1.Text);
            SqlCommand komut = new SqlCommand("delete tblOgrenci where ogrNo= '" + numara + "'", con);

            con.Open();
            int sonuc = komut.ExecuteNonQuery();
            if (sonuc > 0)
            {
                MessageBox.Show("Kayt silindi", "Silme ekranı");
            }
            else
                MessageBox.Show("Kayıt silinemedi", "Silme ekranı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            textBox1.Text = "";
            con.Close();
            listele();
        }

    }
}
