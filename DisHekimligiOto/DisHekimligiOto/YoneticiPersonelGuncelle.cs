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
    public partial class YoneticiPersonelGuncelle : Form
    {
        OracleBaglanti ODB = new OracleBaglanti();
        public string id, ad, soyad, uzmanlik, tc, adres, eposta, telefon;

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand perSil = new OracleCommand("DELETE FROM PROJ_CALISAN WHERE CALID = :p1",ODB.orCon());
            perSil.Parameters.Add(new OracleParameter("p1",textBoxID.Text));
            perSil.ExecuteNonQuery();
            MessageBox.Show("SİLME İŞLEMİ BAŞARILI");
        }

        private void YoneticiPersonelGuncelle_Load(object sender, EventArgs e)
        {
            textBoxID.Text = id;
            textBoxAd.Text = ad;
            textBoxSoyad.Text = soyad;
            textBoxPozisyon.Text = uzmanlik;
            textBoxEposta.Text = eposta;
            maskedTextBoxTC.Text = tc;
            maskedTextBoxTel.Text = telefon;
            richTextBoxAdres.Text = adres;
        }
        public YoneticiPersonelGuncelle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OracleCommand persGuncelle = new OracleCommand("UPDATE PROJ_CALISAN SET CALAD = :p1, CALSOYAD = :p2, CALTC = :p3, CALTEL = :p4, CALUZMANLIK = :p5, CALADRES = :p6, CALEPOSTA = :p7 WHERE CALID = :p8", ODB.orCon());
            persGuncelle.Parameters.Add(new OracleParameter("p1", textBoxAd.Text));
            persGuncelle.Parameters.Add(new OracleParameter("p2", textBoxSoyad.Text));
            persGuncelle.Parameters.Add(new OracleParameter("p3", maskedTextBoxTC.Text));
            persGuncelle.Parameters.Add(new OracleParameter("p4", maskedTextBoxTel.Text));
            persGuncelle.Parameters.Add(new OracleParameter("p5", textBoxPozisyon.Text));
            persGuncelle.Parameters.Add(new OracleParameter("p6", richTextBoxAdres.Text));
            persGuncelle.Parameters.Add(new OracleParameter("p7", textBoxEposta.Text));
            persGuncelle.Parameters.Add(new OracleParameter("p8", textBoxID.Text));
            persGuncelle.ExecuteNonQuery();
            MessageBox.Show("BİLGİLER GÜNCELLENDİ");
            
        }

      
    }
}
