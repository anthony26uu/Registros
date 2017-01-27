using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Registros.UI.Consultar
{
    public partial class Tipo_De_Busqueda : Form
    {
        public Tipo_De_Busqueda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UI.Consultar.Consulta consultar = new UI.Consultar.Consulta();
            consultar.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UI.ConsultaPeliculas consulta = new ConsultaPeliculas();
            consulta.Show();
        }
    }
}
