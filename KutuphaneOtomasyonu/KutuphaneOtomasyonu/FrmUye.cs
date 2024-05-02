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
    public partial class FrmUye : Form
    {
        public FrmUye()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        bool durum;
        private void uyekontrol()
        {
            durum = true;
            SqlCommand komut = new SqlCommand("Select*from TBL_UYE", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (MskTC.Text == dr[3].ToString() || MskTC.Text == "")
                {
                    durum = false;
                }
            }
            bgl.baglanti().Close();

        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            DialogResult diyalog;
            diyalog = MessageBox.Show("Üye kaydetmek istediğinizden emin misiniz?", "Soru Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diyalog == DialogResult.Yes)
            {
                uyekontrol();
                if (durum == true)
                {

                    SqlCommand komut = new SqlCommand("insert into TBL_UYE (Ad,Soyad,TC,DogumTarihi,Cinsiyet,Telefon,Email,Sifre,Adres) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                    komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
                    komut.Parameters.AddWithValue("@p3", MskTC.Text);
                    komut.Parameters.AddWithValue("@p4", dateTimePicker1.Text);
                    komut.Parameters.AddWithValue("@p5", CmbCinsiyet.Text);
                    komut.Parameters.AddWithValue("@p6", MskTelefon.Text);
                    komut.Parameters.AddWithValue("@p7", TxtEmail.Text);
                    komut.Parameters.AddWithValue("@p8", TxtSifre.Text);
                    komut.Parameters.AddWithValue("@p9", TxtAdres.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Üye Kaydı Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Böyle bir üye zaten var.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                    if (item is ComboBox)
                    {
                        item.Text = "";
                    }
                    if (item is MaskedTextBox)
                    {
                        item.Text = "";

                    }
                }
            }
        }
            private void BtnKapat_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    }

