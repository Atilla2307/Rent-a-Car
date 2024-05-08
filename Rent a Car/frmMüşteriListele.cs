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
    public partial class frmMüşteriListele : Form
    {


        Araç_Kiralama arackkiralama = new Araç_Kiralama();


        public frmMüşteriListele()
        {
            InitializeComponent();
        }

        private void frmMüşteriListele_Load(object sender, EventArgs e)
        {
            YenileListele();
        }

        public void YenileListele()
        {
            try
            {
                string cümle = "select * from musteri";
                SqlDataAdapter adtr2 = new SqlDataAdapter();
                dataGridView1.DataSource = arackkiralama.listele(adtr2, cümle);

                dataGridView1.Columns[0].HeaderText = "TC No";
                dataGridView1.Columns[1].HeaderText = "Ad Soyad";
                dataGridView1.Columns[2].HeaderText = "Telefon";
                dataGridView1.Columns[3].HeaderText = "Adres";
                dataGridView1.Columns[4].HeaderText = "E-Mail";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label7.Text = DateTime.Now.ToString();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string cümle = "select * from musteri where tc like '%" + txtAra.Text + "%'";
                SqlDataAdapter adtr2 = new SqlDataAdapter();
                dataGridView1.DataSource = arackkiralama.listele(adtr2, cümle);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string cümle = "update musteri set adsoyad=@adsoyad , telefon=@telefon , adres=@adres , email=@email where tc=@tc";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.AddWithValue("@tc", txtTc.Text);
                komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
                komut2.Parameters.AddWithValue("@email", txtEmail.Text);
                arackkiralama.ekl_sil_güncelle(komut2, cümle);
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                YenileListele();
                MessageBox.Show("İşlem Başarılı", "Bilgilerndirme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow satır = dataGridView1.CurrentRow;
                txtTc.Text = satır.Cells[0].Value.ToString();
                txtAdSoyad.Text = satır.Cells[1].Value.ToString();
                txtTelefon.Text = satır.Cells[2].Value.ToString();
                txtAdres.Text = satır.Cells[3].Value.ToString();
                txtEmail.Text = satır.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow satır = dataGridView1.CurrentRow;
                string cümle = "delete from musteri where tc='" + satır.Cells["tc"].Value.ToString() + "'";
                SqlCommand komut2 = new SqlCommand();
                arackkiralama.ekl_sil_güncelle(komut2, cümle);
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                MessageBox.Show("İşlem Tamam", "Bilgilerndirme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                YenileListele();
                MessageBox.Show("İşlem Başarılı", "Bilgilerndirme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
