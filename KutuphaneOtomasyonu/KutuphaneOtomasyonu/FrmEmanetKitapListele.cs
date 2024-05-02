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
    public partial class FrmEmanetKitapListele : Form
    {
        public FrmEmanetKitapListele()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmEmanetKitapListele_Load(object sender, EventArgs e)
        {
            emanetlistele();
            SqlCommand komut = new SqlCommand("Select count(*) from TBL_EMANETKİTAPLAR", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblEmanetVerilenKitapSayısı.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();


        }

        private void emanetlistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_EMANETKİTAPLAR", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnCıkış_Click(object sender, EventArgs e)
        {
            DialogResult diyalog;
            diyalog = MessageBox.Show("Çıkış Yapmak İstediğinizden Emin Misiniz?", "Soru Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diyalog==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CmbAramaTürü_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbAramaTürü.SelectedIndex==0)
            {
                emanetlistele();
            }
            else if (CmbAramaTürü.SelectedIndex==1)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_EMANETKİTAPLAR where '"+DateTime.Now.ToShortDateString()+"'> İadeTarihi", bgl.baglanti());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (CmbAramaTürü.SelectedIndex==2)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_EMANETKİTAPLAR where '" + DateTime.Now.ToShortDateString() + "'< İadeTarihi", bgl.baglanti());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
