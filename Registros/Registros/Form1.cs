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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            DAL.UsuarioDB db = new DAL.UsuarioDB();
            Entidades.Usuario usuario = new Entidades.Usuario();

            usuario.Usuarios = "anthony26u";
            usuario.clave = "1234";
            usuario.Nombres = "Anthony Santana";

            db.Usuario.Add(usuario);
             db.SaveChanges();
    */


            UI.Consultar.Consulta consultar = new UI.Consultar.Consulta();
            consultar.Show();
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UI.Registro.Registro registrar = new UI.Registro.Registro();


            registrar.Show();
        }
    }
}
