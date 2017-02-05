using Registros.DAL;
using Registros.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;

namespace Registros.UI.Consultar
{


    public partial class Consulta : Form
    {

        int p;


        public Consulta()
        {
            InitializeComponent();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usuarioDBDataSet.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.usuarioDBDataSet.Usuario);

        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usuarioDBDataSet);

        }

        private void usuarioBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usuarioDBDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //   SqlDataReader leer = comando.ExcuteReader();

            List<Usuario> Lista = new List<Usuario>();
            var db = new UsuarioDB();
            Lista = db.Usuario.ToList();
            dataGridView1.DataSource = Lista;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            var usuario = new Usuario();

            usuario.Nombres = maskedTextBox1.Text;
            usuario.clave = claveTextBox.Text;
          //  usuario.Usuarios = usuariosTextBox.Text;

            if (usuario != null)
            {
                BLL.UsuariosBLL.Insertar(usuario);
              
            }



            //Limpia al final de registtrar usuario
            MessageBox.Show("Usuario Agregado correctamente");
            maskedTextBox1.Text = "";
            nombresTextBox.Text = "";
            claveTextBox.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DAL.UsuarioDB db = new DAL.UsuarioDB();
            Entidades.Usuario usuario = new Entidades.Usuario();

            dataGridView1[0, p].Value = maskedTextBox1.Text;
            dataGridView1[2, p].Value = nombresTextBox.Text;
            dataGridView1[1, p].Value = claveTextBox.Text;

            db.Usuario.Add(usuario);
            db.SaveChanges();






            //Limpia al final de registtrar usuario
            maskedTextBox1.Text = "";
            nombresTextBox.Text = "";
            claveTextBox.Text = "";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            p = dataGridView1.CurrentRow.Index;


            maskedTextBox1.Text = dataGridView1[0, p].Value.ToString();
            nombresTextBox.Text = dataGridView1[2, p].Value.ToString();
            claveTextBox.Text = dataGridView1[1, p].Value.ToString();





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            

  
           // usuarioBindingSource.Remove(dataGridView1);


        }


        private void nombresToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void nombresToolStripLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var Elimina = BLL.UsuariosBLL.Buscar(Convert.ToInt32(maskedTextBox1.Text));

            if (Elimina != null)
            {
                BLL.UsuariosBLL.Eliminar(Elimina);
               
                maskedTextBox1.Text = "";

            }
            else
            {
                MessageBox.Show("No se ha Eliminado...");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            var usuario = BLL.UsuariosBLL.Buscar(Convert.ToInt32(maskedTextBox1.Text));

            if (usuario != null)
            {
                nombresTextBox.Text = usuario.Nombres;
                claveTextBox.Text = usuario.clave;

                MessageBox.Show("Estos son sus resultados.");
            }

          
        }
    }
    }

