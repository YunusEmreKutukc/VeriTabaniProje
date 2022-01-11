using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace DisHekimligiOto
{
    public partial class SEKRETER : Form
    {
        OracleBaglanti ODB = new OracleBaglanti();
      //burada sadece var olan randevular görünecek işlemler butonlardan yapılacak
        public SEKRETER()
        {
            InitializeComponent();
        }

        private void labelBaslik_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelBackground_Click(object sender, EventArgs e)
        {

        }

        private void SEKRETER_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet3.PROJ_HASTA' table. You can move, or remove it, as needed.
            this.pROJ_HASTATableAdapter.Fill(this.dataSet3.PROJ_HASTA);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            RandevuAL randevuAL = new RandevuAL();
            randevuAL.Show();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
      
                int secimHasta;
                secimHasta = dataGridViewRandevu.SelectedCells[0].RowIndex;
                SekreterGuncelle sekGuncelle = new SekreterGuncelle();
                sekGuncelle.id = dataGridViewRandevu.Rows[secimHasta].Cells[0].Value.ToString();
                sekGuncelle.ad = dataGridViewRandevu.Rows[secimHasta].Cells[1].Value.ToString();
                sekGuncelle.soyad = dataGridViewRandevu.Rows[secimHasta].Cells[2].Value.ToString();
                sekGuncelle.tc = dataGridViewRandevu.Rows[secimHasta].Cells[3].Value.ToString();
                sekGuncelle.meslek = dataGridViewRandevu.Rows[secimHasta].Cells[6].Value.ToString();
                sekGuncelle.tel = dataGridViewRandevu.Rows[secimHasta].Cells[8].Value.ToString();
                sekGuncelle.sikayet = dataGridViewRandevu.Rows[secimHasta].Cells[11].Value.ToString();
                sekGuncelle.adres = dataGridViewRandevu.Rows[secimHasta].Cells[10].Value.ToString();
                sekGuncelle.eposta = dataGridViewRandevu.Rows[secimHasta].Cells[9].Value.ToString();
                sekGuncelle.Show();
    
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            string select = "SELECT * FROM PROJ_HASTA";
            OracleDataAdapter oDa = new OracleDataAdapter(select, ODB.orCon());
            DataTable dt = new DataTable();
            oDa.Fill(dt);
            dataGridViewRandevu.DataSource = dt;
            ODB.orCon().Close();
        }
    }
    
}
