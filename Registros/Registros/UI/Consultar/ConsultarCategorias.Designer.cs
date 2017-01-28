namespace Registros.UI.Consultar
{
    partial class ConsultarCategorias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label descripcionLabel;
            this.categoriasDBDataSet = new Registros.CategoriasDBDataSet();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new Registros.CategoriasDBDataSetTableAdapters.CategoriaTableAdapter();
            this.tableAdapterManager = new Registros.CategoriasDBDataSetTableAdapters.TableAdapterManager();
            this.categoriaTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.categoriaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            categoriaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(324, 53);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(55, 13);
            categoriaLabel.TabIndex = 1;
            categoriaLabel.Text = "Categoria:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(324, 79);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 3;
            descripcionLabel.Text = "Descripcion:";
            // 
            // categoriasDBDataSet
            // 
            this.categoriasDBDataSet.DataSetName = "CategoriasDBDataSet";
            this.categoriasDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.categoriasDBDataSet;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = this.categoriaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Registros.CategoriasDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categoriaTextBox
            // 
            this.categoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "Categoria", true));
            this.categoriaTextBox.Location = new System.Drawing.Point(396, 50);
            this.categoriaTextBox.Name = "categoriaTextBox";
            this.categoriaTextBox.Size = new System.Drawing.Size(100, 20);
            this.categoriaTextBox.TabIndex = 2;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(396, 76);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(261, 185);
            this.descripcionTextBox.TabIndex = 4;
            // 
            // categoriaDataGridView
            // 
            this.categoriaDataGridView.AutoGenerateColumns = false;
            this.categoriaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.categoriaDataGridView.DataSource = this.categoriaBindingSource;
            this.categoriaDataGridView.Location = new System.Drawing.Point(13, 53);
            this.categoriaDataGridView.Name = "categoriaDataGridView";
            this.categoriaDataGridView.Size = new System.Drawing.Size(282, 222);
            this.categoriaDataGridView.TabIndex = 5;
            this.categoriaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoriaDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Categoria";
            this.dataGridViewTextBoxColumn1.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Mostrar Todo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(509, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Nuevo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Consultar Categorias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "NUEVA CATEGORIA";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(199, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // ConsultarCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 411);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.categoriaDataGridView);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(this.categoriaTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Name = "ConsultarCategorias";
            this.Text = "ConsultarCategorias";
            this.Load += new System.EventHandler(this.ConsultarCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriasDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CategoriasDBDataSet categoriasDBDataSet;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private CategoriasDBDataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private CategoriasDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox categoriaTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.DataGridView categoriaDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}