using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace KitchenKitten
{
    public partial class Registrar : Form
    {
        SqlConnection conexion = new SqlConnection("server=(local)\\SQLEXPRESS;database=master;Integrated Security = SSPI");
        SqlCommand comandosql = new SqlCommand();
        SqlTransaction mitransaccion;


        public Registrar()
        {
            InitializeComponent();
            conexion.Open();
        }
        private string generarHash(string pass)
        {
            string hash;
            using (SHA1 sha1Hash = SHA1.Create())
            {
                //From String to byte array
                byte[] sourceBytes = Encoding.UTF8.GetBytes(pass);
                byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
            }
            return hash;
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            FormInicio inicio = new FormInicio();
            this.Visible = false;

            inicio.ShowDialog();
            
            this.Dispose();
        }

        private void btRegistro_Click(object sender, EventArgs e)
        {
            if (tbContra.Text != tbConfContra.Text)
            {
                MessageBox.Show("Error, las contraseñas no coinciden, vuelve a intentar.", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbContra.Text = "";
                tbConfContra.Text = "";

            }
            else if(!cbTOS.Checked)
            {
                MessageBox.Show("Por favor aceptar nuestros terminos de uso.", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbContra.Text = "";
                tbConfContra.Text = "";

            }
            else {
                int user_id = getNewUserID() + 1;
                string hash = generarHash(tbContra.Text);

                string[] datos_usuario = new string[] { tbNombre.Text, tbApellidos.Text, tbCorreo.Text, hash };


                mitransaccion = conexion.BeginTransaction();
                comandosql.Connection = conexion;
                comandosql.Transaction = mitransaccion;
                comandosql.CommandText = "INSERT INTO  dbo.Usuario(usuario_id, nombre, apellidos, correo_electronico, contraseña) VALUES("+user_id+",'" +datos_usuario[0]+"', '" + datos_usuario[1] + "','" + datos_usuario[2] + "','" + datos_usuario[3] + "')";
                try
                {
                    comandosql.ExecuteNonQuery();

                    mitransaccion.Commit();
                    MessageBox.Show("Usuario registrado exitosamente!", "Confirmacion de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btCancelar_Click(sender, e);
                }
                catch
                {
                    MessageBox.Show("Error, no se ha podido registrar el usuario, verifica los datos y prueba otra vez.", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                
            }
        }

        private int getNewUserID()
        {
            int buffer = -1;
            comandosql.Connection = conexion;
            comandosql.CommandText = "SELECT max(usuario_id) FROM usuario";
            try
            {
                SqlDataReader midatareader = comandosql.ExecuteReader();
                while (midatareader.Read())
                {
                    buffer = midatareader.GetInt32(0);
                }
                midatareader.Close();
            }
            catch
            {
            }
            
            return buffer;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TyC tc = new TyC();
            tc.ShowDialog();
        }
    }
}
