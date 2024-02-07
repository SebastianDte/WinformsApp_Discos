namespace Discos
{
    partial class FrmDisco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDisco));
            this.dgvDisco = new System.Windows.Forms.DataGridView();
            this.pxbDiscos = new System.Windows.Forms.PictureBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.btnRestaurar = new FontAwesome.Sharp.IconButton();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.menuLateral = new System.Windows.Forms.Panel();
            this.panelSubMenuBuscar = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscarMenu = new FontAwesome.Sharp.IconButton();
            this.panelSubMenuDiscos = new System.Windows.Forms.Panel();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnDiscosPanel = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pxbLogo = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbDiscos)).BeginInit();
            this.barraTitulo.SuspendLayout();
            this.menuLateral.SuspendLayout();
            this.panelSubMenuBuscar.SuspendLayout();
            this.panelSubMenuDiscos.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxbLogo)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDisco
            // 
            this.dgvDisco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvDisco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisco.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDisco.Location = new System.Drawing.Point(15, 288);
            this.dgvDisco.MultiSelect = false;
            this.dgvDisco.Name = "dgvDisco";
            this.dgvDisco.RowHeadersWidth = 45;
            this.dgvDisco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisco.Size = new System.Drawing.Size(680, 248);
            this.dgvDisco.TabIndex = 7;
            this.dgvDisco.SelectionChanged += new System.EventHandler(this.dgvDisco_SelectionChanged);
            // 
            // pxbDiscos
            // 
            this.pxbDiscos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pxbDiscos.Location = new System.Drawing.Point(200, 66);
            this.pxbDiscos.Margin = new System.Windows.Forms.Padding(2);
            this.pxbDiscos.Name = "pxbDiscos";
            this.pxbDiscos.Size = new System.Drawing.Size(326, 217);
            this.pxbDiscos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxbDiscos.TabIndex = 1;
            this.pxbDiscos.TabStop = false;
            // 
            // lblFiltro
            // 
            this.lblFiltro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFiltro.Location = new System.Drawing.Point(12, 243);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(55, 18);
            this.lblFiltro.TabIndex = 5;
            this.lblFiltro.Text = "Buscar";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFiltro.Location = new System.Drawing.Point(15, 263);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(117, 20);
            this.txtFiltro.TabIndex = 6;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(101, 114);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 34);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Aplicar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCampo.Location = new System.Drawing.Point(6, 25);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(52, 17);
            this.lblCampo.TabIndex = 0;
            this.lblCampo.Text = "Campo";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCriterio.Location = new System.Drawing.Point(6, 52);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(53, 17);
            this.lblCriterio.TabIndex = 2;
            this.lblCriterio.Text = "Criterio";
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroAvanzado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(16, 79);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(39, 17);
            this.lblFiltroAvanzado.TabIndex = 10;
            this.lblFiltroAvanzado.Text = "Filtro";
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(64, 22);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(121, 21);
            this.cboCampo.TabIndex = 1;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(64, 49);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboCriterio.TabIndex = 3;
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(64, 76);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(121, 20);
            this.txtFiltroAvanzado.TabIndex = 4;
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.barraTitulo.Controls.Add(this.btnRestaurar);
            this.barraTitulo.Controls.Add(this.btnMinimizar);
            this.barraTitulo.Controls.Add(this.btnMaximizar);
            this.barraTitulo.Controls.Add(this.btnCerrar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(907, 35);
            this.barraTitulo.TabIndex = 11;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnRestaurar.IconColor = System.Drawing.Color.White;
            this.btnRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestaurar.IconSize = 20;
            this.btnRestaurar.Location = new System.Drawing.Point(839, 7);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.White;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 20;
            this.btnMinimizar.Location = new System.Drawing.Point(808, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximizar.IconColor = System.Drawing.Color.White;
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizar.IconSize = 20;
            this.btnMaximizar.Location = new System.Drawing.Point(839, 7);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 20;
            this.btnCerrar.Location = new System.Drawing.Point(870, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // menuLateral
            // 
            this.menuLateral.AutoScroll = true;
            this.menuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuLateral.Controls.Add(this.panelSubMenuBuscar);
            this.menuLateral.Controls.Add(this.btnBuscarMenu);
            this.menuLateral.Controls.Add(this.panelSubMenuDiscos);
            this.menuLateral.Controls.Add(this.btnDiscosPanel);
            this.menuLateral.Controls.Add(this.panelLogo);
            this.menuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuLateral.Location = new System.Drawing.Point(0, 35);
            this.menuLateral.Name = "menuLateral";
            this.menuLateral.Size = new System.Drawing.Size(200, 548);
            this.menuLateral.TabIndex = 12;
            // 
            // panelSubMenuBuscar
            // 
            this.panelSubMenuBuscar.Controls.Add(this.btnLimpiar);
            this.panelSubMenuBuscar.Controls.Add(this.cboCampo);
            this.panelSubMenuBuscar.Controls.Add(this.lblCampo);
            this.panelSubMenuBuscar.Controls.Add(this.txtFiltroAvanzado);
            this.panelSubMenuBuscar.Controls.Add(this.btnBuscar);
            this.panelSubMenuBuscar.Controls.Add(this.lblCriterio);
            this.panelSubMenuBuscar.Controls.Add(this.cboCriterio);
            this.panelSubMenuBuscar.Controls.Add(this.lblFiltroAvanzado);
            this.panelSubMenuBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuBuscar.Location = new System.Drawing.Point(0, 283);
            this.panelSubMenuBuscar.Name = "panelSubMenuBuscar";
            this.panelSubMenuBuscar.Size = new System.Drawing.Size(200, 150);
            this.panelSubMenuBuscar.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(2, 114);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(97, 34);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscarMenu
            // 
            this.btnBuscarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnBuscarMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarMenu.FlatAppearance.BorderSize = 0;
            this.btnBuscarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarMenu.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarMenu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBuscarMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarMenu.IconSize = 40;
            this.btnBuscarMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarMenu.Location = new System.Drawing.Point(0, 238);
            this.btnBuscarMenu.Name = "btnBuscarMenu";
            this.btnBuscarMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBuscarMenu.Size = new System.Drawing.Size(200, 45);
            this.btnBuscarMenu.TabIndex = 11;
            this.btnBuscarMenu.Text = "Buscar";
            this.btnBuscarMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarMenu.UseVisualStyleBackColor = false;
            this.btnBuscarMenu.Click += new System.EventHandler(this.btnBuscarMenu_Click_1);
            // 
            // panelSubMenuDiscos
            // 
            this.panelSubMenuDiscos.Controls.Add(this.btnEliminar);
            this.panelSubMenuDiscos.Controls.Add(this.btnModificar);
            this.panelSubMenuDiscos.Controls.Add(this.btnAgregar);
            this.panelSubMenuDiscos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuDiscos.Location = new System.Drawing.Point(0, 121);
            this.panelSubMenuDiscos.Name = "panelSubMenuDiscos";
            this.panelSubMenuDiscos.Size = new System.Drawing.Size(200, 117);
            this.panelSubMenuDiscos.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.Location = new System.Drawing.Point(0, 80);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEliminar.Size = new System.Drawing.Size(200, 40);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnModificar.IconColor = System.Drawing.Color.Black;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.Location = new System.Drawing.Point(0, 40);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnModificar.Size = new System.Drawing.Size(200, 40);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.Location = new System.Drawing.Point(0, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAgregar.Size = new System.Drawing.Size(200, 40);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnDiscosPanel
            // 
            this.btnDiscosPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnDiscosPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiscosPanel.FlatAppearance.BorderSize = 0;
            this.btnDiscosPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscosPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscosPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDiscosPanel.IconChar = FontAwesome.Sharp.IconChar.CompactDisc;
            this.btnDiscosPanel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDiscosPanel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDiscosPanel.IconSize = 40;
            this.btnDiscosPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscosPanel.Location = new System.Drawing.Point(0, 76);
            this.btnDiscosPanel.Name = "btnDiscosPanel";
            this.btnDiscosPanel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDiscosPanel.Size = new System.Drawing.Size(200, 45);
            this.btnDiscosPanel.TabIndex = 1;
            this.btnDiscosPanel.Text = "Discos";
            this.btnDiscosPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscosPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDiscosPanel.UseVisualStyleBackColor = false;
            this.btnDiscosPanel.Click += new System.EventHandler(this.btnDiscosPanel_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pxbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 76);
            this.panelLogo.TabIndex = 0;
            // 
            // pxbLogo
            // 
            this.pxbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pxbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pxbLogo.Image")));
            this.pxbLogo.Location = new System.Drawing.Point(0, 0);
            this.pxbLogo.Name = "pxbLogo";
            this.pxbLogo.Size = new System.Drawing.Size(200, 76);
            this.pxbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxbLogo.TabIndex = 0;
            this.pxbLogo.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelContenedor.Controls.Add(this.panel1);
            this.panelContenedor.Controls.Add(this.lblFiltro);
            this.panelContenedor.Controls.Add(this.txtFiltro);
            this.panelContenedor.Controls.Add(this.pxbDiscos);
            this.panelContenedor.Controls.Add(this.dgvDisco);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(200, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(707, 548);
            this.panelContenedor.TabIndex = 13;
            this.panelContenedor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelContenedor_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 61);
            this.panel1.TabIndex = 8;
            // 
            // FrmDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 583);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.menuLateral);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.MinimumSize = new System.Drawing.Size(707, 473);
            this.Name = "FrmDisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discos";
            this.Load += new System.EventHandler(this.FrmDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbDiscos)).EndInit();
            this.barraTitulo.ResumeLayout(false);
            this.menuLateral.ResumeLayout(false);
            this.panelSubMenuBuscar.ResumeLayout(false);
            this.panelSubMenuBuscar.PerformLayout();
            this.panelSubMenuDiscos.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pxbLogo)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisco;
        private System.Windows.Forms.PictureBox pxbDiscos;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Panel menuLateral;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Panel panelContenedor;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnRestaurar;
        private FontAwesome.Sharp.IconButton btnDiscosPanel;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelSubMenuDiscos;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.Panel panelSubMenuBuscar;
        private FontAwesome.Sharp.IconButton btnBuscarMenu;
        private System.Windows.Forms.PictureBox pxbLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

