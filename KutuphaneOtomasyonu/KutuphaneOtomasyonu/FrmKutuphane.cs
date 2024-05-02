using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KutuphaneOtomasyonu
{
    public partial class FrmKutuphane : Form
    {
        public FrmKutuphane()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            DialogResult diyalog;
            diyalog = MessageBox.Show("Çıkış Yapmak İstediğinizden Emin Misiniz?", "Soru Pencresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diyalog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnUyeListele_Click(object sender, EventArgs e)
        {
            FrmUyeListele fr = new FrmUyeListele();
            fr.Show();
        }

        private void BtnKitapEkle_Click(object sender, EventArgs e)
        {
            FrmKitapEkle fr = new FrmKitapEkle();
            fr.Show();
        }

        private void BtnKitapListele_Click(object sender, EventArgs e)
        {
            FrmKitapListele fr = new FrmKitapListele();
            fr.Show();
        }

        private void BtnEmanetAlVer_Click(object sender, EventArgs e)
        {
            FrmEmanetKitapVerme fr = new FrmEmanetKitapVerme();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEmanetKitapListele fr = new FrmEmanetKitapListele();
            fr.Show();
        }

        private void BtnEmanetVerilenKitaplar_Click(object sender, EventArgs e)
        {
            FrmEmanetKitapİade fr = new FrmEmanetKitapİade();
            fr.Show();
        }
    }
}
