
namespace KitchenKitten
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbContra = new System.Windows.Forms.TextBox();
            this.btRegistro = new System.Windows.Forms.Button();
            this.btAcceder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo Electronico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(320, 94);
            this.tbCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(313, 22);
            this.tbCorreo.TabIndex = 3;
            // 
            // tbContra
            // 
            this.tbContra.Location = new System.Drawing.Point(320, 164);
            this.tbContra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbContra.Name = "tbContra";
            this.tbContra.Size = new System.Drawing.Size(313, 22);
            this.tbContra.TabIndex = 4;
            this.tbContra.UseSystemPasswordChar = true;
            // 
            // btRegistro
            // 
            this.btRegistro.BackColor = System.Drawing.Color.LightBlue;
            this.btRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRegistro.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegistro.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold);
            this.btRegistro.Location = new System.Drawing.Point(-11, 309);
            this.btRegistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btRegistro.Name = "btRegistro";
            this.btRegistro.Size = new System.Drawing.Size(337, 107);
            this.btRegistro.TabIndex = 5;
            this.btRegistro.Text = "Registrarse";
            this.btRegistro.UseVisualStyleBackColor = false;
            this.btRegistro.Click += new System.EventHandler(this.btRegistro_Click);
            // 
            // btAcceder
            // 
            this.btAcceder.BackColor = System.Drawing.Color.LightBlue;
            this.btAcceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAcceder.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAcceder.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold);
            this.btAcceder.Location = new System.Drawing.Point(320, 309);
            this.btAcceder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAcceder.Name = "btAcceder";
            this.btAcceder.Size = new System.Drawing.Size(339, 107);
            this.btAcceder.TabIndex = 6;
            this.btAcceder.Text = "Acceder";
            this.btAcceder.UseVisualStyleBackColor = false;
            this.btAcceder.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(272, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 45);
            this.label3.TabIndex = 7;
            this.label3.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(651, 410);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btAcceder);
            this.Controls.Add(this.btRegistro);
            this.Controls.Add(this.tbContra);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbContra;
        private System.Windows.Forms.Button btRegistro;
        private System.Windows.Forms.Button btAcceder;
        private System.Windows.Forms.Label label3;
    }
}