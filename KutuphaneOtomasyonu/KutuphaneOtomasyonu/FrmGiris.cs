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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi(); // SINIFI ÇAĞIRDIK

        bool durum;
        private void giriskontrol()
        {
            durum = true;
            SqlCommand komut = new SqlCommand("Select*from TBL_UYE", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (TxtEmail.Text == dr[7].ToString() && TxtEmail.Text == "" || TxtSifre.Text == dr[8].ToString() && TxtSifre.Text == "")
                {
                    durum = false;
                }
                bgl.baglanti().Close();
            }
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            giriskontrol();
            if (durum == true)
            {
                SqlCommand komut = new SqlCommand("Select*from TBL_UYE where Email=@p1 and Sifre=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtEmail.Text);
                komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Sisteme Başarılı Bir Şekilde Giriş Yapıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmKutuphane fr = new FrmKutuphane();
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Email & Şifre");
                }
                bgl.baglanti().Close();

            }

        }
        private void LnkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUye fr = new FrmUye();
            fr.Show();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {

            if (checkBox2.CheckState == CheckState.Checked)
            {
                TxtSifre.UseSystemPasswordChar = false;
            }
            else if (checkBox2.CheckState == CheckState.Unchecked)
            {
                TxtSifre.UseSystemPasswordChar = true;
            }
        }
    }
}