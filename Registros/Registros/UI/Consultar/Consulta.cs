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
            //  UI.Registro.Registro registrar = new UI.Registro.Registro();
            //registrar.Show();

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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DAL.UsuarioDB db = new DAL.UsuarioDB();
            Entidades.Usuario usuario = new Entidades.Usuario();

            dataGridView1[0, p].Value = usuariosTextBox.Text;
            dataGridView1[2, p].Value = nombresTextBox.Text;
            dataGridView1[1, p].Value = claveTextBox.Text;

            db.Usuario.Add(usuario);
            db.SaveChanges();






            //Limpia al final de registtrar usuario
            usuariosTextBox.Text = "";
            nombresTextBox.Text = "";
            claveTextBox.Text = "";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            p = dataGridView1.CurrentRow.Index;


            usuariosTextBox.Text = dataGridView1[0, p].Value.ToString();
            nombresTextBox.Text = dataGridView1[2, p].Value.ToString();
            claveTextBox.Text = dataGridView1[1, p].Value.ToString();





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


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
    }
    }

