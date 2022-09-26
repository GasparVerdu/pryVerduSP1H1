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
    public partial class FrmConsultaCultivos : Form
    {
        //string[,] matCultivosConsulta = new string[24,2];
        string[] vecCultivosConsulta = new string[100];
        public FrmConsultaCultivos()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (File.Exists("./Cultivos.txt"))
            {
                char separador = Convert.ToChar(",");
                //int fm = 0;
                int i = 0;
                StreamReader srConsulta = new StreamReader("./Cultivos.txt");
                while (!srConsulta.EndOfStream)
                {
                    string[] vecConsulta = srConsulta.ReadLine().Split(separador);
                    vecCultivosConsulta[0] = vecConsulta[0];
                    vecCultivosConsulta[1] = vecConsulta[1];

                    dgvCultivos.Rows.Add(vecCultivosConsulta[0], vecCultivosConsulta[1]);
                    //fm++;
                    i++;
                }
                srConsulta.Close();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvCultivos.Rows.Clear();
        }
    }
}
