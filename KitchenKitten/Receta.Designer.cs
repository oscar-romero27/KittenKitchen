
namespace KitchenKitten
{
    partial class Receta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receta));
            this.btImprimir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbPasos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btVideoReceta = new System.Windows.Forms.Button();
            this.listViewIngredientes = new System.Windows.Forms.ListView();
            this.Ingredientes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btImprimir
            // 
            this.btImprimir.BackColor = System.Drawing.Color.LightBlue;
            this.btImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btImprimir.Location = new System.Drawing.Point(637, 479);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(233, 62);
            this.btImprimir.TabIndex = 9;
            this.btImprimir.Text = "Imprimir receta";
            this.btImprimir.UseVisualStyleBackColor = false;
            this.btImprimir.Click += new System.EventHandler(this.btConfReceta_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbPasos);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(281, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 429);
            this.panel1.TabIndex = 8;
            // 
            // tbPasos
            // 
            this.tbPasos.BackColor = System.Drawing.Color.SteelBlue;
            this.tbPasos.Location = new System.Drawing.Point(17, 56);
            this.tbPasos.Multiline = true;
            this.tbPasos.Name = "tbPasos";
            this.tbPasos.ReadOnly = true;
            this.tbPasos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbPasos.Size = new System.Drawing.Size(571, 372);
            this.tbPasos.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Pasos";
            // 
            // btVideoReceta
            // 
            this.btVideoReceta.BackColor = System.Drawing.Color.LightBlue;
            this.btVideoReceta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVideoReceta.Location = new System.Drawing.Point(281, 479);
            this.btVideoReceta.Name = "btVideoReceta";
            this.btVideoReceta.Size = new System.Drawing.Size(233, 62);
            this.btVideoReceta.TabIndex = 10;
            this.btVideoReceta.Text = "Ver video de receta";
            this.btVideoReceta.UseVisualStyleBackColor = false;
            this.btVideoReceta.Click += new System.EventHandler(this.btVideoReceta_Click);
            // 
            // listViewIngredientes
            // 
            this.listViewIngredientes.BackColor = System.Drawing.Color.MidnightBlue;
            this.listViewIngredientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ingredientes});
            this.listViewIngredientes.ForeColor = System.Drawing.Color.Red;
            this.listViewIngredientes.HideSelection = false;
            this.listViewIngredientes.Location = new System.Drawing.Point(1, 39);
            this.listViewIngredientes.Name = "listViewIngredientes";
            this.listViewIngredientes.Size = new System.Drawing.Size(226, 515);
            this.listViewIngredientes.TabIndex = 11;
            this.listViewIngredientes.UseCompatibleStateImageBehavior = false;
            this.listViewIngredientes.View = System.Windows.Forms.View.Details;
            // 
            // Ingredientes
            // 
            this.Ingredientes.Text = "Ingredientes";
            this.Ingredientes.Width = 218;
            // 
            // Receta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(887, 553);
            this.Controls.Add(this.listViewIngredientes);
            this.Controls.Add(this.btVideoReceta);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Receta";
            this.Text = "KitchenKitten";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbPasos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btVideoReceta;
        private System.Windows.Forms.ListView listViewIngredientes;
        private System.Windows.Forms.ColumnHeader Ingredientes;
    }
}