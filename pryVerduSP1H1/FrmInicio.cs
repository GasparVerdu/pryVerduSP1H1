using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVerduSP1H1
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

        }
        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void cultivosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmCultivos frmcultivos = new FrmCultivos();
            frmcultivos.ShowDialog();
        }

        private void localidadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmLocalidad frmlocalidad = new FrmLocalidad();
            frmlocalidad.ShowDialog();
        }

        private void produccionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmProduccion frmproduccion = new FrmProduccion();
            frmproduccion.ShowDialog();
        }

        private void consultaCultivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaCultivos frmCcultivos = new FrmConsultaCultivos();
            frmCcultivos.ShowDialog();

        }

        private void consultaLocalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaLocalidad frmClocalidad = new FrmConsultaLocalidad();
            frmClocalidad.ShowDialog();

        }

        private void consultaProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaProduccion frmCproduccion = new FrmConsultaProduccion();
            frmCproduccion.ShowDialog();
        }
    }
}
