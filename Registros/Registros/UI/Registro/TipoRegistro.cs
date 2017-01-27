using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Registros.UI.Registro
{
    public partial class TipoRegistro : Form
    {
        public TipoRegistro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UI.Registro.Registro registrar = new UI.Registro.Registro();


            registrar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UI.Registro.RegistroPeliculas registroP = new RegistroPeliculas();
            //UI.Registro.Registro_Peliculas registrar = new UI.Registro.Registro_Peliculas();

            registroP.Show();
        }
    }
}
