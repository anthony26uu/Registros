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
    public partial class RegistroCategoria : Form
    {
        public RegistroCategoria()
        {
            InitializeComponent();
        }

        private void categoriaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.categoriasDBDataSet);

        }

        private void RegistroCategoria_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'categoriasDBDataSet.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.categoriasDBDataSet.Categoria);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var categoria = new Categorias();
            categoria.id = maskedTextBox1.Text;
            categoria.Descripcion = descripcionTextBox.Text;
            categoria.Categoria = categoriaTextBox.Text;


            if (categoria != null)
            {
                BLL.CategoriaBLL.Insertar(categoria);
                MessageBox.Show("Guardando...");
            }



            //Limpia al final de registtrar usuario
            MessageBox.Show("Categoria Agregada correctamente");
            categoriaTextBox.Text = "";
            maskedTextBox1.Text = "";
            descripcionTextBox.Text = "";
            //Limpia al final de registtrar usuario
            MessageBox.Show("Categoria Agregada correctamente");
            categoriaTextBox.Text = "";
            descripcionTextBox.Text = "";
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            var bus = BLL.CategoriaBLL.Buscar(maskedTextBox1.Text);

            if (bus != null)
            {

                descripcionTextBox.Text = bus.Descripcion;
                categoriaTextBox.Text = bus.Categoria;
                MessageBox.Show("Busqueda Correcta...");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var categoria = new Categorias();
            categoria.id = maskedTextBox1.Text;
            categoria.Descripcion = descripcionTextBox.Text;
            categoria.Categoria = categoriaTextBox.Text;


            if (categoria != null)
            {
                BLL.CategoriaBLL.Insertar(categoria);

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            var categ = BLL.CategoriaBLL.Buscar(maskedTextBox1.Text);

            if (categ != null)
            {
                BLL.CategoriaBLL.Eliminar(categ);
                MessageBox.Show("Eliminado...");

            }
            else
            {
                MessageBox.Show("No se ha Eliminado...");
            }

            maskedTextBox1.Text = "";
            descripcionTextBox.Text = "";
            categoriaTextBox.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UI.Consultar.ConsultarCategorias consultar = new ConsultarCategorias();
            consultar.Show();
        }
    }
}
