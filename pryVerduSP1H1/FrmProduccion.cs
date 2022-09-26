using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVerduSP1H1
{
    public partial class FrmProduccion : Form
    {
        public FrmProduccion()
        {
            InitializeComponent();
        }
        private void FrmProduccion_Load(object sender, EventArgs e)
        {
            StreamReader srCultivos = new StreamReader("./Cultivos.txt");
            StreamReader srLocalidad = new StreamReader("./Localidades.txt");
            //StreamWriter swProduccion = new StreamWriter("./Produccion.txt", true);
            //swProduccion.Close();

            char separador = Convert.ToChar(",");
            //recorrer mientras sea distinto a EOF
            while (!srCultivos.EndOfStream)
            {
                //cargar las localidades en un vec
                string[] DatosCultivos = srCultivos.ReadLine().Split(separador);
                //posicion uno porque la segunda es el nombre y la primera el id
                cboNombreCultivo.Items.Add(DatosCultivos[1]);

            }
            srCultivos.Close();

            while (!srLocalidad.EndOfStream)
            {
                string[] InformacionLocalidad = srLocalidad.ReadLine().Split(separador);

                cboNombreLocalidad.Items.Add(InformacionLocalidad[1]);
            }
            srLocalidad.Close();
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            StreamWriter swProduccion = new StreamWriter("./Produccion.txt", true);
            swProduccion.WriteLine(cboNombreLocalidad.Text + "," + dtpFecha.Text + "," + cboNombreCultivo.Text + "," + +nudCantidad.Value);
            MessageBox.Show("Datos cargados");
            swProduccion.Close();
        }
    }
}
