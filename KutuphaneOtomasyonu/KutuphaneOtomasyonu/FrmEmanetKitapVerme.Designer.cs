namespace KutuphaneOtomasyonu
{
    partial class FrmEmanetKitapVerme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmanetKitapVerme));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtStokSayısı = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtYayınevi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtYazarAdı = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtBarkodNo = new System.Windows.Forms.TextBox();
            this.TxtSayfaSayısı = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtKitapAdı = new System.Windows.Forms.TextBox();
            this.BtnSil = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnTeslimEt = new System.Windows.Forms.Button();
            this.BtnCıkıs = new System.Windows.Forms.Button();
            this.LblKayıtlıKitapSayısı = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LblKitapSayısı = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(321, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.MskTelefon);
            this.groupBox1.Controls.Add(this.MskTC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 193);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Bilgileri";
//            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefon:";
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(81, 146);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(186, 31);
            this.MskTelefon.TabIndex = 4;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(81, 26);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(186, 31);
            this.MskTC.TabIndex = 1;
            this.MskTC.ValidatingType = typeof(int);
            this.MskTC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MskTC_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "TC:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(81, 66);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(186, 31);
            this.TxtAd.TabIndex = 2;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(81, 106);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(186, 31);
            this.TxtSoyad.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Soyad:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.TxtStokSayısı);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.TxtYayınevi);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TxtYazarAdı);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TxtBarkodNo);
            this.groupBox2.Controls.Add(this.TxtSayfaSayısı);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtKitapAdı);
            this.groupBox2.Location = new System.Drawing.Point(12, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 348);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Bilgileri";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(121, 310);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(165, 31);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 312);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 23);
            this.label12.TabIndex = 7;
            this.label12.Text = "İade Tarihi:";
            // 
            // TxtStokSayısı
            // 
            this.TxtStokSayısı.Location = new System.Drawing.Point(121, 230);
            this.TxtStokSayısı.Name = "TxtStokSayısı";
            this.TxtStokSayısı.Size = new System.Drawing.Size(165, 31);
            this.TxtStokSayısı.TabIndex = 10;
            this.TxtStokSayısı.Text = "1";
            this.TxtStokSayısı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 23);
            this.label10.TabIndex = 22;
            this.label10.Text = "Stok Sayısı:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 270);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 31);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 23);
            this.label11.TabIndex = 5;
            this.label11.Text = "Teslim Tarihi:";
            // 
            // TxtYayınevi
            // 
            this.TxtYayınevi.Location = new System.Drawing.Point(121, 150);
            this.TxtYayınevi.Name = "TxtYayınevi";
            this.TxtYayınevi.Size = new System.Drawing.Size(165, 31);
            this.TxtYayınevi.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Sayfa Sayısı:";
            // 
            // TxtYazarAdı
            // 
            this.TxtYazarAdı.Location = new System.Drawing.Point(121, 110);
            this.TxtYazarAdı.Name = "TxtYazarAdı";
            this.TxtYazarAdı.Size = new System.Drawing.Size(165, 31);
            this.TxtYazarAdı.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Yayınevi:";
            // 
            // TxtBarkodNo
            // 
            this.TxtBarkodNo.Location = new System.Drawing.Point(121, 30);
            this.TxtBarkodNo.Name = "TxtBarkodNo";
            this.TxtBarkodNo.Size = new System.Drawing.Size(165, 31);
            this.TxtBarkodNo.TabIndex = 5;
            this.TxtBarkodNo.TextChanged += new System.EventHandler(this.TxtBarkodNo_TextChanged);
            // 
            // TxtSayfaSayısı
            // 
            this.TxtSayfaSayısı.Location = new System.Drawing.Point(121, 190);
            this.TxtSayfaSayısı.Name = "TxtSayfaSayısı";
            this.TxtSayfaSayısı.Size = new System.Drawing.Size(165, 31);
            this.TxtSayfaSayısı.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kitap Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Barkod No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Yazar Adı:";
            // 
            // TxtKitapAdı
            // 
            this.TxtKitapAdı.Location = new System.Drawing.Point(121, 70);
            this.TxtKitapAdı.Name = "TxtKitapAdı";
            this.TxtKitapAdı.Size = new System.Drawing.Size(165, 31);
            this.TxtKitapAdı.TabIndex = 6;
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.White;
            this.BtnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSil.ImageIndex = 2;
            this.BtnSil.ImageList = this.ımageList1;
            this.BtnSil.Location = new System.Drawing.Point(637, 378);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(145, 48);
            this.BtnSil.TabIndex = 6;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "21635-middle.png");
            this.ımageList1.Images.SetKeyName(1, "kitap ekleme 2.png");
            this.ımageList1.Images.SetKeyName(2, "icons8_delete_240px.png");
            this.ımageList1.Images.SetKeyName(3, "icons8_cancel_480px_1.png");
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.White;
            this.BtnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEkle.ImageIndex = 0;
            this.BtnEkle.ImageList = this.ımageList1;
            this.BtnEkle.Location = new System.Drawing.Point(321, 378);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(145, 48);
            this.BtnEkle.TabIndex = 8;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnTeslimEt
            // 
            this.BtnTeslimEt.BackColor = System.Drawing.Color.White;
            this.BtnTeslimEt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTeslimEt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTeslimEt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnTeslimEt.ImageIndex = 1;
            this.BtnTeslimEt.ImageList = this.ımageList1;
            this.BtnTeslimEt.Location = new System.Drawing.Point(479, 376);
            this.BtnTeslimEt.Name = "BtnTeslimEt";
            this.BtnTeslimEt.Size = new System.Drawing.Size(145, 48);
            this.BtnTeslimEt.TabIndex = 9;
            this.BtnTeslimEt.Text = "Teslim Et";
            this.BtnTeslimEt.UseVisualStyleBackColor = false;
            this.BtnTeslimEt.Click += new System.EventHandler(this.BtnTeslimEt_Click);
            // 
            // BtnCıkıs
            // 
            this.BtnCıkıs.BackColor = System.Drawing.Color.White;
            this.BtnCıkıs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCıkıs.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnCıkıs.ImageIndex = 3;
            this.BtnCıkıs.ImageList = this.ımageList1;
            this.BtnCıkıs.Location = new System.Drawing.Point(795, 378);
            this.BtnCıkıs.Name = "BtnCıkıs";
            this.BtnCıkıs.Size = new System.Drawing.Size(145, 48);
            this.BtnCıkıs.TabIndex = 20;
            this.BtnCıkıs.Text = "Çıkış";
            this.BtnCıkıs.UseVisualStyleBackColor = false;
            this.BtnCıkıs.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // LblKayıtlıKitapSayısı
            // 
            this.LblKayıtlıKitapSayısı.AutoSize = true;
            this.LblKayıtlıKitapSayısı.BackColor = System.Drawing.Color.White;
            this.LblKayıtlıKitapSayısı.Location = new System.Drawing.Point(605, 459);
            this.LblKayıtlıKitapSayısı.Name = "LblKayıtlıKitapSayısı";
            this.LblKayıtlıKitapSayısı.Size = new System.Drawing.Size(0, 23);
            this.LblKayıtlıKitapSayısı.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(450, 459);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 23);
            this.label13.TabIndex = 29;
            this.label13.Text = "Kayıtlı Kitap Sayısı:";
            // 
            // LblKitapSayısı
            // 
            this.LblKitapSayısı.AutoSize = true;
            this.LblKitapSayısı.BackColor = System.Drawing.Color.White;
            this.LblKitapSayısı.Location = new System.Drawing.Point(753, 459);
            this.LblKitapSayısı.Name = "LblKitapSayısı";
            this.LblKitapSayısı.Size = new System.Drawing.Size(0, 23);
            this.LblKitapSayısı.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(653, 459);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 23);
            this.label15.TabIndex = 31;
            this.label15.Text = "Kitap Sayısı:";
            // 
            // FrmEmanetKitapVerme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(945, 554);
            this.Controls.Add(this.LblKitapSayısı);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.LblKayıtlıKitapSayısı);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.BtnCıkıs);
            this.Controls.Add(this.BtnTeslimEt);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmEmanetKitapVerme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet Kitap Verme";
            this.Load += new System.EventHandler(this.FrmEmanetKitapVerme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtYazarAdı;
        private System.Windows.Forms.TextBox TxtBarkodNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtKitapAdı;
        private System.Windows.Forms.TextBox TxtYayınevi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtSayfaSayısı;
        private System.Windows.Forms.TextBox TxtStokSayısı;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnTeslimEt;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button BtnCıkıs;
        private System.Windows.Forms.Label LblKayıtlıKitapSayısı;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LblKitapSayısı;
        private System.Windows.Forms.Label label15;
    }
}