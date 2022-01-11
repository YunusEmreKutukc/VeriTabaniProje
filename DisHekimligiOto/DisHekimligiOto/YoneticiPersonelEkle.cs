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
    public partial class YoneticiPersonelEkle : Form
    {
        OracleBaglanti ODB = new OracleBaglanti();
        public YoneticiPersonelEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            OracleCommand dokEkle = new OracleCommand("INSERT INTO PROJ_CALISAN(CALAD, CALSOYAD, CALTC, CALTEL, CALUZMANLIK, CALADRES, CALEPOSTA) VALUES(:p1, :p2, :p3, :p4, :p5, :p6, :p7)", ODB.orCon());
            dokEkle.Parameters.Add(new OracleParameter("p1", textBoxAd.Text));
            dokEkle.Parameters.Add(new OracleParameter("p2", textBoxSoyad.Text));
            dokEkle.Parameters.Add(new OracleParameter("p3", maskedTextBoxTC.Text));
            dokEkle.Parameters.Add(new OracleParameter("p4", maskedTextBoxTel.Text));
            dokEkle.Parameters.Add(new OracleParameter("p5", textBoxPozisyon.Text));
            dokEkle.Parameters.Add(new OracleParameter("p6", richTextBoxAdres.Text));
            dokEkle.Parameters.Add(new OracleParameter("p7", textBoxEposta.Text));
            dokEkle.ExecuteNonQuery();
            //ID INCREMENT YAPILACAK +TRYCATCH
            MessageBox.Show("PERSONEL KAYDI BAŞARIYLA EKLENDİ");      
            }
            catch
            {
                MessageBox.Show("HATA !! PERSONEL KAYDI EKLENEMEDİ");
            }
        }
    }
}
