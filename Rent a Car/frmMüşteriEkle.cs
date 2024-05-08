using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rent_a_Car
{
    public partial class frmMüşteriEkle : Form
    {

        Araç_Kiralama arac_kiralama = new Araç_Kiralama();


        public frmMüşteriEkle()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string cümle = "insert into musteri(tc,adsoyad,telefon,adres,email) values (@tc,@adsoyad,@telefon,@adres,@email)";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.AddWithValue("@tc", txtTc.Text);
                komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
                komut2.Parameters.AddWithValue("@email", txtEmail.Text);
                arac_kiralama.ekl_sil_güncelle(komut2, cümle);
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                MessageBox.Show("İşlem Başarılı", "Bilgilerndirme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           

        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString();
        }

        private void frmMüşteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
