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
    public partial class FrmEmanetKitapVerme : Form
    {
        public FrmEmanetKitapVerme()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        bool durum;

        private void emanetkitapkontrol()
        {
            durum= true;
            SqlCommand komut = new SqlCommand("Select * from TBL_EMANETKİTAPLAR", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (TxtBarkodNo.Text==dr[5].ToString() || TxtBarkodNo.Text=="")
                {
                    durum = false;
                }
                
            }
            bgl.baglanti().Close();
        }

        private void sepetlistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select*from TBL_SEPET", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
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
            emanetkitapkontrol();
            if (durum==true)
            {
                SqlCommand komut = new SqlCommand("insert into TBL_SEPET(BarkodNo,KitapAdi,YazarAdi,Yayınevi,SayfaSayisi,StokSayisi,TeslimTarihi,İadeTarihi values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtBarkodNo.Text);
                komut.Parameters.AddWithValue("@p2", TxtKitapAdı.Text);
                komut.Parameters.AddWithValue("@p3", TxtYazarAdı.Text);
                komut.Parameters.AddWithValue("@p4", TxtYayınevi.Text);
                komut.Parameters.AddWithValue("@p5", TxtSayfaSayısı.Text);
                komut.Parameters.AddWithValue("@p6", int.Parse(TxtStokSayısı.Text));
                komut.Parameters.AddWithValue("@p7", dateTimePicker1.Text);
                komut.Parameters.AddWithValue("@p8", dateTimePicker2.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kitaplar Sepete Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sepetlistele();
                LblKitapSayısı.Text = "";
                stoksayisi();
            }
            else
            {
                MessageBox.Show("Önce Kitap Bilgileri Eklenmelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != TxtStokSayısı) //KİTAP SAYISNI HARİÇ TUTUYORUZ
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void stoksayisi()
        {
            SqlCommand komut = new SqlCommand("Select sum(StokSayisi) from TBL_SEPET", bgl.baglanti());
            LblKitapSayısı.Text = komut.ExecuteScalar().ToString();
            bgl.baglanti().Close();
        }
        private void FrmEmanetKitapVerme_Load(object sender, EventArgs e)
        {
            sepetlistele();

        }

        private void MskTC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TBL_UYE where TC like '" + MskTC.Text + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                MskTelefon.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();


            SqlCommand komut2 = new SqlCommand("Select sum(StokSayisi) from TBL_EMANETKİTAPLAR where TC='" + MskTC.Text + "'", bgl.baglanti());
            LblKayıtlıKitapSayısı.Text = komut2.ExecuteScalar().ToString();
            bgl.baglanti().Close();

            if (MskTC.Text == "")
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item is MaskedTextBox)
                        {
                            item.Text = "";
                        }
                    }
                }
                LblKayıtlıKitapSayısı.Text = "";

            }
        }

        private void TxtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TBL_KİTAP where BarkodNo like '" + TxtBarkodNo.Text + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtKitapAdı.Text = dr[2].ToString();
                TxtYazarAdı.Text = dr[3].ToString();
                TxtYayınevi.Text = dr[4].ToString();
                TxtSayfaSayısı.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();

            if (MskTC.Text == "")
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item is MaskedTextBox)
                        {
                            item.Text = "";
                        }
                    }
                }
                LblKayıtlıKitapSayısı.Text = "";
            }
        }

                private void BtnSil_Click(object sender, EventArgs e)
                {
                   DialogResult diyalog;
                   diyalog = MessageBox.Show("Kayıt silmek istediğinizden emin misiniz?", "Soru Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diyalog==DialogResult.Yes)
                {
                  SqlCommand komut = new SqlCommand("Delete from TBL_SEPET where BarkodNo='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'", bgl.baglanti());
                  komut.ExecuteNonQuery();
                  bgl.baglanti().Close();
                  MessageBox.Show("Silme İşlemi Yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  sepetlistele();
                  LblKitapSayısı.Text = "";
                  stoksayisi();
                }
           
                }
        private void BtnTeslimEt_Click(object sender, EventArgs e)
        {
            if (LblKitapSayısı.Text!="") // BOŞLUKTAN FARKLI İSE
            {
                if (LblKayıtlıKitapSayısı.Text == "" && int.Parse(LblKitapSayısı.Text) <= 3 || LblKayıtlıKitapSayısı.Text != "" && int.Parse(LblKayıtlıKitapSayısı.Text) + int.Parse(LblKitapSayısı.Text) <= 3)
                {
                    if (MskTC.Text!="" && TxtAd.Text!="" && TxtSoyad.Text!="" && MskTelefon.Text!="")
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) // SEPETTEN EKSİLECEK
                        {
                            SqlCommand komut = new SqlCommand("insert into TBL_EMANETKİTAPLAR  (TC,Ad,Soyad,Telefon,BarkodNo,KitapAdi,YazarAdi,Yayınevi,SayfaSayisi,StokSayisi,TeslimTarihi,İadeTarihi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", bgl.baglanti());
                            komut.Parameters.AddWithValue("@p1", MskTC.Text);
                            komut.Parameters.AddWithValue("@p2", TxtAd.Text);
                            komut.Parameters.AddWithValue("@p3", TxtSoyad.Text);
                            komut.Parameters.AddWithValue("@p4", MskTelefon.Text);
                            komut.Parameters.AddWithValue("@p5", dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString());
                            komut.Parameters.AddWithValue("@p6", dataGridView1.Rows[i].Cells["KitapAdi"].Value.ToString());
                            komut.Parameters.AddWithValue("@p7", dataGridView1.Rows[i].Cells["YazarAdi"].Value.ToString());
                            komut.Parameters.AddWithValue("@p8", dataGridView1.Rows[i].Cells["Yayınevi"].Value.ToString());
                            komut.Parameters.AddWithValue("@p9", dataGridView1.Rows[i].Cells["SayfaSayisi"].Value.ToString());
                            komut.Parameters.AddWithValue("@p10", dataGridView1.Rows[i].Cells["StokSayisi"].Value.ToString());
                            komut.Parameters.AddWithValue("@p11", dataGridView1.Rows[i].Cells["TeslimTarihi"].Value.ToString());
                            komut.Parameters.AddWithValue("@p12", dataGridView1.Rows[i].Cells["İadeTarihi"].Value.ToString());
                            komut.ExecuteNonQuery();

                            SqlCommand komut4 = new SqlCommand("Update TBL_EMANETKİTAPLAR set StokSayisi=StokSayisi+'" + int.Parse(dataGridView1.Rows[i].Cells["StokSayisi"].Value.ToString()) + "'where BarkodNo='" + dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString() + "'", bgl.baglanti());

                            SqlCommand komut2 = new SqlCommand("Update TBL_KİTAP set StokSayisi=StokSayisi-'" + int.Parse(dataGridView1.Rows[i].Cells["StokSayisi"].Value.ToString()) + "'where BarkodNo='"+ dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString()+"'",bgl.baglanti());
                            komut2.ExecuteNonQuery();
                            bgl.baglanti().Close();
                        }
                        SqlCommand komut3 = new SqlCommand("Delete from TBL_SEPET", bgl.baglanti());
                        komut3.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Kitaplar Emanet Edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sepetlistele();
                        MskTC.Text = "";
                        LblKitapSayısı.Text = "";
                        stoksayisi();
                        LblKayıtlıKitapSayısı.Text="";
                    }
                    else
                    {
                        MessageBox.Show("Önce Üye İsmi Seçmeniz Gerekir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Emanet Kitap Sayısı 3'ten Fazla Olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Önce Sepete Kitap Eklenmelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
    }
}
