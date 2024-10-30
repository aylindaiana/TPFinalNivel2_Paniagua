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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxArticuloImagen = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionSalidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrarPestañaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreLaAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblDescNombre = new System.Windows.Forms.Label();
            this.lblDescMarca = new System.Windows.Forms.Label();
            this.lblDescPrecio = new System.Windows.Forms.Label();
            this.lblDescCodigo = new System.Windows.Forms.Label();
            this.lblDescDescripcion = new System.Windows.Forms.Label();
            this.lblDescCateg = new System.Windows.Forms.Label();
            this.pnlEdicion = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.cbxCampo = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblTituloAgregar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticuloImagen)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlEdicion.SuspendLayout();
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
            this.dgvArticulos.Size = new System.Drawing.Size(556, 118);
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
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(64, 298);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 82);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(224, 298);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(108, 82);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.opcionSalidaToolStripMenuItem,
            this.sobreLaAppToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(941, 24);
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
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
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
            this.carrarPestañaToolStripMenuItem.Click += new System.EventHandler(this.carrarPestañaToolStripMenuItem_Click);
            // 
            // sobreLaAppToolStripMenuItem
            // 
            this.sobreLaAppToolStripMenuItem.Name = "sobreLaAppToolStripMenuItem";
            this.sobreLaAppToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.sobreLaAppToolStripMenuItem.Text = "Sobre la App";
            this.sobreLaAppToolStripMenuItem.Click += new System.EventHandler(this.sobreLaAppToolStripMenuItem_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(416, 298);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 82);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(51, 87);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(152, 24);
            this.lblBusqueda.TabIndex = 8;
            this.lblBusqueda.Text = "Buscar Rápido:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(209, 91);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(350, 20);
            this.txtBusqueda.TabIndex = 9;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // lblDescNombre
            // 
            this.lblDescNombre.AutoSize = true;
            this.lblDescNombre.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescNombre.Location = new System.Drawing.Point(707, 271);
            this.lblDescNombre.Name = "lblDescNombre";
            this.lblDescNombre.Size = new System.Drawing.Size(54, 14);
            this.lblDescNombre.TabIndex = 10;
            this.lblDescNombre.Text = "nombre";
            // 
            // lblDescMarca
            // 
            this.lblDescMarca.AutoSize = true;
            this.lblDescMarca.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescMarca.Location = new System.Drawing.Point(781, 364);
            this.lblDescMarca.Name = "lblDescMarca";
            this.lblDescMarca.Size = new System.Drawing.Size(44, 14);
            this.lblDescMarca.TabIndex = 11;
            this.lblDescMarca.Text = "marca";
            // 
            // lblDescPrecio
            // 
            this.lblDescPrecio.AutoSize = true;
            this.lblDescPrecio.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescPrecio.Location = new System.Drawing.Point(778, 301);
            this.lblDescPrecio.Name = "lblDescPrecio";
            this.lblDescPrecio.Size = new System.Drawing.Size(47, 14);
            this.lblDescPrecio.TabIndex = 12;
            this.lblDescPrecio.Text = "precio";
            // 
            // lblDescCodigo
            // 
            this.lblDescCodigo.AutoSize = true;
            this.lblDescCodigo.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescCodigo.Location = new System.Drawing.Point(592, 301);
            this.lblDescCodigo.Name = "lblDescCodigo";
            this.lblDescCodigo.Size = new System.Drawing.Size(51, 14);
            this.lblDescCodigo.TabIndex = 13;
            this.lblDescCodigo.Text = "codigo";
            // 
            // lblDescDescripcion
            // 
            this.lblDescDescripcion.AutoSize = true;
            this.lblDescDescripcion.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescDescripcion.Location = new System.Drawing.Point(592, 333);
            this.lblDescDescripcion.Name = "lblDescDescripcion";
            this.lblDescDescripcion.Size = new System.Drawing.Size(81, 14);
            this.lblDescDescripcion.TabIndex = 14;
            this.lblDescDescripcion.Text = "descripcion";
            // 
            // lblDescCateg
            // 
            this.lblDescCateg.AutoSize = true;
            this.lblDescCateg.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescCateg.Location = new System.Drawing.Point(592, 364);
            this.lblDescCateg.Name = "lblDescCateg";
            this.lblDescCateg.Size = new System.Drawing.Size(66, 14);
            this.lblDescCateg.TabIndex = 15;
            this.lblDescCateg.Text = "categoria";
            // 
            // pnlEdicion
            // 
            this.pnlEdicion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlEdicion.Controls.Add(this.btnLimpiar);
            this.pnlEdicion.Controls.Add(this.txtFiltro);
            this.pnlEdicion.Controls.Add(this.btnBuscar);
            this.pnlEdicion.Controls.Add(this.cbxCriterio);
            this.pnlEdicion.Controls.Add(this.cbxCampo);
            this.pnlEdicion.Controls.Add(this.lblFiltro);
            this.pnlEdicion.Controls.Add(this.lblCriterio);
            this.pnlEdicion.Controls.Add(this.lblCampo);
            this.pnlEdicion.Location = new System.Drawing.Point(29, 27);
            this.pnlEdicion.Name = "pnlEdicion";
            this.pnlEdicion.Size = new System.Drawing.Size(891, 48);
            this.pnlEdicion.TabIndex = 18;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(824, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(64, 43);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar\r\nTodo\r\n";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(530, 14);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(159, 20);
            this.txtFiltro.TabIndex = 7;
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(713, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 32);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Location = new System.Drawing.Point(318, 15);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(121, 21);
            this.cbxCriterio.TabIndex = 4;
            // 
            // cbxCampo
            // 
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.Location = new System.Drawing.Point(92, 15);
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(121, 21);
            this.cbxCampo.TabIndex = 3;
            this.cbxCampo.SelectedIndexChanged += new System.EventHandler(this.cbxCampo_SelectedIndexChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(484, 18);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(29, 13);
            this.lblFiltro.TabIndex = 2;
            this.lblFiltro.Text = "Filtro";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(264, 18);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(39, 13);
            this.lblCriterio.TabIndex = 1;
            this.lblCriterio.Text = "Criterio";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(32, 18);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(40, 13);
            this.lblCampo.TabIndex = 0;
            this.lblCampo.Text = "Campo";
            // 
            // lblTituloAgregar
            // 
            this.lblTituloAgregar.AutoSize = true;
            this.lblTituloAgregar.Location = new System.Drawing.Point(87, 272);
            this.lblTituloAgregar.Name = "lblTituloAgregar";
            this.lblTituloAgregar.Size = new System.Drawing.Size(44, 13);
            this.lblTituloAgregar.TabIndex = 19;
            this.lblTituloAgregar.Text = "Agregar";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 407);
            this.Controls.Add(this.lblTituloAgregar);
            this.Controls.Add(this.pnlEdicion);
            this.Controls.Add(this.lblDescCateg);
            this.Controls.Add(this.lblDescDescripcion);
            this.Controls.Add(this.lblDescCodigo);
            this.Controls.Add(this.lblDescPrecio);
            this.Controls.Add(this.lblDescMarca);
            this.Controls.Add(this.lblDescNombre);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxArticuloImagen);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticuloImagen)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlEdicion.ResumeLayout(false);
            this.pnlEdicion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxArticuloImagen;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionSalidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrarPestañaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreLaAppToolStripMenuItem;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblDescNombre;
        private System.Windows.Forms.Label lblDescMarca;
        private System.Windows.Forms.Label lblDescPrecio;
        private System.Windows.Forms.Label lblDescCodigo;
        private System.Windows.Forms.Label lblDescDescripcion;
        private System.Windows.Forms.Label lblDescCateg;
        private System.Windows.Forms.Panel pnlEdicion;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.ComboBox cbxCampo;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblTituloAgregar;
    }
}

