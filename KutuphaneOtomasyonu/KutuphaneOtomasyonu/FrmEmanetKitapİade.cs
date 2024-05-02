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
    public partial class FrmEmanetKitapİade : Form
    {
        public FrmEmanetKitapİade()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            DialogResult diyalog;
            diyalog = MessageBox.Show("Çıkış Yapmak İstediğinizden Emin Misiniz?", "Soru Pencresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diyalog==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmEmanetKitapİade_Load(object sender, EventArgs e)
        {
            emanetlistele();
        }

        private void emanetlistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select*from TBL_EMANETKİTAPLAR", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
           DataTable dt = new DataTable();
           SqlDataAdapter da = new SqlDataAdapter("Select* from TBL_EMANETKİTAPLAR where BarkodNo like '%" + TxtAra.Text + "%'", bgl.baglanti());
           da.Fill(dt);
           dataGridView1.DataSource = dt;
        }

        private void BtnTeslimAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_EMANETKİTAPLAR where BarkodNo='" + dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString() +"'", bgl.baglanti());
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("Update TBL_KİTAP set StokSayisi=StokSayisi+'" + dataGridView1.CurrentRow.Cells["StokSayisi"].Value.ToString() +"' where BarkodNo=@BarkodNo" , bgl.baglanti());
            komut2.Parameters.AddWithValue("BarkodNo", dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString());
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kitaplar İade Edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            emanetlistele();
        }
    }
}
