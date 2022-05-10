
namespace KitchenKitten
{
    partial class MenuUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUsuario));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEliminarDeHabitual = new System.Windows.Forms.Button();
            this.btRealizarCompraHabitual = new System.Windows.Forms.Button();
            this.dgvCompraHabitual = new System.Windows.Forms.DataGridView();
            this.dgvMisIngredientes = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btConfReceta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbRecetas = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnEliminarCesta = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.dgvCestaDeCompras = new System.Windows.Forms.DataGridView();
            this.Id_Ingrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarHabitual = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txtbBuscarIngrediente = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvCompraIngredientes = new System.Windows.Forms.DataGridView();
            this.idingredienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new global::KitchenKitten.masterDataSet();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.btnCambiarCorreo = new System.Windows.Forms.Button();
            this.btnCambiarApellido = new System.Windows.Forms.Button();
            this.btCambiarNombre = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombreUsuario = new System.Windows.Forms.TextBox();
            this.tbAppellidosUsuario = new System.Windows.Forms.TextBox();
            this.tbContraUsuario = new System.Windows.Forms.TextBox();
            this.tbCorreoUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.recetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recetaTableAdapter = new global::KitchenKitten.masterDataSetTableAdapters.RecetaTableAdapter();
            this.ingredientetieneRecetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingrediente_tiene_RecetaTableAdapter = new global::KitchenKitten.masterDataSetTableAdapters.Ingrediente_tiene_RecetaTableAdapter();
            this.ingredienteTableAdapter = new global::KitchenKitten.masterDataSetTableAdapters.IngredienteTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompraHabitual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisIngredientes)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCestaDeCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompraIngredientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientetieneRecetaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(911, 618);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.btnEliminarDeHabitual);
            this.tabPage1.Controls.Add(this.btRealizarCompraHabitual);
            this.tabPage1.Controls.Add(this.dgvCompraHabitual);
            this.tabPage1.Controls.Add(this.dgvMisIngredientes);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(903, 592);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mi Frigorífico";
            // 
            // btnEliminarDeHabitual
            // 
            this.btnEliminarDeHabitual.BackColor = System.Drawing.Color.LightBlue;
            this.btnEliminarDeHabitual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDeHabitual.Location = new System.Drawing.Point(642, 422);
            this.btnEliminarDeHabitual.Name = "btnEliminarDeHabitual";
            this.btnEliminarDeHabitual.Size = new System.Drawing.Size(233, 62);
            this.btnEliminarDeHabitual.TabIndex = 5;
            this.btnEliminarDeHabitual.Text = "Eliminar de compra Habitual";
            this.btnEliminarDeHabitual.UseVisualStyleBackColor = false;
            this.btnEliminarDeHabitual.Click += new System.EventHandler(this.btnEliminarDeHabitual_Click);
            // 
            // btRealizarCompraHabitual
            // 
            this.btRealizarCompraHabitual.BackColor = System.Drawing.Color.LightBlue;
            this.btRealizarCompraHabitual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRealizarCompraHabitual.Location = new System.Drawing.Point(642, 322);
            this.btRealizarCompraHabitual.Name = "btRealizarCompraHabitual";
            this.btRealizarCompraHabitual.Size = new System.Drawing.Size(233, 62);
            this.btRealizarCompraHabitual.TabIndex = 4;
            this.btRealizarCompraHabitual.Text = "Realizar compra habitual";
            this.btRealizarCompraHabitual.UseVisualStyleBackColor = false;
            this.btRealizarCompraHabitual.Click += new System.EventHandler(this.btRealizarCompraHabitual_Click);
            // 
            // dgvCompraHabitual
            // 
            this.dgvCompraHabitual.AllowUserToAddRows = false;
            this.dgvCompraHabitual.AllowUserToDeleteRows = false;
            this.dgvCompraHabitual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompraHabitual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompraHabitual.Location = new System.Drawing.Point(43, 322);
            this.dgvCompraHabitual.Name = "dgvCompraHabitual";
            this.dgvCompraHabitual.ReadOnly = true;
            this.dgvCompraHabitual.RowHeadersWidth = 51;
            this.dgvCompraHabitual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompraHabitual.Size = new System.Drawing.Size(563, 217);
            this.dgvCompraHabitual.TabIndex = 3;
            // 
            // dgvMisIngredientes
            // 
            this.dgvMisIngredientes.AllowUserToAddRows = false;
            this.dgvMisIngredientes.AllowUserToDeleteRows = false;
            this.dgvMisIngredientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMisIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMisIngredientes.Location = new System.Drawing.Point(43, 48);
            this.dgvMisIngredientes.Name = "dgvMisIngredientes";
            this.dgvMisIngredientes.ReadOnly = true;
            this.dgvMisIngredientes.RowHeadersWidth = 51;
            this.dgvMisIngredientes.Size = new System.Drawing.Size(645, 217);
            this.dgvMisIngredientes.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Compra habitual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mis Ingredientes";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage2.Controls.Add(this.btConfReceta);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.lbRecetas);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(903, 592);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recetas";
            // 
            // btConfReceta
            // 
            this.btConfReceta.BackColor = System.Drawing.Color.LightBlue;
            this.btConfReceta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfReceta.Location = new System.Drawing.Point(637, 491);
            this.btConfReceta.Name = "btConfReceta";
            this.btConfReceta.Size = new System.Drawing.Size(233, 62);
            this.btConfReceta.TabIndex = 5;
            this.btConfReceta.Text = "Confirmar receta";
            this.btConfReceta.UseVisualStyleBackColor = false;
            this.btConfReceta.Click += new System.EventHandler(this.btConfReceta_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbDescripcion);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(281, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 429);
            this.panel1.TabIndex = 2;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.AllowDrop = true;
            this.tbDescripcion.BackColor = System.Drawing.Color.SteelBlue;
            this.tbDescripcion.Location = new System.Drawing.Point(17, 58);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDescripcion.Size = new System.Drawing.Size(571, 370);
            this.tbDescripcion.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Descripción básica";
            // 
            // lbRecetas
            // 
            this.lbRecetas.BackColor = System.Drawing.Color.MidnightBlue;
            this.lbRecetas.FormattingEnabled = true;
            this.lbRecetas.HorizontalScrollbar = true;
            this.lbRecetas.ItemHeight = 20;
            this.lbRecetas.Location = new System.Drawing.Point(0, 33);
            this.lbRecetas.Name = "lbRecetas";
            this.lbRecetas.Size = new System.Drawing.Size(238, 524);
            this.lbRecetas.TabIndex = 1;
            this.lbRecetas.SelectedIndexChanged += new System.EventHandler(this.lbRecetas_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Recetas";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage3.Controls.Add(this.btnEliminarCesta);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.tbTotal);
            this.tabPage3.Controls.Add(this.dgvCestaDeCompras);
            this.tabPage3.Controls.Add(this.btnAgregarHabitual);
            this.tabPage3.Controls.Add(this.btBuscar);
            this.tabPage3.Controls.Add(this.txtbBuscarIngrediente);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.dgvCompraIngredientes);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(903, 592);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Comprar Ingredientes";
            // 
            // btnEliminarCesta
            // 
            this.btnEliminarCesta.BackColor = System.Drawing.Color.LightBlue;
            this.btnEliminarCesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCesta.Location = new System.Drawing.Point(625, 408);
            this.btnEliminarCesta.Name = "btnEliminarCesta";
            this.btnEliminarCesta.Size = new System.Drawing.Size(233, 62);
            this.btnEliminarCesta.TabIndex = 21;
            this.btnEliminarCesta.Text = "Eliminar de la cesta";
            this.btnEliminarCesta.UseVisualStyleBackColor = false;
            this.btnEliminarCesta.Click += new System.EventHandler(this.btnEliminarCesta_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightBlue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(625, 509);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(233, 62);
            this.button7.TabIndex = 20;
            this.button7.Text = "Ir a pago";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(597, 354);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Total:";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(659, 351);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(100, 26);
            this.tbTotal.TabIndex = 18;
            this.tbTotal.Text = "0";
            // 
            // dgvCestaDeCompras
            // 
            this.dgvCestaDeCompras.AllowUserToAddRows = false;
            this.dgvCestaDeCompras.AllowUserToDeleteRows = false;
            this.dgvCestaDeCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCestaDeCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Ingrediente,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn12});
            this.dgvCestaDeCompras.Location = new System.Drawing.Point(46, 354);
            this.dgvCestaDeCompras.Name = "dgvCestaDeCompras";
            this.dgvCestaDeCompras.ReadOnly = true;
            this.dgvCestaDeCompras.RowHeadersWidth = 51;
            this.dgvCestaDeCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCestaDeCompras.Size = new System.Drawing.Size(543, 217);
            this.dgvCestaDeCompras.TabIndex = 11;
            this.dgvCestaDeCompras.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvCestaDeCompras_RowsAdded);
            // 
            // Id_Ingrediente
            // 
            this.Id_Ingrediente.HeaderText = "Id_ingrediente";
            this.Id_Ingrediente.MinimumWidth = 6;
            this.Id_Ingrediente.Name = "Id_Ingrediente";
            this.Id_Ingrediente.ReadOnly = true;
            this.Id_Ingrediente.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Unidad";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // btnAgregarHabitual
            // 
            this.btnAgregarHabitual.BackColor = System.Drawing.Color.LightBlue;
            this.btnAgregarHabitual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarHabitual.Location = new System.Drawing.Point(625, 195);
            this.btnAgregarHabitual.Name = "btnAgregarHabitual";
            this.btnAgregarHabitual.Size = new System.Drawing.Size(233, 62);
            this.btnAgregarHabitual.TabIndex = 10;
            this.btnAgregarHabitual.Text = "Agregar a compra habitual";
            this.btnAgregarHabitual.UseVisualStyleBackColor = false;
            this.btnAgregarHabitual.Click += new System.EventHandler(this.button5_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.LightBlue;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Location = new System.Drawing.Point(368, 22);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(129, 44);
            this.btBuscar.TabIndex = 9;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // txtbBuscarIngrediente
            // 
            this.txtbBuscarIngrediente.Location = new System.Drawing.Point(46, 31);
            this.txtbBuscarIngrediente.Name = "txtbBuscarIngrediente";
            this.txtbBuscarIngrediente.Size = new System.Drawing.Size(302, 26);
            this.txtbBuscarIngrediente.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(625, 72);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(233, 62);
            this.button4.TabIndex = 7;
            this.button4.Text = "Agregar a la cesta";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvCompraIngredientes
            // 
            this.dgvCompraIngredientes.AllowUserToAddRows = false;
            this.dgvCompraIngredientes.AllowUserToDeleteRows = false;
            this.dgvCompraIngredientes.AutoGenerateColumns = false;
            this.dgvCompraIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompraIngredientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idingredienteDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.unidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn});
            this.dgvCompraIngredientes.DataSource = this.ingredienteBindingSource;
            this.dgvCompraIngredientes.Location = new System.Drawing.Point(46, 72);
            this.dgvCompraIngredientes.Name = "dgvCompraIngredientes";
            this.dgvCompraIngredientes.ReadOnly = true;
            this.dgvCompraIngredientes.RowHeadersWidth = 51;
            this.dgvCompraIngredientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompraIngredientes.Size = new System.Drawing.Size(543, 217);
            this.dgvCompraIngredientes.TabIndex = 6;
            // 
            // idingredienteDataGridViewTextBoxColumn
            // 
            this.idingredienteDataGridViewTextBoxColumn.DataPropertyName = "Id_ingrediente";
            this.idingredienteDataGridViewTextBoxColumn.HeaderText = "Id_ingrediente";
            this.idingredienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idingredienteDataGridViewTextBoxColumn.Name = "idingredienteDataGridViewTextBoxColumn";
            this.idingredienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idingredienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // unidadDataGridViewTextBoxColumn
            // 
            this.unidadDataGridViewTextBoxColumn.DataPropertyName = "unidad";
            this.unidadDataGridViewTextBoxColumn.HeaderText = "unidad";
            this.unidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unidadDataGridViewTextBoxColumn.Name = "unidadDataGridViewTextBoxColumn";
            this.unidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.unidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ingredienteBindingSource
            // 
            this.ingredienteBindingSource.DataMember = "Ingrediente";
            this.ingredienteBindingSource.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Cesta de compras";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.btnCambiarContraseña);
            this.tabPage4.Controls.Add(this.btnCambiarCorreo);
            this.tabPage4.Controls.Add(this.btnCambiarApellido);
            this.tabPage4.Controls.Add(this.btCambiarNombre);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.tbNombreUsuario);
            this.tabPage4.Controls.Add(this.tbAppellidosUsuario);
            this.tabPage4.Controls.Add(this.tbContraUsuario);
            this.tabPage4.Controls.Add(this.tbCorreoUsuario);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage4.Size = new System.Drawing.Size(903, 592);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Mi Perfil";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(400, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Mis datos";
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.BackColor = System.Drawing.Color.LightBlue;
            this.btnCambiarContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarContraseña.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btnCambiarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCambiarContraseña.Location = new System.Drawing.Point(560, 214);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(117, 40);
            this.btnCambiarContraseña.TabIndex = 32;
            this.btnCambiarContraseña.Text = "Cambiar";
            this.btnCambiarContraseña.UseVisualStyleBackColor = false;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCambiarCorreo
            // 
            this.btnCambiarCorreo.BackColor = System.Drawing.Color.LightBlue;
            this.btnCambiarCorreo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarCorreo.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btnCambiarCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCambiarCorreo.Location = new System.Drawing.Point(560, 170);
            this.btnCambiarCorreo.Name = "btnCambiarCorreo";
            this.btnCambiarCorreo.Size = new System.Drawing.Size(117, 40);
            this.btnCambiarCorreo.TabIndex = 31;
            this.btnCambiarCorreo.Text = "Cambiar";
            this.btnCambiarCorreo.UseVisualStyleBackColor = false;
            this.btnCambiarCorreo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCambiarApellido
            // 
            this.btnCambiarApellido.BackColor = System.Drawing.Color.LightBlue;
            this.btnCambiarApellido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarApellido.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btnCambiarApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCambiarApellido.Location = new System.Drawing.Point(560, 125);
            this.btnCambiarApellido.Name = "btnCambiarApellido";
            this.btnCambiarApellido.Size = new System.Drawing.Size(117, 40);
            this.btnCambiarApellido.TabIndex = 30;
            this.btnCambiarApellido.Text = "Cambiar";
            this.btnCambiarApellido.UseVisualStyleBackColor = false;
            this.btnCambiarApellido.Click += new System.EventHandler(this.btnCambiarApellido_Click);
            // 
            // btCambiarNombre
            // 
            this.btCambiarNombre.BackColor = System.Drawing.Color.LightBlue;
            this.btCambiarNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCambiarNombre.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btCambiarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCambiarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btCambiarNombre.Location = new System.Drawing.Point(560, 79);
            this.btCambiarNombre.Name = "btCambiarNombre";
            this.btCambiarNombre.Size = new System.Drawing.Size(117, 40);
            this.btCambiarNombre.TabIndex = 29;
            this.btCambiarNombre.Text = "Cambiar";
            this.btCambiarNombre.UseVisualStyleBackColor = false;
            this.btCambiarNombre.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(39, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Apellidos";
            // 
            // tbNombreUsuario
            // 
            this.tbNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbNombreUsuario.Location = new System.Drawing.Point(275, 93);
            this.tbNombreUsuario.Name = "tbNombreUsuario";
            this.tbNombreUsuario.Size = new System.Drawing.Size(236, 26);
            this.tbNombreUsuario.TabIndex = 27;
            // 
            // tbAppellidosUsuario
            // 
            this.tbAppellidosUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbAppellidosUsuario.Location = new System.Drawing.Point(275, 139);
            this.tbAppellidosUsuario.Name = "tbAppellidosUsuario";
            this.tbAppellidosUsuario.Size = new System.Drawing.Size(236, 26);
            this.tbAppellidosUsuario.TabIndex = 26;
            // 
            // tbContraUsuario
            // 
            this.tbContraUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbContraUsuario.Location = new System.Drawing.Point(275, 228);
            this.tbContraUsuario.Name = "tbContraUsuario";
            this.tbContraUsuario.Size = new System.Drawing.Size(236, 26);
            this.tbContraUsuario.TabIndex = 25;
            this.tbContraUsuario.UseSystemPasswordChar = true;
            // 
            // tbCorreoUsuario
            // 
            this.tbCorreoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbCorreoUsuario.Location = new System.Drawing.Point(275, 184);
            this.tbCorreoUsuario.Name = "tbCorreoUsuario";
            this.tbCorreoUsuario.Size = new System.Drawing.Size(236, 26);
            this.tbCorreoUsuario.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(39, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(39, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Confirmar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(39, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Correo Electronico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(39, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre";
            // 
            // recetaBindingSource
            // 
            this.recetaBindingSource.DataMember = "Receta";
            this.recetaBindingSource.DataSource = this.masterDataSet;
            // 
            // recetaTableAdapter
            // 
            this.recetaTableAdapter.ClearBeforeFill = true;
            // 
            // ingredientetieneRecetaBindingSource
            // 
            this.ingredientetieneRecetaBindingSource.DataMember = "Ingrediente_tiene_Receta";
            this.ingredientetieneRecetaBindingSource.DataSource = this.masterDataSet;
            // 
            // ingrediente_tiene_RecetaTableAdapter
            // 
            this.ingrediente_tiene_RecetaTableAdapter.ClearBeforeFill = true;
            // 
            // ingredienteTableAdapter
            // 
            this.ingredienteTableAdapter.ClearBeforeFill = true;
            // 
            // MenuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(909, 620);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuUsuario";
            this.Text = "KitchenKitten";
            this.Load += new System.EventHandler(this.MenuUsuario_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompraHabitual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisIngredientes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCestaDeCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompraIngredientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientetieneRecetaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox tbNombreUsuario;
        private System.Windows.Forms.TextBox tbAppellidosUsuario;
        private System.Windows.Forms.TextBox tbContraUsuario;
        private System.Windows.Forms.TextBox tbCorreoUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.Button btnCambiarCorreo;
        private System.Windows.Forms.Button btnCambiarApellido;
        private System.Windows.Forms.Button btCambiarNombre;
        private System.Windows.Forms.DataGridView dgvCompraHabitual;
        private System.Windows.Forms.DataGridView dgvMisIngredientes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btRealizarCompraHabitual;
        private System.Windows.Forms.ListBox lbRecetas;
        private System.Windows.Forms.Label label8;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource recetaBindingSource;
        private masterDataSetTableAdapters.RecetaTableAdapter recetaTableAdapter;
        private System.Windows.Forms.Button btConfReceta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox txtbBuscarIngrediente;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvCompraIngredientes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvCestaDeCompras;
        private System.Windows.Forms.Button btnAgregarHabitual;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbTotal;
        public System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.BindingSource ingredientetieneRecetaBindingSource;
        private masterDataSetTableAdapters.Ingrediente_tiene_RecetaTableAdapter ingrediente_tiene_RecetaTableAdapter;
        private System.Windows.Forms.BindingSource ingredienteBindingSource;
        private masterDataSetTableAdapters.IngredienteTableAdapter ingredienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idingredienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEliminarCesta;
        private System.Windows.Forms.Button btnEliminarDeHabitual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Ingrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}