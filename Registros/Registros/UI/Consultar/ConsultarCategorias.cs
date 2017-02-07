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
            // TODO: This line of code loads data into the 'categoriasDBDataSet1.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter1.Fill(this.categoriasDBDataSet1.Categoria);
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
         
          
        }

       

       
        private void categoriaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }
    }
}
