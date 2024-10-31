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
            this.lblTituloActualizar = new System.Windows.Forms.Label();
            this.lblTituloEliminar = new System.Windows.Forms.Label();
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
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(55, 147);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(555, 127);
            this.dgvArticulos.TabIndex = 17;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbxArticuloImagen
            // 
            this.pbxArticuloImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxArticuloImagen.Location = new System.Drawing.Point(660, 116);
            this.pbxArticuloImagen.Name = "pbxArticuloImagen";
            this.pbxArticuloImagen.Size = new System.Drawing.Size(201, 172);
            this.pbxArticuloImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticuloImagen.TabIndex = 1;
            this.pbxArticuloImagen.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(63, 321);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(93, 88);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(225, 321);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(108, 88);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.sobreLaAppToolStripMenuItem,
            this.opcionSalidaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(941, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcaToolStripMenuItem,
            this.categoriaToolStripMenuItem});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // opcionSalidaToolStripMenuItem
            // 
            this.opcionSalidaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carrarPestañaToolStripMenuItem});
            this.opcionSalidaToolStripMenuItem.Name = "opcionSalidaToolStripMenuItem";
            this.opcionSalidaToolStripMenuItem.Size = new System.Drawing.Size(92, 19);
            this.opcionSalidaToolStripMenuItem.Text = "Opcion Salida";
            // 
            // carrarPestañaToolStripMenuItem
            // 
            this.carrarPestañaToolStripMenuItem.Name = "carrarPestañaToolStripMenuItem";
            this.carrarPestañaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.carrarPestañaToolStripMenuItem.Text = "Carrar Pestaña";
            this.carrarPestañaToolStripMenuItem.Click += new System.EventHandler(this.carrarPestañaToolStripMenuItem_Click);
            // 
            // sobreLaAppToolStripMenuItem
            // 
            this.sobreLaAppToolStripMenuItem.Name = "sobreLaAppToolStripMenuItem";
            this.sobreLaAppToolStripMenuItem.Size = new System.Drawing.Size(86, 19);
            this.sobreLaAppToolStripMenuItem.Text = "Sobre la App";
            this.sobreLaAppToolStripMenuItem.Click += new System.EventHandler(this.sobreLaAppToolStripMenuItem_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(417, 321);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 88);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(41, 111);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(154, 26);
            this.lblBusqueda.TabIndex = 8;
            this.lblBusqueda.Text = "Buscar Rápido:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(201, 111);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(349, 24);
            this.txtBusqueda.TabIndex = 9;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // lblDescNombre
            // 
            this.lblDescNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescNombre.AutoSize = true;
            this.lblDescNombre.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescNombre.Location = new System.Drawing.Point(707, 291);
            this.lblDescNombre.Name = "lblDescNombre";
            this.lblDescNombre.Size = new System.Drawing.Size(54, 14);
            this.lblDescNombre.TabIndex = 10;
            this.lblDescNombre.Text = "nombre";
            // 
            // lblDescMarca
            // 
            this.lblDescMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescMarca.AutoSize = true;
            this.lblDescMarca.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescMarca.Location = new System.Drawing.Point(781, 392);
            this.lblDescMarca.Name = "lblDescMarca";
            this.lblDescMarca.Size = new System.Drawing.Size(44, 14);
            this.lblDescMarca.TabIndex = 11;
            this.lblDescMarca.Text = "marca";
            // 
            // lblDescPrecio
            // 
            this.lblDescPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescPrecio.AutoSize = true;
            this.lblDescPrecio.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescPrecio.Location = new System.Drawing.Point(777, 325);
            this.lblDescPrecio.Name = "lblDescPrecio";
            this.lblDescPrecio.Size = new System.Drawing.Size(47, 14);
            this.lblDescPrecio.TabIndex = 12;
            this.lblDescPrecio.Text = "precio";
            // 
            // lblDescCodigo
            // 
            this.lblDescCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescCodigo.AutoSize = true;
            this.lblDescCodigo.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescCodigo.Location = new System.Drawing.Point(591, 325);
            this.lblDescCodigo.Name = "lblDescCodigo";
            this.lblDescCodigo.Size = new System.Drawing.Size(51, 14);
            this.lblDescCodigo.TabIndex = 13;
            this.lblDescCodigo.Text = "codigo";
            // 
            // lblDescDescripcion
            // 
            this.lblDescDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescDescripcion.AutoSize = true;
            this.lblDescDescripcion.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescDescripcion.Location = new System.Drawing.Point(591, 359);
            this.lblDescDescripcion.Name = "lblDescDescripcion";
            this.lblDescDescripcion.Size = new System.Drawing.Size(81, 14);
            this.lblDescDescripcion.TabIndex = 14;
            this.lblDescDescripcion.Text = "descripcion";
            // 
            // lblDescCateg
            // 
            this.lblDescCateg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescCateg.AutoSize = true;
            this.lblDescCateg.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescCateg.Location = new System.Drawing.Point(591, 392);
            this.lblDescCateg.Name = "lblDescCateg";
            this.lblDescCateg.Size = new System.Drawing.Size(66, 14);
            this.lblDescCateg.TabIndex = 15;
            this.lblDescCateg.Text = "categoria";
            // 
            // pnlEdicion
            // 
            this.pnlEdicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlEdicion.Controls.Add(this.btnLimpiar);
            this.pnlEdicion.Controls.Add(this.txtFiltro);
            this.pnlEdicion.Controls.Add(this.btnBuscar);
            this.pnlEdicion.Controls.Add(this.cbxCriterio);
            this.pnlEdicion.Controls.Add(this.cbxCampo);
            this.pnlEdicion.Controls.Add(this.lblFiltro);
            this.pnlEdicion.Controls.Add(this.lblCriterio);
            this.pnlEdicion.Controls.Add(this.lblCampo);
            this.pnlEdicion.Location = new System.Drawing.Point(29, 29);
            this.pnlEdicion.Name = "pnlEdicion";
            this.pnlEdicion.Size = new System.Drawing.Size(891, 63);
            this.pnlEdicion.TabIndex = 18;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(803, 9);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(63, 46);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar\r\nTodo\r\n";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(528, 17);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(159, 24);
            this.txtFiltro.TabIndex = 7;
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(715, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 56);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Location = new System.Drawing.Point(318, 17);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(121, 27);
            this.cbxCriterio.TabIndex = 4;
            // 
            // cbxCampo
            // 
            this.cbxCampo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.Location = new System.Drawing.Point(93, 17);
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(121, 27);
            this.cbxCampo.TabIndex = 3;
            this.cbxCampo.SelectedIndexChanged += new System.EventHandler(this.cbxCampo_SelectedIndexChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(459, 17);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(54, 22);
            this.lblFiltro.TabIndex = 2;
            this.lblFiltro.Text = "Filtro";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.Location = new System.Drawing.Point(231, 17);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(72, 22);
            this.lblCriterio.TabIndex = 1;
            this.lblCriterio.Text = "Criterio";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.Location = new System.Drawing.Point(12, 18);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(68, 22);
            this.lblCampo.TabIndex = 0;
            this.lblCampo.Text = "Campo";
            // 
            // lblTituloAgregar
            // 
            this.lblTituloAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTituloAgregar.AutoSize = true;
            this.lblTituloAgregar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAgregar.Location = new System.Drawing.Point(73, 291);
            this.lblTituloAgregar.Name = "lblTituloAgregar";
            this.lblTituloAgregar.Size = new System.Drawing.Size(76, 22);
            this.lblTituloAgregar.TabIndex = 19;
            this.lblTituloAgregar.Text = "Agregar";
            // 
            // lblTituloActualizar
            // 
            this.lblTituloActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTituloActualizar.AutoSize = true;
            this.lblTituloActualizar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloActualizar.Location = new System.Drawing.Point(231, 291);
            this.lblTituloActualizar.Name = "lblTituloActualizar";
            this.lblTituloActualizar.Size = new System.Drawing.Size(90, 22);
            this.lblTituloActualizar.TabIndex = 20;
            this.lblTituloActualizar.Text = "Actualizar";
            // 
            // lblTituloEliminar
            // 
            this.lblTituloEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTituloEliminar.AutoSize = true;
            this.lblTituloEliminar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEliminar.Location = new System.Drawing.Point(427, 291);
            this.lblTituloEliminar.Name = "lblTituloEliminar";
            this.lblTituloEliminar.Size = new System.Drawing.Size(76, 22);
            this.lblTituloEliminar.TabIndex = 21;
            this.lblTituloEliminar.Text = "Eliminar";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(941, 438);
            this.Controls.Add(this.lblTituloEliminar);
            this.Controls.Add(this.lblTituloActualizar);
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
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.Label lblTituloActualizar;
        private System.Windows.Forms.Label lblTituloEliminar;
    }
}

