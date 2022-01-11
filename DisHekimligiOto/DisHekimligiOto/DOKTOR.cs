using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisHekimligiOto
{
    public partial class DOKTOR : Form
    {
        public DOKTOR()
        {
            InitializeComponent();
        }

        private void DOKTOR_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet5.PROJ_HASTA' table. You can move, or remove it, as needed.
            this.pROJ_HASTATableAdapter.Fill(this.dataSet5.PROJ_HASTA);
            // TODO: This line of code loads data into the 'dataSet4.PROJ_DOKRAPOR' table. You can move, or remove it, as needed.
            this.pROJ_DOKRAPORTableAdapter.Fill(this.dataSet4.PROJ_DOKRAPOR);


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim;
            secim = dataGridViewRandevuLst.SelectedCells[0].RowIndex;
            TedaviEkranı tedEk = new TedaviEkranı();
            tedEk.TC = dataGridViewRandevuLst.Rows[secim].Cells[3].Value.ToString();
            tedEk.Show();
        }
    }
}
