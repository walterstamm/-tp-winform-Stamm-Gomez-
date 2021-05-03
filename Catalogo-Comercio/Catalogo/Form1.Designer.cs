
namespace Catalogo
{
    partial class Form1
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
            this.dgvArticulo = new System.Windows.Forms.DataGridView();
            this.LblFiltrar = new System.Windows.Forms.Label();
            this.btnAgregarArticulos = new System.Windows.Forms.Button();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.PbxImagen = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulo.Location = new System.Drawing.Point(12, 63);
            this.dgvArticulo.MultiSelect = false;
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.ReadOnly = true;
            this.dgvArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulo.Size = new System.Drawing.Size(619, 305);
            this.dgvArticulo.TabIndex = 0;
            this.dgvArticulo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvArticulo_MouseClick);
            // 
            // LblFiltrar
            // 
            this.LblFiltrar.AutoSize = true;
            this.LblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFiltrar.Location = new System.Drawing.Point(12, 23);
            this.LblFiltrar.Name = "LblFiltrar";
            this.LblFiltrar.Size = new System.Drawing.Size(56, 20);
            this.LblFiltrar.TabIndex = 1;
            this.LblFiltrar.Text = "Filtrar";
            // 
            // btnAgregarArticulos
            // 
            this.btnAgregarArticulos.Location = new System.Drawing.Point(15, 386);
            this.btnAgregarArticulos.Name = "btnAgregarArticulos";
            this.btnAgregarArticulos.Size = new System.Drawing.Size(127, 34);
            this.btnAgregarArticulos.TabIndex = 3;
            this.btnAgregarArticulos.Text = "Agregar Articulos";
            this.btnAgregarArticulos.UseVisualStyleBackColor = true;
            this.btnAgregarArticulos.Click += new System.EventHandler(this.btnAgregarArticulos_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Location = new System.Drawing.Point(174, 386);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(127, 34);
            this.btnModificarArticulo.TabIndex = 4;
            this.btnModificarArticulo.Text = "Modificar";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(347, 386);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(127, 34);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar ";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.Location = new System.Drawing.Point(504, 386);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(127, 34);
            this.btnDetalles.TabIndex = 6;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.UseVisualStyleBackColor = true;
            // 
            // PbxImagen
            // 
            this.PbxImagen.Location = new System.Drawing.Point(653, 63);
            this.PbxImagen.Name = "PbxImagen";
            this.PbxImagen.Size = new System.Drawing.Size(263, 319);
            this.PbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxImagen.TabIndex = 7;
            this.PbxImagen.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(370, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 31);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(90, 22);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(259, 20);
            this.txtFiltro.TabIndex = 9;
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.PbxImagen);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.btnAgregarArticulos);
            this.Controls.Add(this.LblFiltrar);
            this.Controls.Add(this.dgvArticulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulo;
        private System.Windows.Forms.Label LblFiltrar;
        private System.Windows.Forms.Button btnAgregarArticulos;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.PictureBox PbxImagen;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
    }
}

