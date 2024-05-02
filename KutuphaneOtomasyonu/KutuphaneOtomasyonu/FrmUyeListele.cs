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
    public partial class FrmUyeListele : Form
    {
        public FrmUyeListele()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select*from TBL_UYE", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void FrmUyeListele_Load(object sender, EventArgs e)
        {
            listele();
            SqlCommand komut = new SqlCommand("Select count(*)from TBL_UYE", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblUyeSayısı.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            DialogResult diyalog;
            diyalog = MessageBox.Show("Çıkış Yapmak İstediğinizden Emin Misiniz?", "Soru Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diyalog==DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult diyalog;
            diyalog = MessageBox.Show("Bu kişiyi güncellemek istediğinizden emin misiniz?", "Soru Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diyalog == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Update TBL_UYE set Ad=@p1,Soyad=@p2,DogumTarihi=@p4,Cinsiyet=@p5,Telefon=@p6,Email=@p7,Sifre=@p8,Adres=@p9 where TC=@p3", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", MskTC.Text);
                komut.Parameters.AddWithValue("@p4", DtDogumTarihi.Text);
                komut.Parameters.AddWithValue("@p5", CmbCinsiyet.Text);
                komut.Parameters.AddWithValue("@p6", MskTelefon.Text);
                komut.Parameters.AddWithValue("@p7", TxtEmail.Text);
                komut.Parameters.AddWithValue("@p8", TxtSifre.Text);
                komut.Parameters.AddWithValue("@p9", TxtAdres.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                listele();
                MessageBox.Show("Kişi Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (item is MaskedTextBox)
                    {
                        item.Text = "";
                    }

                }
            }
        
        }

        

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult diyalog;
            diyalog = MessageBox.Show("Bu kişiyi silmek istediğinizden emin misiniz?", "Soru Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diyalog==DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete from TBL_UYE Where TC=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", MskTC.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                listele();
                MessageBox.Show("Kişi Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskTC.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            DtDogumTarihi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            CmbCinsiyet.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            MskTelefon.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            TxtEmail.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            TxtAdres.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select* from TBL_UYE where TC like '%" + TxtAra.Text + "%'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

    }
}