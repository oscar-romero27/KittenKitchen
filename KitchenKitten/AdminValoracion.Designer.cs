
namespace KitchenKitten
{
    partial class AdminValoracion
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
            System.Windows.Forms.Label valoracion_idLabel;
            System.Windows.Forms.Label puntuacionLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label usuario_idLabel;
            System.Windows.Forms.Label receta_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminValoracion));
            this.masterDataSet = new global::KitchenKitten.masterDataSet();
            this.valoracionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valoracionTableAdapter = new global::KitchenKitten.masterDataSetTableAdapters.ValoracionTableAdapter();
            this.tableAdapterManager = new global::KitchenKitten.masterDataSetTableAdapters.TableAdapterManager();
            this.valoracionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.valoracionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.valoracionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoracion_idTextBox = new System.Windows.Forms.TextBox();
            this.puntuacionTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.usuario_idTextBox = new System.Windows.Forms.TextBox();
            this.receta_idTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            valoracion_idLabel = new System.Windows.Forms.Label();
            puntuacionLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            usuario_idLabel = new System.Windows.Forms.Label();
            receta_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valoracionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valoracionBindingNavigator)).BeginInit();
            this.valoracionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valoracionDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // valoracion_idLabel
            // 
            valoracion_idLabel.AutoSize = true;
            valoracion_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valoracion_idLabel.Location = new System.Drawing.Point(24, 27);
            valoracion_idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            valoracion_idLabel.Name = "valoracion_idLabel";
            valoracion_idLabel.Size = new System.Drawing.Size(109, 18);
            valoracion_idLabel.TabIndex = 2;
            valoracion_idLabel.Text = "valoracion id:";
            // 
            // puntuacionLabel
            // 
            puntuacionLabel.AutoSize = true;
            puntuacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            puntuacionLabel.Location = new System.Drawing.Point(24, 59);
            puntuacionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            puntuacionLabel.Name = "puntuacionLabel";
            puntuacionLabel.Size = new System.Drawing.Size(95, 18);
            puntuacionLabel.TabIndex = 4;
            puntuacionLabel.Text = "puntuacion:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(24, 91);
            descripcionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(100, 18);
            descripcionLabel.TabIndex = 6;
            descripcionLabel.Text = "descripcion:";
            // 
            // usuario_idLabel
            // 
            usuario_idLabel.AutoSize = true;
            usuario_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usuario_idLabel.Location = new System.Drawing.Point(24, 123);
            usuario_idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            usuario_idLabel.Name = "usuario_idLabel";
            usuario_idLabel.Size = new System.Drawing.Size(87, 18);
            usuario_idLabel.TabIndex = 8;
            usuario_idLabel.Text = "usuario id:";
            // 
            // receta_idLabel
            // 
            receta_idLabel.AutoSize = true;
            receta_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            receta_idLabel.Location = new System.Drawing.Point(24, 155);
            receta_idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            receta_idLabel.Name = "receta_idLabel";
            receta_idLabel.Size = new System.Drawing.Size(78, 18);
            receta_idLabel.TabIndex = 10;
            receta_idLabel.Text = "receta id:";
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // valoracionBindingSource
            // 
            this.valoracionBindingSource.DataMember = "Valoracion";
            this.valoracionBindingSource.DataSource = this.masterDataSet;
            // 
            // valoracionTableAdapter
            // 
            this.valoracionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Ingrediente_tiene_RecetaTableAdapter = null;
            this.tableAdapterManager.IngredienteTableAdapter = null;
            this.tableAdapterManager.RecetaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = global::KitchenKitten.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.ValoracionTableAdapter = this.valoracionTableAdapter;
            // 
            // valoracionBindingNavigator
            // 
            this.valoracionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.valoracionBindingNavigator.BindingSource = this.valoracionBindingSource;
            this.valoracionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.valoracionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.valoracionBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.valoracionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.valoracionBindingNavigatorSaveItem});
            this.valoracionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.valoracionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.valoracionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.valoracionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.valoracionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.valoracionBindingNavigator.Name = "valoracionBindingNavigator";
            this.valoracionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.valoracionBindingNavigator.Size = new System.Drawing.Size(1067, 31);
            this.valoracionBindingNavigator.TabIndex = 0;
            this.valoracionBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // valoracionBindingNavigatorSaveItem
            // 
            this.valoracionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.valoracionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("valoracionBindingNavigatorSaveItem.Image")));
            this.valoracionBindingNavigatorSaveItem.Name = "valoracionBindingNavigatorSaveItem";
            this.valoracionBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.valoracionBindingNavigatorSaveItem.Text = "Guardar datos";
            this.valoracionBindingNavigatorSaveItem.Click += new System.EventHandler(this.valoracionBindingNavigatorSaveItem_Click);
            // 
            // valoracionDataGridView
            // 
            this.valoracionDataGridView.AutoGenerateColumns = false;
            this.valoracionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.valoracionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.valoracionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.valoracionDataGridView.DataSource = this.valoracionBindingSource;
            this.valoracionDataGridView.Location = new System.Drawing.Point(108, 250);
            this.valoracionDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.valoracionDataGridView.Name = "valoracionDataGridView";
            this.valoracionDataGridView.RowHeadersWidth = 51;
            this.valoracionDataGridView.Size = new System.Drawing.Size(827, 271);
            this.valoracionDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "valoracion_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "valoracion_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "puntuacion";
            this.dataGridViewTextBoxColumn2.HeaderText = "puntuacion";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "descripcion";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "usuario_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "usuario_id";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "receta_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "receta_id";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // valoracion_idTextBox
            // 
            this.valoracion_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.valoracionBindingSource, "valoracion_id", true));
            this.valoracion_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valoracion_idTextBox.Location = new System.Drawing.Point(143, 23);
            this.valoracion_idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.valoracion_idTextBox.Name = "valoracion_idTextBox";
            this.valoracion_idTextBox.Size = new System.Drawing.Size(132, 24);
            this.valoracion_idTextBox.TabIndex = 3;
            // 
            // puntuacionTextBox
            // 
            this.puntuacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.valoracionBindingSource, "puntuacion", true));
            this.puntuacionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntuacionTextBox.Location = new System.Drawing.Point(143, 55);
            this.puntuacionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.puntuacionTextBox.Name = "puntuacionTextBox";
            this.puntuacionTextBox.Size = new System.Drawing.Size(132, 24);
            this.puntuacionTextBox.TabIndex = 5;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.valoracionBindingSource, "descripcion", true));
            this.descripcionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionTextBox.Location = new System.Drawing.Point(143, 87);
            this.descripcionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(132, 24);
            this.descripcionTextBox.TabIndex = 7;
            // 
            // usuario_idTextBox
            // 
            this.usuario_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.valoracionBindingSource, "usuario_id", true));
            this.usuario_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario_idTextBox.Location = new System.Drawing.Point(143, 119);
            this.usuario_idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usuario_idTextBox.Name = "usuario_idTextBox";
            this.usuario_idTextBox.Size = new System.Drawing.Size(132, 24);
            this.usuario_idTextBox.TabIndex = 9;
            // 
            // receta_idTextBox
            // 
            this.receta_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.valoracionBindingSource, "receta_id", true));
            this.receta_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receta_idTextBox.Location = new System.Drawing.Point(143, 151);
            this.receta_idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.receta_idTextBox.Name = "receta_idTextBox";
            this.receta_idTextBox.Size = new System.Drawing.Size(132, 24);
            this.receta_idTextBox.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.valoracion_idTextBox);
            this.groupBox1.Controls.Add(valoracion_idLabel);
            this.groupBox1.Controls.Add(this.receta_idTextBox);
            this.groupBox1.Controls.Add(receta_idLabel);
            this.groupBox1.Controls.Add(puntuacionLabel);
            this.groupBox1.Controls.Add(this.usuario_idTextBox);
            this.groupBox1.Controls.Add(this.puntuacionTextBox);
            this.groupBox1.Controls.Add(usuario_idLabel);
            this.groupBox1.Controls.Add(descripcionLabel);
            this.groupBox1.Controls.Add(this.descripcionTextBox);
            this.groupBox1.Location = new System.Drawing.Point(320, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(336, 187);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Gestión Valoración";
            // 
            // AdminValoracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.valoracionDataGridView);
            this.Controls.Add(this.valoracionBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminValoracion";
            this.Text = "KittchenKitten";
            this.Load += new System.EventHandler(this.AdminValoracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valoracionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valoracionBindingNavigator)).EndInit();
            this.valoracionBindingNavigator.ResumeLayout(false);
            this.valoracionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valoracionDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource valoracionBindingSource;
        private masterDataSetTableAdapters.ValoracionTableAdapter valoracionTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator valoracionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton valoracionBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView valoracionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox valoracion_idTextBox;
        private System.Windows.Forms.TextBox puntuacionTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox usuario_idTextBox;
        private System.Windows.Forms.TextBox receta_idTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}