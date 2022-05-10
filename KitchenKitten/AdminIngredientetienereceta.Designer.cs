
namespace KitchenKitten
{
    partial class AdminIngredientetienereceta
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
            System.Windows.Forms.Label ingrediente_idLabel;
            System.Windows.Forms.Label receta_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminIngredientetienereceta));
            this.masterDataSet = new global::KitchenKitten.masterDataSet();
            this.ingrediente_tiene_RecetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingrediente_tiene_RecetaTableAdapter = new global::KitchenKitten.masterDataSetTableAdapters.Ingrediente_tiene_RecetaTableAdapter();
            this.tableAdapterManager = new global::KitchenKitten.masterDataSetTableAdapters.TableAdapterManager();
            this.ingrediente_tiene_RecetaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.ingrediente_tiene_RecetaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ingrediente_idTextBox = new System.Windows.Forms.TextBox();
            this.receta_idTextBox = new System.Windows.Forms.TextBox();
            this.ingrediente_tiene_RecetaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ingrediente_idLabel = new System.Windows.Forms.Label();
            receta_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingrediente_tiene_RecetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingrediente_tiene_RecetaBindingNavigator)).BeginInit();
            this.ingrediente_tiene_RecetaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingrediente_tiene_RecetaDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ingrediente_idLabel
            // 
            ingrediente_idLabel.AutoSize = true;
            ingrediente_idLabel.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ingrediente_idLabel.Location = new System.Drawing.Point(17, 19);
            ingrediente_idLabel.Name = "ingrediente_idLabel";
            ingrediente_idLabel.Size = new System.Drawing.Size(91, 17);
            ingrediente_idLabel.TabIndex = 1;
            ingrediente_idLabel.Text = "ingrediente id:";
            // 
            // receta_idLabel
            // 
            receta_idLabel.AutoSize = true;
            receta_idLabel.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            receta_idLabel.Location = new System.Drawing.Point(17, 53);
            receta_idLabel.Name = "receta_idLabel";
            receta_idLabel.Size = new System.Drawing.Size(61, 17);
            receta_idLabel.TabIndex = 3;
            receta_idLabel.Text = "receta id:";
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ingrediente_tiene_RecetaBindingSource
            // 
            this.ingrediente_tiene_RecetaBindingSource.DataMember = "Ingrediente_tiene_Receta";
            this.ingrediente_tiene_RecetaBindingSource.DataSource = this.masterDataSet;
            // 
            // ingrediente_tiene_RecetaTableAdapter
            // 
            this.ingrediente_tiene_RecetaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Ingrediente_tiene_RecetaTableAdapter = this.ingrediente_tiene_RecetaTableAdapter;
            this.tableAdapterManager.IngredienteTableAdapter = null;
            this.tableAdapterManager.RecetaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = global::KitchenKitten.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.ValoracionTableAdapter = null;
            // 
            // ingrediente_tiene_RecetaBindingNavigator
            // 
            this.ingrediente_tiene_RecetaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ingrediente_tiene_RecetaBindingNavigator.BindingSource = this.ingrediente_tiene_RecetaBindingSource;
            this.ingrediente_tiene_RecetaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ingrediente_tiene_RecetaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ingrediente_tiene_RecetaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ingrediente_tiene_RecetaBindingNavigatorSaveItem});
            this.ingrediente_tiene_RecetaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ingrediente_tiene_RecetaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ingrediente_tiene_RecetaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ingrediente_tiene_RecetaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ingrediente_tiene_RecetaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ingrediente_tiene_RecetaBindingNavigator.Name = "ingrediente_tiene_RecetaBindingNavigator";
            this.ingrediente_tiene_RecetaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ingrediente_tiene_RecetaBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.ingrediente_tiene_RecetaBindingNavigator.TabIndex = 0;
            this.ingrediente_tiene_RecetaBindingNavigator.Text = "bindingNavigator1";
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
            // ingrediente_tiene_RecetaBindingNavigatorSaveItem
            // 
            this.ingrediente_tiene_RecetaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ingrediente_tiene_RecetaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ingrediente_tiene_RecetaBindingNavigatorSaveItem.Image")));
            this.ingrediente_tiene_RecetaBindingNavigatorSaveItem.Name = "ingrediente_tiene_RecetaBindingNavigatorSaveItem";
            this.ingrediente_tiene_RecetaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ingrediente_tiene_RecetaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.ingrediente_tiene_RecetaBindingNavigatorSaveItem.Click += new System.EventHandler(this.ingrediente_tiene_RecetaBindingNavigatorSaveItem_Click);
            // 
            // ingrediente_idTextBox
            // 
            this.ingrediente_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingrediente_tiene_RecetaBindingSource, "ingrediente_id", true));
            this.ingrediente_idTextBox.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingrediente_idTextBox.Location = new System.Drawing.Point(126, 19);
            this.ingrediente_idTextBox.Name = "ingrediente_idTextBox";
            this.ingrediente_idTextBox.Size = new System.Drawing.Size(100, 24);
            this.ingrediente_idTextBox.TabIndex = 2;
            // 
            // receta_idTextBox
            // 
            this.receta_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingrediente_tiene_RecetaBindingSource, "receta_id", true));
            this.receta_idTextBox.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receta_idTextBox.Location = new System.Drawing.Point(126, 53);
            this.receta_idTextBox.Name = "receta_idTextBox";
            this.receta_idTextBox.Size = new System.Drawing.Size(100, 24);
            this.receta_idTextBox.TabIndex = 4;
            // 
            // ingrediente_tiene_RecetaDataGridView
            // 
            this.ingrediente_tiene_RecetaDataGridView.AutoGenerateColumns = false;
            this.ingrediente_tiene_RecetaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ingrediente_tiene_RecetaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingrediente_tiene_RecetaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.ingrediente_tiene_RecetaDataGridView.DataSource = this.ingrediente_tiene_RecetaBindingSource;
            this.ingrediente_tiene_RecetaDataGridView.Location = new System.Drawing.Point(95, 212);
            this.ingrediente_tiene_RecetaDataGridView.Name = "ingrediente_tiene_RecetaDataGridView";
            this.ingrediente_tiene_RecetaDataGridView.Size = new System.Drawing.Size(569, 220);
            this.ingrediente_tiene_RecetaDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ingrediente_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ingrediente_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "receta_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "receta_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ingrediente_idTextBox);
            this.groupBox1.Controls.Add(this.receta_idTextBox);
            this.groupBox1.Controls.Add(ingrediente_idLabel);
            this.groupBox1.Controls.Add(receta_idLabel);
            this.groupBox1.Location = new System.Drawing.Point(239, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Gestión Ingredientes de Recetas";
            // 
            // AdminIngredientetienereceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ingrediente_tiene_RecetaDataGridView);
            this.Controls.Add(this.ingrediente_tiene_RecetaBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminIngredientetienereceta";
            this.Text = "KichenKitten";
            this.Load += new System.EventHandler(this.AdminIngredientetienereceta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingrediente_tiene_RecetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingrediente_tiene_RecetaBindingNavigator)).EndInit();
            this.ingrediente_tiene_RecetaBindingNavigator.ResumeLayout(false);
            this.ingrediente_tiene_RecetaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingrediente_tiene_RecetaDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource ingrediente_tiene_RecetaBindingSource;
        private masterDataSetTableAdapters.Ingrediente_tiene_RecetaTableAdapter ingrediente_tiene_RecetaTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ingrediente_tiene_RecetaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ingrediente_tiene_RecetaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox ingrediente_idTextBox;
        private System.Windows.Forms.TextBox receta_idTextBox;
        private System.Windows.Forms.DataGridView ingrediente_tiene_RecetaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}