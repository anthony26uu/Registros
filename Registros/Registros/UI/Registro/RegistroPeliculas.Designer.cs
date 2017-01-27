namespace Registros.UI.Registro
{
    partial class RegistroPeliculas
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
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label estrenoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label categoriaLabel;
            this.peliculasDBDataSet = new Registros.PeliculasDBDataSet();
            this.peliculasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peliculasTableAdapter = new Registros.PeliculasDBDataSetTableAdapters.PeliculasTableAdapter();
            this.tableAdapterManager = new Registros.PeliculasDBDataSetTableAdapters.TableAdapterManager();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.estrenoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.categoriaTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            estrenoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // peliculasDBDataSet
            // 
            this.peliculasDBDataSet.DataSetName = "PeliculasDBDataSet";
            this.peliculasDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peliculasBindingSource
            // 
            this.peliculasBindingSource.DataMember = "Peliculas";
            this.peliculasBindingSource.DataSource = this.peliculasDBDataSet;
            // 
            // peliculasTableAdapter
            // 
            this.peliculasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PeliculasTableAdapter = this.peliculasTableAdapter;
            this.tableAdapterManager.UpdateOrder = Registros.PeliculasDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(62, 91);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(52, 13);
            nombresLabel.TabIndex = 1;
            nombresLabel.Text = "Nombres:";
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "Nombres", true));
            this.nombresTextBox.Location = new System.Drawing.Point(134, 88);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombresTextBox.TabIndex = 2;
            // 
            // estrenoLabel
            // 
            estrenoLabel.AutoSize = true;
            estrenoLabel.Location = new System.Drawing.Point(62, 117);
            estrenoLabel.Name = "estrenoLabel";
            estrenoLabel.Size = new System.Drawing.Size(46, 13);
            estrenoLabel.TabIndex = 3;
            estrenoLabel.Text = "Estreno:";
            // 
            // estrenoMaskedTextBox
            // 
            this.estrenoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "Estreno", true));
            this.estrenoMaskedTextBox.Location = new System.Drawing.Point(134, 114);
            this.estrenoMaskedTextBox.Name = "estrenoMaskedTextBox";
            this.estrenoMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.estrenoMaskedTextBox.TabIndex = 4;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(62, 143);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 5;
            descripcionLabel.Text = "Descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(134, 140);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(158, 90);
            this.descripcionTextBox.TabIndex = 6;
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(62, 239);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(55, 13);
            categoriaLabel.TabIndex = 7;
            categoriaLabel.Text = "Categoria:";
            // 
            // categoriaTextBox
            // 
            this.categoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "Categoria", true));
            this.categoriaTextBox.Location = new System.Drawing.Point(134, 236);
            this.categoriaTextBox.Name = "categoriaTextBox";
            this.categoriaTextBox.Size = new System.Drawing.Size(100, 20);
            this.categoriaTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Registrar Peliculas";
            // 
            // RegistroPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(estrenoLabel);
            this.Controls.Add(this.estrenoMaskedTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(this.categoriaTextBox);
            this.Name = "RegistroPeliculas";
            this.Text = "RegistroPeliculas";
            this.Load += new System.EventHandler(this.RegistroPeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.peliculasDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PeliculasDBDataSet peliculasDBDataSet;
        private System.Windows.Forms.BindingSource peliculasBindingSource;
        private PeliculasDBDataSetTableAdapters.PeliculasTableAdapter peliculasTableAdapter;
        private PeliculasDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.MaskedTextBox estrenoMaskedTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox categoriaTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}