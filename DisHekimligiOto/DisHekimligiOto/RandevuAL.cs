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
    public partial class RandevuAL : Form
    {
        OracleBaglanti ODB = new OracleBaglanti();
        public RandevuAL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
               //IDyi 1 arttıracak trigger lazım
                OracleCommand komutEkle = new OracleCommand("INSERT INTO PROJ_HASTA (HASTAD,HASTSOYAD,HASTTC,HASTDOGUM,HASTRANDEVU,HASTMESLEK,HASTCINSIYET,HASTSIKAYET,HASTADRES,HASTTEL,HASTEPOSTA) VALUES(:p1 ,:p2 ,:p3 ,:p4 ,:p5 ,:p6 ,:p7 ,:p8 ,:p9 ,:p10 ,:p11) ", ODB.orCon());
                komutEkle.Parameters.Add(new OracleParameter("p1", textAd.Text));
                komutEkle.Parameters.Add(new OracleParameter("p2", textSoyad.Text));
                komutEkle.Parameters.Add(new OracleParameter("p3", textTC.Text));
                komutEkle.Parameters.Add(new OracleParameter("p4", maskedTextBoxDogum.Text));
                komutEkle.Parameters.Add(new OracleParameter("p5", maskedTextBoxRandevu.Text));
                komutEkle.Parameters.Add(new OracleParameter("p6", textMeslek.Text));
                komutEkle.Parameters.Add(new OracleParameter("p7", comboBoxCinsiyet.SelectedItem.ToString()));
                komutEkle.Parameters.Add(new OracleParameter("p8", textSikayet.Text));
                komutEkle.Parameters.Add(new OracleParameter("p9", textAdres.Text));
                komutEkle.Parameters.Add(new OracleParameter("p10", textTEL.Text));
                komutEkle.Parameters.Add(new OracleParameter("p11", textEposta.Text));
                komutEkle.ExecuteNonQuery();

               
                      
        }

        private void RandevuAL_Load(object sender, EventArgs e)
        {

        }
    }
}
