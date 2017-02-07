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
    public partial class RegistroPeliculas : Form
    {
        public RegistroPeliculas()
        {
            InitializeComponent();
        }

        private void peliculasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peliculasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.peliculasDBDataSet);

        }

        private void RegistroPeliculas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'peliculasDBDataSet.Peliculas' table. You can move, or remove it, as needed.
            this.peliculasTableAdapter.Fill(this.peliculasDBDataSet.Peliculas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
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
    }
}
