namespace Registros.UI.Registro
{
    partial class Registro
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
            System.Windows.Forms.Label usuariosLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label claveLabel;
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioDBDataSet = new Registros.UsuarioDBDataSet();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usuarioTableAdapter = new Registros.UsuarioDBDataSetTableAdapters.UsuarioTableAdapter();
            this.tableAdapterManager = new Registros.UsuarioDBDataSetTableAdapters.TableAdapterManager();
            this.button2 = new System.Windows.Forms.Button();
            this.usuariosTextBox = new System.Windows.Forms.MaskedTextBox();
            usuariosLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            claveLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // usuariosLabel
            // 
            usuariosLabel.AutoSize = true;
            usuariosLabel.Location = new System.Drawing.Point(149, 100);
            usuariosLabel.Name = "usuariosLabel";
            usuariosLabel.Size = new System.Drawing.Size(51, 13);
            usuariosLabel.TabIndex = 1;
            usuariosLabel.Text = "Usuarios:";
            usuariosLabel.Click += new System.EventHandler(this.usuariosLabel_Click);
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(149, 126);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(52, 13);
            nombresLabel.TabIndex = 3;
            nombresLabel.Text = "Nombres:";
            nombresLabel.Click += new System.EventHandler(this.nombresLabel_Click);
            // 
            // claveLabel
            // 
            claveLabel.AutoSize = true;
            claveLabel.Location = new System.Drawing.Point(149, 152);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new System.Drawing.Size(36, 13);
            claveLabel.TabIndex = 5;
            claveLabel.Text = "clave:";
            claveLabel.Click += new System.EventHandler(this.claveLabel_Click);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.usuarioDBDataSet;
            // 
            // usuarioDBDataSet
            // 
            this.usuarioDBDataSet.DataSetName = "UsuarioDBDataSet";
            this.usuarioDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nombres", true));
            this.nombresTextBox.Location = new System.Drawing.Point(207, 123);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombresTextBox.TabIndex = 4;
            this.nombresTextBox.TextChanged += new System.EventHandler(this.nombresTextBox_TextChanged);
            // 
            // claveTextBox
            // 
            this.claveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "clave", true));
            this.claveTextBox.Location = new System.Drawing.Point(207, 149);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.Size = new System.Drawing.Size(100, 20);
            this.claveTextBox.TabIndex = 6;
            this.claveTextBox.Text = "Constraseña ";
            this.claveTextBox.TextChanged += new System.EventHandler(this.claveTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Inserte datos";
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Registros.UsuarioDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = this.usuarioTableAdapter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // usuariosTextBox
            // 
            this.usuariosTextBox.Location = new System.Drawing.Point(207, 93);
            this.usuariosTextBox.Mask = "99999";
            this.usuariosTextBox.Name = "usuariosTextBox";
            this.usuariosTextBox.Size = new System.Drawing.Size(100, 20);
            this.usuariosTextBox.TabIndex = 10;
            this.usuariosTextBox.ValidatingType = typeof(int);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 316);
            this.Controls.Add(this.usuariosTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(usuariosLabel);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(claveLabel);
            this.Controls.Add(this.claveTextBox);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UsuarioDBDataSet usuarioDBDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private UsuarioDBDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private UsuarioDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox usuariosTextBox;
    }
}