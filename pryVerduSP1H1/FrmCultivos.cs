using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryVerduSP1H1
{
    public partial class FrmCultivos : Form
    {
        public FrmCultivos()
        {
            InitializeComponent();
        }

        private void FrmCultivos_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string varNombre;
            varNombre = txtNombre.Text;

            int varCodigo;
            varCodigo = Convert.ToInt32(txtCodigo.Text);

            bool bandera = false;

            //crear archivo
            //textwriter leerlo o crarlo
            //TextWriter Cultivo = new StreamWriter("./cultivos.txt", true);
            //Cultivo.Close();
            StreamWriter swCultivos = new StreamWriter("./Cultivos.txt", true);
            swCultivos.Close();

            if (varCodigo != 0 && varNombre != "")
            {
                char Separador = Convert.ToChar(",");
                StreamReader srCultivos = new StreamReader("./cultivos.txt");

                //recorrer el archivo para ver si esta repetido el codigo
                while (!srCultivos.EndOfStream && bandera == false)
                {
                    //tomar el dato que esta en el archivo separado con el separador y cargarlo en un vector
                    string[] vecCultivos = srCultivos.ReadLine().Split(Separador);
                    string idVec = (vecCultivos[0]);
                    if (idVec == Convert.ToString(varCodigo))
                    {
                        bandera = true;
                        MessageBox.Show("Este Codigo ya existe");
                    }
                }
                srCultivos.Close();

                StreamWriter swDatos = File.AppendText("./cultivos.txt");
                if (bandera == false)
                {
                    swDatos.WriteLine(varCodigo + "," + varNombre);
                    MessageBox.Show("Datos cargados");
                }
                swDatos.Close();
            }
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtNombre.Focus();
        }
    }
}
