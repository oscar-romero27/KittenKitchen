
namespace KitchenKitten
{
    partial class CargarHistórico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargarHistórico));
            this.dgvHistoricodeCompras = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoricodeCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistoricodeCompras
            // 
            this.dgvHistoricodeCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoricodeCompras.Location = new System.Drawing.Point(114, 93);
            this.dgvHistoricodeCompras.Name = "dgvHistoricodeCompras";
            this.dgvHistoricodeCompras.RowHeadersWidth = 51;
            this.dgvHistoricodeCompras.RowTemplate.Height = 24;
            this.dgvHistoricodeCompras.Size = new System.Drawing.Size(734, 352);
            this.dgvHistoricodeCompras.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Visualizar el histórico de compras";
            // 
            // CargarHistórico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(967, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHistoricodeCompras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CargarHistórico";
            this.Text = "CargarHistórico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoricodeCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistoricodeCompras;
        private System.Windows.Forms.Label label1;
    }
}