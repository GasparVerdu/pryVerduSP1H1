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
    public partial class FrmConsultaProduccion : Form
    {
        //matriz para guardar los datos que van a ser ingresados en el vector con ayuda del separador, y asi despues mostrarlos en la dgv
        //string[,] matConsultaProduccion = new string[30, 4];
        string[] vecConsulta = new string[100];
        public FrmConsultaProduccion()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvProduccion.Rows.Clear();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //pregunta si el archivo existe
            //if (File.Exists("./Produccion.txt"))
            //{
            //    char separador = Convert.ToChar(",");
            //    int fm = 0;
            //    StreamReader srConsulta = new StreamReader("./Produccion.txt");
            //    while (!srConsulta.EndOfStream)
            //    {
            //        string[] vecConsulta = srConsulta.ReadLine().Split(separador);
            //        matConsultaProduccion[fm, 0] = vecConsulta[0];
            //        matConsultaProduccion[fm, 1] = vecConsulta[1];
            //        matConsultaProduccion[fm, 2] = vecConsulta[2];
            //        matConsultaProduccion[fm, 3] = vecConsulta[3];
            //        dgvProduccion.Rows.Add(matConsultaProduccion[fm, 0], matConsultaProduccion[fm, 1], matConsultaProduccion[fm, 2], matConsultaProduccion[fm, 3]);
            //        fm++;
            //    }
            //    srConsulta.Close();
            //}


            if (File.Exists("./Produccion.txt"))
            {
                char separador = Convert.ToChar(",");
                //int fm = 0;
                int i = 0;
                StreamReader srConsulta = new StreamReader("./Produccion.txt");
                while (!srConsulta.EndOfStream)
                {
                    string[] vecConsulta = srConsulta.ReadLine().Split(separador);
                    vecConsulta[0] = vecConsulta[0];
                    vecConsulta[1] = vecConsulta[1];
                    vecConsulta[2] = vecConsulta[2];
                    vecConsulta[3] = vecConsulta[3];
                    dgvProduccion.Rows.Add(vecConsulta[0], vecConsulta[1], vecConsulta[2], vecConsulta[3]);
                    //fm++;
                    i++;
                }
                srConsulta.Close();
            }
        }
    }
}
