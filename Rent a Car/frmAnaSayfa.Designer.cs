namespace Rent_a_Car
{
    partial class frmAnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Kayit = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_musterilist = new System.Windows.Forms.Button();
            this.btn_araçkayit = new System.Windows.Forms.Button();
            this.btn_araçlist = new System.Windows.Forms.Button();
            this.btn_kontrat = new System.Windows.Forms.Button();
            this.btn_rapor = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(848, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1077, 1048);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Kayit
            // 
            this.btn_Kayit.BackColor = System.Drawing.Color.Lime;
            this.btn_Kayit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Kayit.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_Kayit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Kayit.ImageIndex = 3;
            this.btn_Kayit.ImageList = this.ımageList1;
            this.btn_Kayit.Location = new System.Drawing.Point(34, 32);
            this.btn_Kayit.Name = "btn_Kayit";
            this.btn_Kayit.Size = new System.Drawing.Size(300, 125);
            this.btn_Kayit.TabIndex = 1;
            this.btn_Kayit.Text = "Yeni Müsteri Kayıt";
            this.btn_Kayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Kayit.UseVisualStyleBackColor = false;
            this.btn_Kayit.Click += new System.EventHandler(this.btn_Kayit_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "dollar.png");
            this.ımageList1.Images.SetKeyName(1, "checklist.png");
            this.ımageList1.Images.SetKeyName(2, "clipboard.png");
            this.ımageList1.Images.SetKeyName(3, "users.png");
            this.ımageList1.Images.SetKeyName(4, "agreement.png");
            this.ımageList1.Images.SetKeyName(5, "close.png");
            this.ımageList1.Images.SetKeyName(6, "transport.png");
            this.ımageList1.Images.SetKeyName(7, "increasing_5329486.png");
            this.ımageList1.Images.SetKeyName(8, "add_13319877.png");
            this.ımageList1.Images.SetKeyName(9, "sport-car_12024268.png");
            // 
            // btn_musterilist
            // 
            this.btn_musterilist.BackColor = System.Drawing.Color.Lime;
            this.btn_musterilist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_musterilist.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_musterilist.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_musterilist.ImageIndex = 2;
            this.btn_musterilist.ImageList = this.ımageList1;
            this.btn_musterilist.Location = new System.Drawing.Point(34, 322);
            this.btn_musterilist.Name = "btn_musterilist";
            this.btn_musterilist.Size = new System.Drawing.Size(300, 125);
            this.btn_musterilist.TabIndex = 2;
            this.btn_musterilist.Text = "Müsteri Listesi";
            this.btn_musterilist.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_musterilist.UseVisualStyleBackColor = false;
            this.btn_musterilist.Click += new System.EventHandler(this.btn_musterilist_Click);
            // 
            // btn_araçkayit
            // 
            this.btn_araçkayit.BackColor = System.Drawing.Color.Lime;
            this.btn_araçkayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_araçkayit.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_araçkayit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_araçkayit.ImageIndex = 8;
            this.btn_araçkayit.ImageList = this.ımageList1;
            this.btn_araçkayit.Location = new System.Drawing.Point(34, 177);
            this.btn_araçkayit.Name = "btn_araçkayit";
            this.btn_araçkayit.Size = new System.Drawing.Size(300, 125);
            this.btn_araçkayit.TabIndex = 3;
            this.btn_araçkayit.Text = "Yeni Araç Kayıt";
            this.btn_araçkayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_araçkayit.UseVisualStyleBackColor = false;
            this.btn_araçkayit.Click += new System.EventHandler(this.btn_araçkayit_Click);
            // 
            // btn_araçlist
            // 
            this.btn_araçlist.BackColor = System.Drawing.Color.Lime;
            this.btn_araçlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_araçlist.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_araçlist.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_araçlist.ImageIndex = 1;
            this.btn_araçlist.ImageList = this.ımageList1;
            this.btn_araçlist.Location = new System.Drawing.Point(34, 467);
            this.btn_araçlist.Name = "btn_araçlist";
            this.btn_araçlist.Size = new System.Drawing.Size(300, 125);
            this.btn_araçlist.TabIndex = 4;
            this.btn_araçlist.Text = "Araç Listesi";
            this.btn_araçlist.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_araçlist.UseVisualStyleBackColor = false;
            this.btn_araçlist.Click += new System.EventHandler(this.btn_araçlist_Click);
            // 
            // btn_kontrat
            // 
            this.btn_kontrat.BackColor = System.Drawing.Color.Lime;
            this.btn_kontrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kontrat.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_kontrat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_kontrat.ImageIndex = 4;
            this.btn_kontrat.ImageList = this.ımageList1;
            this.btn_kontrat.Location = new System.Drawing.Point(34, 612);
            this.btn_kontrat.Name = "btn_kontrat";
            this.btn_kontrat.Size = new System.Drawing.Size(300, 125);
            this.btn_kontrat.TabIndex = 5;
            this.btn_kontrat.Text = "Kontratlar";
            this.btn_kontrat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_kontrat.UseVisualStyleBackColor = false;
            this.btn_kontrat.Click += new System.EventHandler(this.btn_kontrat_Click);
            // 
            // btn_rapor
            // 
            this.btn_rapor.BackColor = System.Drawing.Color.Lime;
            this.btn_rapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rapor.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_rapor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rapor.ImageIndex = 7;
            this.btn_rapor.ImageList = this.ımageList1;
            this.btn_rapor.Location = new System.Drawing.Point(34, 757);
            this.btn_rapor.Name = "btn_rapor";
            this.btn_rapor.Size = new System.Drawing.Size(300, 125);
            this.btn_rapor.TabIndex = 6;
            this.btn_rapor.Text = "Rapor";
            this.btn_rapor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rapor.UseVisualStyleBackColor = false;
            this.btn_rapor.Click += new System.EventHandler(this.btn_rapor_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Red;
            this.btn_kapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kapat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_kapat.ImageIndex = 5;
            this.btn_kapat.ImageList = this.ımageList1;
            this.btn_kapat.Location = new System.Drawing.Point(34, 903);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(300, 125);
            this.btn_kapat.TabIndex = 7;
            this.btn_kapat.Text = "Programı Kapat";
            this.btn_kapat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(448, 964);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 44);
            this.label1.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.btn_rapor);
            this.Controls.Add(this.btn_kontrat);
            this.Controls.Add(this.btn_araçlist);
            this.Controls.Add(this.btn_araçkayit);
            this.Controls.Add(this.btn_musterilist);
            this.Controls.Add(this.btn_Kayit);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAnaSayfa";
            this.Text = "An Sayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Kayit;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_musterilist;
        private System.Windows.Forms.Button btn_araçkayit;
        private System.Windows.Forms.Button btn_araçlist;
        private System.Windows.Forms.Button btn_kontrat;
        private System.Windows.Forms.Button btn_rapor;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

