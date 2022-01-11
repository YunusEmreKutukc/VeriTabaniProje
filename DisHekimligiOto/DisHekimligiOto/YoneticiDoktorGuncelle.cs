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
    public partial class YoneticiDoktorGuncelle : Form
    {
        OracleBaglanti ODB = new OracleBaglanti();
        public string id, ad, soyad, uzmanlik, tc, adres, eposta, telefon;

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand dokSil = new OracleCommand("DELETE FROM PROJ_DOKTOR WHERE DOKID= :p1",ODB.orCon());
            dokSil.Parameters.Add(new OracleParameter("p1", textBoxID.Text));
            dokSil.ExecuteNonQuery();
            ODB.orCon().Close();
            MessageBox.Show("SİLME İŞLEMİ BAŞARILI");
        }

        private void YoneticiDoktorGuncelle_Load(object sender, EventArgs e)
        {
            textBoxID.Text = id;
            textBoxAd.Text = ad;
            textBoxSoyad.Text = soyad;
            textBoxUzmanlik.Text = uzmanlik;
            textBoxEposta.Text = eposta;
            maskedTextBoxTC.Text = tc;
            maskedTextBoxTel.Text = telefon;
            richTextBoxAdres.Text = adres;
        }

        public YoneticiDoktorGuncelle()
        {
            InitializeComponent();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            OracleCommand dokEkle = new OracleCommand("UPDATE PROJ_DOKTOR SET DOKAD = :p1, DOKSOYAD = :p2, DOKTC = :p3 , DOKTEL = :p4, DOKUZMANLIK = :p5, DOKADRES = :p6, DOKEPOSTA =:p7 WHERE DOKID = :p8", ODB.orCon());
            dokEkle.Parameters.Add(new OracleParameter("p1", textBoxAd.Text));
            dokEkle.Parameters.Add(new OracleParameter("p2", textBoxSoyad.Text));
            dokEkle.Parameters.Add(new OracleParameter("p3", maskedTextBoxTC.Text));
            dokEkle.Parameters.Add(new OracleParameter("p4", maskedTextBoxTel.Text));
            dokEkle.Parameters.Add(new OracleParameter("p5", textBoxUzmanlik.Text));
            dokEkle.Parameters.Add(new OracleParameter("p6", richTextBoxAdres.Text));
            dokEkle.Parameters.Add(new OracleParameter("p7", textBoxEposta.Text));
            dokEkle.Parameters.Add(new OracleParameter("p8", textBoxID.Text));
            dokEkle.ExecuteNonQuery();
                MessageBox.Show("DOKTOR KAYITLARI BAŞARIYLA GÜNCELLENDİ");
            }
            catch
            {
                MessageBox.Show("HATA !! DOKTOR KAYITLARI GÜNCELLENEMEDİ");
            }
        }

      
    }
}
