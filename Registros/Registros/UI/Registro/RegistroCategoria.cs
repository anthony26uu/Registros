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
    }
}
