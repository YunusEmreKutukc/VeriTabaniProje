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
    public partial class Yonetici : Form
    {
        OracleBaglanti ODB = new OracleBaglanti();
        public Yonetici()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Yonetici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetUyelik.PROJ_GIRIS' table. You can move, or remove it, as needed.
            this.pROJ_GIRISTableAdapter.Fill(this.dataSetUyelik.PROJ_GIRIS);
            // TODO: This line of code loads data into the 'oracleDBCalisan.PROJ_CALISAN' table. You can move, or remove it, as needed.
            this.pROJ_CALISANTableAdapter.Fill(this.oracleDBCalisan.PROJ_CALISAN);
            // TODO: This line of code loads data into the 'oracleDBDoktor.PROJ_DOKTOR' table. You can move, or remove it, as needed.
            this.pROJ_DOKTORTableAdapter.Fill(this.oracleDBDoktor.PROJ_DOKTOR);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            YoneticiDoktorEkle dokEkle = new YoneticiDoktorEkle();
            dokEkle.Show();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            YoneticiPersonelEkle persEkle = new YoneticiPersonelEkle();
            persEkle.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                  
        }

        private void dataGridViewDoktor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim;
            secim = dataGridViewDoktor.SelectedCells[0].RowIndex;
            YoneticiDoktorGuncelle dokGuncelle = new YoneticiDoktorGuncelle();
            dokGuncelle.id = dataGridViewDoktor.Rows[secim].Cells[0].Value.ToString();
            dokGuncelle.ad = dataGridViewDoktor.Rows[secim].Cells[1].Value.ToString();
            dokGuncelle.soyad = dataGridViewDoktor.Rows[secim].Cells[2].Value.ToString();
            dokGuncelle.tc = dataGridViewDoktor.Rows[secim].Cells[3].Value.ToString();
            dokGuncelle.telefon = dataGridViewDoktor.Rows[secim].Cells[4].Value.ToString();
            dokGuncelle.uzmanlik = dataGridViewDoktor.Rows[secim].Cells[5].Value.ToString();
            dokGuncelle.adres = dataGridViewDoktor.Rows[secim].Cells[6].Value.ToString();
            dokGuncelle.eposta = dataGridViewDoktor.Rows[secim].Cells[7].Value.ToString();
            dokGuncelle.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string select = "SELECT * FROM PROJ_DOKTOR";
            OracleDataAdapter oDa = new OracleDataAdapter(select, ODB.orCon());
            DataTable dt = new DataTable();
            oDa.Fill(dt);
            dataGridViewDoktor.DataSource = dt;
            ODB.orCon().Close();
        }

        private void dataGridViewPersonel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secimPers;
            secimPers = dataGridViewPersonel.SelectedCells[0].RowIndex;
            YoneticiPersonelGuncelle perGuncelle = new YoneticiPersonelGuncelle();
            perGuncelle.id = dataGridViewPersonel.Rows[secimPers].Cells[0].Value.ToString();
            perGuncelle.ad = dataGridViewPersonel.Rows[secimPers].Cells[1].Value.ToString();
            perGuncelle.soyad = dataGridViewPersonel.Rows[secimPers].Cells[2].Value.ToString();
            perGuncelle.tc = dataGridViewPersonel.Rows[secimPers].Cells[3].Value.ToString();
            perGuncelle.telefon = dataGridViewPersonel.Rows[secimPers].Cells[4].Value.ToString();
            perGuncelle.uzmanlik = dataGridViewPersonel.Rows[secimPers].Cells[5].Value.ToString();
            perGuncelle.adres = dataGridViewPersonel.Rows[secimPers].Cells[6].Value.ToString();
            perGuncelle.eposta = dataGridViewPersonel.Rows[secimPers].Cells[7].Value.ToString();
            perGuncelle.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OracleCommand uyeEkle = new OracleCommand("INSERT INTO PROJ_GIRIS(GIRISKULAD,GIRISPAROLA,GIRISUZMANLIK) VALUES(:p1, :p2, :p3)",ODB.orCon());
            uyeEkle.Parameters.Add(new OracleParameter("p1",textBoxKulAd.Text));
            uyeEkle.Parameters.Add(new OracleParameter("p2",textBoxParola.Text));
            uyeEkle.Parameters.Add(new OracleParameter("p3",comboBoxTür.SelectedItem.ToString()));
            uyeEkle.ExecuteNonQuery();
            MessageBox.Show("UYE EKLEME İŞLEMİ BAŞARILI");
            dataGridViewUye.DataSource = null;
            dataGridViewUye.DataSource = pROJGIRISBindingSource;
            dataGridViewUye.Update();
            dataGridViewUye.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try {
                OracleCommand uyeKaldir = new OracleCommand("DELETE FROM PROJ_GIRIS WHERE GIRISID = :p1", ODB.orCon());
                uyeKaldir.Parameters.Add(new OracleParameter("p1", textBoxID.Text));
                uyeKaldir.ExecuteNonQuery();
                MessageBox.Show("UYE KALDIRILDI");
            }
            catch {
                MessageBox.Show("KALDIRALACAK UYENIN IDSINI GİRİN");
            }
        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string select = "SELECT * FROM PROJ_CALISAN";
            OracleDataAdapter oDa = new OracleDataAdapter(select, ODB.orCon());
            DataTable dt = new DataTable();
            oDa.Fill(dt);
            dataGridViewDoktor.DataSource = dt;
            ODB.orCon().Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string select = "SELECT * FROM PROJ_GIRIS";
            OracleDataAdapter oDa = new OracleDataAdapter(select, ODB.orCon());
            DataTable dt = new DataTable();
            oDa.Fill(dt);
            dataGridViewDoktor.DataSource = dt;
            ODB.orCon().Close();
        }
    }
}
