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
            this.optPre = new System.Windows.Forms.RadioButton();
            this.optPost = new System.Windows.Forms.RadioButton();
            this.optIn = new System.Windows.Forms.RadioButton();
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
            this.gpbGrilla.Location = new System.Drawing.Point(10, 216);
            this.gpbGrilla.Name = "gpbGrilla";
            this.gpbGrilla.Size = new System.Drawing.Size(607, 218);
            this.gpbGrilla.TabIndex = 14;
            this.gpbGrilla.TabStop = false;
            this.gpbGrilla.Text = "Listado del arbol";
            // 
            // optPre
            // 
            this.optPre.AutoSize = true;
            this.optPre.Location = new System.Drawing.Point(11, 85);
            this.optPre.Margin = new System.Windows.Forms.Padding(2);
            this.optPre.Name = "optPre";
            this.optPre.Size = new System.Drawing.Size(73, 17);
            this.optPre.TabIndex = 8;
            this.optPre.TabStop = true;
            this.optPre.Text = "Pre-Orden";
            this.optPre.UseVisualStyleBackColor = true;
            // 
            // optPost
            // 
            this.optPost.AutoSize = true;
            this.optPost.Location = new System.Drawing.Point(11, 133);
            this.optPost.Margin = new System.Windows.Forms.Padding(2);
            this.optPost.Name = "optPost";
            this.optPost.Size = new System.Drawing.Size(78, 17);
            this.optPost.TabIndex = 7;
            this.optPost.TabStop = true;
            this.optPost.Text = "Post-Orden";
            this.optPost.UseVisualStyleBackColor = true;
            // 
            // optIn
            // 
            this.optIn.AutoSize = true;
            this.optIn.Location = new System.Drawing.Point(11, 43);
            this.optIn.Margin = new System.Windows.Forms.Padding(2);
            this.optIn.Name = "optIn";
            this.optIn.Size = new System.Drawing.Size(66, 17);
            this.optIn.TabIndex = 6;
            this.optIn.TabStop = true;
            this.optIn.Text = "In-Orden";
            this.optIn.UseVisualStyleBackColor = true;
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgvLista.Location = new System.Drawing.Point(190, 19);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.Size = new System.Drawing.Size(410, 186);
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
            this.gpbEliminar.Location = new System.Drawing.Point(416, 15);
            this.gpbEliminar.Name = "gpbEliminar";
            this.gpbEliminar.Size = new System.Drawing.Size(200, 115);
            this.gpbEliminar.TabIndex = 13;
            this.gpbEliminar.TabStop = false;
            this.gpbEliminar.Text = "Elemento a eliminar";
            // 
            // cmbEliminar
            // 
            this.cmbEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEliminar.FormattingEnabled = true;
            this.cmbEliminar.Location = new System.Drawing.Point(52, 26);
            this.cmbEliminar.Name = "cmbEliminar";
            this.cmbEliminar.Size = new System.Drawing.Size(121, 21);
            this.cmbEliminar.TabIndex = 7;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(21, 67);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(151, 36);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
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
            this.gpbNuevo.Location = new System.Drawing.Point(194, 11);
            this.gpbNuevo.Name = "gpbNuevo";
            this.gpbNuevo.Size = new System.Drawing.Size(200, 193);
            this.gpbNuevo.TabIndex = 12;
            this.gpbNuevo.TabStop = false;
            this.gpbNuevo.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(21, 130);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(151, 36);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(72, 94);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 5;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(72, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(102, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(70, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trámite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Enabled = false;
            this.btnEquilibrar.Location = new System.Drawing.Point(416, 156);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(200, 36);
            this.btnEquilibrar.TabIndex = 15;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(9, 15);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(178, 189);
            this.treeView1.TabIndex = 16;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.gpbGrilla);
            this.Controls.Add(this.gpbEliminar);
            this.Controls.Add(this.gpbNuevo);
            this.Margin = new System.Windows.Forms.Padding(2);
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