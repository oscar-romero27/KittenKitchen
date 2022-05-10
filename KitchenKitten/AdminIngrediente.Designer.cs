
namespace KitchenKitten
{
    partial class AdminIngrediente
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
            System.Windows.Forms.Label id_ingredienteLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label unidadLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label tipoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminIngrediente));
            this.masterDataSet = new global::KitchenKitten.masterDataSet();
            this.ingredienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingredienteTableAdapter = new global::KitchenKitten.masterDataSetTableAdapters.IngredienteTableAdapter();
            this.tableAdapterManager = new global::KitchenKitten.masterDataSetTableAdapters.TableAdapterManager();
            this.ingredienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ingredienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_ingredienteTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.unidadTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.ingredienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            id_ingredienteLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            unidadLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredienteBindingNavigator)).BeginInit();
            this.ingredienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingredienteDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_ingredienteLabel
            // 
            id_ingredienteLabel.AutoSize = true;
            id_ingredienteLabel.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_ingredienteLabel.Location = new System.Drawing.Point(2, 22);
            id_ingredienteLabel.Name = "id_ingredienteLabel";
            id_ingredienteLabel.Size = new System.Drawing.Size(92, 17);
            id_ingredienteLabel.TabIndex = 1;
            id_ingredienteLabel.Text = "Id ingrediente:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(2, 48);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(56, 17);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "nombre:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cantidadLabel.Location = new System.Drawing.Point(2, 74);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(61, 17);
            cantidadLabel.TabIndex = 5;
            cantidadLabel.Text = "cantidad:";
            // 
            // unidadLabel
            // 
            unidadLabel.AutoSize = true;
            unidadLabel.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            unidadLabel.Location = new System.Drawing.Point(2, 100);
            unidadLabel.Name = "unidadLabel";
            unidadLabel.Size = new System.Drawing.Size(51, 17);
            unidadLabel.TabIndex = 7;
            unidadLabel.Text = "unidad:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioLabel.Location = new System.Drawing.Point(2, 126);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(46, 17);
            precioLabel.TabIndex = 9;
            precioLabel.Text = "precio:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoLabel.Location = new System.Drawing.Point(2, 152);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(33, 17);
            tipoLabel.TabIndex = 11;
            tipoLabel.Text = "tipo:";
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ingredienteBindingSource
            // 
            this.ingredienteBindingSource.DataMember = "Ingrediente";
            this.ingredienteBindingSource.DataSource = this.masterDataSet;
            // 
            // ingredienteTableAdapter
            // 
            this.ingredienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Ingrediente_tiene_RecetaTableAdapter = null;
            this.tableAdapterManager.IngredienteTableAdapter = this.ingredienteTableAdapter;
            this.tableAdapterManager.RecetaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = global::KitchenKitten.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.ValoracionTableAdapter = null;
            // 
            // ingredienteBindingNavigator
            // 
            this.ingredienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ingredienteBindingNavigator.BindingSource = this.ingredienteBindingSource;
            this.ingredienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ingredienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ingredienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ingredienteBindingNavigatorSaveItem});
            this.ingredienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ingredienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ingredienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ingredienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ingredienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ingredienteBindingNavigator.Name = "ingredienteBindingNavigator";
            this.ingredienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ingredienteBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.ingredienteBindingNavigator.TabIndex = 0;
            this.ingredienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ingredienteBindingNavigatorSaveItem
            // 
            this.ingredienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ingredienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ingredienteBindingNavigatorSaveItem.Image")));
            this.ingredienteBindingNavigatorSaveItem.Name = "ingredienteBindingNavigatorSaveItem";
            this.ingredienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ingredienteBindingNavigatorSaveItem.Text = "Guardar datos";
            this.ingredienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.ingredienteBindingNavigatorSaveItem_Click);
            // 
            // id_ingredienteTextBox
            // 
            this.id_ingredienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredienteBindingSource, "Id_ingrediente", true));
            this.id_ingredienteTextBox.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_ingredienteTextBox.Location = new System.Drawing.Point(100, 19);
            this.id_ingredienteTextBox.Name = "id_ingredienteTextBox";
            this.id_ingredienteTextBox.Size = new System.Drawing.Size(100, 24);
            this.id_ingredienteTextBox.TabIndex = 2;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredienteBindingSource, "nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(100, 45);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 24);
            this.nombreTextBox.TabIndex = 4;
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredienteBindingSource, "cantidad", true));
            this.cantidadTextBox.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadTextBox.Location = new System.Drawing.Point(100, 71);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(100, 24);
            this.cantidadTextBox.TabIndex = 6;
            // 
            // unidadTextBox
            // 
            this.unidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredienteBindingSource, "unidad", true));
            this.unidadTextBox.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unidadTextBox.Location = new System.Drawing.Point(100, 97);
            this.unidadTextBox.Name = "unidadTextBox";
            this.unidadTextBox.Size = new System.Drawing.Size(100, 24);
            this.unidadTextBox.TabIndex = 8;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredienteBindingSource, "precio", true));
            this.precioTextBox.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioTextBox.Location = new System.Drawing.Point(100, 123);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(100, 24);
            this.precioTextBox.TabIndex = 10;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredienteBindingSource, "tipo", true));
            this.tipoTextBox.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoTextBox.Location = new System.Drawing.Point(100, 149);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(100, 24);
            this.tipoTextBox.TabIndex = 12;
            // 
            // ingredienteDataGridView
            // 
            this.ingredienteDataGridView.AutoGenerateColumns = false;
            this.ingredienteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ingredienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.ingredienteDataGridView.DataSource = this.ingredienteBindingSource;
            this.ingredienteDataGridView.Location = new System.Drawing.Point(53, 294);
            this.ingredienteDataGridView.Name = "ingredienteDataGridView";
            this.ingredienteDataGridView.Size = new System.Drawing.Size(662, 220);
            this.ingredienteDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_ingrediente";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_ingrediente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cantidad";
            this.dataGridViewTextBoxColumn3.HeaderText = "cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "unidad";
            this.dataGridViewTextBoxColumn4.HeaderText = "unidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "precio";
            this.dataGridViewTextBoxColumn5.HeaderText = "precio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "tipo";
            this.dataGridViewTextBoxColumn6.HeaderText = "tipo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.id_ingredienteTextBox);
            this.groupBox1.Controls.Add(this.tipoTextBox);
            this.groupBox1.Controls.Add(id_ingredienteLabel);
            this.groupBox1.Controls.Add(tipoLabel);
            this.groupBox1.Controls.Add(this.precioTextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(precioLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(this.unidadTextBox);
            this.groupBox1.Controls.Add(cantidadLabel);
            this.groupBox1.Controls.Add(unidadLabel);
            this.groupBox1.Controls.Add(this.cantidadTextBox);
            this.groupBox1.Location = new System.Drawing.Point(261, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 195);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Gestión Ingredientes";
            // 
            // AdminIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ingredienteDataGridView);
            this.Controls.Add(this.ingredienteBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminIngrediente";
            this.Text = "KitchenKitten";
            this.Load += new System.EventHandler(this.AdminIngrediente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredienteBindingNavigator)).EndInit();
            this.ingredienteBindingNavigator.ResumeLayout(false);
            this.ingredienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingredienteDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource ingredienteBindingSource;
        private masterDataSetTableAdapters.IngredienteTableAdapter ingredienteTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ingredienteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ingredienteBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_ingredienteTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.TextBox unidadTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.DataGridView ingredienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}