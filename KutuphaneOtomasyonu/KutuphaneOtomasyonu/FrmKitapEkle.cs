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
    public partial class FrmKitapEkle : Form
    {
        public FrmKitapEkle()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        bool durum;
        private void kitapkontrol()
        {
            durum = true;
            SqlCommand komut = new SqlCommand("Select*from TBL_KİTAP", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (TxtBarkodNumarası.Text == dr[1].ToString() || TxtBarkodNumarası.Text == "")
                {
                    durum = false;
                }
                bgl.baglanti().Close();
            }
        }
        private void BtnKapat_Click(object sender, EventArgs e)
        {
            DialogResult diyalog;
            diyalog = MessageBox.Show("Çıkış Yapmak İstediğinizden Emin Misiniz?", "Soru Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diyalog==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            DialogResult diyalog;
            diyalog = MessageBox.Show("Bu kitabı kaydetmek istediğinizden emin misiniz?", "Soru Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diyalog == DialogResult.Yes)
            {
                kitapkontrol();
                if (durum == true)
                {
                    SqlCommand komut = new SqlCommand("insert into TBL_KİTAP (BarkodNo,KitapAdi,YazarAdi,Yayınevi,SayfaSayisi,Kitapturu,KitapBasımYılı,StokSayisi,Aciklama,KayıtTarihi)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", TxtBarkodNumarası.Text);
                    komut.Parameters.AddWithValue("@p2", TxtKitapAdı.Text);
                    komut.Parameters.AddWithValue("@p3", TxtYazarAdı.Text);
                    komut.Parameters.AddWithValue("@p4", TxtYayınevi.Text);
                    komut.Parameters.AddWithValue("@p5", TxtSayfaSayısı.Text);
                    komut.Parameters.AddWithValue("@p6", CmbKitaptürü.Text);
                    komut.Parameters.AddWithValue("@p7", TxtBasımYılı.Text);
                    komut.Parameters.AddWithValue("@p8", TxtStokSayısı.Text);
                    komut.Parameters.AddWithValue("@p9", TxtAçıklama.Text);
                    komut.Parameters.AddWithValue("@p10", DateTime.Now.ToShortDateString());
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Kitap Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Böyle bir kitap zaten var.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                    if (item is ComboBox)
                    {
                        item.Text = "";
                    }
                }
            }
    }   }
}
    

