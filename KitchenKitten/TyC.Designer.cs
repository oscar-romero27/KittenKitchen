
namespace KitchenKitten
{
    partial class TyC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TyC));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btRealizarCompraHabitual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(429, 386);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // btRealizarCompraHabitual
            // 
            this.btRealizarCompraHabitual.BackColor = System.Drawing.Color.LightBlue;
            this.btRealizarCompraHabitual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRealizarCompraHabitual.Location = new System.Drawing.Point(167, 404);
            this.btRealizarCompraHabitual.Name = "btRealizarCompraHabitual";
            this.btRealizarCompraHabitual.Size = new System.Drawing.Size(109, 40);
            this.btRealizarCompraHabitual.TabIndex = 5;
            this.btRealizarCompraHabitual.Text = "Vale";
            this.btRealizarCompraHabitual.UseVisualStyleBackColor = false;
            this.btRealizarCompraHabitual.Click += new System.EventHandler(this.btRealizarCompraHabitual_Click);
            // 
            // TyC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(453, 456);
            this.Controls.Add(this.btRealizarCompraHabitual);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TyC";
            this.Text = "TyC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btRealizarCompraHabitual;
    }
}