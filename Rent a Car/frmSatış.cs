﻿using System;
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
    public partial class frmSatış : Form
    {
        public frmSatış()
        {
            InitializeComponent();
        }

        Araç_Kiralama arac = new Araç_Kiralama();

        private void frmSatış_Load(object sender, EventArgs e)
        {
            try
            {
                string sorgu2 = "Select * from satis";
                SqlDataAdapter adtr2 = new SqlDataAdapter();
                dataGridView1.DataSource = arac.listele(adtr2, sorgu2);
                arac.satışhesapla(label1);

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
    }
}
