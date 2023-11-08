namespace PryEDCantallops
{
    partial class frmRepaso
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbListar = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtListar = new System.Windows.Forms.RichTextBox();
            this.dgvListar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operación a realizar en la base de datos:";
            // 
            // cmbListar
            // 
            this.cmbListar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListar.FormattingEnabled = true;
            this.cmbListar.Items.AddRange(new object[] {
            "Union",
            "Diferencia",
            "Interseccion",
            "Proyección Simple",
            "Proyección Multiatributo",
            "Juntar",
            "Selección Simple",
            "Selección Multiatributo con operador AND",
            "Selección Multiatributo con operador OR",
            "Selección Multiatributo por convulsion"});
            this.cmbListar.Location = new System.Drawing.Point(295, 20);
            this.cmbListar.Name = "cmbListar";
            this.cmbListar.Size = new System.Drawing.Size(562, 21);
            this.cmbListar.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(863, 20);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(96, 23);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtListar
            // 
            this.txtListar.Enabled = false;
            this.txtListar.Location = new System.Drawing.Point(15, 49);
            this.txtListar.Name = "txtListar";
            this.txtListar.Size = new System.Drawing.Size(944, 136);
            this.txtListar.TabIndex = 3;
            this.txtListar.Text = "";
            // 
            // dgvListar
            // 
            this.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListar.Location = new System.Drawing.Point(15, 191);
            this.dgvListar.Name = "dgvListar";
            this.dgvListar.Size = new System.Drawing.Size(944, 309);
            this.dgvListar.TabIndex = 4;
            // 
            // frmRepaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 515);
            this.Controls.Add(this.dgvListar);
            this.Controls.Add(this.txtListar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cmbListar);
            this.Controls.Add(this.label1);
            this.Name = "frmRepaso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones en base de Datos";
            this.Load += new System.EventHandler(this.frmRepaso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbListar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.RichTextBox txtListar;
        private System.Windows.Forms.DataGridView dgvListar;
    }
}