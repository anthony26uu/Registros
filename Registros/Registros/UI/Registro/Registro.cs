﻿
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
         //   n.Usuarios = usuariosTextBox.Text;
            return n;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
         
            DAL.UsuarioDB db = new DAL.UsuarioDB();
            Entidades.Usuario usuario = new Entidades.Usuario();


            
        //    usuario.Usuarios = usuariosTextBox.Text;
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
            var usuario = new Usuario();

            var n = new CategoriaBLL();
            
            

            usuario.Nombres = usuariosTextBox.Text;
            usuario.clave = claveTextBox.Text;
            //  usuario.Usuarios = usuariosTextBox.Text;

            if (usuario != null)
            {
                BLL.UsuariosBLL.Insertar(usuario);
                MessageBox.Show("Guardado Usuario...");
            }



            //Limpia al final de registtrar usuario
            MessageBox.Show("Usuario Agregado correctamente");
            usuariosTextBox.Text = "";
            nombresTextBox.Text = "";
            claveTextBox.Text = "";

            //Limpia al final de registtrar usuario
            MessageBox.Show("Usuario Agregado correctamente");
            usuariosTextBox.Text = "";
            nombresTextBox.Text = "";
            claveTextBox.Text = "";

          

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var Elimina = BLL.UsuariosBLL.Buscar(Convert.ToInt32(usuariosTextBox.Text));

            if (Elimina != null)
            {
                BLL.UsuariosBLL.Eliminar(Elimina);

                usuariosTextBox.Text = "";

            }
            else
            {
                MessageBox.Show("No se ha Eliminado...");
            }
        }

        private void butBuscar_Click(object sender, EventArgs e)
        {
            var usuario = BLL.UsuariosBLL.Buscar(Convert.ToInt32(usuariosTextBox.Text));

            if (usuario != null)
            {
                nombresTextBox.Text = usuario.Nombres;
                claveTextBox.Text = usuario.clave;

                MessageBox.Show("Estos son sus resultados.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UI.Consultar.Consulta consultar = new UI.Consultar.Consulta();
            consultar.Show();
        }
    }
}
