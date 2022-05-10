
namespace KitchenKitten
{
    partial class AdminUsuario
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
            System.Windows.Forms.Label usuario_idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label correo_electronicoLabel;
            System.Windows.Forms.Label contraseñaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUsuario));
            this.masterDataSet = new global::KitchenKitten.masterDataSet();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new global::KitchenKitten.masterDataSetTableAdapters.UsuarioTableAdapter();
            this.tableAdapterManager = new global::KitchenKitten.masterDataSetTableAdapters.TableAdapterManager();
            this.usuarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.usuarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.usuario_idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.correo_electronicoTextBox = new System.Windows.Forms.TextBox();
            this.contraseñaTextBox = new System.Windows.Forms.TextBox();
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            usuario_idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            correo_electronicoLabel = new System.Windows.Forms.Label();
            contraseñaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingNavigator)).BeginInit();
            this.usuarioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usuario_idLabel
            // 
            usuario_idLabel.AutoSize = true;
            usuario_idLabel.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usuario_idLabel.Location = new System.Drawing.Point(7, 36);
            usuario_idLabel.Name = "usuario_idLabel";
            usuario_idLabel.Size = new System.Drawing.Size(68, 17);
            usuario_idLabel.TabIndex = 1;
            usuario_idLabel.Text = "usuario id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(7, 62);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(56, 17);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "nombre:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidosLabel.Location = new System.Drawing.Point(7, 88);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(61, 17);
            apellidosLabel.TabIndex = 5;
            apellidosLabel.Text = "apellidos:";
            // 
            // correo_electronicoLabel
            // 
            correo_electronicoLabel.AutoSize = true;
            correo_electronicoLabel.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            correo_electronicoLabel.Location = new System.Drawing.Point(7, 114);
            correo_electronicoLabel.Name = "correo_electronicoLabel";
            correo_electronicoLabel.Size = new System.Drawing.Size(115, 17);
            correo_electronicoLabel.TabIndex = 7;
            correo_electronicoLabel.Text = "correo electronico:";
            // 
            // contraseñaLabel
            // 
            contraseñaLabel.AutoSize = true;
            contraseñaLabel.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contraseñaLabel.Location = new System.Drawing.Point(7, 140);
            contraseñaLabel.Name = "contraseñaLabel";
            contraseñaLabel.Size = new System.Drawing.Size(77, 17);
            contraseñaLabel.TabIndex = 9;
            contraseñaLabel.Text = "contraseña:";
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.masterDataSet;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Ingrediente_tiene_RecetaTableAdapter = null;
            this.tableAdapterManager.IngredienteTableAdapter = null;
            this.tableAdapterManager.RecetaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = global::KitchenKitten.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = this.usuarioTableAdapter;
            this.tableAdapterManager.ValoracionTableAdapter = null;
            // 
            // usuarioBindingNavigator
            // 
            this.usuarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.usuarioBindingNavigator.BindingSource = this.usuarioBindingSource;
            this.usuarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.usuarioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.usuarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.usuarioBindingNavigatorSaveItem});
            this.usuarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.usuarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.usuarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.usuarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.usuarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.usuarioBindingNavigator.Name = "usuarioBindingNavigator";
            this.usuarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.usuarioBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.usuarioBindingNavigator.TabIndex = 0;
            this.usuarioBindingNavigator.Text = "bindingNavigator1";
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
            // usuarioBindingNavigatorSaveItem
            // 
            this.usuarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usuarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("usuarioBindingNavigatorSaveItem.Image")));
            this.usuarioBindingNavigatorSaveItem.Name = "usuarioBindingNavigatorSaveItem";
            this.usuarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.usuarioBindingNavigatorSaveItem.Text = "Guardar datos";
            this.usuarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.usuarioBindingNavigatorSaveItem_Click);
            // 
            // usuario_idTextBox
            // 
            this.usuario_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "usuario_id", true));
            this.usuario_idTextBox.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario_idTextBox.Location = new System.Drawing.Point(128, 33);
            this.usuario_idTextBox.Name = "usuario_idTextBox";
            this.usuario_idTextBox.Size = new System.Drawing.Size(100, 24);
            this.usuario_idTextBox.TabIndex = 2;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(128, 59);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 24);
            this.nombreTextBox.TabIndex = 4;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "apellidos", true));
            this.apellidosTextBox.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidosTextBox.Location = new System.Drawing.Point(128, 85);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(100, 24);
            this.apellidosTextBox.TabIndex = 6;
            // 
            // correo_electronicoTextBox
            // 
            this.correo_electronicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "correo_electronico", true));
            this.correo_electronicoTextBox.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo_electronicoTextBox.Location = new System.Drawing.Point(128, 111);
            this.correo_electronicoTextBox.Name = "correo_electronicoTextBox";
            this.correo_electronicoTextBox.Size = new System.Drawing.Size(100, 24);
            this.correo_electronicoTextBox.TabIndex = 8;
            // 
            // contraseñaTextBox
            // 
            this.contraseñaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "contraseña", true));
            this.contraseñaTextBox.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñaTextBox.Location = new System.Drawing.Point(128, 137);
            this.contraseñaTextBox.Name = "contraseñaTextBox";
            this.contraseñaTextBox.Size = new System.Drawing.Size(100, 24);
            this.contraseñaTextBox.TabIndex = 10;
            // 
            // usuarioDataGridView
            // 
            this.usuarioDataGridView.AutoGenerateColumns = false;
            this.usuarioDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.usuarioDataGridView.DataSource = this.usuarioBindingSource;
            this.usuarioDataGridView.Location = new System.Drawing.Point(48, 259);
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.Size = new System.Drawing.Size(695, 220);
            this.usuarioDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "usuario_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "usuario_id";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "apellidos";
            this.dataGridViewTextBoxColumn3.HeaderText = "apellidos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "correo_electronico";
            this.dataGridViewTextBoxColumn4.HeaderText = "correo_electronico";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "contraseña";
            this.dataGridViewTextBoxColumn5.HeaderText = "contraseña";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.usuario_idTextBox);
            this.groupBox1.Controls.Add(this.contraseñaTextBox);
            this.groupBox1.Controls.Add(usuario_idLabel);
            this.groupBox1.Controls.Add(contraseñaLabel);
            this.groupBox1.Controls.Add(this.correo_electronicoTextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(correo_electronicoLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(this.apellidosTextBox);
            this.groupBox1.Controls.Add(apellidosLabel);
            this.groupBox1.Location = new System.Drawing.Point(263, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 182);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Gestión Usuario";
            // 
            // AdminUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.usuarioDataGridView);
            this.Controls.Add(this.usuarioBindingNavigator);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminUsuario";
            this.Text = "KitchenKitten";
            this.Load += new System.EventHandler(this.AdminUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingNavigator)).EndInit();
            this.usuarioBindingNavigator.ResumeLayout(false);
            this.usuarioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private masterDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator usuarioBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton usuarioBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox usuario_idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox correo_electronicoTextBox;
        private System.Windows.Forms.TextBox contraseñaTextBox;
        private System.Windows.Forms.DataGridView usuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}