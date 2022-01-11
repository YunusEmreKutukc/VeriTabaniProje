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
    public partial class GirisEkrani : Form
    {
        OracleBaglanti DB = new OracleBaglanti();
        public string girisTur;
        public GirisEkrani()
        {
            InitializeComponent();
            
        }

        private void labelBckGrnd_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            OracleCommand komut = new OracleCommand("SELECT*FROM PROJ_GIRIS WHERE GIRISKULAD = :p1 AND GIRISPAROLA = :p2 AND GIRISUZMANLIK= :p3 ", DB.orCon());
            komut.Parameters.Add(new OracleParameter("p1",textBoxKulAd.Text));
            komut.Parameters.Add(new OracleParameter("p2", textBoxParola.Text));
            komut.Parameters.Add(new OracleParameter("p3", comboBoxGiris.SelectedItem.ToString()));

            OracleDataReader read = komut.ExecuteReader();
            if (read.Read())
            {
                girisTur = comboBoxGiris.SelectedItem.ToString();
                if (girisTur.Equals("YONETICI")) {
                    Yonetici formYonetici = new Yonetici();
                    formYonetici.Show();
                   // this.Close();
       
                }
                else if (girisTur.Equals("DOKTOR")) {
                    DOKTOR doktor = new DOKTOR();
                    doktor.Show();
                }
                else if (girisTur.Equals("SEKRETER")) {
                    SEKRETER sekreter = new SEKRETER();
                    sekreter.Show();
                }

            }
            else
            {
                MessageBox.Show("HATALI KULLANICI ADI VEYA PAROLA GİRDİNİZ");
            }
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
