namespace PryEDCantallops
{
    partial class frmListaDoble
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
            this.gpbGrilla = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.gpbEliminar = new System.Windows.Forms.GroupBox();
            this.cmbEliminar = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gpbNuevo = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbLista = new System.Windows.Forms.GroupBox();
            this.optDescendente = new System.Windows.Forms.RadioButton();
            this.optAscendente = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.gpbEliminar.SuspendLayout();
            this.gpbNuevo.SuspendLayout();
            this.gpbLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbGrilla
            // 
            this.gpbGrilla.Controls.Add(this.dgvLista);
            this.gpbGrilla.Controls.Add(this.lstLista);
            this.gpbGrilla.Location = new System.Drawing.Point(28, 271);
            this.gpbGrilla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbGrilla.Name = "gpbGrilla";
            this.gpbGrilla.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbGrilla.Size = new System.Drawing.Size(844, 268);
            this.gpbGrilla.TabIndex = 11;
            this.gpbGrilla.TabStop = false;
            this.gpbGrilla.Text = "Listado en una Lista y una Grilla";
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgvLista.Location = new System.Drawing.Point(289, 23);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.Size = new System.Drawing.Size(547, 229);
            this.dgvLista.TabIndex = 5;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Tramite
            // 
            this.Tramite.HeaderText = "Trámite";
            this.Tramite.MinimumWidth = 6;
            this.Tramite.Name = "Tramite";
            this.Tramite.Width = 125;
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.ItemHeight = 16;
            this.lstLista.Location = new System.Drawing.Point(8, 23);
            this.lstLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(257, 228);
            this.lstLista.TabIndex = 4;
            // 
            // gpbEliminar
            // 
            this.gpbEliminar.Controls.Add(this.cmbEliminar);
            this.gpbEliminar.Controls.Add(this.btnEliminar);
            this.gpbEliminar.Controls.Add(this.label6);
            this.gpbEliminar.Location = new System.Drawing.Point(605, 15);
            this.gpbEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbEliminar.Name = "gpbEliminar";
            this.gpbEliminar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbEliminar.Size = new System.Drawing.Size(267, 132);
            this.gpbEliminar.TabIndex = 10;
            this.gpbEliminar.TabStop = false;
            this.gpbEliminar.Text = "Elemento a eliminar";
            // 
            // cmbEliminar
            // 
            this.cmbEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEliminar.FormattingEnabled = true;
            this.cmbEliminar.Location = new System.Drawing.Point(81, 34);
            this.cmbEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEliminar.Name = "cmbEliminar";
            this.cmbEliminar.Size = new System.Drawing.Size(160, 24);
            this.cmbEliminar.TabIndex = 7;
            this.cmbEliminar.SelectedIndexChanged += new System.EventHandler(this.cmbEliminar_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(40, 74);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(201, 44);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Código";
            // 
            // gpbNuevo
            // 
            this.gpbNuevo.Controls.Add(this.btnAgregar);
            this.gpbNuevo.Controls.Add(this.txtTramite);
            this.gpbNuevo.Controls.Add(this.txtNombre);
            this.gpbNuevo.Controls.Add(this.txtCodigo);
            this.gpbNuevo.Controls.Add(this.label3);
            this.gpbNuevo.Controls.Add(this.label2);
            this.gpbNuevo.Controls.Add(this.label1);
            this.gpbNuevo.Location = new System.Drawing.Point(317, 15);
            this.gpbNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbNuevo.Name = "gpbNuevo";
            this.gpbNuevo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbNuevo.Size = new System.Drawing.Size(267, 238);
            this.gpbNuevo.TabIndex = 9;
            this.gpbNuevo.TabStop = false;
            this.gpbNuevo.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(28, 160);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(201, 44);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(96, 116);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(132, 22);
            this.txtTramite.TabIndex = 5;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 74);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(136, 38);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(92, 22);
            this.txtCodigo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trámite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // gpbLista
            // 
            this.gpbLista.Controls.Add(this.optDescendente);
            this.gpbLista.Controls.Add(this.optAscendente);
            this.gpbLista.Location = new System.Drawing.Point(605, 154);
            this.gpbLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbLista.Name = "gpbLista";
            this.gpbLista.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbLista.Size = new System.Drawing.Size(267, 98);
            this.gpbLista.TabIndex = 12;
            this.gpbLista.TabStop = false;
            this.gpbLista.Text = "Listar Datos";
            // 
            // optDescendente
            // 
            this.optDescendente.AutoSize = true;
            this.optDescendente.Location = new System.Drawing.Point(12, 62);
            this.optDescendente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optDescendente.Name = "optDescendente";
            this.optDescendente.Size = new System.Drawing.Size(109, 20);
            this.optDescendente.TabIndex = 1;
            this.optDescendente.TabStop = true;
            this.optDescendente.Text = "Descendente";
            this.optDescendente.UseVisualStyleBackColor = true;
            this.optDescendente.CheckedChanged += new System.EventHandler(this.optDescendente_CheckedChanged);
            // 
            // optAscendente
            // 
            this.optAscendente.AutoSize = true;
            this.optAscendente.Location = new System.Drawing.Point(12, 33);
            this.optAscendente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optAscendente.Name = "optAscendente";
            this.optAscendente.Size = new System.Drawing.Size(100, 20);
            this.optAscendente.TabIndex = 0;
            this.optAscendente.TabStop = true;
            this.optAscendente.Text = "Ascendente";
            this.optAscendente.UseVisualStyleBackColor = true;
            this.optAscendente.CheckedChanged += new System.EventHandler(this.optAscendente_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryEDCantallops.Properties.Resources.listadoble;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 554);
            this.Controls.Add(this.gpbLista);
            this.Controls.Add(this.gpbGrilla);
            this.Controls.Add(this.gpbEliminar);
            this.Controls.Add(this.gpbNuevo);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListaDoble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Doblemente Enlazada";
            this.gpbGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.gpbEliminar.ResumeLayout(false);
            this.gpbEliminar.PerformLayout();
            this.gpbNuevo.ResumeLayout(false);
            this.gpbNuevo.PerformLayout();
            this.gpbLista.ResumeLayout(false);
            this.gpbLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbGrilla;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.GroupBox gpbEliminar;
        private System.Windows.Forms.ComboBox cmbEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gpbNuevo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpbLista;
        private System.Windows.Forms.RadioButton optDescendente;
        private System.Windows.Forms.RadioButton optAscendente;
    }
}