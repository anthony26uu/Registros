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

namespace Registros.UI
{
    public partial class ConsultaPeliculas : Form
    {
        int p;
        public ConsultaPeliculas()
        {
            InitializeComponent();
        }

        private void peliculasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peliculasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.peliculasDBDataSet);

        }

        private void ConsultaPeliculas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'peliculasDBDataSet.Peliculas' table. You can move, or remove it, as needed.
            this.peliculasTableAdapter.Fill(this.peliculasDBDataSet.Peliculas);

        }

        private void descripcionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Peliculas> Lista = new List<Peliculas>();
            var db = new PeliculasDB();
            Lista = db.Peliculas.ToList();
            peliculasDataGridView.DataSource = Lista;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DAL.PeliculasDB db = new DAL.PeliculasDB();

            Entidades.Peliculas pelicula = new Entidades.Peliculas();



            pelicula.Nombres = nombresTextBox.Text;
            pelicula.Estreno = maskedTextBox1.Text;
            pelicula.Categoria = categoriaTextBox.Text;
            pelicula.Descripcion = descripcionTextBox.Text;


            db.Peliculas.Add(pelicula);
            db.SaveChanges();

            //Limpia al final de registtrar usuario
            MessageBox.Show("Usuario Agregado correctamente");
            nombresTextBox.Text = "";
            maskedTextBox1.Text = "";
            categoriaTextBox.Text = "";
            descripcionTextBox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DAL.PeliculasDB db = new DAL.PeliculasDB();
            Entidades.Peliculas usuario = new Entidades.Peliculas();

            peliculasDataGridView[0, p].Value = nombresTextBox.Text;
            peliculasDataGridView[1, p].Value = maskedTextBox1.Text;
            peliculasDataGridView[2, p].Value = descripcionTextBox.Text;
            peliculasDataGridView[3, p].Value = categoriaTextBox.Text;




            //Limpia al final de registtrar usuario
            nombresTextBox.Text = "";
            maskedTextBox1.Text = "";
            descripcionTextBox.Text = "";
            categoriaTextBox.Text = "";

        }

        private void buscarToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.peliculasTableAdapter.Buscar(this.peliculasDBDataSet.Peliculas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void buscar1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.peliculasTableAdapter.Buscar1(this.peliculasDBDataSet.Peliculas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void buscar1ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buscar2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.peliculasTableAdapter.Buscar2(this.peliculasDBDataSet.Peliculas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void peliculasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buscaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.peliculasTableAdapter.Busca(this.peliculasDBDataSet.Peliculas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
