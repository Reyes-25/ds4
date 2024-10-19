namespace Laboratorio14
{
    partial class frmProductos
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
            this.tsbNuevo = new System.Windows.Forms.PictureBox();
            this.tsbGuardar = new System.Windows.Forms.PictureBox();
            this.tsbEliminar = new System.Windows.Forms.PictureBox();
            this.tsbCancelar = new System.Windows.Forms.PictureBox();
            this.lbl_buscarId = new System.Windows.Forms.Label();
            this.tstId = new System.Windows.Forms.TextBox();
            this.tsbBuscar = new System.Windows.Forms.PictureBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tsbNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = global::Laboratorio14.Properties.Resources.nuevo;
            this.tsbNuevo.Location = new System.Drawing.Point(7, 6);
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(20, 20);
            this.tsbNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tsbNuevo.TabIndex = 0;
            this.tsbNuevo.TabStop = false;
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Image = global::Laboratorio14.Properties.Resources.guardar;
            this.tsbGuardar.Location = new System.Drawing.Point(33, 6);
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(20, 20);
            this.tsbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tsbGuardar.TabIndex = 2;
            this.tsbGuardar.TabStop = false;
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = global::Laboratorio14.Properties.Resources.eliminar;
            this.tsbEliminar.Location = new System.Drawing.Point(85, 6);
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(20, 20);
            this.tsbEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tsbEliminar.TabIndex = 3;
            this.tsbEliminar.TabStop = false;
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Image = global::Laboratorio14.Properties.Resources.cancelar;
            this.tsbCancelar.Location = new System.Drawing.Point(59, 6);
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(20, 20);
            this.tsbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tsbCancelar.TabIndex = 4;
            this.tsbCancelar.TabStop = false;
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // lbl_buscarId
            // 
            this.lbl_buscarId.AutoSize = true;
            this.lbl_buscarId.Location = new System.Drawing.Point(117, 9);
            this.lbl_buscarId.Name = "lbl_buscarId";
            this.lbl_buscarId.Size = new System.Drawing.Size(75, 13);
            this.lbl_buscarId.TabIndex = 5;
            this.lbl_buscarId.Text = "Buscar por ID:";
            // 
            // tstId
            // 
            this.tstId.Location = new System.Drawing.Point(198, 6);
            this.tstId.Name = "tstId";
            this.tstId.Size = new System.Drawing.Size(100, 20);
            this.tstId.TabIndex = 6;
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.Image = global::Laboratorio14.Properties.Resources.buscar;
            this.tsbBuscar.Location = new System.Drawing.Point(304, 6);
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(20, 20);
            this.tsbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tsbBuscar.TabIndex = 7;
            this.tsbBuscar.TabStop = false;
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(21, 63);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 13);
            this.lbl_id.TabIndex = 8;
            this.lbl_id.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(24, 79);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(67, 20);
            this.txtId.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 79);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(412, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(133, 63);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 11;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(21, 136);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(40, 13);
            this.lbl_precio.TabIndex = 12;
            this.lbl_precio.Text = "Precio:";
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Location = new System.Drawing.Point(133, 136);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(38, 13);
            this.lbl_stock.TabIndex = 13;
            this.lbl_stock.Text = "Stock:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(24, 152);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(97, 20);
            this.txtPrecio.TabIndex = 14;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(136, 152);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(108, 20);
            this.txtStock.TabIndex = 15;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnSalir.Location = new System.Drawing.Point(24, 196);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 24);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 263);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lbl_stock);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.tsbBuscar);
            this.Controls.Add(this.tstId);
            this.Controls.Add(this.lbl_buscarId);
            this.Controls.Add(this.tsbCancelar);
            this.Controls.Add(this.tsbEliminar);
            this.Controls.Add(this.tsbGuardar);
            this.Controls.Add(this.tsbNuevo);
            this.Name = "frmProductos";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.tsbNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tsbNuevo;
        private System.Windows.Forms.PictureBox tsbGuardar;
        private System.Windows.Forms.PictureBox tsbEliminar;
        private System.Windows.Forms.PictureBox tsbCancelar;
        private System.Windows.Forms.Label lbl_buscarId;
        private System.Windows.Forms.TextBox tstId;
        private System.Windows.Forms.PictureBox tsbBuscar;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnSalir;
    }
}

