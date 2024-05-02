namespace KutuphaneOtomasyonu
{
    partial class FrmKitapListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKitapListele));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtAçıklama = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtBasımYılı = new System.Windows.Forms.TextBox();
            this.CmbKitaptürü = new System.Windows.Forms.ComboBox();
            this.TxtStokSayısı = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtYazarAdı = new System.Windows.Forms.TextBox();
            this.TxtBarkodNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtYayınevi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtKitapAdı = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSayfaSayısı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtAra = new System.Windows.Forms.TextBox();
            this.BtnAra = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblKitapSayısı = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnCıkıs = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtAçıklama);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxtBasımYılı);
            this.groupBox1.Controls.Add(this.CmbKitaptürü);
            this.groupBox1.Controls.Add(this.TxtStokSayısı);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtYazarAdı);
            this.groupBox1.Controls.Add(this.TxtBarkodNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtYayınevi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtKitapAdı);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtSayfaSayısı);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(5, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bilgileri";
            // 
            // TxtAçıklama
            // 
            this.TxtAçıklama.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAçıklama.Location = new System.Drawing.Point(385, 147);
            this.TxtAçıklama.Multiline = true;
            this.TxtAçıklama.Name = "TxtAçıklama";
            this.TxtAçıklama.Size = new System.Drawing.Size(469, 106);
            this.TxtAçıklama.TabIndex = 9;
            this.TxtAçıklama.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(297, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 23);
            this.label10.TabIndex = 23;
            this.label10.Text = "Açıklama:";
            // 
            // TxtBasımYılı
            // 
            this.TxtBasımYılı.Location = new System.Drawing.Point(687, 24);
            this.TxtBasımYılı.Name = "TxtBasımYılı";
            this.TxtBasımYılı.Size = new System.Drawing.Size(165, 31);
            this.TxtBasımYılı.TabIndex = 7;
            // 
            // CmbKitaptürü
            // 
            this.CmbKitaptürü.FormattingEnabled = true;
            this.CmbKitaptürü.Items.AddRange(new object[] {
            "Roman",
            "Hikaye",
            "Polisiye",
            "Şiir",
            "Psikoloji",
            "Tarih",
            "Felsefe",
            "Bilim Kurgu",
            "Din",
            "Siyaset"});
            this.CmbKitaptürü.Location = new System.Drawing.Point(385, 110);
            this.CmbKitaptürü.Name = "CmbKitaptürü";
            this.CmbKitaptürü.Size = new System.Drawing.Size(165, 31);
            this.CmbKitaptürü.TabIndex = 6;
            // 
            // TxtStokSayısı
            // 
            this.TxtStokSayısı.Location = new System.Drawing.Point(687, 64);
            this.TxtStokSayısı.Name = "TxtStokSayısı";
            this.TxtStokSayısı.Size = new System.Drawing.Size(165, 31);
            this.TxtStokSayısı.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(552, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Kitap Basım Yılı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Kitap Türü:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(587, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Stok Sayısı:";
//            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // TxtYazarAdı
            // 
            this.TxtYazarAdı.Location = new System.Drawing.Point(102, 115);
            this.TxtYazarAdı.Name = "TxtYazarAdı";
            this.TxtYazarAdı.Size = new System.Drawing.Size(165, 31);
            this.TxtYazarAdı.TabIndex = 3;
            // 
            // TxtBarkodNo
            // 
            this.TxtBarkodNo.Location = new System.Drawing.Point(102, 31);
            this.TxtBarkodNo.Name = "TxtBarkodNo";
            this.TxtBarkodNo.Size = new System.Drawing.Size(165, 31);
            this.TxtBarkodNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Barkod No:";
            // 
            // TxtYayınevi
            // 
            this.TxtYayınevi.Location = new System.Drawing.Point(385, 26);
            this.TxtYayınevi.Name = "TxtYayınevi";
            this.TxtYayınevi.Size = new System.Drawing.Size(165, 31);
            this.TxtYayınevi.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sayfa Sayısı:";
            // 
            // TxtKitapAdı
            // 
            this.TxtKitapAdı.Location = new System.Drawing.Point(102, 73);
            this.TxtKitapAdı.Name = "TxtKitapAdı";
            this.TxtKitapAdı.Size = new System.Drawing.Size(165, 31);
            this.TxtKitapAdı.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Yayınevi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Yazar Adı:";
            // 
            // TxtSayfaSayısı
            // 
            this.TxtSayfaSayısı.Location = new System.Drawing.Point(385, 73);
            this.TxtSayfaSayısı.Name = "TxtSayfaSayısı";
            this.TxtSayfaSayısı.Size = new System.Drawing.Size(165, 31);
            this.TxtSayfaSayısı.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kitap Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtAra);
            this.groupBox2.Controls.Add(this.BtnAra);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(578, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 73);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama Yap";
            // 
            // TxtAra
            // 
            this.TxtAra.Location = new System.Drawing.Point(173, 27);
            this.TxtAra.Name = "TxtAra";
            this.TxtAra.Size = new System.Drawing.Size(129, 31);
            this.TxtAra.TabIndex = 25;
            // 
            // BtnAra
            // 
            this.BtnAra.BackColor = System.Drawing.Color.White;
            this.BtnAra.ImageIndex = 3;
            this.BtnAra.ImageList = this.ımageList1;
            this.BtnAra.Location = new System.Drawing.Point(308, 23);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(42, 39);
            this.BtnAra.TabIndex = 26;
            this.BtnAra.UseVisualStyleBackColor = false;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8_cancel_480px_1.png");
            this.ımageList1.Images.SetKeyName(1, "icons8_refresh_480px_1.png");
            this.ımageList1.Images.SetKeyName(2, "icons8_delete_240px.png");
            this.ımageList1.Images.SetKeyName(3, "icons8_search_500px.png");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(28, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 23);
            this.label9.TabIndex = 24;
            this.label9.Text = "Barkod No Ara:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnGuncelle);
            this.groupBox3.Controls.Add(this.BtnSil);
            this.groupBox3.Location = new System.Drawing.Point(869, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 259);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.White;
            this.BtnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuncelle.ImageIndex = 1;
            this.BtnGuncelle.ImageList = this.ımageList1;
            this.BtnGuncelle.Location = new System.Drawing.Point(6, 59);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(124, 48);
            this.BtnGuncelle.TabIndex = 6;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.White;
            this.BtnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSil.ImageIndex = 2;
            this.BtnSil.ImageList = this.ımageList1;
            this.BtnSil.Location = new System.Drawing.Point(6, 131);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(124, 48);
            this.BtnSil.TabIndex = 7;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 345);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1002, 192);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // LblKitapSayısı
            // 
            this.LblKitapSayısı.AutoSize = true;
            this.LblKitapSayısı.BackColor = System.Drawing.Color.White;
            this.LblKitapSayısı.Location = new System.Drawing.Point(162, 549);
            this.LblKitapSayısı.Name = "LblKitapSayısı";
            this.LblKitapSayısı.Size = new System.Drawing.Size(20, 23);
            this.LblKitapSayısı.TabIndex = 28;
            this.LblKitapSayısı.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(6, 549);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 23);
            this.label11.TabIndex = 27;
            this.label11.Text = "Kayıtlı Kitap Sayısı:";
            // 
            // BtnCıkıs
            // 
            this.BtnCıkıs.BackColor = System.Drawing.Color.White;
            this.BtnCıkıs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCıkıs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCıkıs.ImageIndex = 0;
            this.BtnCıkıs.ImageList = this.ımageList1;
            this.BtnCıkıs.Location = new System.Drawing.Point(884, 543);
            this.BtnCıkıs.Name = "BtnCıkıs";
            this.BtnCıkıs.Size = new System.Drawing.Size(121, 34);
            this.BtnCıkıs.TabIndex = 29;
            this.BtnCıkıs.Text = "Çıkış";
            this.BtnCıkıs.UseVisualStyleBackColor = false;
            this.BtnCıkıs.Click += new System.EventHandler(this.BtnCıkıs_Click);
            // 
            // FrmKitapListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 579);
            this.Controls.Add(this.BtnCıkıs);
            this.Controls.Add(this.LblKitapSayısı);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmKitapListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKitapListele";
            this.Load += new System.EventHandler(this.FrmKitapListele_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtYazarAdı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBarkodNo;
        private System.Windows.Forms.TextBox TxtSayfaSayısı;
        private System.Windows.Forms.TextBox TxtKitapAdı;
        private System.Windows.Forms.TextBox TxtYayınevi;
        private System.Windows.Forms.TextBox TxtBasımYılı;
        private System.Windows.Forms.ComboBox CmbKitaptürü;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtStokSayısı;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtAçıklama;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.TextBox TxtAra;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblKitapSayısı;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnCıkıs;
        private System.Windows.Forms.ImageList ımageList1;
    }
}