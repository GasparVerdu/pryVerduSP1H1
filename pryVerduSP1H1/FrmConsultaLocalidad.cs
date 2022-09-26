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
    public partial class FrmConsultaLocalidad : Form
    {
        //string[,] matConsultaLocalidad = new string[24, 2];
        string[] vecConsultaLocalidad = new string[100];
        public FrmConsultaLocalidad()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvLocalidad.Rows.Clear();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //if (File.Exists("./Localidad.txt"))
            //{
            //    char separador = Convert.ToChar(",");
            //    int fm = 0;
            //    StreamReader srConsulta = new StreamReader("./Localidad.txt");
            //    while (!srConsulta.EndOfStream)
            //    {
            //        string[] vecConsulta = srConsulta.ReadLine().Split(separador);
            //        matConsultaLocalidad[fm, 0] = vecConsulta[0];
            //        matConsultaLocalidad[fm, 1] = vecConsulta[1];
            //        matConsultaLocalidad[fm, 2] = vecConsulta[2];
            //        matConsultaLocalidad[fm, 3] = vecConsulta[3];
            //        dgvLocalidad.Rows.Add(matConsultaLocalidad[fm, 0], matConsultaLocalidad[fm, 1], matConsultaLocalidad[fm, 2], matConsultaLocalidad[fm, 3]);
            //        fm++;
            //    }
            //    srConsulta.Close();
            //}

            if (File.Exists("./Localidades.txt"))
            {
                char separador = Convert.ToChar(",");
                //int fm = 0;
                int i = 0;
                StreamReader srConsulta = new StreamReader("./Localidades.txt");
                while (!srConsulta.EndOfStream)
                {
                    string[] vecConsulta = srConsulta.ReadLine().Split(separador);
                    vecConsultaLocalidad[0] = vecConsulta[0];
                    vecConsultaLocalidad[1] = vecConsulta[1];


                    dgvLocalidad.Rows.Add(vecConsultaLocalidad[0], vecConsultaLocalidad[1]);
                    //fm++
                    i++;
                }
                srConsulta.Close();
            }
        }
    }
}
