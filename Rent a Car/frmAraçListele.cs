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
    public partial class frmAraçListele : Form
    {

        Araç_Kiralama araçkiralama = new Araç_Kiralama();

        public frmAraçListele()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow satır = dataGridView1.CurrentRow;
                txtPlaka.Text = satır.Cells["plaka"].Value.ToString();
                cmbMarka.Text = satır.Cells["marka"].Value.ToString();
                cmbSeri.Text = satır.Cells["seri"].Value.ToString();
                txtbYıl.Text = satır.Cells["yil"].Value.ToString();
                txtRenk.Text = satır.Cells["renk"].Value.ToString();
                txtKm.Text = satır.Cells["km"].Value.ToString();
                cmbyakıt.Text = satır.Cells["yakit"].Value.ToString();
                txtÜcret.Text = satır.Cells["kiraucreti"].Value.ToString();
                pictureBox3.ImageLocation = satır.Cells["resim"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void frmAraçListele_Load(object sender, EventArgs e)
        {
            YenileAraçlarListele();

            comboBox1.SelectedIndex = 0;
        }

        public void YenileAraçlarListele()
        {

            string cümle = "Select * from Araç ";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = araçkiralama.listele(adtr2, cümle);
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbSeri.Items.Clear();
                if (cmbMarka.SelectedIndex >= 0)
                {
                    string selectedBrand = cmbMarka.SelectedItem.ToString();
                    switch (selectedBrand)
                    {
                        case "Alfa Romeo":
                            cmbSeri.Items.Add("Giulia");
                            cmbSeri.Items.Add("Stelvio");
                            cmbSeri.Items.Add("Giulietta");
                            cmbSeri.Items.Add("4C Coupe");
                            cmbSeri.Items.Add("4C Spider");
                            cmbSeri.Items.Add("MiTo");
                            cmbSeri.Items.Add("Giulia Quadrifoglio");
                            cmbSeri.Items.Add("Stelvio Quadrifoglio");
                            cmbSeri.Items.Add("Giulia GTAm");
                            cmbSeri.Items.Add("Stelvio GTAm");

                            break;
                        case "Audi":
                            cmbSeri.Items.Add("A1");
                            cmbSeri.Items.Add("A3");
                            cmbSeri.Items.Add("A4");
                            cmbSeri.Items.Add("A5");
                            cmbSeri.Items.Add("A6");
                            cmbSeri.Items.Add("A7");
                            cmbSeri.Items.Add("A8");
                            cmbSeri.Items.Add("Q2");
                            cmbSeri.Items.Add("Q3");
                            cmbSeri.Items.Add("Q5");
                            cmbSeri.Items.Add("Q7");
                            cmbSeri.Items.Add("Q8");
                            cmbSeri.Items.Add("TT");
                            cmbSeri.Items.Add("R8");
                            cmbSeri.Items.Add("RS3");
                            cmbSeri.Items.Add("RS4");
                            cmbSeri.Items.Add("RS5");
                            cmbSeri.Items.Add("RS6");
                            cmbSeri.Items.Add("RS7");
                            cmbSeri.Items.Add("RS Q3");
                            cmbSeri.Items.Add("S3");
                            cmbSeri.Items.Add("S4");
                            cmbSeri.Items.Add("S5");
                            cmbSeri.Items.Add("S6");
                            cmbSeri.Items.Add("S7");
                            cmbSeri.Items.Add("S8");
                            cmbSeri.Items.Add("SQ2");
                            cmbSeri.Items.Add("SQ5");
                            cmbSeri.Items.Add("SQ7");
                            cmbSeri.Items.Add("SQ8");

                            break;
                        case "BMW":
                            cmbSeri.Items.Add("1 Series");
                            cmbSeri.Items.Add("2 Series");
                            cmbSeri.Items.Add("3 Series");
                            cmbSeri.Items.Add("4 Series");
                            cmbSeri.Items.Add("5 Series");
                            cmbSeri.Items.Add("6 Series");
                            cmbSeri.Items.Add("7 Series");
                            cmbSeri.Items.Add("8 Series");
                            cmbSeri.Items.Add("X1");
                            cmbSeri.Items.Add("X2");
                            cmbSeri.Items.Add("X3");
                            cmbSeri.Items.Add("X4");
                            cmbSeri.Items.Add("X5");
                            cmbSeri.Items.Add("X6");
                            cmbSeri.Items.Add("X7");
                            cmbSeri.Items.Add("Z4");
                            cmbSeri.Items.Add("M2");
                            cmbSeri.Items.Add("M3");
                            cmbSeri.Items.Add("M4");
                            cmbSeri.Items.Add("M5");
                            cmbSeri.Items.Add("M8");
                            cmbSeri.Items.Add("i3");
                            cmbSeri.Items.Add("i4");
                            cmbSeri.Items.Add("i8");

                            break;
                        case "Chevrolet":
                            cmbSeri.Items.Add("Camaro");
                            cmbSeri.Items.Add("Corvette");
                            cmbSeri.Items.Add("Cruze");
                            cmbSeri.Items.Add("Malibu");
                            cmbSeri.Items.Add("Spark");
                            cmbSeri.Items.Add("Suburban");
                            cmbSeri.Items.Add("Tahoe");
                            cmbSeri.Items.Add("Trailblazer");
                            cmbSeri.Items.Add("Traverse");

                            break;
                        case "Citroën":
                            cmbSeri.Items.Add("C1");
                            cmbSeri.Items.Add("C3");
                            cmbSeri.Items.Add("C3 Aircross");
                            cmbSeri.Items.Add("C4");
                            cmbSeri.Items.Add("C4 Cactus");
                            cmbSeri.Items.Add("C5 Aircross");
                            cmbSeri.Items.Add("Berlingo");
                            cmbSeri.Items.Add("Jumper");
                            cmbSeri.Items.Add("SpaceTourer");

                            break;
                        case "Dodge":
                            cmbSeri.Items.Add("Challenger");
                            cmbSeri.Items.Add("Charger");
                            cmbSeri.Items.Add("Durango");
                            cmbSeri.Items.Add("Journey");

                            break;
                        case "Fiat":
                            cmbSeri.Items.Add("500");
                            cmbSeri.Items.Add("Panda");
                            cmbSeri.Items.Add("Tipo");
                            cmbSeri.Items.Add("124 Spider");
                            cmbSeri.Items.Add("500X");
                            cmbSeri.Items.Add("500L");
                            cmbSeri.Items.Add("Ducato");
                            cmbSeri.Items.Add("Talento");
                            cmbSeri.Items.Add("Fullback");
                            cmbSeri.Items.Add("Egea Sedan");
                            cmbSeri.Items.Add("Egea Hatchback");
                            cmbSeri.Items.Add("Egea Station Wagon");
                            cmbSeri.Items.Add("Tipo Sedan");
                            cmbSeri.Items.Add("Tipo Hatchback");
                            cmbSeri.Items.Add("Tipo Station Wagon");
                            cmbSeri.Items.Add("Linea");

                            break;
                        case "Ford":
                            cmbSeri.Items.Add("Fiesta");
                            cmbSeri.Items.Add("Focus");
                            cmbSeri.Items.Add("Mondeo");
                            cmbSeri.Items.Add("Mustang");
                            cmbSeri.Items.Add("EcoSport");
                            cmbSeri.Items.Add("Escape");
                            cmbSeri.Items.Add("Explorer");
                            cmbSeri.Items.Add("Edge");
                            cmbSeri.Items.Add("Ranger");
                            cmbSeri.Items.Add("F-150");
                            cmbSeri.Items.Add("Transit");

                            break;
                        case "Honda":
                            cmbSeri.Items.Add("Civic");
                            cmbSeri.Items.Add("Accord");
                            cmbSeri.Items.Add("CR-V");
                            cmbSeri.Items.Add("HR-V");
                            cmbSeri.Items.Add("Jazz");
                            cmbSeri.Items.Add("Odyssey");
                            cmbSeri.Items.Add("Pilot");

                            break;
                        case "Hyundai":
                            cmbSeri.Items.Add("i10");
                            cmbSeri.Items.Add("i20");
                            cmbSeri.Items.Add("i30");
                            cmbSeri.Items.Add("i40");
                            cmbSeri.Items.Add("Kona");
                            cmbSeri.Items.Add("Tucson");
                            cmbSeri.Items.Add("Santa Fe");
                            cmbSeri.Items.Add("Palisade");
                            cmbSeri.Items.Add("Nexo");
                            cmbSeri.Items.Add("Ioniq");
                            cmbSeri.Items.Add("Sonata");
                            cmbSeri.Items.Add("Elantra");
                            cmbSeri.Items.Add("Accent");
                            cmbSeri.Items.Add("Venue");

                            break;
                        case "Jaguar":
                            cmbSeri.Items.Add("E-Pace");
                            cmbSeri.Items.Add("F-Pace");
                            cmbSeri.Items.Add("I-Pace");
                            cmbSeri.Items.Add("XE");
                            cmbSeri.Items.Add("XF");
                            cmbSeri.Items.Add("XJ");

                            break;
                        case "Jeep":
                            cmbSeri.Items.Add("Cherokee");
                            cmbSeri.Items.Add("Compass");
                            cmbSeri.Items.Add("Grand Cherokee");
                            cmbSeri.Items.Add("Renegade");
                            cmbSeri.Items.Add("Wrangler");
                            cmbSeri.Items.Add("Gladiator");

                            break;
                        case "Kia":
                            cmbSeri.Items.Add("Picanto");
                            cmbSeri.Items.Add("Rio");
                            cmbSeri.Items.Add("Stonic");
                            cmbSeri.Items.Add("Soul");
                            cmbSeri.Items.Add("Niro");
                            cmbSeri.Items.Add("Ceed");
                            cmbSeri.Items.Add("Optima");
                            cmbSeri.Items.Add("Stinger");
                            cmbSeri.Items.Add("Sportage");
                            cmbSeri.Items.Add("Sorento");
                            cmbSeri.Items.Add("Telluride");

                            break;
                        case "Land Rover":
                            cmbSeri.Items.Add("Discovery");
                            cmbSeri.Items.Add("Discovery Sport");
                            cmbSeri.Items.Add("Range Rover");
                            cmbSeri.Items.Add("Range Rover Evoque");
                            cmbSeri.Items.Add("Range Rover Sport");
                            cmbSeri.Items.Add("Range Rover Velar");
                            cmbSeri.Items.Add("Defender");

                            break;
                        case "Lexus":
                            cmbSeri.Items.Add("IS");
                            cmbSeri.Items.Add("ES");
                            cmbSeri.Items.Add("LS");
                            cmbSeri.Items.Add("UX");
                            cmbSeri.Items.Add("NX");
                            cmbSeri.Items.Add("RX");
                            cmbSeri.Items.Add("GX");
                            cmbSeri.Items.Add("LX");
                            cmbSeri.Items.Add("RC");
                            cmbSeri.Items.Add("LC");

                            break;
                        case "Mazda":
                            cmbSeri.Items.Add("Mazda2");
                            cmbSeri.Items.Add("Mazda3");
                            cmbSeri.Items.Add("Mazda6");
                            cmbSeri.Items.Add("MX-5");
                            cmbSeri.Items.Add("CX-3");
                            cmbSeri.Items.Add("CX-30");
                            cmbSeri.Items.Add("CX-5");
                            cmbSeri.Items.Add("CX-8");
                            cmbSeri.Items.Add("CX-9");
                            cmbSeri.Items.Add("BT-50");

                            break;
                        case "Mercedes-Benz":
                            cmbSeri.Items.Add("A-Class");
                            cmbSeri.Items.Add("B-Class");
                            cmbSeri.Items.Add("C-Class");
                            cmbSeri.Items.Add("E-Class");
                            cmbSeri.Items.Add("S-Class");
                            cmbSeri.Items.Add("CLA");
                            cmbSeri.Items.Add("CLS");
                            cmbSeri.Items.Add("GLA");
                            cmbSeri.Items.Add("GLB");
                            cmbSeri.Items.Add("GLC");
                            cmbSeri.Items.Add("GLE");
                            cmbSeri.Items.Add("GLS");
                            cmbSeri.Items.Add("G-Class");
                            cmbSeri.Items.Add("EQC");
                            cmbSeri.Items.Add("EQA");
                            cmbSeri.Items.Add("EQB");
                            cmbSeri.Items.Add("AMG GT");
                            cmbSeri.Items.Add("SLS AMG");

                            break;
                        case "Mini":
                            cmbSeri.Items.Add("Cooper");
                            cmbSeri.Items.Add("Countryman");
                            cmbSeri.Items.Add("Clubman");
                            cmbSeri.Items.Add("Convertible");
                            cmbSeri.Items.Add("Coupe");
                            cmbSeri.Items.Add("Roadster");
                            cmbSeri.Items.Add("Paceman");

                            break;
                        case "Mitsubishi":
                            cmbSeri.Items.Add("Mirage");
                            cmbSeri.Items.Add("Eclipse Cross");
                            cmbSeri.Items.Add("ASX");
                            cmbSeri.Items.Add("Outlander");
                            cmbSeri.Items.Add("Pajero");
                            cmbSeri.Items.Add("L200");

                            break;
                        case "Nissan":
                            cmbSeri.Items.Add("Micra");
                            cmbSeri.Items.Add("Juke");
                            cmbSeri.Items.Add("Qashqai");
                            cmbSeri.Items.Add("X-Trail");
                            cmbSeri.Items.Add("Leaf");
                            cmbSeri.Items.Add("Navara");
                            cmbSeri.Items.Add("Patrol");
                            cmbSeri.Items.Add("Murano");
                            cmbSeri.Items.Add("GTR");

                            break;
                        case "Peugeot":
                            cmbSeri.Items.Add("108");
                            cmbSeri.Items.Add("208");
                            cmbSeri.Items.Add("2008");
                            cmbSeri.Items.Add("308");
                            cmbSeri.Items.Add("3008");
                            cmbSeri.Items.Add("508");
                            cmbSeri.Items.Add("5008");
                            cmbSeri.Items.Add("Rifter");
                            cmbSeri.Items.Add("Traveller");

                            break;
                        case "Porsche":
                            cmbSeri.Items.Add("911");
                            cmbSeri.Items.Add("Panamera");
                            cmbSeri.Items.Add("Cayenne");
                            cmbSeri.Items.Add("Macan");
                            cmbSeri.Items.Add("Taycan");
                            cmbSeri.Items.Add("Boxster");
                            cmbSeri.Items.Add("Cayman");
                            cmbSeri.Items.Add("911 GT3");
                            cmbSeri.Items.Add("918 Spyder");
                            cmbSeri.Items.Add("Carrera GT");

                            break;
                        case "Renault":
                            cmbSeri.Items.Add("Clio");
                            cmbSeri.Items.Add("Captur");
                            cmbSeri.Items.Add("Megane");
                            cmbSeri.Items.Add("Kadjar");
                            cmbSeri.Items.Add("Scenic");
                            cmbSeri.Items.Add("Talisman");
                            cmbSeri.Items.Add("Koleos");
                            cmbSeri.Items.Add("Zoe");
                            cmbSeri.Items.Add("Twingo");

                            break;
                        case "Skoda":
                            cmbSeri.Items.Add("Fabia");
                            cmbSeri.Items.Add("Octavia");
                            cmbSeri.Items.Add("Superb");
                            cmbSeri.Items.Add("Kodiaq");
                            cmbSeri.Items.Add("Karoq");
                            cmbSeri.Items.Add("Scala");
                            cmbSeri.Items.Add("Citigo");
                            cmbSeri.Items.Add("Enyaq");

                            break;
                        case "Subaru":
                            cmbSeri.Items.Add("Impreza");
                            cmbSeri.Items.Add("Legacy");
                            cmbSeri.Items.Add("Outback");
                            cmbSeri.Items.Add("Forester");
                            cmbSeri.Items.Add("XV");
                            cmbSeri.Items.Add("BRZ");
                            cmbSeri.Items.Add("WRX");
                            cmbSeri.Items.Add("Ascent");

                            break;
                        case "Suzuki":
                            cmbSeri.Items.Add("Swift");
                            cmbSeri.Items.Add("Jimny");
                            cmbSeri.Items.Add("Vitara");
                            cmbSeri.Items.Add("S-Cross");
                            cmbSeri.Items.Add("Baleno");
                            cmbSeri.Items.Add("Ignis");
                            cmbSeri.Items.Add("Celerio");
                            cmbSeri.Items.Add("SX4 S-Cross");

                            break;
                        case "Tesla":
                            cmbSeri.Items.Add("Model S");
                            cmbSeri.Items.Add("Model 3");
                            cmbSeri.Items.Add("Model X");
                            cmbSeri.Items.Add("Model Y");
                            cmbSeri.Items.Add("Roadster");
                            cmbSeri.Items.Add("Cybertruck");
                            cmbSeri.Items.Add("Semi");

                            break;
                        case "Toyota":
                            cmbSeri.Items.Add("Yaris");
                            cmbSeri.Items.Add("Corolla");
                            cmbSeri.Items.Add("Camry");
                            cmbSeri.Items.Add("Prius");
                            cmbSeri.Items.Add("RAV4");
                            cmbSeri.Items.Add("Highlander");
                            cmbSeri.Items.Add("Land Cruiser");
                            cmbSeri.Items.Add("4Runner");
                            cmbSeri.Items.Add("Supra");
                            cmbSeri.Items.Add("GR Yaris");
                            cmbSeri.Items.Add("C-HR");
                            cmbSeri.Items.Add("Sienna");
                            cmbSeri.Items.Add("Tacoma");
                            cmbSeri.Items.Add("Tundra");

                            break;
                        case "Volkswagen":
                            cmbSeri.Items.Add("Polo");
                            cmbSeri.Items.Add("Golf");
                            cmbSeri.Items.Add("Passat");
                            cmbSeri.Items.Add("Tiguan");
                            cmbSeri.Items.Add("T-Roc");
                            cmbSeri.Items.Add("Arteon");
                            cmbSeri.Items.Add("Up!");
                            cmbSeri.Items.Add("ID.3");
                            cmbSeri.Items.Add("ID.4");
                            cmbSeri.Items.Add("Touran");
                            cmbSeri.Items.Add("Sharan");
                            cmbSeri.Items.Add("T-Cross");
                            cmbSeri.Items.Add("Caddy");
                            cmbSeri.Items.Add("Amarok");

                            break;
                        case "Volvo":
                            cmbSeri.Items.Add("S60");
                            cmbSeri.Items.Add("S90");
                            cmbSeri.Items.Add("V60");
                            cmbSeri.Items.Add("V90");
                            cmbSeri.Items.Add("XC40");
                            cmbSeri.Items.Add("XC60");
                            cmbSeri.Items.Add("XC90");
                            cmbSeri.Items.Add("C40");
                            cmbSeri.Items.Add("V40");
                            cmbSeri.Items.Add("XC20");
                            cmbSeri.Items.Add("Polestar 1");
                            cmbSeri.Items.Add("Polestar 2");

                            break;
                        default:
                            // Seçilen marka için modeller bulunamadıysa bir mesaj gösterebilirsin.
                            cmbSeri.Items.Add("Modeller bulunamadı.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }

        private void btnResim_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                pictureBox3.ImageLocation = openFileDialog1.FileName;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cümle = "update araç set marka=@marka , seri=@seri , yil=@yil , renk=@renk , km=@km , yakit=@yakit , kiraucreti=@kiraucreti , resim=@resim ,tarih=@tarih where plaka=@plaka";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.AddWithValue("@plaka", txtPlaka.Text);
                komut2.Parameters.AddWithValue("@marka", cmbMarka.Text);
                komut2.Parameters.AddWithValue("@seri", cmbSeri.Text);
                komut2.Parameters.AddWithValue("@yil", txtbYıl.Text);
                komut2.Parameters.AddWithValue("@renk", txtRenk.Text);
                komut2.Parameters.AddWithValue("@km", txtKm.Text);
                komut2.Parameters.AddWithValue("@yakit", cmbyakıt.Text);
                komut2.Parameters.AddWithValue("@kiraucreti", txtÜcret.Text);
                komut2.Parameters.AddWithValue("@resim", pictureBox3.ImageLocation);
                komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

                araçkiralama.ekl_sil_güncelle(komut2, cümle);
                cmbSeri.Items.Clear();
                pictureBox3.Image = null;
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
                YenileAraçlarListele();

                MessageBox.Show("İşlem Başarılı", "Bilgilerndirme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                string cümle = "Delete from araç where plaka= '" + satır.Cells["plaka"].Value.ToString() + "'";
                SqlCommand komut2 = new SqlCommand();
                araçkiralama.ekl_sil_güncelle(komut2, cümle);
                cmbSeri.Items.Clear();
                pictureBox3.ImageLocation = null;
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
                YenileAraçlarListele();

                MessageBox.Show("İşlem Başarılı", "Bilgilerndirme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    YenileAraçlarListele();
                }

                if (comboBox1.SelectedIndex == 1)
                {
                    string cümle = "Select * from araç where durumu ='DOLU' ";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = araçkiralama.listele(adtr2, cümle);

                }

                if (comboBox1.SelectedIndex == 2)
                {
                    string cümle = "Select * from araç where durumu ='BOŞ '";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = araçkiralama.listele(adtr2, cümle);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
          
        }
    }
}
