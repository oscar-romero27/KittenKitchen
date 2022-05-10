
namespace KitchenKitten
{
    partial class AdminReceta
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
            System.Windows.Forms.Label receta_idLabel;
            System.Windows.Forms.Label tiempo_preparacionLabel;
            System.Windows.Forms.Label nombre_recetaLabel;
            System.Windows.Forms.Label descripcion_recetaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminReceta));
            this.masterDataSet = new global::KitchenKitten.masterDataSet();
            this.recetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recetaTableAdapter = new global::KitchenKitten.masterDataSetTableAdapters.RecetaTableAdapter();
            this.tableAdapterManager = new global::KitchenKitten.masterDataSetTableAdapters.TableAdapterManager();
            this.recetaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.recetaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.recetaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receta_idTextBox = new System.Windows.Forms.TextBox();
            this.tiempo_preparacionTextBox = new System.Windows.Forms.TextBox();
            this.nombre_recetaTextBox = new System.Windows.Forms.TextBox();
            this.descripcion_recetaTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            receta_idLabel = new System.Windows.Forms.Label();
            tiempo_preparacionLabel = new System.Windows.Forms.Label();
            nombre_recetaLabel = new System.Windows.Forms.Label();
            descripcion_recetaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetaBindingNavigator)).BeginInit();
            this.recetaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recetaDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // receta_idLabel
            // 
            receta_idLabel.AutoSize = true;
            receta_idLabel.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            receta_idLabel.Location = new System.Drawing.Point(18, 16);
            receta_idLabel.Name = "receta_idLabel";
            receta_idLabel.Size = new System.Drawing.Size(61, 17);
            receta_idLabel.TabIndex = 2;
            receta_idLabel.Text = "receta id:";
            // 
            // tiempo_preparacionLabel
            // 
            tiempo_preparacionLabel.AutoSize = true;
            tiempo_preparacionLabel.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tiempo_preparacionLabel.Location = new System.Drawing.Point(18, 42);
            tiempo_preparacionLabel.Name = "tiempo_preparacionLabel";
            tiempo_preparacionLabel.Size = new System.Drawing.Size(123, 17);
            tiempo_preparacionLabel.TabIndex = 4;
            tiempo_preparacionLabel.Text = "tiempo preparacion:";
            // 
            // nombre_recetaLabel
            // 
            nombre_recetaLabel.AutoSize = true;
            nombre_recetaLabel.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombre_recetaLabel.Location = new System.Drawing.Point(18, 68);
            nombre_recetaLabel.Name = "nombre_recetaLabel";
            nombre_recetaLabel.Size = new System.Drawing.Size(96, 17);
            nombre_recetaLabel.TabIndex = 6;
            nombre_recetaLabel.Text = "nombre receta:";
            // 
            // descripcion_recetaLabel
            // 
            descripcion_recetaLabel.AutoSize = true;
            descripcion_recetaLabel.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcion_recetaLabel.Location = new System.Drawing.Point(18, 94);
            descripcion_recetaLabel.Name = "descripcion_recetaLabel";
            descripcion_recetaLabel.Size = new System.Drawing.Size(116, 17);
            descripcion_recetaLabel.TabIndex = 8;
            descripcion_recetaLabel.Text = "descripcion receta:";
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Ingrediente_tiene_RecetaTableAdapter = null;
            this.tableAdapterManager.IngredienteTableAdapter = null;
            this.tableAdapterManager.RecetaTableAdapter = this.recetaTableAdapter;
            this.tableAdapterManager.UpdateOrder = global::KitchenKitten.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.ValoracionTableAdapter = null;
            // 
            // recetaBindingNavigator
            // 
            this.recetaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.recetaBindingNavigator.BindingSource = this.recetaBindingSource;
            this.recetaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.recetaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.recetaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.recetaBindingNavigatorSaveItem});
            this.recetaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.recetaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.recetaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.recetaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.recetaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.recetaBindingNavigator.Name = "recetaBindingNavigator";
            this.recetaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.recetaBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.recetaBindingNavigator.TabIndex = 0;
            this.recetaBindingNavigator.Text = "bindingNavigator1";
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
            // recetaBindingNavigatorSaveItem
            // 
            this.recetaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.recetaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("recetaBindingNavigatorSaveItem.Image")));
            this.recetaBindingNavigatorSaveItem.Name = "recetaBindingNavigatorSaveItem";
            this.recetaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.recetaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.recetaBindingNavigatorSaveItem.Click += new System.EventHandler(this.recetaBindingNavigatorSaveItem_Click);
            // 
            // recetaDataGridView
            // 
            this.recetaDataGridView.AutoGenerateColumns = false;
            this.recetaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recetaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recetaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.recetaDataGridView.DataSource = this.recetaBindingSource;
            this.recetaDataGridView.Location = new System.Drawing.Point(103, 196);
            this.recetaDataGridView.Name = "recetaDataGridView";
            this.recetaDataGridView.Size = new System.Drawing.Size(581, 220);
            this.recetaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "receta_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "receta_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tiempo_preparacion";
            this.dataGridViewTextBoxColumn2.HeaderText = "tiempo_preparacion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nombre_receta";
            this.dataGridViewTextBoxColumn3.HeaderText = "nombre_receta";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "descripcion_receta";
            this.dataGridViewTextBoxColumn4.HeaderText = "descripcion_receta";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // receta_idTextBox
            // 
            this.receta_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recetaBindingSource, "receta_id", true));
            this.receta_idTextBox.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receta_idTextBox.Location = new System.Drawing.Point(142, 13);
            this.receta_idTextBox.Name = "receta_idTextBox";
            this.receta_idTextBox.Size = new System.Drawing.Size(100, 24);
            this.receta_idTextBox.TabIndex = 3;
            // 
            // tiempo_preparacionTextBox
            // 
            this.tiempo_preparacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recetaBindingSource, "tiempo_preparacion", true));
            this.tiempo_preparacionTextBox.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempo_preparacionTextBox.Location = new System.Drawing.Point(142, 39);
            this.tiempo_preparacionTextBox.Name = "tiempo_preparacionTextBox";
            this.tiempo_preparacionTextBox.Size = new System.Drawing.Size(100, 24);
            this.tiempo_preparacionTextBox.TabIndex = 5;
            // 
            // nombre_recetaTextBox
            // 
            this.nombre_recetaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recetaBindingSource, "nombre_receta", true));
            this.nombre_recetaTextBox.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_recetaTextBox.Location = new System.Drawing.Point(142, 65);
            this.nombre_recetaTextBox.Name = "nombre_recetaTextBox";
            this.nombre_recetaTextBox.Size = new System.Drawing.Size(100, 24);
            this.nombre_recetaTextBox.TabIndex = 7;
            // 
            // descripcion_recetaTextBox
            // 
            this.descripcion_recetaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recetaBindingSource, "descripcion_receta", true));
            this.descripcion_recetaTextBox.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion_recetaTextBox.Location = new System.Drawing.Point(142, 91);
            this.descripcion_recetaTextBox.Name = "descripcion_recetaTextBox";
            this.descripcion_recetaTextBox.Size = new System.Drawing.Size(100, 24);
            this.descripcion_recetaTextBox.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(receta_idLabel);
            this.groupBox1.Controls.Add(this.receta_idTextBox);
            this.groupBox1.Controls.Add(this.descripcion_recetaTextBox);
            this.groupBox1.Controls.Add(tiempo_preparacionLabel);
            this.groupBox1.Controls.Add(descripcion_recetaLabel);
            this.groupBox1.Controls.Add(this.tiempo_preparacionTextBox);
            this.groupBox1.Controls.Add(this.nombre_recetaTextBox);
            this.groupBox1.Controls.Add(nombre_recetaLabel);
            this.groupBox1.Location = new System.Drawing.Point(248, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 132);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(8, 9);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Gestión Recetas";
            // 
            // AdminReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.recetaDataGridView);
            this.Controls.Add(this.recetaBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminReceta";
            this.Text = "KitchenKitten";
            this.Load += new System.EventHandler(this.AdminReceta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetaBindingNavigator)).EndInit();
            this.recetaBindingNavigator.ResumeLayout(false);
            this.recetaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recetaDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource recetaBindingSource;
        private masterDataSetTableAdapters.RecetaTableAdapter recetaTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator recetaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton recetaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView recetaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox receta_idTextBox;
        private System.Windows.Forms.TextBox tiempo_preparacionTextBox;
        private System.Windows.Forms.TextBox nombre_recetaTextBox;
        private System.Windows.Forms.TextBox descripcion_recetaTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}