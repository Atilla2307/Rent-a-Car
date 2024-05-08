using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rent_a_Car
{
    internal class Araç_Kiralama
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-NOMPM02\\SQLEXPRESS;Initial Catalog=Araç_Kiralama;Integrated Security=True;Encrypt=False");
        DataTable tablo;
        
        public void ekl_sil_güncelle(SqlCommand komut , string sorgu)
        {
            try
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = sorgu;
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        public DataTable listele(SqlDataAdapter adtr , string sorgu)
        {
            try
            {
                tablo = new DataTable();
                adtr = new SqlDataAdapter(sorgu, baglanti);
                adtr.Fill(tablo);
                baglanti.Close();

                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return tablo;

        }

        public void Boş_Araçlar(ComboBox combo , string sorgu)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    combo.Items.Add(read["plaka"].ToString());
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        public void Tc_Ara(TextBox tcara, TextBox tc, TextBox adsoyad, TextBox telefon, string sorgu)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    tc.Text = read["tc"].ToString();
                    adsoyad.Text = read["adsoyad"].ToString();
                    telefon.Text = read["telefon"].ToString();
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }


        public void CombodanGetir(ComboBox araçlar, TextBox marka, TextBox Seri, TextBox yil, TextBox renk, string sorgu)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    marka.Text = read["marka"].ToString();
                    Seri.Text = read["seri"].ToString();
                    yil.Text = read["yil"].ToString();
                    renk.Text = read["renk"].ToString();
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }



        public void Ücrethesapla(ComboBox combokiraşekli, TextBox ücret, string sorgu)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                SqlDataReader read = komut.ExecuteReader();

                while (read.Read())
                {
                    if (combokiraşekli.SelectedIndex == 0) ücret.Text = (int.Parse(read["kiraucreti"].ToString()) * 1).ToString();
                    if (combokiraşekli.SelectedIndex == 1) ücret.Text = (int.Parse(read["kiraucreti"].ToString()) * 0.80).ToString();
                    if (combokiraşekli.SelectedIndex == 2) ücret.Text = (int.Parse(read["kiraucreti"].ToString()) * 0.70).ToString();

                }

                baglanti.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        public void satışhesapla(Label lbl)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(tutar) from satis", baglanti);
                lbl.Text = "Toplam Kazanılan Tutar: " + komut.ExecuteScalar() + "₺";
                baglanti.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        
        }
    }
}
