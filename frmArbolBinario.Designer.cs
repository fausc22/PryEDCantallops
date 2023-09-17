namespace PryEDCantallops
{
    partial class frmArbolBinario
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
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.optIn = new System.Windows.Forms.RadioButton();
            this.optPost = new System.Windows.Forms.RadioButton();
            this.optPre = new System.Windows.Forms.RadioButton();
            this.gpbGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.gpbEliminar.SuspendLayout();
            this.gpbNuevo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbGrilla
            // 
            this.gpbGrilla.Controls.Add(this.optPre);
            this.gpbGrilla.Controls.Add(this.optPost);
            this.gpbGrilla.Controls.Add(this.optIn);
            this.gpbGrilla.Controls.Add(this.dgvLista);
            this.gpbGrilla.Location = new System.Drawing.Point(13, 266);
            this.gpbGrilla.Margin = new System.Windows.Forms.Padding(4);
            this.gpbGrilla.Name = "gpbGrilla";
            this.gpbGrilla.Padding = new System.Windows.Forms.Padding(4);
            this.gpbGrilla.Size = new System.Drawing.Size(809, 268);
            this.gpbGrilla.TabIndex = 14;
            this.gpbGrilla.TabStop = false;
            this.gpbGrilla.Text = "Listado del arbol";
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgvLista.Location = new System.Drawing.Point(254, 23);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(4);
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
            // gpbEliminar
            // 
            this.gpbEliminar.Controls.Add(this.cmbEliminar);
            this.gpbEliminar.Controls.Add(this.btnEliminar);
            this.gpbEliminar.Controls.Add(this.label6);
            this.gpbEliminar.Location = new System.Drawing.Point(555, 19);
            this.gpbEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.gpbEliminar.Name = "gpbEliminar";
            this.gpbEliminar.Padding = new System.Windows.Forms.Padding(4);
            this.gpbEliminar.Size = new System.Drawing.Size(267, 142);
            this.gpbEliminar.TabIndex = 13;
            this.gpbEliminar.TabStop = false;
            this.gpbEliminar.Text = "Elemento a eliminar";
            // 
            // cmbEliminar
            // 
            this.cmbEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEliminar.FormattingEnabled = true;
            this.cmbEliminar.Location = new System.Drawing.Point(69, 32);
            this.cmbEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEliminar.Name = "cmbEliminar";
            this.cmbEliminar.Size = new System.Drawing.Size(160, 24);
            this.cmbEliminar.TabIndex = 7;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(28, 82);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(201, 44);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 35);
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
            this.gpbNuevo.Location = new System.Drawing.Point(259, 13);
            this.gpbNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.gpbNuevo.Name = "gpbNuevo";
            this.gpbNuevo.Padding = new System.Windows.Forms.Padding(4);
            this.gpbNuevo.Size = new System.Drawing.Size(267, 238);
            this.gpbNuevo.TabIndex = 12;
            this.gpbNuevo.TabStop = false;
            this.gpbNuevo.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(28, 160);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(201, 44);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(96, 116);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(4);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(132, 22);
            this.txtTramite.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 74);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(136, 38);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
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
            // btnEquilibrar
            // 
            this.btnEquilibrar.Enabled = false;
            this.btnEquilibrar.Location = new System.Drawing.Point(555, 192);
            this.btnEquilibrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(267, 44);
            this.btnEquilibrar.TabIndex = 15;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 19);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(236, 232);
            this.treeView1.TabIndex = 16;
            // 
            // optIn
            // 
            this.optIn.AutoSize = true;
            this.optIn.Location = new System.Drawing.Point(15, 53);
            this.optIn.Name = "optIn";
            this.optIn.Size = new System.Drawing.Size(79, 20);
            this.optIn.TabIndex = 6;
            this.optIn.TabStop = true;
            this.optIn.Text = "In-Orden";
            this.optIn.UseVisualStyleBackColor = true;
            // 
            // optPost
            // 
            this.optPost.AutoSize = true;
            this.optPost.Location = new System.Drawing.Point(15, 164);
            this.optPost.Name = "optPost";
            this.optPost.Size = new System.Drawing.Size(96, 20);
            this.optPost.TabIndex = 7;
            this.optPost.TabStop = true;
            this.optPost.Text = "Post-Orden";
            this.optPost.UseVisualStyleBackColor = true;
            // 
            // optPre
            // 
            this.optPre.AutoSize = true;
            this.optPre.Location = new System.Drawing.Point(15, 105);
            this.optPre.Name = "optPre";
            this.optPre.Size = new System.Drawing.Size(90, 20);
            this.optPre.TabIndex = 8;
            this.optPre.TabStop = true;
            this.optPre.Text = "Pre-Orden";
            this.optPre.UseVisualStyleBackColor = true;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 552);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.gpbGrilla);
            this.Controls.Add(this.gpbEliminar);
            this.Controls.Add(this.gpbNuevo);
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructuras Ramificadas - Arbol Binario";
            this.gpbGrilla.ResumeLayout(false);
            this.gpbGrilla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.gpbEliminar.ResumeLayout(false);
            this.gpbEliminar.PerformLayout();
            this.gpbNuevo.ResumeLayout(false);
            this.gpbNuevo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbGrilla;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
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
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RadioButton optPre;
        private System.Windows.Forms.RadioButton optPost;
        private System.Windows.Forms.RadioButton optIn;
    }
}