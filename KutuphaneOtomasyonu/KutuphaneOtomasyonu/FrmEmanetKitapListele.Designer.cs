namespace KutuphaneOtomasyonu
{
    partial class FrmEmanetKitapListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmanetKitapListele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CmbAramaTürü = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCıkış = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.LblEmanetVerilenKitapSayısı = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(835, 355);
            this.dataGridView1.TabIndex = 0;
            // 
            // CmbAramaTürü
            // 
            this.CmbAramaTürü.FormattingEnabled = true;
            this.CmbAramaTürü.Items.AddRange(new object[] {
            "Tüm Kitaplar",
            "Geciken Kitaplar",
            "Gecikmeyen Kitaplar"});
            this.CmbAramaTürü.Location = new System.Drawing.Point(150, 30);
            this.CmbAramaTürü.Name = "CmbAramaTürü";
            this.CmbAramaTürü.Size = new System.Drawing.Size(169, 31);
            this.CmbAramaTürü.TabIndex = 1;
            this.CmbAramaTürü.Text = "Seçiniz...";
            this.CmbAramaTürü.SelectedIndexChanged += new System.EventHandler(this.CmbAramaTürü_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arama Türü:";
            // 
            // BtnCıkış
            // 
            this.BtnCıkış.BackColor = System.Drawing.Color.White;
            this.BtnCıkış.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCıkış.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCıkış.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnCıkış.ImageIndex = 0;
            this.BtnCıkış.ImageList = this.ımageList1;
            this.BtnCıkış.Location = new System.Drawing.Point(707, 460);
            this.BtnCıkış.Name = "BtnCıkış";
            this.BtnCıkış.Size = new System.Drawing.Size(127, 42);
            this.BtnCıkış.TabIndex = 29;
            this.BtnCıkış.Text = "Çıkış";
            this.BtnCıkış.UseVisualStyleBackColor = false;
            this.BtnCıkış.Click += new System.EventHandler(this.BtnCıkış_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8_cancel_480px_1.png");
            // 
            // LblEmanetVerilenKitapSayısı
            // 
            this.LblEmanetVerilenKitapSayısı.AutoSize = true;
            this.LblEmanetVerilenKitapSayısı.BackColor = System.Drawing.Color.White;
            this.LblEmanetVerilenKitapSayısı.Location = new System.Drawing.Point(221, 467);
            this.LblEmanetVerilenKitapSayısı.Name = "LblEmanetVerilenKitapSayısı";
            this.LblEmanetVerilenKitapSayısı.Size = new System.Drawing.Size(20, 23);
            this.LblEmanetVerilenKitapSayısı.TabIndex = 31;
            this.LblEmanetVerilenKitapSayısı.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(5, 467);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(220, 23);
            this.label11.TabIndex = 30;
            this.label11.Text = "Emanet Verilen Kitap Sayısı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbAramaTürü);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(493, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 72);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Yap";
            // 
            // FrmEmanetKitapListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(838, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblEmanetVerilenKitapSayısı);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtnCıkış);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmEmanetKitapListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet Kitap Listele";
            this.Load += new System.EventHandler(this.FrmEmanetKitapListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox CmbAramaTürü;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCıkış;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label LblEmanetVerilenKitapSayısı;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}