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
            DAL.PeliculasDB db = new DAL.PeliculasDB();
            Entidades.Peliculas pelicula = new Entidades.Peliculas();

          


            pelicula.Nombres = nombresTextBox.Text;
            pelicula.Estreno = estrenoMaskedTextBox.Text;
            pelicula.Categoria = categoriaTextBox.Text;
            pelicula.Descripcion = descripcionTextBox.Text;


        //    db.Peliculas.Add(pelicula);
          

          
            db.SaveChanges();

            //Limpia al final de registtrar usuario
            MessageBox.Show("Usuario Agregado correctamente");
            nombresTextBox.Text = "";
            estrenoMaskedTextBox.Text = "";
            categoriaTextBox.Text = "";
            descripcionTextBox.Text = "";
        }
    }
}
