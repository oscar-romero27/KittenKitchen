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
    public partial class MenuUsuario : Form
    {
        //Inicio de conexion con la base de datos
        SqlConnection conexion = new SqlConnection("server=(local)\\SQLEXPRESS;database=master;Integrated Security = SSPI");
        SqlCommand comandosql = new SqlCommand();
        public SqlTransaction mitransaccion;
        //Fin de inicio de conexion con la base de datos
        Usuario usuarioActual;
        
        public MenuUsuario(Usuario usuarioLoggeado)
        {
            InitializeComponent();
            usuarioActual = usuarioLoggeado;
            //Visualizar datos en Mi Perfil
            tbNombreUsuario.Text = usuarioActual.nombre;
            tbAppellidosUsuario.Text = usuarioActual.apellidos;
            tbCorreoUsuario.Text = usuarioActual.correo_electronico;

            //Mostrar recetas en el lbRecetas
            conexion.Open();
            comandosql.Connection = conexion;
            comandosql.CommandText = "SELECT nombre_receta FROM Receta";
            SqlDataReader midatareader = comandosql.ExecuteReader();
            string dato1;
            
            while (midatareader.Read())
            {
                dato1 = midatareader.GetString(0); //nombre de la receta
                lbRecetas.Items.Add(dato1);
                
            }
            midatareader.Close();
            conexion.Close();
            //Fin mostrar recetas en el lbrecetas
            cargarMiFrigo();






        }

        private void cargarMiFrigo()
        {
            try

            {
                //Guardar los elementos de la tabla Usuario_compra_ingrediente en un datagrid view, pasamos los ingredientes que ha comprado dicho usuario al mismo.
                //MIS INGREDIENTES
                conexion.Open();
                comandosql.Connection = conexion;
                comandosql.CommandText = "SELECT i.Nombre, i.Unidad, i.Cantidad, u.fec_compra 'Fecha de compra' , u.fec_cad 'Fecha de caducidad', u.cantidad 'Numero de ingredientes' FROM Usuario_compra_ingrediente u, Ingrediente i where u.usuario_id = " + usuarioActual.usuario_id + "" + " AND i.Id_ingrediente = u.ingrediente_id";
                SqlDataAdapter da = new SqlDataAdapter(comandosql);

                DataTable data = new DataTable();


                da.Fill(data);
                da.Dispose();
                conexion.Close();


                dgvMisIngredientes.DataSource = data;
                //FIN MIS INGREDIENTES

                //Guardar los elementos de la tabla Usuario_compraHabitual_ingrediente en un datagrid view, pasamos los ingredientes que ha comprado dicho usuario al mismo. 

                //COMPRA HABITUAL
                Cargar_Compra_Habitual();
                //FIN COMPRA HABITUAL
            }

            catch

            {

                MessageBox.Show("El usuario no tiene ingredientes comprados");

            }
        }

        private void MenuUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Ingrediente' Puede moverla o quitarla según sea necesario.
            this.ingredienteTableAdapter.Fill(this.masterDataSet.Ingrediente);
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Ingrediente_tiene_Receta' Puede moverla o quitarla según sea necesario.
            this.ingrediente_tiene_RecetaTableAdapter.Fill(this.masterDataSet.Ingrediente_tiene_Receta);
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Receta' Puede moverla o quitarla según sea necesario.
            this.recetaTableAdapter.Fill(this.masterDataSet.Receta);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(dgvCestaDeCompras.Rows.Count == 0)
            {
                MessageBox.Show("No hay nada en la lista de la compra");
                return;
            }
            try
            {
                Pago pagoDialog = new Pago(usuarioActual, dgvCestaDeCompras);

                //this.Visible = false;

                pagoDialog.ShowDialog();
            }
            catch
            {
                MessageBox.Show("error al abrir el pago");
            }
            //this.Dispose();

        }

        private void btConfReceta_Click(object sender, EventArgs e)
        {
            conexion.Open();
            comandosql.Connection = conexion;
            comandosql.CommandText = "SELECT receta_id FROM Receta WHERE nombre_receta='"+lbRecetas.SelectedItem.ToString() +"'";
            SqlDataReader midatareader3 = comandosql.ExecuteReader();
            
            int id_receta=0;

            while (midatareader3.Read())
            {
                id_receta = midatareader3.GetInt32(0); //nombre de la receta
                

            }
            midatareader3.Close();
            conexion.Close();

            Receta recetaDialog = new Receta(id_receta, usuarioActual);

            //this.Visible = false;

            recetaDialog.ShowDialog();

            //this.Dispose();

        }

        private void btRealizarCompraHabitual_Click(object sender, EventArgs e)
        {
            Pago pagoDialog = new Pago(usuarioActual,dgvCompraHabitual);

            //this.Visible = false;

            pagoDialog.ShowDialog();

            //this.Dispose();
        }
        
        private void lbRecetas_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Inicio mostrar descripcion de receta

            conexion.Open();
            comandosql.Connection = conexion;
            comandosql.CommandText = "SELECT descripcion_receta FROM Receta WHERE nombre_receta= '" + lbRecetas.SelectedItem.ToString() + "'";
            SqlDataReader midatareader2 = comandosql.ExecuteReader();
            string dato2;

            while (midatareader2.Read())
            {
                dato2 = midatareader2.GetString(0); //descripcion de la receta
                string text = dato2;
                string[] separatingStrings = { "::" };
                string[] frases = text.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
                tbDescripcion.Text = frases[0];
            }
            midatareader2.Close();
            conexion.Close();
            //Fin mostrar descripcion de receta
            


        }

        /*
        * Tab de control de compra
        */


        /*
         * Boton añadir a la cesta 
         * 
         */
        private void button4_Click(object sender, EventArgs e)
        {
            //si no hay ninguna celda seleccionada no hace nada.
           if(dgvCompraIngredientes.SelectedCells.Count == 0)
            {
                return;
            }
           //solo permite seleccionar filas enteras, de esta forma nos movemos por las que se han seleccionado
            for (int nRows = 0; nRows < dgvCompraIngredientes.SelectedRows.Count; nRows++) {
                
                int iRow = dgvCompraIngredientes.SelectedRows[nRows].Index;
                List<string> NuevoIngrediente = new List<string>();
                for (int iCol = 0; iCol < dgvCompraIngredientes.Columns.Count; iCol++)
                {
                    NuevoIngrediente.Add(dgvCompraIngredientes.Rows[iRow].Cells[iCol].Value.ToString());

                }
                //se añade la fila completa a la cesta
                 dgvCestaDeCompras.Rows.Add(NuevoIngrediente.ToArray());
            }
        }

        //cuando se añade una o mas filas a la cesta
        private void dgvCestaDeCompras_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int index = e.RowIndex; index <= e.RowIndex + e.RowCount - 1; index++)
            {
                DataGridViewRow row = dgvCestaDeCompras.Rows[index];
                float precio = float.Parse(row.Cells[4].Value.ToString());
                float total = float.Parse(tbTotal.Text);
                total = total + precio; 
                tbTotal.Text = total.ToString(); //actualiza el textbox donde se almacena el total
            }
        }

        private void btnEliminarCesta_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow iRow in dgvCestaDeCompras.SelectedRows)
            {
                float precio = float.Parse(iRow.Cells[4].Value.ToString());
                float total = float.Parse(tbTotal.Text);
                total = total - precio;
                tbTotal.Text = total.ToString();
                dgvCestaDeCompras.Rows.RemoveAt(iRow.Index);
               
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {

            var select = "SELECT * FROM Ingrediente WHERE nombre Like \'%" +txtbBuscarIngrediente.Text + "%\'";
            //var c = new SqlConnection(conexion.ConnectionString); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, conexion);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();

            try
            {
                dataAdapter.Fill(ds);
                //dataGridView1.ReadOnly = true;
                dgvCompraIngredientes.DataSource = ds.Tables[0];
                //dgvCompraIngredientes.DataSource ;
            }
            catch
            {
                MessageBox.Show("Error al buscar");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dgvCompraIngredientes.SelectedRows.Count ==0) //si no hay seleccionado ninguna fila para añadir
            {
                return;
            }

            //se abre una conexion para buscar el ingrediente en la tabla de comprahHabitual
           
            
            foreach(DataGridViewRow iRow in dgvCompraIngredientes.SelectedRows)
            {
                    conexion.Open();
                    mitransaccion = conexion.BeginTransaction();
                    comandosql.Connection = conexion;
                    comandosql.Transaction = mitransaccion;
                Random rnd = new Random();
                int month = rnd.Next(1, 13);
                //MessageBox.Show("se han añadido estos meses     " + month + " la fecha actual es: "+ DateTime.Now.ToString("yyyy-MM-dd") + "la fecha de caducidad es:   "+ DateTime.Now.AddMonths(month).ToString("yyyy-MM-dd"));
                comandosql.CommandText = "INSERT INTO [dbo].[Usuario_compraHabitual_Ingrediente] ([ingrediente_id], [usuario_id], [fec_compra], [fec_cad]) VALUES ( \'" + iRow.Cells[0].Value + "\' ,  \'"+ usuarioActual.usuario_id+ "\' , \'"+ DateTime.Now.ToString("yyyy-MM-dd") +"\', \'"+ DateTime.Now.AddMonths(month).ToString("yyyy-MM-dd") + "\')";
                   
                try
                      {
                        comandosql.ExecuteNonQuery();
                        mitransaccion.Commit();
                        mitransaccion.Dispose();
                        conexion.Close();
                     }
                    catch(Exception ex)
                    {

                   MessageBox.Show("Ha habido un error con el insert ->"+ ex.Message);
                    mitransaccion.Rollback();
                    mitransaccion.Dispose();
                    conexion.Close();
                    }
                
            }
            Cargar_Compra_Habitual();
        }
        public void Cargar_Compra_Habitual()
        {
            conexion.Open();
            comandosql.Connection = conexion;
            comandosql.CommandText = "SELECT i.id_ingrediente , i.nombre, i.cantidad, i.unidad, i.precio, i.tipo FROM Usuario_compraHabitual_Ingrediente u, Ingrediente i where u.usuario_id = " + usuarioActual.usuario_id + "" + " AND i.Id_ingrediente = u.ingrediente_id";
            SqlDataAdapter dat = new SqlDataAdapter(comandosql);
            DataTable dato = new DataTable();
            dat.Fill(dato);
            dat.Dispose();
            conexion.Close();


            dgvCompraHabitual.DataSource = dato;
            dgvCompraHabitual.Columns[0].Visible = false;
        }

        private void btnEliminarDeHabitual_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow iRow in dgvCompraHabitual.SelectedRows)
            {
                conexion.Open();
                mitransaccion = conexion.BeginTransaction();
                comandosql.Connection = conexion;
                comandosql.Transaction = mitransaccion;
                
                comandosql.CommandText = "DELETE FROM [dbo].[Usuario_compraHabitual_Ingrediente] WHERE INGREDIENTE_ID  = \'" + iRow.Cells[0].Value + "\' AND  usuario_id = \'" + usuarioActual.usuario_id + "\'";

                try
                {
                    comandosql.ExecuteNonQuery();
                    mitransaccion.Commit();
                    mitransaccion.Dispose();
                    conexion.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ha habido un error con el insert ->" + ex.Message);
                    mitransaccion.Rollback();
                    mitransaccion.Dispose();
                    conexion.Close();
                }

            }
            Cargar_Compra_Habitual();
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


        private void actualizarDatosUsuario(string col, string dato)
        {
            conexion.Open();
            mitransaccion = conexion.BeginTransaction();
            comandosql.Connection = conexion;
            comandosql.Transaction = mitransaccion;

            comandosql.CommandText = "UPDATE [dbo].[Usuario] SET " + col + " = '" + dato + "' WHERE usuario_id =" + usuarioActual.usuario_id + "";

            try
            {
                comandosql.ExecuteNonQuery();
                mitransaccion.Commit();
                mitransaccion.Dispose();
                conexion.Close();
                MessageBox.Show("Se ha cambiado correctamente");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha habido un error con la actualizacion de datos ->" + ex.Message);
                mitransaccion.Rollback();
                mitransaccion.Dispose();
                conexion.Close();
                MessageBox.Show("Ha habido un error");
            }
        }

        // BOTONES DE CAMBIO DE DATOS
        private void button3_Click(object sender, EventArgs e)
        {
            usuarioActual.contrasenia = generarHash(tbContraUsuario.Text);
            actualizarDatosUsuario("contraseña", usuarioActual.contrasenia);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usuarioActual.correo_electronico = tbCorreoUsuario.Text;
            actualizarDatosUsuario("correo_electronico", usuarioActual.correo_electronico);

        }

  

        private void btLogin_Click(object sender, EventArgs e)
        {
            usuarioActual.nombre = tbNombreUsuario.Text;
            actualizarDatosUsuario("nombre", usuarioActual.nombre);

        }

    
        private void btnCambiarApellido_Click(object sender, EventArgs e)
        {
               usuarioActual.apellidos = tbAppellidosUsuario.Text;
            actualizarDatosUsuario("apellidos", usuarioActual.apellidos);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarMiFrigo();
        }
    }
}
