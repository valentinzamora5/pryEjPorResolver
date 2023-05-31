namespace pryLeerBaseArchivoTXT
{
    partial class frmMetodoDeBusqueda
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
            this.btnLeerArchivo = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Datos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnResumen = new System.Windows.Forms.Button();
            this.cboItems = new System.Windows.Forms.ComboBox();
            this.lblElegir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLeerArchivo
            // 
            this.btnLeerArchivo.Location = new System.Drawing.Point(35, 22);
            this.btnLeerArchivo.Name = "btnLeerArchivo";
            this.btnLeerArchivo.Size = new System.Drawing.Size(75, 23);
            this.btnLeerArchivo.TabIndex = 0;
            this.btnLeerArchivo.Text = "Leer Archivo";
            this.btnLeerArchivo.UseVisualStyleBackColor = true;
            this.btnLeerArchivo.Click += new System.EventHandler(this.btnLeerArchivo_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(133, 27);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(10, 13);
            this.lblEstado.TabIndex = 1;
            this.lblEstado.Text = "-";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datos});
            this.dgvDatos.Location = new System.Drawing.Point(35, 73);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(605, 250);
            this.dgvDatos.TabIndex = 2;
            // 
            // Datos
            // 
            this.Datos.HeaderText = "Datos";
            this.Datos.Name = "Datos";
            // 
            // btnResumen
            // 
            this.btnResumen.Location = new System.Drawing.Point(35, 346);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(152, 23);
            this.btnResumen.TabIndex = 3;
            this.btnResumen.Text = "Resumen de los datos";
            this.btnResumen.UseVisualStyleBackColor = true;
            // 
            // cboItems
            // 
            this.cboItems.FormattingEnabled = true;
            this.cboItems.Location = new System.Drawing.Point(501, 348);
            this.cboItems.Name = "cboItems";
            this.cboItems.Size = new System.Drawing.Size(139, 21);
            this.cboItems.TabIndex = 4;
            // 
            // lblElegir
            // 
            this.lblElegir.AutoSize = true;
            this.lblElegir.Location = new System.Drawing.Point(426, 355);
            this.lblElegir.Name = "lblElegir";
            this.lblElegir.Size = new System.Drawing.Size(57, 13);
            this.lblElegir.TabIndex = 5;
            this.lblElegir.Text = "Elegir ítem";
            // 
            // frmMetodoDeBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 493);
            this.Controls.Add(this.lblElegir);
            this.Controls.Add(this.cboItems);
            this.Controls.Add(this.btnResumen);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnLeerArchivo);
            this.Name = "frmMetodoDeBusqueda";
            this.Text = "frmMetodoDeBusqueda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeerArchivo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datos;
        private System.Windows.Forms.Button btnResumen;
        private System.Windows.Forms.ComboBox cboItems;
        private System.Windows.Forms.Label lblElegir;
    }
}