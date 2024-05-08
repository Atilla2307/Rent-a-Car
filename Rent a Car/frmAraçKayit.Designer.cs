namespace Rent_a_Car
{
    partial class frmAraçKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAraçKayit));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtbYıl = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtÜcret = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.cmbSeri = new System.Windows.Forms.ComboBox();
            this.cmbyakıt = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnResim = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(561, 926);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 31);
            this.label7.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(150, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(401, 64);
            this.label6.TabIndex = 36;
            this.label6.Text = "Yeni Araba Ekle";
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackColor = System.Drawing.Color.Red;
            this.btn_iptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_iptal.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iptal.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_iptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_iptal.ImageIndex = 1;
            this.btn_iptal.ImageList = this.ımageList1;
            this.btn_iptal.Location = new System.Drawing.Point(398, 590);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(163, 64);
            this.btn_iptal.TabIndex = 35;
            this.btn_iptal.Text = "Geri Dön";
            this.btn_iptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_iptal.UseVisualStyleBackColor = false;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "sport-car_12024268.png");
            this.ımageList1.Images.SetKeyName(1, "close_7786357.png");
            this.ımageList1.Images.SetKeyName(2, "icons8-add-picture-96.png");
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kaydet.ImageIndex = 0;
            this.btn_kaydet.ImageList = this.ımageList1;
            this.btn_kaydet.Location = new System.Drawing.Point(205, 590);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(163, 64);
            this.btn_kaydet.TabIndex = 34;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(251, 715);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(253, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(70, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 28);
            this.label4.TabIndex = 32;
            this.label4.Text = "Renk:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(14, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 28);
            this.label5.TabIndex = 31;
            this.label5.Tag = "";
            this.label5.Text = "Model(Yıl):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(84, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 28);
            this.label3.TabIndex = 30;
            this.label3.Text = "Seri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(56, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 28);
            this.label2.TabIndex = 29;
            this.label2.Text = "Marka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(67, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "Plaka:";
            // 
            // txtRenk
            // 
            this.txtRenk.BackColor = System.Drawing.Color.Lime;
            this.txtRenk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRenk.Font = new System.Drawing.Font("Arial", 17F);
            this.txtRenk.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtRenk.Location = new System.Drawing.Point(172, 332);
            this.txtRenk.Multiline = true;
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(202, 29);
            this.txtRenk.TabIndex = 27;
            // 
            // txtbYıl
            // 
            this.txtbYıl.BackColor = System.Drawing.Color.Lime;
            this.txtbYıl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbYıl.Font = new System.Drawing.Font("Arial", 17F);
            this.txtbYıl.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtbYıl.Location = new System.Drawing.Point(172, 278);
            this.txtbYıl.Multiline = true;
            this.txtbYıl.Name = "txtbYıl";
            this.txtbYıl.Size = new System.Drawing.Size(202, 29);
            this.txtbYıl.TabIndex = 26;
            // 
            // txtPlaka
            // 
            this.txtPlaka.BackColor = System.Drawing.Color.Lime;
            this.txtPlaka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlaka.Font = new System.Drawing.Font("Arial", 17F);
            this.txtPlaka.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtPlaka.Location = new System.Drawing.Point(172, 116);
            this.txtPlaka.Multiline = true;
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(202, 29);
            this.txtPlaka.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(848, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1077, 1048);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtÜcret
            // 
            this.txtÜcret.BackColor = System.Drawing.Color.Lime;
            this.txtÜcret.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtÜcret.Font = new System.Drawing.Font("Arial", 17F);
            this.txtÜcret.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtÜcret.Location = new System.Drawing.Point(172, 494);
            this.txtÜcret.Multiline = true;
            this.txtÜcret.Name = "txtÜcret";
            this.txtÜcret.Size = new System.Drawing.Size(202, 29);
            this.txtÜcret.TabIndex = 41;
            // 
            // txtKm
            // 
            this.txtKm.BackColor = System.Drawing.Color.Lime;
            this.txtKm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKm.Font = new System.Drawing.Font("Arial", 17F);
            this.txtKm.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtKm.Location = new System.Drawing.Point(172, 386);
            this.txtKm.Multiline = true;
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(202, 29);
            this.txtKm.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(12, 493);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 28);
            this.label8.TabIndex = 44;
            this.label8.Text = "Kira Bedeli:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(66, 439);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 28);
            this.label9.TabIndex = 43;
            this.label9.Tag = "";
            this.label9.Text = "Yakıt:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(84, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 28);
            this.label10.TabIndex = 42;
            this.label10.Text = "Km:";
            // 
            // cmbMarka
            // 
            this.cmbMarka.BackColor = System.Drawing.Color.Lime;
            this.cmbMarka.Font = new System.Drawing.Font("Arial", 14F);
            this.cmbMarka.ForeColor = System.Drawing.Color.OrangeRed;
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Items.AddRange(new object[] {
            "Alfa Romeo",
            "Audi",
            "BMW",
            "Chevrolet",
            "Citroën",
            "Dodge",
            "Fiat",
            "Ford",
            "Honda",
            "Hyundai",
            "Jaguar",
            "Jeep",
            "Kia",
            "Land Rover",
            "Lexus",
            "Mazda",
            "Mercedes-Benz",
            "Mini",
            "Mitsubishi",
            "Nissan",
            "Peugeot",
            "Porsche",
            "Renault",
            "Skoda",
            "Subaru",
            "Suzuki",
            "Tesla",
            "Toyota",
            "Volkswagen",
            "Volvo"});
            this.cmbMarka.Location = new System.Drawing.Point(172, 169);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(202, 30);
            this.cmbMarka.TabIndex = 45;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // cmbSeri
            // 
            this.cmbSeri.BackColor = System.Drawing.Color.Lime;
            this.cmbSeri.Font = new System.Drawing.Font("Arial", 14F);
            this.cmbSeri.ForeColor = System.Drawing.Color.OrangeRed;
            this.cmbSeri.FormattingEnabled = true;
            this.cmbSeri.Location = new System.Drawing.Point(172, 224);
            this.cmbSeri.Name = "cmbSeri";
            this.cmbSeri.Size = new System.Drawing.Size(202, 30);
            this.cmbSeri.TabIndex = 46;
            // 
            // cmbyakıt
            // 
            this.cmbyakıt.BackColor = System.Drawing.Color.Lime;
            this.cmbyakıt.Font = new System.Drawing.Font("Arial", 14F);
            this.cmbyakıt.ForeColor = System.Drawing.Color.OrangeRed;
            this.cmbyakıt.FormattingEnabled = true;
            this.cmbyakıt.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin + LPG"});
            this.cmbyakıt.Location = new System.Drawing.Point(172, 440);
            this.cmbyakıt.Name = "cmbyakıt";
            this.cmbyakıt.Size = new System.Drawing.Size(202, 30);
            this.cmbyakıt.TabIndex = 47;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox3.Location = new System.Drawing.Point(458, 116);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(243, 243);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // btnResim
            // 
            this.btnResim.BackColor = System.Drawing.Color.Yellow;
            this.btnResim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResim.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResim.ForeColor = System.Drawing.Color.Black;
            this.btnResim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResim.ImageKey = "icons8-add-picture-96.png";
            this.btnResim.ImageList = this.ımageList1;
            this.btnResim.Location = new System.Drawing.Point(484, 385);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(187, 53);
            this.btnResim.TabIndex = 49;
            this.btnResim.Text = "Resim Ekle";
            this.btnResim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResim.UseVisualStyleBackColor = false;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAraçKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnResim);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.cmbyakıt);
            this.Controls.Add(this.cmbSeri);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtÜcret);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.txtbYıl);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAraçKayit";
            this.Text = "frmAraçKayit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAraçKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.TextBox txtbYıl;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtÜcret;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.ComboBox cmbSeri;
        private System.Windows.Forms.ComboBox cmbyakıt;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}