namespace PryEDCantallops
{
    partial class frmBD
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnProMulti = new System.Windows.Forms.Button();
            this.btnProSimple = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConvolucin = new System.Windows.Forms.Button();
            this.btnSelecMulti = new System.Windows.Forms.Button();
            this.btnSelecSimplee = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDif = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 294);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnJuntar);
            this.groupBox1.Controls.Add(this.btnProMulti);
            this.groupBox1.Controls.Add(this.btnProSimple);
            this.groupBox1.Location = new System.Drawing.Point(12, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 113);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones de Proyeccion - SELECT";
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(6, 77);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(235, 23);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            // 
            // btnProMulti
            // 
            this.btnProMulti.Location = new System.Drawing.Point(6, 48);
            this.btnProMulti.Name = "btnProMulti";
            this.btnProMulti.Size = new System.Drawing.Size(235, 23);
            this.btnProMulti.TabIndex = 1;
            this.btnProMulti.Text = "Proyeccion multiatributo";
            this.btnProMulti.UseVisualStyleBackColor = true;
            // 
            // btnProSimple
            // 
            this.btnProSimple.Location = new System.Drawing.Point(6, 19);
            this.btnProSimple.Name = "btnProSimple";
            this.btnProSimple.Size = new System.Drawing.Size(235, 23);
            this.btnProSimple.TabIndex = 0;
            this.btnProSimple.Text = "Proyeccion simple";
            this.btnProSimple.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConvolucin);
            this.groupBox2.Controls.Add(this.btnSelecMulti);
            this.groupBox2.Controls.Add(this.btnSelecSimplee);
            this.groupBox2.Location = new System.Drawing.Point(288, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 113);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones de Seleccion - WHERE";
            // 
            // btnConvolucin
            // 
            this.btnConvolucin.Location = new System.Drawing.Point(6, 77);
            this.btnConvolucin.Name = "btnConvolucin";
            this.btnConvolucin.Size = new System.Drawing.Size(235, 23);
            this.btnConvolucin.TabIndex = 2;
            this.btnConvolucin.Text = "Selección por convolución";
            this.btnConvolucin.UseVisualStyleBackColor = true;
            // 
            // btnSelecMulti
            // 
            this.btnSelecMulti.Location = new System.Drawing.Point(6, 48);
            this.btnSelecMulti.Name = "btnSelecMulti";
            this.btnSelecMulti.Size = new System.Drawing.Size(235, 23);
            this.btnSelecMulti.TabIndex = 1;
            this.btnSelecMulti.Text = "Seleccion multiatributo";
            this.btnSelecMulti.UseVisualStyleBackColor = true;
            // 
            // btnSelecSimplee
            // 
            this.btnSelecSimplee.Location = new System.Drawing.Point(6, 19);
            this.btnSelecSimplee.Name = "btnSelecSimplee";
            this.btnSelecSimplee.Size = new System.Drawing.Size(235, 23);
            this.btnSelecSimplee.TabIndex = 0;
            this.btnSelecSimplee.Text = "Seleccion simple";
            this.btnSelecSimplee.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDif);
            this.groupBox3.Controls.Add(this.btnInterseccion);
            this.groupBox3.Controls.Add(this.btnUnion);
            this.groupBox3.Location = new System.Drawing.Point(541, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 113);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operaciones Algebraicas";
            // 
            // btnDif
            // 
            this.btnDif.Location = new System.Drawing.Point(6, 77);
            this.btnDif.Name = "btnDif";
            this.btnDif.Size = new System.Drawing.Size(235, 23);
            this.btnDif.TabIndex = 2;
            this.btnDif.Text = "Diferencia";
            this.btnDif.UseVisualStyleBackColor = true;
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(6, 48);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(235, 23);
            this.btnInterseccion.TabIndex = 1;
            this.btnInterseccion.Text = "Interseccion";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(6, 19);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(235, 23);
            this.btnUnion.TabIndex = 0;
            this.btnUnion.Text = "Union";
            this.btnUnion.UseVisualStyleBackColor = true;
            // 
            // frmBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnProMulti;
        private System.Windows.Forms.Button btnProSimple;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConvolucin;
        private System.Windows.Forms.Button btnSelecMulti;
        private System.Windows.Forms.Button btnSelecSimplee;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDif;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnUnion;
    }
}