using Registros.BLL;
using Registros.DAL;
using Registros.Entidades;
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
   
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usuarioDBDataSet);

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usuarioDBDataSet.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.usuarioDBDataSet.Usuario);

        }

        private void usuariosTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private Usuario crearusuario()
        {
            Usuario n = new Usuario();
            n.Nombres = nombresTextBox.Text;
            n.clave = claveTextBox.Text;
            n.Usuarios = usuariosTextBox.Text;
            return n;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
         
            DAL.UsuarioDB db = new DAL.UsuarioDB();
            Entidades.Usuario usuario = new Entidades.Usuario();


            
            usuario.Usuarios = usuariosTextBox.Text;
            usuario.Nombres =  nombresTextBox.Text;
            usuario.clave = claveTextBox.Text;

            db.Usuario.Add(usuario);
            db.SaveChanges();

            //Limpia al final de registtrar usuario
            MessageBox.Show("Usuario Agregado correctamente");
            usuariosTextBox.Text = "";
            nombresTextBox.Text = "";
            claveTextBox.Text = "";
            
            
        }

        private void usuariosLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombresLabel_Click(object sender, EventArgs e)
        {

        }

        private void nombresTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void claveLabel_Click(object sender, EventArgs e)
        {

        }

        private void claveTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }
        
        private void button2_Click(object sender, EventArgs e)
        {

            DAL.UsuarioDB db = new DAL.UsuarioDB();
            Entidades.Usuario usuario = new Entidades.Usuario();



            usuario.Usuarios = usuariosTextBox.Text;
            usuario.Nombres = nombresTextBox.Text;
            usuario.clave = claveTextBox.Text;

            db.Usuario.Add(usuario);
            db.SaveChanges();

            //Limpia al final de registtrar usuario
            MessageBox.Show("Usuario Agregado correctamente");
            usuariosTextBox.Text = "";
            nombresTextBox.Text = "";
            claveTextBox.Text = "";

            /*
        
            Usuario usuario = new Usuario();

            usuario = crearusuario();

            if (UsuarioBLL.Insertar(usuario))
            {
                MessageBox.Show("Registrado con exito");
            }
            else
            {
                MessageBox.Show("No se guardo");
            }
            */

        }
    }
}
