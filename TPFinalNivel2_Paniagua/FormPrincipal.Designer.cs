namespace TPFinalNivel2_Paniagua
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxArticuloImagen = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionSalidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrarPestañaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreLaAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txbBusqueda = new System.Windows.Forms.TextBox();
            this.lblDescNombre = new System.Windows.Forms.Label();
            this.lblDescMarca = new System.Windows.Forms.Label();
            this.lblDescPrecio = new System.Windows.Forms.Label();
            this.lblDescCodigo = new System.Windows.Forms.Label();
            this.lblDescDescripcion = new System.Windows.Forms.Label();
            this.lblDescCateg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticuloImagen)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(55, 136);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(559, 132);
            this.dgvArticulos.TabIndex = 17;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbxArticuloImagen
            // 
            this.pbxArticuloImagen.Location = new System.Drawing.Point(660, 108);
            this.pbxArticuloImagen.Name = "pbxArticuloImagen";
            this.pbxArticuloImagen.Size = new System.Drawing.Size(200, 160);
            this.pbxArticuloImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticuloImagen.TabIndex = 1;
            this.pbxArticuloImagen.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(21, 364);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 31);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(346, 364);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(106, 31);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(522, 364);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(106, 31);
            this.btnAlta.TabIndex = 4;
            this.btnAlta.Text = "Dar de Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.opcionSalidaToolStripMenuItem,
            this.sobreLaAppToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcaToolStripMenuItem,
            this.categoriaToolStripMenuItem});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // opcionSalidaToolStripMenuItem
            // 
            this.opcionSalidaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carrarPestañaToolStripMenuItem});
            this.opcionSalidaToolStripMenuItem.Name = "opcionSalidaToolStripMenuItem";
            this.opcionSalidaToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.opcionSalidaToolStripMenuItem.Text = "Opcion Salida";
            // 
            // carrarPestañaToolStripMenuItem
            // 
            this.carrarPestañaToolStripMenuItem.Name = "carrarPestañaToolStripMenuItem";
            this.carrarPestañaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.carrarPestañaToolStripMenuItem.Text = "Carrar Pestaña";
            // 
            // sobreLaAppToolStripMenuItem
            // 
            this.sobreLaAppToolStripMenuItem.Name = "sobreLaAppToolStripMenuItem";
            this.sobreLaAppToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.sobreLaAppToolStripMenuItem.Text = "Sobre la App";
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(171, 364);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(106, 31);
            this.btnBaja.TabIndex = 6;
            this.btnBaja.Text = "Dar de Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(711, 364);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 31);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(51, 87);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(110, 24);
            this.lblBusqueda.TabIndex = 8;
            this.lblBusqueda.Text = "Busqueda:";
            // 
            // txbBusqueda
            // 
            this.txbBusqueda.Location = new System.Drawing.Point(171, 92);
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.Size = new System.Drawing.Size(378, 20);
            this.txbBusqueda.TabIndex = 9;
            // 
            // lblDescNombre
            // 
            this.lblDescNombre.AutoSize = true;
            this.lblDescNombre.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescNombre.Location = new System.Drawing.Point(657, 284);
            this.lblDescNombre.Name = "lblDescNombre";
            this.lblDescNombre.Size = new System.Drawing.Size(54, 14);
            this.lblDescNombre.TabIndex = 10;
            this.lblDescNombre.Text = "nombre";
            // 
            // lblDescMarca
            // 
            this.lblDescMarca.AutoSize = true;
            this.lblDescMarca.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescMarca.Location = new System.Drawing.Point(168, 325);
            this.lblDescMarca.Name = "lblDescMarca";
            this.lblDescMarca.Size = new System.Drawing.Size(44, 14);
            this.lblDescMarca.TabIndex = 11;
            this.lblDescMarca.Text = "marca";
            // 
            // lblDescPrecio
            // 
            this.lblDescPrecio.AutoSize = true;
            this.lblDescPrecio.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescPrecio.Location = new System.Drawing.Point(804, 284);
            this.lblDescPrecio.Name = "lblDescPrecio";
            this.lblDescPrecio.Size = new System.Drawing.Size(47, 14);
            this.lblDescPrecio.TabIndex = 12;
            this.lblDescPrecio.Text = "precio";
            // 
            // lblDescCodigo
            // 
            this.lblDescCodigo.AutoSize = true;
            this.lblDescCodigo.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescCodigo.Location = new System.Drawing.Point(76, 294);
            this.lblDescCodigo.Name = "lblDescCodigo";
            this.lblDescCodigo.Size = new System.Drawing.Size(51, 14);
            this.lblDescCodigo.TabIndex = 13;
            this.lblDescCodigo.Text = "codigo";
            // 
            // lblDescDescripcion
            // 
            this.lblDescDescripcion.AutoSize = true;
            this.lblDescDescripcion.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescDescripcion.Location = new System.Drawing.Point(305, 294);
            this.lblDescDescripcion.Name = "lblDescDescripcion";
            this.lblDescDescripcion.Size = new System.Drawing.Size(81, 14);
            this.lblDescDescripcion.TabIndex = 14;
            this.lblDescDescripcion.Text = "descripcion";
            // 
            // lblDescCateg
            // 
            this.lblDescCateg.AutoSize = true;
            this.lblDescCateg.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescCateg.Location = new System.Drawing.Point(457, 325);
            this.lblDescCateg.Name = "lblDescCateg";
            this.lblDescCateg.Size = new System.Drawing.Size(66, 14);
            this.lblDescCateg.TabIndex = 15;
            this.lblDescCateg.Text = "categoria";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.lblDescCateg);
            this.Controls.Add(this.lblDescDescripcion);
            this.Controls.Add(this.lblDescCodigo);
            this.Controls.Add(this.lblDescPrecio);
            this.Controls.Add(this.lblDescMarca);
            this.Controls.Add(this.lblDescNombre);
            this.Controls.Add(this.txbBusqueda);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxArticuloImagen);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticuloImagen)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxArticuloImagen;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionSalidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrarPestañaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreLaAppToolStripMenuItem;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txbBusqueda;
        private System.Windows.Forms.Label lblDescNombre;
        private System.Windows.Forms.Label lblDescMarca;
        private System.Windows.Forms.Label lblDescPrecio;
        private System.Windows.Forms.Label lblDescCodigo;
        private System.Windows.Forms.Label lblDescDescripcion;
        private System.Windows.Forms.Label lblDescCateg;
    }
}

