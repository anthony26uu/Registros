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
            // TODO: This line of code loads data into the 'peliculaDBDataSet.Peliculas' table. You can move, or remove it, as needed.
            this.peliculasTableAdapter1.Fill(this.peliculaDBDataSet.Peliculas);
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


            var pelicula = new Peliculas();
         
            pelicula.Estreno = maskedTextBox1.Text;
            pelicula.Descripcion = descripcionTextBox.Text;
            pelicula.Categoria = categoriaTextBox.Text;
            pelicula.Id = textBox1.Text;
         //   pelicula.Nombres = nombresTextBox.Text;


            if (pelicula != null)
            {
                BLL.PeliculasBLL.Insertar(pelicula);
                MessageBox.Show("Pelicula agregada correctamente");

            }

            //Limpia al final de registtrar usuario
            textBox1.Text = "";
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            var elim = BLL.PeliculasBLL.Buscar(Convert.ToInt32(nombresTextBox.Text));
            if (elim != null)
            {
                BLL.PeliculasBLL.Eliminar(elim);
                MessageBox.Show("Eliminado...");
            }
            else
            {
                MessageBox.Show("No se ha Elimimnado...");
            }
            textBox1.Text = "";
            nombresTextBox.Text = "";
            maskedTextBox1.Text = "";
            categoriaTextBox.Text = "";
            descripcionTextBox.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {          
                var buscar = BLL.PeliculasBLL.Buscar(Convert.ToInt32(nombresTextBox.Text));
                if (buscar != null)
                {

                 // nombresTextBox.Text = buscar.Nombres;
                    maskedTextBox1.Text = buscar.Estreno;
                    categoriaTextBox.Text = buscar.Categoria;
                    descripcionTextBox.Text = buscar.Descripcion;
                textBox1.Text = buscar.Id;
                    MessageBox.Show("Resultados de busqueda");
                }
                else
                {
                    MessageBox.Show("Campo Vacio");
                }
            
           
          

            //Limpia al final de registtrar usuario
           
           
        }

        private void peliculasDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
