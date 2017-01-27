using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Registros
{
    public partial class Peliculas : Form
    {
        public Peliculas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            UI.Consultar.Tipo_De_Busqueda  consultar = new UI.Consultar.Tipo_De_Busqueda();
            consultar.Show();
          
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
       //     UI.Registro.Registro registrar = new UI.Registro.Registro();
            UI.Registro.TipoRegistro registrar = new UI.Registro.TipoRegistro();

            registrar.Show();
        }
    }
}
