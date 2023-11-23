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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("Data Source=LAPTOP-SINNOVD9;Initial Catalog=dbOgrKayit;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("select *from tblGiris where kullaniciAdi='" + txtKAdi.Text + "' and parola='" + txtParola.Text + "'",con);
            con.Open();
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read()) //kullanıcının girdiği adres doğruysa 
            {
                Form2 f2 = new Form2(); //yeni form sayfası açalım
                f2.Show();
            }
            else
            
                MessageBox.Show("Hatalı kullanıcı Adı ve parola", "Giriş ekranı" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKAdi.Text = "";
                txtParola.Text = "";
                con.Close();
            


         



            

        }
    }
}
