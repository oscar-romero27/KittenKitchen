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
    public partial class Login : Form
    {
        SqlConnection conexion = new SqlConnection("server=(local)\\SQLEXPRESS;database=master;Integrated Security = SSPI");
        SqlCommand comandosql = new SqlCommand();

        public Login()
        {
            InitializeComponent();
            conexion.Open();
            comandosql.Connection = conexion;

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
        private void btRegistro_Click(object sender, EventArgs e)
        {
            Registrar reg = new Registrar();
            this.Visible = false;

            reg.ShowDialog();

            this.Dispose();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            bool isUser = false;
            bool isAdmin = false;

            Usuario usuario1 = new Usuario();
            string buffer_correo = tbCorreo.Text;
            string buffer_contraseña = generarHash(tbContra.Text);
            comandosql.CommandText = "SELECT usuario_id,nombre, apellidos,correo_electronico, contraseña FROM usuario";
            SqlDataReader midatareader = comandosql.ExecuteReader();
            while (midatareader.Read())
            {
                usuario1.usuario_id = midatareader.GetInt32(0);
                usuario1.nombre = midatareader.GetString(1);
                usuario1.apellidos = midatareader.GetString(2);
                usuario1.correo_electronico = midatareader.GetString(3);
                usuario1.contrasenia = midatareader.GetString(4);
                if (usuario1.correo_electronico == buffer_correo && usuario1.contrasenia == buffer_contraseña)
                {
                    isUser = true;
                    isAdmin = false;
                    break;
                }
                    
            }
            midatareader.Close();

            if (!isUser) { 
                comandosql.CommandText = "SELECT correo_electronico, contraseña FROM Administrador";
                midatareader = comandosql.ExecuteReader();
                while (midatareader.Read())
                {
                    usuario1.correo_electronico = midatareader.GetString(0);
                    usuario1.contrasenia = midatareader.GetString(1);
                    if (usuario1.correo_electronico == buffer_correo && usuario1.contrasenia == buffer_contraseña)
                    {
                        isAdmin = true;
                        isUser = false;
                        break;
                    }

                }
            }
            midatareader.Close();


            midatareader.Close();
            if(!(isUser || isAdmin))
            {
                MessageBox.Show("Error, correo electronico o contraseña erroneos, no se ha encontrado este usuario en el sistema.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (isUser)
                {
                    MenuUsuario usuario = new MenuUsuario(usuario1);
                    this.Visible = false;
                    conexion.Close();

                    usuario.ShowDialog();
                }
                if (isAdmin)
                {
                    MenuAdmin admin = new MenuAdmin();

                    this.Visible = false;
                    conexion.Close();

                    admin.ShowDialog();

                }


                this.Dispose();
            }

            
        }
    }
}
