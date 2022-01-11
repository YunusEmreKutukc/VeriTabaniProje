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
    public partial class TedaviEkranı : Form
    {
        OracleBaglanti ODB = new OracleBaglanti();
        public string TC;
        public TedaviEkranı()
        {
            //BURADA TEDAVI TABLE A BİLGİ GİRİLECEK
            //LİSTBOX DIŞINDA SEÇİLEN BİLGİLER AYNI ZAMANDA BİR LABEL VE TEXTBOXA KAYDEDİLECEK ORADAN DA DATABASE 
            //-------------------------------------------LL-----------------------------------------
            InitializeComponent();
        

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TedaviEkranı_Load(object sender, EventArgs e)
        {
            textBoxHastaTc.Text = TC;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand kaydetKomut = new OracleCommand("INSERT INTO PROJ_DOKRAPOR(RAPORTEDAVI,RAPORILAC,RAPORDIS,RAPORTC) VALUES (:p1, :p2, :p3, :p4) ",ODB.orCon());
            kaydetKomut.Parameters.Add(new OracleParameter("p1",textBoxTedavi.Text));
            kaydetKomut.Parameters.Add(new OracleParameter("p2",textBoxIlac.Text));
            kaydetKomut.Parameters.Add(new OracleParameter("p3",textBox1.Text));
            kaydetKomut.Parameters.Add(new OracleParameter("p4", textBoxHastaTc.Text));
            kaydetKomut.ExecuteNonQuery();
            TabloYenile();
        }
        public void TabloYenile()
        {
            string select = "SELECT * FROM PROJ_DOKRAPOR ";
            OracleDataAdapter oDa = new OracleDataAdapter(select, ODB.orCon());
            DataTable dt = new DataTable();
            oDa.Fill(dt);
            dataGridViewRapor.DataSource = dt;
            ODB.orCon().Close();
        }
    

        //textbox a sadece rakam girişi yapılabilir
        private void textBoxUcret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBoxLL1.Checked )
            {
                textBox1.Text = "(LL1)ALTSOL1";
            }
            else if (checkBoxLL2.Checked)
            {
                textBox1.Text = "(LL2)ALTSOL2";
            }
            else if (checkBoxLL3.Checked)
            {
                textBox1.Text = ("(LL3)ALTSOL3");
            }
            else if (checkBoxLL4.Checked)
            {
                textBox1.Text = ("(LL4)ALTSOL4");
            }
            else if (checkBoxLL5.Checked)
            {
                textBox1.Text = ("(LL5)ALTSOL5");
            }
            else if (checkBoxLL6.Checked)
            {
                textBox1.Text = ("(LL6)ALTSOL6");
            }
            else if (checkBoxLL7.Checked)
            {
                textBox1.Text = ("(LL7)ALTSOL7");
            }
            else if (checkBoxLL8.Checked)
            {
                textBox1.Text = ("(LL8)ALTSOL8");
            }
            //-------------------------------------LR--------------------------------------------
            else if (checkBoxLR1.Checked)
            {
                textBox1.Text = ("(LR1)ALTSAG1");
            }
            else if (checkBoxLR2.Checked)
            {
                textBox1.Text = ("(LR2)ALTSAG2");
            }
            else if (checkBoxLR3.Checked)
            {
                textBox1.Text = ("(LR3)ALTSAG3");
            }
            else if (checkBoxLR4.Checked)
            {
                textBox1.Text = ("(LR4)ALTSAG4");
            }
            else if (checkBoxLR5.Checked)
            {
                textBox1.Text = ("(LR5)ALTSAG5");
            }
            else if (checkBoxLR6.Checked)
            {
                textBox1.Text = ("(LR6)ALTSAG6");
            }
            else if (checkBoxLR7.Checked)
            {
                textBox1.Text = ("(LR7)ALTSAG7");
            }
            else if (checkBoxLR8.Checked)
            {
                textBox1.Text = ("(LR8)ALTSAG8");
            }
            //-------------------------------------UL---------------------------------------------------
            else if (checkBoxUL1.Checked)
            {
                textBox1.Text = ("(UL1)USTSOL1");
            }
            else if (checkBoxUL2.Checked)
            {
                textBox1.Text = ("(UL2)USTSOL2");
            }
            else if (checkBoxUL3.Checked)
            {
                textBox1.Text = ("(UL3)USTSOL3");
                 
            }
            else if (checkBoxUL4.Checked)
            {
                textBox1.Text = ("(UL4)USTSOL4");
               
            }
            else if (checkBoxUL5.Checked)
            {
                textBox1.Text = ("(UL5)USTSOL5");
                 
            }
            if (checkBoxUL6.Checked)
            {
                textBox1.Text = ("(UL6)USTSOL6");
                 
            }
            if (checkBoxUL7.Checked)
            {
                textBox1.Text = ("(UL7)USTSOL7");
               
            }
            if (checkBoxUL8.Checked)
            {
                textBox1.Text = ("(UL8)USTSOL8");     
            }

            //------------------------------------UR-------------------------------------------
            if (checkBoxUR1.Checked)
            {
                textBox1.Text = ("(UR1)USTSAG1");
         
            }
            if (checkBoxUR2.Checked)
            {
                textBox1.Text = ("(UR2)USTSAG2");
 
            }
            if (checkBoxUR3.Checked)
            {
                textBox1.Text = ("(UR3)USTSAG3");               
            }
            if (checkBoxUR4.Checked)
            {
                textBox1.Text = ("(UR4)USTSAG4");
            
            }
            if (checkBoxUR5.Checked)
            {
                textBox1.Text = ("(UR5)USTSAG5");
             
            }
            if (checkBoxUR6.Checked)
            {
                textBox1.Text = ("(UR6)USTSAG6");
  
            }
            if (checkBoxUR7.Checked)
            {
                textBox1.Text = ("(UR7)USTSAG7");             
            }
            if (checkBoxUR8.Checked)
            {
                textBox1.Text = ("(UR8)USTSAG8");
          
            }

            checkBoxLL1.Checked = false;
            checkBoxLL2.Checked = false;
            checkBoxLL3.Checked = false;
            checkBoxLL4.Checked = false;
            checkBoxLL5.Checked = false;
            checkBoxLL6.Checked = false;
            checkBoxLL7.Checked = false;
            checkBoxLL8.Checked = false;
            checkBoxLR1.Checked = false;
            checkBoxLR2.Checked = false;
            checkBoxLR3.Checked = false;
            checkBoxLR4.Checked = false;
            checkBoxLR5.Checked = false;
            checkBoxLR6.Checked = false;
            checkBoxLR7.Checked = false;
            checkBoxLR8.Checked = false;
            checkBoxUR1.Checked = false;
            checkBoxUR2.Checked = false;
            checkBoxUR3.Checked = false;
            checkBoxUR4.Checked = false;
            checkBoxUR5.Checked = false;
            checkBoxUR6.Checked = false;
            checkBoxUR7.Checked = false;
            checkBoxUR8.Checked = false;
            checkBoxUL1.Checked = false;
            checkBoxUL2.Checked = false;
            checkBoxUL3.Checked = false;
            checkBoxUL4.Checked = false;
            checkBoxUL5.Checked = false;
            checkBoxUL6.Checked = false;
            checkBoxUL7.Checked = false;
            checkBoxUL8.Checked = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUcret_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewRapor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TabloYenile();
        }
    }
}
