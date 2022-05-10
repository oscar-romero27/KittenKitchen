
namespace KitchenKitten
{
    partial class FormInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btRegistro = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btRegistro
            // 
            this.btRegistro.BackColor = System.Drawing.Color.LightBlue;
            this.btRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRegistro.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegistro.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold);
            this.btRegistro.Location = new System.Drawing.Point(-7, 370);
            this.btRegistro.Name = "btRegistro";
            this.btRegistro.Size = new System.Drawing.Size(253, 87);
            this.btRegistro.TabIndex = 1;
            this.btRegistro.Text = "Registrarse";
            this.btRegistro.UseVisualStyleBackColor = false;
            this.btRegistro.Click += new System.EventHandler(this.btRegistro_Click);
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.LightBlue;
            this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogin.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold);
            this.btLogin.Location = new System.Drawing.Point(243, 370);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(254, 87);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Acceder";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold);
            this.richTextBox1.Location = new System.Drawing.Point(129, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(231, 64);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Kitchen Kitten";
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(493, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.btRegistro);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInicio";
            this.Text = "KitchenKitten";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btRegistro;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

