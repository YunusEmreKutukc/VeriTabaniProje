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
    public partial class YoneticiDoktorEkle : Form
    {
        OracleBaglanti ODB = new OracleBaglanti();
        public YoneticiDoktorEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         OracleCommand dokEkle = new  OracleCommand("INSERT INTO PROJ_DOKTOR(DOKAD, DOKSOYAD, DOKTC, DOKTEL, DOKUZMANLIK, DOKADRES, DOKEPOSTA) VALUES(:p1, :p2, :p3, :p4, :p5, :p6, :p7)",ODB.orCon());
            dokEkle.Parameters.Add(new OracleParameter("p1",textBoxAd.Text));
            dokEkle.Parameters.Add(new OracleParameter("p2",textBoxSoyad.Text));
            dokEkle.Parameters.Add(new OracleParameter("p3",maskedTextBoxTC.Text));
            dokEkle.Parameters.Add(new OracleParameter("p4",maskedTextBoxTelefon.Text));
            dokEkle.Parameters.Add(new OracleParameter("p5",textBoxUzmanlik.Text));
            dokEkle.Parameters.Add(new OracleParameter("p6",richTextBoxAdres.Text));
            dokEkle.Parameters.Add(new OracleParameter("p7",textBoxEposta.Text));
            dokEkle.ExecuteNonQuery();
            //ID INCREMENT YAPILACAK +TRYCATCH
            MessageBox.Show("DOKTOR KAYDI BAŞARIYLA EKLENDİ");
        }
    }
}
