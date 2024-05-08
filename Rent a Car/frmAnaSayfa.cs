using System;
using System.Windows.Forms;

namespace Rent_a_Car
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void btn_Kayit_Click(object sender, EventArgs e)
        {
            frmMüşteriEkle ekle = new frmMüşteriEkle();
            ekle.ShowDialog();
        }

        private void btn_musterilist_Click(object sender, EventArgs e)
        {
            frmMüşteriListele listele = new frmMüşteriListele();
            listele.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void btn_araçkayit_Click(object sender, EventArgs e)
        {
            frmAraçKayit araçKayit = new frmAraçKayit();
            araçKayit.ShowDialog();
        }

        private void btn_araçlist_Click(object sender, EventArgs e)
        {
            frmAraçListele listele = new frmAraçListele();
            listele.ShowDialog();
        }

        private void btn_kontrat_Click(object sender, EventArgs e)
        {
            frmSözleşme sözleşme = new frmSözleşme();
            sözleşme.ShowDialog();
        }

        private void btn_rapor_Click(object sender, EventArgs e)
        {
            frmSatış satış = new frmSatış();
            satış.ShowDialog();
        }
    }
}
    