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


namespace KitchenKitten
{
    public partial class Valoracion : Form
    {
        Button[] estrellas = new Button[5];
        Usuario usuarioActual;
        SqlConnection conexion = new SqlConnection("server=(local)\\SQLEXPRESS;database=master;Integrated Security = SSPI");
        SqlCommand comandosql = new SqlCommand();
        SqlTransaction mitransaccion;
        private int valoracion = 0;
        private int id_receta;

        public Valoracion(Usuario usuario,int idreceta)
        {
            InitializeComponent();
            usuarioActual = usuario;
            id_receta = idreceta;
            estrellas[0] = btEstrella1;
            estrellas[1] = btEstrella2;
            estrellas[2] = btEstrella3;
            estrellas[3] = btEstrella4;
            estrellas[4] = btEstrella5;
        }

        private void btEstrella1_Click(object sender, EventArgs e)
        {
            for(int i=0; i < 5; i++)
            {
                if(i < 1) estrellas[i].ImageIndex = 0;
                else estrellas[i].ImageIndex = 1;
            }
            valoracion = 1;

        }

        private void btEstrella2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                if (i < 2) estrellas[i].ImageIndex = 0;
                else estrellas[i].ImageIndex = 1;
            }
            valoracion = 2;

        }

        private void btEstrella3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                if (i < 3) estrellas[i].ImageIndex = 0;
                else estrellas[i].ImageIndex = 1;
            }
            valoracion = 3;

        }

        private void btEstrella4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                if (i < 4) estrellas[i].ImageIndex = 0;
                else estrellas[i].ImageIndex = 1;
            }
            valoracion = 4;

        }

        private void btEstrella5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                if (i < 5) estrellas[i].ImageIndex = 0;
                else estrellas[i].ImageIndex = 1;
            }
            valoracion = 5;

        }

        private void btConfReceta_Click(object sender, EventArgs e)
        {
            int valoracionid = getNewValoracionID() + 1;
            conexion.Open();

            mitransaccion = conexion.BeginTransaction();
            comandosql.Connection = conexion;
            comandosql.Transaction = mitransaccion;
            comandosql.CommandText = "INSERT INTO  dbo.Valoracion(valoracion_id, puntuacion, descripcion, usuario_id, receta_id) VALUES(" + valoracionid + "," + valoracion + ", '" + tbDescripcion.Text + "'," + usuarioActual.usuario_id + "," + id_receta + ")";
            int resultado = comandosql.ExecuteNonQuery();
            if (resultado < 0)
            {
                MessageBox.Show("Error, no se ha podido insertar la valoracion.", "Error de valoracion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mitransaccion.Commit();

            }
            conexion.Close();
            Dispose();
        }

        private int getNewValoracionID()
        {
            conexion.Open();
            int buffer = -1;
            comandosql.Connection = conexion;
            comandosql.CommandText = "SELECT count(valoracion_id) FROM Valoracion";
            SqlDataReader midatareader = comandosql.ExecuteReader();
            while (midatareader.Read())
            {
                buffer = midatareader.GetInt32(0);
            }
            midatareader.Close();
            conexion.Close();
            return buffer;
        }
    }
}
