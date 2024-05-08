using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Rent_a_Car
{
    public partial class frmSözleşme : Form
    {
        public frmSözleşme()
        {
            InitializeComponent();
        }

        Araç_Kiralama araç = new Araç_Kiralama();

        private void frmSözleşme_Load(object sender, EventArgs e)
        {
            try
            {

                Boş_Araçlar();

                Yenile();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Boş_Araçlar()
        {
            try
            {
                string sorgu2 = "Select * from araç where durumu='BOŞ'";
                araç.Boş_Araçlar(cmbAraçlar, sorgu2);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void Yenile()
        {
            try
            {
                string sorugu3 = "Select * from sözleşme";
                SqlDataAdapter adtr2 = new SqlDataAdapter();
                dataGridView1.DataSource = araç.listele(adtr2, sorugu3);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void cmbAraçlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "Select * from araç where plaka like '" + cmbAraçlar.SelectedItem + "'";
            araç.CombodanGetir(cmbAraçlar,txtMarka, txtSeri, txtModel, txtRenk, sorgu2);
        }

        private void cmbKiraTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sorgu2 = "Select * from araç where plaka like '" + cmbAraçlar.SelectedItem + "'";
                araç.Ücrethesapla(cmbKiraTipi, txtKiraÜcreti, sorgu2);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                Temizle();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void dtDönüş_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                TimeSpan gun = DateTime.Parse(dtDönüş.Text) - DateTime.Parse(dtÇıkış.Text);
                int gun2 = gun.Days;
                txtGün.Text = gun2.ToString();

                txtTutar.Text = (gun2 * int.Parse(txtKiraÜcreti.Text)).ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        public void Temizle()
        {
            try
            {
                dtDönüş.Text = DateTime.Now.ToShortDateString();
                dtÇıkış.Text = DateTime.Now.ToShortDateString();
                cmbKiraTipi.Text = null;
                cmbAraçlar.Text = null;
                txtKiraÜcreti.Text = null;
                txtGün.Text = null;
                txtTutar.Text = null;
                txtSeri.Text = null;
                txtRenk.Text = null;
                txtMarka.Text = null;
                txtModel.Text = null;
                cmbKiraTipi.Text = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu2 = "insert into sözleşme(tc,adsoyad,telefon,ehliyetno,e_tarih,e_yer,plaka,marka,seri,yil,renk,kirasekli,kiraucreti,gun,tutar,ctarih,dtarih) values (@tc,@adsoyad,@telefon,@ehliyetno,@e_tarih,@e_yer,@plaka,@marka,@seri,@yil,@renk,@kirasekli,@kiraucreti,@gun,@tutar,@ctarih,@dtarih)";

                SqlCommand komut2 = new SqlCommand(sorgu2);
                komut2.Parameters.AddWithValue("@tc", txtTC.Text);
                komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut2.Parameters.AddWithValue("@ehliyetno", txtE_no.Text);
                komut2.Parameters.AddWithValue("@e_tarih", txtE_Tarih.Text);
                komut2.Parameters.AddWithValue("@e_yer", txtV_yer.Text);
                komut2.Parameters.AddWithValue("@plaka", cmbAraçlar.Text);
                komut2.Parameters.AddWithValue("@marka", txtMarka.Text);
                komut2.Parameters.AddWithValue("@seri", txtSeri.Text);
                komut2.Parameters.AddWithValue("@yil", txtModel.Text);
                komut2.Parameters.AddWithValue("@renk", txtRenk.Text);
                komut2.Parameters.AddWithValue("@kirasekli", cmbKiraTipi.Text);
                komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(txtKiraÜcreti.Text));
                komut2.Parameters.AddWithValue("@gun", int.Parse(txtGün.Text));
                komut2.Parameters.AddWithValue("@tutar", int.Parse(txtTutar.Text));
                komut2.Parameters.AddWithValue("@ctarih", dtÇıkış.Text);
                komut2.Parameters.AddWithValue("@dtarih", dtDönüş.Text);
                araç.ekl_sil_güncelle(komut2, sorgu2);

                string sorgu3 = "update araç set durumu='DOLU' where plaka='" + cmbAraçlar.Text + "'";
                SqlCommand komut3 = new SqlCommand();
                araç.ekl_sil_güncelle(komut3, sorgu3);

                cmbAraçlar.Items.Clear();
                Boş_Araçlar();
                Yenile();


                Temizle();

                foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
                Temizle();
                MessageBox.Show("İşlem Başarılı", "Bilgilerndirme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu2 = "update sözleşme set tc=@tc , adsoyad=@adsoyad , telefon=@telefon , ehliyetno=@ehliyetno , e_tarih=@e_tarih , e_yer=@e_yer , marka=@marka , seri=@seri , yil=@yil , renk=@renk , kirasekli=@kirasekli , kiraucreti=@kiraucreti , gun=@gun , tutar=@tutar , ctarih=@ctarih , dtarih=@dtarih where plaka=@plaka";

                SqlCommand komut2 = new SqlCommand(sorgu2);
                komut2.Parameters.AddWithValue("@tc", txtTC.Text.ToString());
                komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut2.Parameters.AddWithValue("@ehliyetno", txtE_no.Text);
                komut2.Parameters.AddWithValue("@e_tarih", txtE_Tarih.Text);
                komut2.Parameters.AddWithValue("@e_yer", txtV_yer.Text);
                komut2.Parameters.AddWithValue("@plaka", cmbAraçlar.Text);
                komut2.Parameters.AddWithValue("@marka", txtMarka.Text);
                komut2.Parameters.AddWithValue("@seri", txtSeri.Text);
                komut2.Parameters.AddWithValue("@yil", txtModel.Text);
                komut2.Parameters.AddWithValue("@renk", txtRenk.Text);
                komut2.Parameters.AddWithValue("@kirasekli", cmbKiraTipi.Text);
                komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(txtKiraÜcreti.Text));
                komut2.Parameters.AddWithValue("@gun", int.Parse(txtGün.Text));
                komut2.Parameters.AddWithValue("@tutar", int.Parse(txtTutar.Text));
                komut2.Parameters.AddWithValue("@ctarih", dtÇıkış.Text);
                komut2.Parameters.AddWithValue("@dtarih", dtDönüş.Text);
                araç.ekl_sil_güncelle(komut2, sorgu2);


                Boş_Araçlar();
                Yenile();

                cmbAraçlar.Items.Clear();

                foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                //foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
                Temizle();
                MessageBox.Show("Kayıt Güncellendi", "Bilgilerndirme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

                txtTC.Text = satır.Cells["tc"].Value.ToString();
                txtAdSoyad.Text = satır.Cells["adsoyad"].Value.ToString();
                txtTelefon.Text = satır.Cells["telefon"].Value.ToString();
                txtE_no.Text = satır.Cells["ehliyetno"].Value.ToString();
                txtE_Tarih.Text = satır.Cells["e_tarih"].Value.ToString();
                txtV_yer.Text = satır.Cells["e_yer"].Value.ToString();
                cmbAraçlar.Text = satır.Cells["plaka"].Value.ToString();
                txtMarka.Text = satır.Cells["marka"].Value.ToString();
                txtSeri.Text = satır.Cells["seri"].Value.ToString();
                txtModel.Text = satır.Cells["yil"].Value.ToString();
                txtRenk.Text = satır.Cells["renk"].Value.ToString();
                cmbKiraTipi.Text = satır.Cells["kirasekli"].Value.ToString();
                txtKiraÜcreti.Text = satır.Cells["kiraucreti"].Value.ToString();
                txtGün.Text = satır.Cells["gun"].Value.ToString();
                txtTutar.Text = satır.Cells["tutar"].Value.ToString();
                dtÇıkış.Text = satır.Cells["ctarih"].Value.ToString();
                dtDönüş.Text = satır.Cells["dtarih"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTcAra.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";

                string sorgu2 = "Select * from musteri where tc like '" + txtTcAra.Text + "'";
                araç.Tc_Ara(txtTcAra, txtTC, txtAdSoyad, txtTelefon, sorgu2);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow satır = dataGridView1.CurrentRow;
                DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
                DateTime dönüş = DateTime.Parse(satır.Cells["dtarih"].Value.ToString());

                int ucret = int.Parse(satır.Cells["kiraucreti"].Value.ToString());

                TimeSpan gunfarkı = bugün - dönüş;

                int _gunfarkı = gunfarkı.Days;
                int ucretfarkı;
                ucretfarkı = _gunfarkı * ucret;

                txtEkstra.Text = ucretfarkı.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
            
        }

        private void btnTeslim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hata benden sonra 1");
            try
            {

                MessageBox.Show("Hata benden sonra 2");

                if (int.Parse(txtEkstra.Text) >= 0 || int.Parse(txtEkstra.Text) < 0)
                {
                    DataGridViewRow satır = dataGridView1.CurrentRow;
                    DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
                    int ucret = int.Parse(satır.Cells["kiraucreti"].Value.ToString());
                    int tutar = int.Parse(satır.Cells["tutar"].Value.ToString());
                    DateTime çıkış = DateTime.Parse(satır.Cells["ctarih"].Value.ToString());
                    TimeSpan gun = bugün - çıkış;
                    int _gun = gun.Days;
                    int toplamtutar = _gun * ucret;


                    MessageBox.Show("Hata benden sonra 3");
                    
                    string sorgu1 = "delete from sözleşme where plaka='" + satır.Cells["plaka"].Value.ToString() + "'";
                    SqlCommand komut = new SqlCommand();
                    araç.ekl_sil_güncelle(komut, sorgu1);

                    string sorgu2 = "update araç set durumu='BOŞ' where plaka='" + satır.Cells["plaka"].Value.ToString() + "'";
                    SqlCommand komut3 = new SqlCommand();
                    araç.ekl_sil_güncelle(komut3, sorgu2);

                    string sorgu3 = "insert into satis(tc,adsoyad,plaka,marka,seri,yıl,renk,gun,tutar,tarih1,tarih2,fiyat) values (@tc,@adsoyad,@plaka,@marka,@seri,@yıl,@renk,@gun,@tutar,@tarih1,@tarih2,@fiyat)";

                    SqlCommand komut2 = new SqlCommand();
                    komut2.Parameters.AddWithValue("@tc", satır.Cells["tc"].Value.ToString());
                    komut2.Parameters.AddWithValue("@adsoyad", satır.Cells["adsoyad"].Value.ToString());

                    komut2.Parameters.AddWithValue("@plaka", satır.Cells["plaka"].Value.ToString());
                    komut2.Parameters.AddWithValue("@marka", satır.Cells["marka"].Value.ToString());
                    komut2.Parameters.AddWithValue("@seri", satır.Cells["seri"].Value.ToString());
                    komut2.Parameters.AddWithValue("@yıl", satır.Cells["yil"].Value.ToString());
                    komut2.Parameters.AddWithValue("@renk", satır.Cells["renk"].Value.ToString());
                    komut2.Parameters.AddWithValue("@gun", _gun);
                    komut2.Parameters.AddWithValue("@tutar", toplamtutar);
                    komut2.Parameters.AddWithValue("@tarih1", satır.Cells["ctarih"].Value.ToString());
                    komut2.Parameters.AddWithValue("@tarih2", DateTime.Now.ToShortDateString());
                    komut2.Parameters.AddWithValue("@fiyat", ucret);

                    MessageBox.Show("Hata benden sonra 4");
                    araç.ekl_sil_güncelle(komut2, sorgu3);

                    cmbAraçlar.Items.Clear();
                    Boş_Araçlar();
                    Yenile();


                    foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                    //foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
                    Temizle();

                    txtEkstra.Text = "";

                    MessageBox.Show("Kayıt Silindi","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }

                else 
                {
                    MessageBox.Show("Lütfen Seçim Yapınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception  ex)
            {

                MessageBox.Show("Hata Oluştu " + ex.Message, " Hata", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }


            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
