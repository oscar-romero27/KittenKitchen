
namespace KitchenKitten
{
    partial class Pago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pago));
            this.dgvCompraFinal = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.btPagar = new System.Windows.Forms.Button();
            this.tbTotalPago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTitular = new System.Windows.Forms.TextBox();
            this.tbNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.tbFechaVenc = new System.Windows.Forms.TextBox();
            this.tbCVV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btEliminiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompraFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompraFinal
            // 
            this.dgvCompraFinal.AllowUserToAddRows = false;
            this.dgvCompraFinal.AllowUserToDeleteRows = false;
            this.dgvCompraFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompraFinal.Location = new System.Drawing.Point(14, 38);
            this.dgvCompraFinal.Margin = new System.Windows.Forms.Padding(5);
            this.dgvCompraFinal.Name = "dgvCompraFinal";
            this.dgvCompraFinal.ReadOnly = true;
            this.dgvCompraFinal.RowHeadersWidth = 51;
            this.dgvCompraFinal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompraFinal.Size = new System.Drawing.Size(546, 284);
            this.dgvCompraFinal.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 13);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Cesta de compras";
            // 
            // btPagar
            // 
            this.btPagar.BackColor = System.Drawing.Color.LightBlue;
            this.btPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btPagar.Location = new System.Drawing.Point(372, 456);
            this.btPagar.Margin = new System.Windows.Forms.Padding(5);
            this.btPagar.Name = "btPagar";
            this.btPagar.Size = new System.Drawing.Size(188, 49);
            this.btPagar.TabIndex = 14;
            this.btPagar.Text = "Realizar compra";
            this.btPagar.UseVisualStyleBackColor = false;
            this.btPagar.Click += new System.EventHandler(this.btPagar_Click);
            // 
            // tbTotalPago
            // 
            this.tbTotalPago.Location = new System.Drawing.Point(460, 330);
            this.tbTotalPago.Name = "tbTotalPago";
            this.tbTotalPago.ReadOnly = true;
            this.tbTotalPago.Size = new System.Drawing.Size(100, 30);
            this.tbTotalPago.TabIndex = 15;
            this.tbTotalPago.TabStop = false;
            this.tbTotalPago.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 333);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Total:";
            // 
            // tbTitular
            // 
            this.tbTitular.Location = new System.Drawing.Point(12, 363);
            this.tbTitular.Name = "tbTitular";
            this.tbTitular.Size = new System.Drawing.Size(306, 30);
            this.tbTitular.TabIndex = 17;
            // 
            // tbNumeroTarjeta
            // 
            this.tbNumeroTarjeta.Location = new System.Drawing.Point(14, 426);
            this.tbNumeroTarjeta.Name = "tbNumeroTarjeta";
            this.tbNumeroTarjeta.Size = new System.Drawing.Size(306, 30);
            this.tbNumeroTarjeta.TabIndex = 18;
            this.tbNumeroTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeroTarjeta_KeyPress);
            // 
            // tbFechaVenc
            // 
            this.tbFechaVenc.Location = new System.Drawing.Point(14, 478);
            this.tbFechaVenc.Name = "tbFechaVenc";
            this.tbFechaVenc.Size = new System.Drawing.Size(100, 30);
            this.tbFechaVenc.TabIndex = 19;
            // 
            // tbCVV
            // 
            this.tbCVV.Location = new System.Drawing.Point(220, 478);
            this.tbCVV.Name = "tbCVV";
            this.tbCVV.Size = new System.Drawing.Size(100, 30);
            this.tbCVV.TabIndex = 20;
            this.tbCVV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCVV_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 455);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Fecha de vencimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 455);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "CVV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 335);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Titular de tarjeta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 396);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Número de tarjeta";
            // 
            // btEliminiar
            // 
            this.btEliminiar.BackColor = System.Drawing.Color.LightBlue;
            this.btEliminiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btEliminiar.Location = new System.Drawing.Point(372, 389);
            this.btEliminiar.Margin = new System.Windows.Forms.Padding(5);
            this.btEliminiar.Name = "btEliminiar";
            this.btEliminiar.Size = new System.Drawing.Size(188, 49);
            this.btEliminiar.TabIndex = 25;
            this.btEliminiar.Text = "Eliminiar ingrediente";
            this.btEliminiar.UseVisualStyleBackColor = false;
            this.btEliminiar.Click += new System.EventHandler(this.btEliminiar_Click);
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(593, 553);
            this.Controls.Add(this.btEliminiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCVV);
            this.Controls.Add(this.tbFechaVenc);
            this.Controls.Add(this.tbNumeroTarjeta);
            this.Controls.Add(this.tbTitular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTotalPago);
            this.Controls.Add(this.btPagar);
            this.Controls.Add(this.dgvCompraFinal);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Pago";
            this.Text = "KitchenKitten";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompraFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompraFinal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btPagar;
        private System.Windows.Forms.TextBox tbTotalPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTitular;
        private System.Windows.Forms.TextBox tbNumeroTarjeta;
        private System.Windows.Forms.TextBox tbFechaVenc;
        private System.Windows.Forms.TextBox tbCVV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btEliminiar;
    }
}