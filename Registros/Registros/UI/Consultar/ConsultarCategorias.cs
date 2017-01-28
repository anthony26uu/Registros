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

namespace Registros.UI.Consultar
{
    public partial class ConsultarCategorias : Form
    {
        int p;
        public ConsultarCategorias()
        {
            InitializeComponent();
        }

        private void categoriaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.categoriasDBDataSet);

        }

        private void ConsultarCategorias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'categoriasDBDataSet.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.categoriasDBDataSet.Categoria);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Categorias> Lista = new List<Categorias>();
            var db = new CategoriasDB();
            Lista = db.Categorias.ToList();
            categoriaDataGridView.DataSource = Lista;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DAL.CategoriasDB db = new DAL.CategoriasDB();
            Entidades.Categorias categoria = new Entidades.Categorias();

            categoria.Categoria = categoriaTextBox.Text;
            categoria.Categoria = descripcionTextBox.Text;


            db.Categorias.Add(categoria);
            db.SaveChanges();

            //Limpia al final de registtrar usuario
            MessageBox.Show("Categoria Agregada correctamente");
            categoriaTextBox.Text = "";
            descripcionTextBox.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DAL.UsuarioDB db = new DAL.UsuarioDB();
            Entidades.Usuario usuario = new Entidades.Usuario();

            categoriaDataGridView[0, p].Value = categoriaTextBox.Text;
            categoriaDataGridView[1, p].Value = descripcionTextBox.Text;





            //Limpia al final de registtrar usuario
            categoriaTextBox.Text = "";
            descripcionTextBox.Text = "";
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        //    categoriaDataGridView.Rows.RemoveAt(categoriaDataGridView.CurrentRow.Index);
            categoriaDataGridView.Rows.RemoveAt(p);
        }

        private void categoriaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
