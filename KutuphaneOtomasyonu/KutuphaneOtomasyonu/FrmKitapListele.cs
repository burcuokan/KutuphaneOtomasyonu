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
    public partial class FrmKitapListele : Form
    {
        public FrmKitapListele()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select*from TBL_KİTAP", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

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

        private void FrmKitapListele_Load(object sender, EventArgs e)
        {
            listele();
            SqlCommand komut = new SqlCommand("Select count(*)from TBL_KİTAP", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblKitapSayısı.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult diyalog;
            diyalog = MessageBox.Show("Bu kitabı güncellemek istediğinizden emin misiniz?", "Soru Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diyalog == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Update TBL_KİTAP set KitapAdi=@p2,YazarAdi=@p3,Yayınevi=@p4,SayfaSayisi=@p5,KitapTuru=@p6,KitapBasımYılı=@P7,StokSayisi=@p8,Aciklama=@p9 where BarkodNo=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtBarkodNo.Text);
                komut.Parameters.AddWithValue("@p2", TxtKitapAdı.Text);
                komut.Parameters.AddWithValue("@p3", TxtYazarAdı.Text);
                komut.Parameters.AddWithValue("@p4", TxtYayınevi.Text);
                komut.Parameters.AddWithValue("@p5", TxtSayfaSayısı.Text);
                komut.Parameters.AddWithValue("@p6", CmbKitaptürü.Text);
                komut.Parameters.AddWithValue("@p7", TxtBasımYılı.Text);
                komut.Parameters.AddWithValue("@p8", int.Parse(TxtStokSayısı.Text));
                komut.Parameters.AddWithValue("@p9", TxtAçıklama.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                listele();
                MessageBox.Show("Kitap Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        }
        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult diyalog;
            diyalog = MessageBox.Show("Bu kitabı silmek istediğinizden emin misiniz?","Soru Penceresi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (diyalog==DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete from TBL_KİTAP where BarkodNo=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtBarkodNo.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                listele();
                MessageBox.Show("Kitap Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtBarkodNo.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtKitapAdı.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtYazarAdı.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtYayınevi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtSayfaSayısı.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            CmbKitaptürü.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            TxtBasımYılı.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            TxtStokSayısı.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            TxtAçıklama.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("select*from TBL_KİTAP where BarkodNo like '%" + TxtAra.Text + "%'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

       
    }
}
