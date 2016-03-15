namespace ServiciosRegistrales
{
    partial class FormStock
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
            this.gpStockArticulos = new System.Windows.Forms.GroupBox();
            this.numericArticulos = new System.Windows.Forms.NumericUpDown();
            this.cmbDepositosArticulos = new System.Windows.Forms.ComboBox();
            this.cmbCodigoArticulos = new System.Windows.Forms.ComboBox();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.lblCantidadMoverArticulos = new System.Windows.Forms.Label();
            this.btnQuitarArticulos = new System.Windows.Forms.Button();
            this.btnConfirmarMovArticulos = new System.Windows.Forms.Button();
            this.numericMoverArticulos = new System.Windows.Forms.NumericUpDown();
            this.cmbMoverDepositosArticulos = new System.Windows.Forms.ComboBox();
            this.lblMoverArticulo = new System.Windows.Forms.Label();
            this.lblDepositoArticulo = new System.Windows.Forms.Label();
            this.lblCantidadArticulo = new System.Windows.Forms.Label();
            this.lblCodArticulo = new System.Windows.Forms.Label();
            this.grdArticulos = new System.Windows.Forms.DataGridView();
            this.gpStockFormularios = new System.Windows.Forms.GroupBox();
            this.numericFormularios = new System.Windows.Forms.NumericUpDown();
            this.cmbDepositosFormularios = new System.Windows.Forms.ComboBox();
            this.cmbCodigoFormularios = new System.Windows.Forms.ComboBox();
            this.btnAgregarFormulario = new System.Windows.Forms.Button();
            this.txtHastaMover = new System.Windows.Forms.TextBox();
            this.lblHastaMover = new System.Windows.Forms.Label();
            this.txtDesdeMover = new System.Windows.Forms.TextBox();
            this.lblDesdeMover = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblCantidadMoverFormulario = new System.Windows.Forms.Label();
            this.grdFormularios = new System.Windows.Forms.DataGridView();
            this.btnQuitarFormulario = new System.Windows.Forms.Button();
            this.lblCodigoFormulario = new System.Windows.Forms.Label();
            this.btnConfirmarFormulario = new System.Windows.Forms.Button();
            this.numericMoverFormulario = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadFormulario = new System.Windows.Forms.Label();
            this.cmbMoverDepositosFormularios = new System.Windows.Forms.ComboBox();
            this.lblMoverFormulario = new System.Windows.Forms.Label();
            this.lblEnFormulario = new System.Windows.Forms.Label();
            this.laoyout = new System.Windows.Forms.TableLayoutPanel();
            this.gpStockArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMoverArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulos)).BeginInit();
            this.gpStockFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFormularios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFormularios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMoverFormulario)).BeginInit();
            this.laoyout.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpStockArticulos
            // 
            this.gpStockArticulos.Controls.Add(this.numericArticulos);
            this.gpStockArticulos.Controls.Add(this.cmbDepositosArticulos);
            this.gpStockArticulos.Controls.Add(this.cmbCodigoArticulos);
            this.gpStockArticulos.Controls.Add(this.btnAgregarArticulo);
            this.gpStockArticulos.Controls.Add(this.lblCantidadMoverArticulos);
            this.gpStockArticulos.Controls.Add(this.btnQuitarArticulos);
            this.gpStockArticulos.Controls.Add(this.btnConfirmarMovArticulos);
            this.gpStockArticulos.Controls.Add(this.numericMoverArticulos);
            this.gpStockArticulos.Controls.Add(this.cmbMoverDepositosArticulos);
            this.gpStockArticulos.Controls.Add(this.lblMoverArticulo);
            this.gpStockArticulos.Controls.Add(this.lblDepositoArticulo);
            this.gpStockArticulos.Controls.Add(this.lblCantidadArticulo);
            this.gpStockArticulos.Controls.Add(this.lblCodArticulo);
            this.gpStockArticulos.Controls.Add(this.grdArticulos);
            this.gpStockArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpStockArticulos.Location = new System.Drawing.Point(3, 3);
            this.gpStockArticulos.Name = "gpStockArticulos";
            this.gpStockArticulos.Size = new System.Drawing.Size(978, 213);
            this.gpStockArticulos.TabIndex = 1;
            this.gpStockArticulos.TabStop = false;
            this.gpStockArticulos.Text = "Stock de artículos en general";
            // 
            // numericArticulos
            // 
            this.numericArticulos.Location = new System.Drawing.Point(251, 35);
            this.numericArticulos.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericArticulos.Name = "numericArticulos";
            this.numericArticulos.Size = new System.Drawing.Size(73, 22);
            this.numericArticulos.TabIndex = 16;
            // 
            // cmbDepositosArticulos
            // 
            this.cmbDepositosArticulos.DisplayMember = "descripcion";
            this.cmbDepositosArticulos.FormattingEnabled = true;
            this.cmbDepositosArticulos.Location = new System.Drawing.Point(396, 34);
            this.cmbDepositosArticulos.Name = "cmbDepositosArticulos";
            this.cmbDepositosArticulos.Size = new System.Drawing.Size(196, 24);
            this.cmbDepositosArticulos.TabIndex = 15;
            this.cmbDepositosArticulos.ValueMember = "id";
            // 
            // cmbCodigoArticulos
            // 
            this.cmbCodigoArticulos.DisplayMember = "codigo";
            this.cmbCodigoArticulos.FormattingEnabled = true;
            this.cmbCodigoArticulos.Location = new System.Drawing.Point(71, 34);
            this.cmbCodigoArticulos.Name = "cmbCodigoArticulos";
            this.cmbCodigoArticulos.Size = new System.Drawing.Size(89, 24);
            this.cmbCodigoArticulos.TabIndex = 14;
            this.cmbCodigoArticulos.ValueMember = "id";
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarArticulo.Enabled = false;
            this.btnAgregarArticulo.Location = new System.Drawing.Point(264, 160);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(180, 26);
            this.btnAgregarArticulo.TabIndex = 13;
            this.btnAgregarArticulo.Text = "Agregar manualmente";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // lblCantidadMoverArticulos
            // 
            this.lblCantidadMoverArticulos.AutoSize = true;
            this.lblCantidadMoverArticulos.Location = new System.Drawing.Point(315, 99);
            this.lblCantidadMoverArticulos.Name = "lblCantidadMoverArticulos";
            this.lblCantidadMoverArticulos.Size = new System.Drawing.Size(65, 16);
            this.lblCantidadMoverArticulos.TabIndex = 12;
            this.lblCantidadMoverArticulos.Text = "Cantidad:";
            // 
            // btnQuitarArticulos
            // 
            this.btnQuitarArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQuitarArticulos.Enabled = false;
            this.btnQuitarArticulos.Location = new System.Drawing.Point(134, 159);
            this.btnQuitarArticulos.Name = "btnQuitarArticulos";
            this.btnQuitarArticulos.Size = new System.Drawing.Size(113, 27);
            this.btnQuitarArticulos.TabIndex = 11;
            this.btnQuitarArticulos.Text = "Quitar todos";
            this.btnQuitarArticulos.UseVisualStyleBackColor = true;
            this.btnQuitarArticulos.Click += new System.EventHandler(this.btnQuitarArticulos_Click);
            // 
            // btnConfirmarMovArticulos
            // 
            this.btnConfirmarMovArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirmarMovArticulos.Location = new System.Drawing.Point(15, 160);
            this.btnConfirmarMovArticulos.Name = "btnConfirmarMovArticulos";
            this.btnConfirmarMovArticulos.Size = new System.Drawing.Size(103, 26);
            this.btnConfirmarMovArticulos.TabIndex = 10;
            this.btnConfirmarMovArticulos.Text = "Confirmar";
            this.btnConfirmarMovArticulos.UseVisualStyleBackColor = true;
            this.btnConfirmarMovArticulos.Click += new System.EventHandler(this.btnConfirmarMovArticulos_Click);
            // 
            // numericMoverArticulos
            // 
            this.numericMoverArticulos.Enabled = false;
            this.numericMoverArticulos.Location = new System.Drawing.Point(396, 97);
            this.numericMoverArticulos.Name = "numericMoverArticulos";
            this.numericMoverArticulos.Size = new System.Drawing.Size(73, 22);
            this.numericMoverArticulos.TabIndex = 9;
            this.numericMoverArticulos.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // cmbMoverDepositosArticulos
            // 
            this.cmbMoverDepositosArticulos.DisplayMember = "descripcion";
            this.cmbMoverDepositosArticulos.Enabled = false;
            this.cmbMoverDepositosArticulos.FormattingEnabled = true;
            this.cmbMoverDepositosArticulos.Location = new System.Drawing.Point(132, 96);
            this.cmbMoverDepositosArticulos.Name = "cmbMoverDepositosArticulos";
            this.cmbMoverDepositosArticulos.Size = new System.Drawing.Size(160, 24);
            this.cmbMoverDepositosArticulos.TabIndex = 8;
            this.cmbMoverDepositosArticulos.ValueMember = "id";
            // 
            // lblMoverArticulo
            // 
            this.lblMoverArticulo.AutoSize = true;
            this.lblMoverArticulo.Location = new System.Drawing.Point(10, 99);
            this.lblMoverArticulo.Name = "lblMoverArticulo";
            this.lblMoverArticulo.Size = new System.Drawing.Size(116, 16);
            this.lblMoverArticulo.TabIndex = 7;
            this.lblMoverArticulo.Text = "Mover a depósito:";
            // 
            // lblDepositoArticulo
            // 
            this.lblDepositoArticulo.AutoSize = true;
            this.lblDepositoArticulo.Location = new System.Drawing.Point(350, 37);
            this.lblDepositoArticulo.Name = "lblDepositoArticulo";
            this.lblDepositoArticulo.Size = new System.Drawing.Size(27, 16);
            this.lblDepositoArticulo.TabIndex = 5;
            this.lblDepositoArticulo.Text = "En:";
            // 
            // lblCantidadArticulo
            // 
            this.lblCantidadArticulo.AutoSize = true;
            this.lblCantidadArticulo.Location = new System.Drawing.Point(177, 37);
            this.lblCantidadArticulo.Name = "lblCantidadArticulo";
            this.lblCantidadArticulo.Size = new System.Drawing.Size(65, 16);
            this.lblCantidadArticulo.TabIndex = 3;
            this.lblCantidadArticulo.Text = "Cantidad:";
            // 
            // lblCodArticulo
            // 
            this.lblCodArticulo.AutoSize = true;
            this.lblCodArticulo.Location = new System.Drawing.Point(10, 37);
            this.lblCodArticulo.Name = "lblCodArticulo";
            this.lblCodArticulo.Size = new System.Drawing.Size(55, 16);
            this.lblCodArticulo.TabIndex = 1;
            this.lblCodArticulo.Text = "Artículo:";
            // 
            // grdArticulos
            // 
            this.grdArticulos.AllowUserToAddRows = false;
            this.grdArticulos.AllowUserToDeleteRows = false;
            this.grdArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdArticulos.Location = new System.Drawing.Point(595, 19);
            this.grdArticulos.Name = "grdArticulos";
            this.grdArticulos.ReadOnly = true;
            this.grdArticulos.RowHeadersVisible = false;
            this.grdArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdArticulos.Size = new System.Drawing.Size(377, 188);
            this.grdArticulos.TabIndex = 0;
            this.grdArticulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdArticulos_CellClick);
            // 
            // gpStockFormularios
            // 
            this.gpStockFormularios.Controls.Add(this.numericFormularios);
            this.gpStockFormularios.Controls.Add(this.cmbDepositosFormularios);
            this.gpStockFormularios.Controls.Add(this.cmbCodigoFormularios);
            this.gpStockFormularios.Controls.Add(this.btnAgregarFormulario);
            this.gpStockFormularios.Controls.Add(this.txtHastaMover);
            this.gpStockFormularios.Controls.Add(this.lblHastaMover);
            this.gpStockFormularios.Controls.Add(this.txtDesdeMover);
            this.gpStockFormularios.Controls.Add(this.lblDesdeMover);
            this.gpStockFormularios.Controls.Add(this.txtHasta);
            this.gpStockFormularios.Controls.Add(this.lblHasta);
            this.gpStockFormularios.Controls.Add(this.txtDesde);
            this.gpStockFormularios.Controls.Add(this.lblDesde);
            this.gpStockFormularios.Controls.Add(this.lblCantidadMoverFormulario);
            this.gpStockFormularios.Controls.Add(this.grdFormularios);
            this.gpStockFormularios.Controls.Add(this.btnQuitarFormulario);
            this.gpStockFormularios.Controls.Add(this.lblCodigoFormulario);
            this.gpStockFormularios.Controls.Add(this.btnConfirmarFormulario);
            this.gpStockFormularios.Controls.Add(this.numericMoverFormulario);
            this.gpStockFormularios.Controls.Add(this.lblCantidadFormulario);
            this.gpStockFormularios.Controls.Add(this.cmbMoverDepositosFormularios);
            this.gpStockFormularios.Controls.Add(this.lblMoverFormulario);
            this.gpStockFormularios.Controls.Add(this.lblEnFormulario);
            this.gpStockFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpStockFormularios.Location = new System.Drawing.Point(3, 222);
            this.gpStockFormularios.Name = "gpStockFormularios";
            this.gpStockFormularios.Size = new System.Drawing.Size(978, 213);
            this.gpStockFormularios.TabIndex = 2;
            this.gpStockFormularios.TabStop = false;
            this.gpStockFormularios.Text = "Stock de formularios";
            this.gpStockFormularios.Enter += new System.EventHandler(this.gpStockFormularios_Enter);
            // 
            // numericFormularios
            // 
            this.numericFormularios.Location = new System.Drawing.Point(251, 37);
            this.numericFormularios.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericFormularios.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.numericFormularios.Name = "numericFormularios";
            this.numericFormularios.Size = new System.Drawing.Size(73, 22);
            this.numericFormularios.TabIndex = 33;
            this.numericFormularios.ValueChanged += new System.EventHandler(this.numericFormularios_ValueChanged);
            // 
            // cmbDepositosFormularios
            // 
            this.cmbDepositosFormularios.DisplayMember = "descripcion";
            this.cmbDepositosFormularios.FormattingEnabled = true;
            this.cmbDepositosFormularios.Location = new System.Drawing.Point(396, 36);
            this.cmbDepositosFormularios.Name = "cmbDepositosFormularios";
            this.cmbDepositosFormularios.Size = new System.Drawing.Size(196, 24);
            this.cmbDepositosFormularios.TabIndex = 16;
            this.cmbDepositosFormularios.ValueMember = "id";
            // 
            // cmbCodigoFormularios
            // 
            this.cmbCodigoFormularios.DisplayMember = "codigo";
            this.cmbCodigoFormularios.FormattingEnabled = true;
            this.cmbCodigoFormularios.Location = new System.Drawing.Point(91, 36);
            this.cmbCodigoFormularios.Name = "cmbCodigoFormularios";
            this.cmbCodigoFormularios.Size = new System.Drawing.Size(80, 24);
            this.cmbCodigoFormularios.TabIndex = 15;
            this.cmbCodigoFormularios.ValueMember = "id";
            // 
            // btnAgregarFormulario
            // 
            this.btnAgregarFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarFormulario.Enabled = false;
            this.btnAgregarFormulario.Location = new System.Drawing.Point(264, 179);
            this.btnAgregarFormulario.Name = "btnAgregarFormulario";
            this.btnAgregarFormulario.Size = new System.Drawing.Size(180, 26);
            this.btnAgregarFormulario.TabIndex = 14;
            this.btnAgregarFormulario.Text = "Agregar manualmente";
            this.btnAgregarFormulario.UseVisualStyleBackColor = true;
            this.btnAgregarFormulario.Click += new System.EventHandler(this.btnAgregarFormulario_Click);
            // 
            // txtHastaMover
            // 
            this.txtHastaMover.Location = new System.Drawing.Point(383, 152);
            this.txtHastaMover.Name = "txtHastaMover";
            this.txtHastaMover.ReadOnly = true;
            this.txtHastaMover.Size = new System.Drawing.Size(209, 22);
            this.txtHastaMover.TabIndex = 32;
            // 
            // lblHastaMover
            // 
            this.lblHastaMover.AutoSize = true;
            this.lblHastaMover.Location = new System.Drawing.Point(330, 155);
            this.lblHastaMover.Name = "lblHastaMover";
            this.lblHastaMover.Size = new System.Drawing.Size(47, 16);
            this.lblHastaMover.TabIndex = 31;
            this.lblHastaMover.Text = "Hasta:";
            // 
            // txtDesdeMover
            // 
            this.txtDesdeMover.Location = new System.Drawing.Point(91, 152);
            this.txtDesdeMover.Name = "txtDesdeMover";
            this.txtDesdeMover.ReadOnly = true;
            this.txtDesdeMover.Size = new System.Drawing.Size(185, 22);
            this.txtDesdeMover.TabIndex = 30;
            this.txtDesdeMover.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesdeMover_KeyPress);
            this.txtDesdeMover.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDesdeMover_KeyUp);
            this.txtDesdeMover.Leave += new System.EventHandler(this.txtDesdeMover_Leave);
            // 
            // lblDesdeMover
            // 
            this.lblDesdeMover.AutoSize = true;
            this.lblDesdeMover.Location = new System.Drawing.Point(10, 155);
            this.lblDesdeMover.Name = "lblDesdeMover";
            this.lblDesdeMover.Size = new System.Drawing.Size(52, 16);
            this.lblDesdeMover.TabIndex = 29;
            this.lblDesdeMover.Text = "Desde:";
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(383, 73);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.ReadOnly = true;
            this.txtHasta.Size = new System.Drawing.Size(209, 22);
            this.txtHasta.TabIndex = 28;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(330, 76);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(47, 16);
            this.lblHasta.TabIndex = 27;
            this.lblHasta.Text = "Hasta:";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(91, 73);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(185, 22);
            this.txtDesde.TabIndex = 26;
            this.txtDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesde_KeyPress);
            this.txtDesde.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDesde_KeyUp);
            this.txtDesde.Leave += new System.EventHandler(this.txtDesde_Leave);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(10, 76);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(52, 16);
            this.lblDesde.TabIndex = 25;
            this.lblDesde.Text = "Desde:";
            // 
            // lblCantidadMoverFormulario
            // 
            this.lblCantidadMoverFormulario.AutoSize = true;
            this.lblCantidadMoverFormulario.Location = new System.Drawing.Point(315, 115);
            this.lblCantidadMoverFormulario.Name = "lblCantidadMoverFormulario";
            this.lblCantidadMoverFormulario.Size = new System.Drawing.Size(65, 16);
            this.lblCantidadMoverFormulario.TabIndex = 24;
            this.lblCantidadMoverFormulario.Text = "Cantidad:";
            // 
            // grdFormularios
            // 
            this.grdFormularios.AllowUserToAddRows = false;
            this.grdFormularios.AllowUserToDeleteRows = false;
            this.grdFormularios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdFormularios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdFormularios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFormularios.Location = new System.Drawing.Point(595, 19);
            this.grdFormularios.Name = "grdFormularios";
            this.grdFormularios.ReadOnly = true;
            this.grdFormularios.RowHeadersVisible = false;
            this.grdFormularios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFormularios.Size = new System.Drawing.Size(377, 188);
            this.grdFormularios.TabIndex = 1;
            this.grdFormularios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFormularios_CellClick);
            // 
            // btnQuitarFormulario
            // 
            this.btnQuitarFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQuitarFormulario.Enabled = false;
            this.btnQuitarFormulario.Location = new System.Drawing.Point(132, 179);
            this.btnQuitarFormulario.Name = "btnQuitarFormulario";
            this.btnQuitarFormulario.Size = new System.Drawing.Size(113, 27);
            this.btnQuitarFormulario.TabIndex = 23;
            this.btnQuitarFormulario.Text = "Quitar todos";
            this.btnQuitarFormulario.UseVisualStyleBackColor = true;
            this.btnQuitarFormulario.Click += new System.EventHandler(this.btnQuitarFormulario_Click);
            // 
            // lblCodigoFormulario
            // 
            this.lblCodigoFormulario.AutoSize = true;
            this.lblCodigoFormulario.Location = new System.Drawing.Point(10, 39);
            this.lblCodigoFormulario.Name = "lblCodigoFormulario";
            this.lblCodigoFormulario.Size = new System.Drawing.Size(75, 16);
            this.lblCodigoFormulario.TabIndex = 13;
            this.lblCodigoFormulario.Text = "Formulario:";
            // 
            // btnConfirmarFormulario
            // 
            this.btnConfirmarFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirmarFormulario.Location = new System.Drawing.Point(15, 179);
            this.btnConfirmarFormulario.Name = "btnConfirmarFormulario";
            this.btnConfirmarFormulario.Size = new System.Drawing.Size(103, 26);
            this.btnConfirmarFormulario.TabIndex = 22;
            this.btnConfirmarFormulario.Text = "Confirmar";
            this.btnConfirmarFormulario.UseVisualStyleBackColor = true;
            this.btnConfirmarFormulario.Click += new System.EventHandler(this.btnConfirmarFormulario_Click);
            // 
            // numericMoverFormulario
            // 
            this.numericMoverFormulario.Enabled = false;
            this.numericMoverFormulario.Location = new System.Drawing.Point(396, 113);
            this.numericMoverFormulario.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericMoverFormulario.Name = "numericMoverFormulario";
            this.numericMoverFormulario.Size = new System.Drawing.Size(73, 22);
            this.numericMoverFormulario.TabIndex = 21;
            this.numericMoverFormulario.ValueChanged += new System.EventHandler(this.numericMoverFormulario_ValueChanged);
            // 
            // lblCantidadFormulario
            // 
            this.lblCantidadFormulario.AutoSize = true;
            this.lblCantidadFormulario.Location = new System.Drawing.Point(180, 39);
            this.lblCantidadFormulario.Name = "lblCantidadFormulario";
            this.lblCantidadFormulario.Size = new System.Drawing.Size(65, 16);
            this.lblCantidadFormulario.TabIndex = 15;
            this.lblCantidadFormulario.Text = "Cantidad:";
            // 
            // cmbMoverDepositosFormularios
            // 
            this.cmbMoverDepositosFormularios.DisplayMember = "descripcion";
            this.cmbMoverDepositosFormularios.Enabled = false;
            this.cmbMoverDepositosFormularios.FormattingEnabled = true;
            this.cmbMoverDepositosFormularios.Location = new System.Drawing.Point(132, 112);
            this.cmbMoverDepositosFormularios.Name = "cmbMoverDepositosFormularios";
            this.cmbMoverDepositosFormularios.Size = new System.Drawing.Size(160, 24);
            this.cmbMoverDepositosFormularios.TabIndex = 20;
            this.cmbMoverDepositosFormularios.ValueMember = "id";
            // 
            // lblMoverFormulario
            // 
            this.lblMoverFormulario.AutoSize = true;
            this.lblMoverFormulario.Location = new System.Drawing.Point(10, 115);
            this.lblMoverFormulario.Name = "lblMoverFormulario";
            this.lblMoverFormulario.Size = new System.Drawing.Size(116, 16);
            this.lblMoverFormulario.TabIndex = 19;
            this.lblMoverFormulario.Text = "Mover a depósito:";
            // 
            // lblEnFormulario
            // 
            this.lblEnFormulario.AutoSize = true;
            this.lblEnFormulario.Location = new System.Drawing.Point(350, 39);
            this.lblEnFormulario.Name = "lblEnFormulario";
            this.lblEnFormulario.Size = new System.Drawing.Size(27, 16);
            this.lblEnFormulario.TabIndex = 17;
            this.lblEnFormulario.Text = "En:";
            // 
            // laoyout
            // 
            this.laoyout.ColumnCount = 1;
            this.laoyout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.laoyout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.laoyout.Controls.Add(this.gpStockArticulos, 0, 0);
            this.laoyout.Controls.Add(this.gpStockFormularios, 0, 1);
            this.laoyout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laoyout.Location = new System.Drawing.Point(0, 24);
            this.laoyout.Name = "laoyout";
            this.laoyout.RowCount = 2;
            this.laoyout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.laoyout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.laoyout.Size = new System.Drawing.Size(984, 438);
            this.laoyout.TabIndex = 3;
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.laoyout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(0, 0);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "FormStock";
            this.Text = "Administración de stock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStock_FormClosing);
            this.Controls.SetChildIndex(this.laoyout, 0);
            this.gpStockArticulos.ResumeLayout(false);
            this.gpStockArticulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMoverArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulos)).EndInit();
            this.gpStockFormularios.ResumeLayout(false);
            this.gpStockFormularios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFormularios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFormularios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMoverFormulario)).EndInit();
            this.laoyout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpStockArticulos;
        private System.Windows.Forms.DataGridView grdArticulos;
        private System.Windows.Forms.GroupBox gpStockFormularios;
        private System.Windows.Forms.DataGridView grdFormularios;
        private System.Windows.Forms.Label lblDepositoArticulo;
        private System.Windows.Forms.Label lblCantidadArticulo;
        private System.Windows.Forms.Label lblCodArticulo;
        private System.Windows.Forms.NumericUpDown numericMoverArticulos;
        private System.Windows.Forms.ComboBox cmbMoverDepositosArticulos;
        private System.Windows.Forms.Label lblMoverArticulo;
        private System.Windows.Forms.Button btnConfirmarMovArticulos;
        private System.Windows.Forms.Label lblCantidadMoverArticulos;
        private System.Windows.Forms.Button btnQuitarArticulos;
        private System.Windows.Forms.Label lblCantidadMoverFormulario;
        private System.Windows.Forms.Button btnQuitarFormulario;
        private System.Windows.Forms.Label lblCodigoFormulario;
        private System.Windows.Forms.Button btnConfirmarFormulario;
        private System.Windows.Forms.NumericUpDown numericMoverFormulario;
        private System.Windows.Forms.Label lblCantidadFormulario;
        private System.Windows.Forms.ComboBox cmbMoverDepositosFormularios;
        private System.Windows.Forms.Label lblMoverFormulario;
        private System.Windows.Forms.Label lblEnFormulario;
        private System.Windows.Forms.TextBox txtHastaMover;
        private System.Windows.Forms.Label lblHastaMover;
        private System.Windows.Forms.TextBox txtDesdeMover;
        private System.Windows.Forms.Label lblDesdeMover;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button btnAgregarFormulario;
        private System.Windows.Forms.ComboBox cmbDepositosArticulos;
        private System.Windows.Forms.ComboBox cmbCodigoArticulos;
        private System.Windows.Forms.ComboBox cmbCodigoFormularios;
        private System.Windows.Forms.ComboBox cmbDepositosFormularios;
        private System.Windows.Forms.NumericUpDown numericArticulos;
        private System.Windows.Forms.NumericUpDown numericFormularios;
        private System.Windows.Forms.TableLayoutPanel laoyout;
    }
}