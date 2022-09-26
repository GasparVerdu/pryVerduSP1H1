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
    public partial class FrmLocalidad : Form
    {
        public FrmLocalidad()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //string varLocalidad;
            //varLocalidad = txtNombreLocalidad.Text;

            //int varIdentificacion;
            //varIdentificacion = Convert.ToInt32(MaskTxtIdentificador.Text);

            ////File.WriteAllText("./Localidades.txt", varLocalidad + varIdentificacion);
            ////MessageBox.Show("Datos guardados");

            ////si el archivo existe lo abre y si no lo crea
            //StreamWriter swLocalidad = new StreamWriter("./localidad.txt", true);
            //swLocalidad.WriteLine("Identificador:" + varIdentificacion + "Localidad:" + varLocalidad);
            //swLocalidad.Close();

            //MessageBox.Show("Datos grabados");

            //txtNombreLocalidad.Text = "";
            //MaskTxtIdentificador.Text = "";

            ////poner el mouse encima del control
            //MaskTxtIdentificador.Focus();


            string varNombreLoc;
            varNombreLoc = txtNombreLocalidad.Text;

            int varMaskCodigo;
            varMaskCodigo = Convert.ToInt32(MaskTxtIdentificador.Text);

            bool bandera = false;

            StreamWriter swLocalidad = new StreamWriter("./Localidades.txt", true);
            swLocalidad.Close();

            if (varMaskCodigo != 0 && varNombreLoc != "")
            {

                char Separador = Convert.ToChar(",");
                StreamReader srLocalidad = new StreamReader("./Localidades.txt");

                //recorrer el archivo para ver si esta repetido el codigo
                while (!srLocalidad.EndOfStream && bandera == false)
                {
                    //tomar el dato que esta en el archivo separado con el separador y cargarlo en un vector
                    string[] vecCultivos = srLocalidad.ReadLine().Split(Separador);
                    int idVec = Convert.ToInt32(vecCultivos[0]);
                    if (idVec == varMaskCodigo)
                    {
                        bandera = true;
                        MessageBox.Show("Este Codigo ya existe");
                    }
                }
                srLocalidad.Close();

                StreamWriter swDatos = File.AppendText("./Localidades.txt");
                if (bandera == false)
                {
                    swDatos.WriteLine(varMaskCodigo + "," + varNombreLoc);
                    MessageBox.Show("Datos cargados");
                }
                swDatos.Close();

            }

            txtNombreLocalidad.Text = "";
        }
    }
}
