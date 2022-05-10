
namespace KitchenKitten
{
    partial class Valoracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Valoracion));
            this.btConfReceta = new System.Windows.Forms.Button();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btEstrella1 = new System.Windows.Forms.Button();
            this.ilEstrellas = new System.Windows.Forms.ImageList(this.components);
            this.btEstrella2 = new System.Windows.Forms.Button();
            this.btEstrella3 = new System.Windows.Forms.Button();
            this.btEstrella4 = new System.Windows.Forms.Button();
            this.btEstrella5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btConfReceta
            // 
            this.btConfReceta.BackColor = System.Drawing.Color.LightBlue;
            this.btConfReceta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfReceta.Location = new System.Drawing.Point(174, 449);
            this.btConfReceta.Name = "btConfReceta";
            this.btConfReceta.Size = new System.Drawing.Size(233, 62);
            this.btConfReceta.TabIndex = 7;
            this.btConfReceta.Text = "Realizar valoración";
            this.btConfReceta.UseVisualStyleBackColor = false;
            this.btConfReceta.Click += new System.EventHandler(this.btConfReceta_Click);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BackColor = System.Drawing.Color.SteelBlue;
            this.tbDescripcion.Location = new System.Drawing.Point(12, 129);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(571, 301);
            this.tbDescripcion.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 106);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Comentarios";
            // 
            // btEstrella1
            // 
            this.btEstrella1.BackColor = System.Drawing.Color.SteelBlue;
            this.btEstrella1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEstrella1.ForeColor = System.Drawing.Color.SteelBlue;
            this.btEstrella1.ImageIndex = 1;
            this.btEstrella1.ImageList = this.ilEstrellas;
            this.btEstrella1.Location = new System.Drawing.Point(74, 28);
            this.btEstrella1.Margin = new System.Windows.Forms.Padding(5);
            this.btEstrella1.Name = "btEstrella1";
            this.btEstrella1.Size = new System.Drawing.Size(78, 64);
            this.btEstrella1.TabIndex = 0;
            this.btEstrella1.UseVisualStyleBackColor = false;
            this.btEstrella1.Click += new System.EventHandler(this.btEstrella1_Click);
            // 
            // ilEstrellas
            // 
            this.ilEstrellas.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilEstrellas.ImageStream")));
            this.ilEstrellas.TransparentColor = System.Drawing.Color.SteelBlue;
            this.ilEstrellas.Images.SetKeyName(0, "llena.png");
            this.ilEstrellas.Images.SetKeyName(1, "vacia.png");
            // 
            // btEstrella2
            // 
            this.btEstrella2.BackColor = System.Drawing.Color.SteelBlue;
            this.btEstrella2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEstrella2.ForeColor = System.Drawing.Color.SteelBlue;
            this.btEstrella2.ImageIndex = 1;
            this.btEstrella2.ImageList = this.ilEstrellas;
            this.btEstrella2.Location = new System.Drawing.Point(162, 28);
            this.btEstrella2.Margin = new System.Windows.Forms.Padding(5);
            this.btEstrella2.Name = "btEstrella2";
            this.btEstrella2.Size = new System.Drawing.Size(78, 64);
            this.btEstrella2.TabIndex = 14;
            this.btEstrella2.UseVisualStyleBackColor = false;
            this.btEstrella2.Click += new System.EventHandler(this.btEstrella2_Click);
            // 
            // btEstrella3
            // 
            this.btEstrella3.BackColor = System.Drawing.Color.SteelBlue;
            this.btEstrella3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEstrella3.ForeColor = System.Drawing.Color.SteelBlue;
            this.btEstrella3.ImageIndex = 1;
            this.btEstrella3.ImageList = this.ilEstrellas;
            this.btEstrella3.Location = new System.Drawing.Point(250, 28);
            this.btEstrella3.Margin = new System.Windows.Forms.Padding(5);
            this.btEstrella3.Name = "btEstrella3";
            this.btEstrella3.Size = new System.Drawing.Size(78, 64);
            this.btEstrella3.TabIndex = 15;
            this.btEstrella3.UseVisualStyleBackColor = false;
            this.btEstrella3.Click += new System.EventHandler(this.btEstrella3_Click);
            // 
            // btEstrella4
            // 
            this.btEstrella4.BackColor = System.Drawing.Color.SteelBlue;
            this.btEstrella4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEstrella4.ForeColor = System.Drawing.Color.SteelBlue;
            this.btEstrella4.ImageIndex = 1;
            this.btEstrella4.ImageList = this.ilEstrellas;
            this.btEstrella4.Location = new System.Drawing.Point(338, 28);
            this.btEstrella4.Margin = new System.Windows.Forms.Padding(5);
            this.btEstrella4.Name = "btEstrella4";
            this.btEstrella4.Size = new System.Drawing.Size(78, 64);
            this.btEstrella4.TabIndex = 16;
            this.btEstrella4.UseVisualStyleBackColor = false;
            this.btEstrella4.Click += new System.EventHandler(this.btEstrella4_Click);
            // 
            // btEstrella5
            // 
            this.btEstrella5.BackColor = System.Drawing.Color.SteelBlue;
            this.btEstrella5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEstrella5.ForeColor = System.Drawing.Color.SteelBlue;
            this.btEstrella5.ImageIndex = 1;
            this.btEstrella5.ImageList = this.ilEstrellas;
            this.btEstrella5.Location = new System.Drawing.Point(426, 28);
            this.btEstrella5.Margin = new System.Windows.Forms.Padding(5);
            this.btEstrella5.Name = "btEstrella5";
            this.btEstrella5.Size = new System.Drawing.Size(78, 64);
            this.btEstrella5.TabIndex = 17;
            this.btEstrella5.UseVisualStyleBackColor = false;
            this.btEstrella5.Click += new System.EventHandler(this.btEstrella5_Click);
            // 
            // Valoracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(595, 523);
            this.Controls.Add(this.btEstrella5);
            this.Controls.Add(this.btEstrella4);
            this.Controls.Add(this.btEstrella3);
            this.Controls.Add(this.btEstrella2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btConfReceta);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.btEstrella1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Valoracion";
            this.Text = "Valoracion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btConfReceta;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btEstrella1;
        private System.Windows.Forms.ImageList ilEstrellas;
        private System.Windows.Forms.Button btEstrella2;
        private System.Windows.Forms.Button btEstrella3;
        private System.Windows.Forms.Button btEstrella4;
        private System.Windows.Forms.Button btEstrella5;
    }
}