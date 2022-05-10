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
    public partial class CargarHistórico : Form
    {
        SqlConnection conexion = new SqlConnection("server=(local)\\SQLEXPRESS;database=master;Integrated Security = SSPI");
        SqlCommand comandosql = new SqlCommand();
        public SqlTransaction mitransaccion;
        //Fin de inicio de conexion con la base de datos
        public CargarHistórico()
        {
            InitializeComponent();
            try

            {
                //Guardar los elementos de la tabla Usuario_compra_ingrediente en un datagrid view, pasamos los ingredientes que ha comprado dicho usuario al mismo.
                //MIS INGREDIENTES
                conexion.Open();
                comandosql.Connection = conexion;
                comandosql.CommandText = "SELECT h.ingrediente_id, h.usuario_id, i.nombre, u.nombre, h.fec_compra FROM Historico_compra h, Ingrediente i, Usuario u where i.Id_ingrediente=h.ingrediente_id and u.usuario_id=h.usuario_id";
                SqlDataAdapter da = new SqlDataAdapter(comandosql);

                DataTable data = new DataTable();


                da.Fill(data);
                da.Dispose();
                conexion.Close();


                dgvHistoricodeCompras.DataSource = data;
            }
            catch

            {

                MessageBox.Show("El usuario no tiene ingredientes comprados");

            }

        }
    }
}
