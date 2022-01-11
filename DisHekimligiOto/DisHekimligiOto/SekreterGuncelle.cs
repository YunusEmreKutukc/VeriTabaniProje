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
    public partial class SekreterGuncelle : Form
    {
        OracleBaglanti ODB = new OracleBaglanti();
        public string ad, soyad,eposta, meslek, adres, sikayet, id, tel, tc;

        private void button3_Click(object sender, EventArgs e)
        {
            OracleCommand hastSil = new OracleCommand("DELETE FROM PROJ_HASTA WHERE HASTID = :p1",ODB.orCon());
            hastSil.Parameters.Add(new OracleParameter("p1",textBoxID.Text));
            hastSil.ExecuteNonQuery();
            MessageBox.Show("SİLME İŞLEMİ BAŞARILI");
        }

        private void SekreterGuncelle_Load(object sender, EventArgs e)
        {
            textBoxAd.Text = ad;
            textBoxSoyad.Text = soyad;
            textBoxMeslek.Text = meslek;
            textBoxEposta.Text = eposta;
            textBoxID.Text = id;
            maskedTextBoxTC.Text = tc;
            maskedTextBoxTel.Text = tel;
            richTextBoxAdres.Text = adres;
            richTextBoxSikayet.Text = sikayet;

        }

        public SekreterGuncelle()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            OracleCommand komutEkle = new OracleCommand("UPDATE PROJ_HASTA SET HASTAD = :p1,HASTSOYAD = :p2 ,HASTTC = :p3 ,HASTDOGUM = :p4 ,HASTRANDEVU = :p5 ,HASTMESLEK = :p6,HASTCINSIYET = :p7 ,HASTSIKAYET = :p8 ,HASTADRES = :p9 ,HASTTEL = :p10 ,HASTEPOSTA = :p11 WHERE HASTID =  :p12", ODB.orCon());
            komutEkle.Parameters.Add(new OracleParameter("p1", textBoxAd.Text));
            komutEkle.Parameters.Add(new OracleParameter("p2", textBoxSoyad.Text));
            komutEkle.Parameters.Add(new OracleParameter("p3", maskedTextBoxTC.Text));
            komutEkle.Parameters.Add(new OracleParameter("p4", maskedTextBoxDogum.Text));
            komutEkle.Parameters.Add(new OracleParameter("p5", maskedTextBoxRandevu.Text));
            komutEkle.Parameters.Add(new OracleParameter("p6", textBoxMeslek.Text));
            komutEkle.Parameters.Add(new OracleParameter("p7", comboBoxCinsiyet.SelectedItem.ToString()));
            komutEkle.Parameters.Add(new OracleParameter("p8", richTextBoxSikayet.Text));
            komutEkle.Parameters.Add(new OracleParameter("p9", richTextBoxAdres.Text));
            komutEkle.Parameters.Add(new OracleParameter("p10", maskedTextBoxTel.Text));
            komutEkle.Parameters.Add(new OracleParameter("p11", textBoxEposta.Text));
            komutEkle.Parameters.Add(new OracleParameter("p12", textBoxID.Text));
            komutEkle.ExecuteNonQuery();
            MessageBox.Show("KAYIT EKLENDI");
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
