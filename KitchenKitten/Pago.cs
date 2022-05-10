using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitchenKitten
{


    public partial class Pago : Form
    {
        //Inicio de conexion con la base de datos
        SqlConnection conexion = new SqlConnection("server=(local)\\SQLEXPRESS;database=master;Integrated Security = SSPI");
        SqlCommand comandosql = new SqlCommand();
        public SqlTransaction mitransaccion;
        Usuario usuarioActual;
        
        public Pago(Usuario usuario, DataGridView dgv)
        {
            InitializeComponent();
           
            usuarioActual = usuario;
            copiarDGV(dgv);
            try
            {
                calcularPago();
            }catch(Exception ex)
            {
                MessageBox.Show("ha habido un error -> " + ex.Message);
            }
        }

        private void calcularPago()
        {
            foreach(DataGridViewRow row in dgvCompraFinal.Rows)
            {
                float precio = float.Parse(row.Cells[4].Value.ToString());
                float total = float.Parse(tbTotalPago.Text);
                total = total + precio;
                tbTotalPago.Text = total.ToString(); //actualiza el textbox donde se almacena el total
            }
        }

        private void copiarDGV(DataGridView dgv)
        {

            try
            {
                if (dgvCompraFinal.Columns.Count == 0)
                {
                    foreach (DataGridViewColumn dgvc in dgv.Columns)
                    {
                        dgvCompraFinal.Columns.Add(dgvc.Clone() as DataGridViewColumn);
                    }
                }

                DataGridViewRow row = new DataGridViewRow();

                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    row = (DataGridViewRow)dgv.Rows[i].Clone();
                    int intColIndex = 0;
                    foreach (DataGridViewCell cell in dgv.Rows[i].Cells)
                    {
                        row.Cells[intColIndex].Value = cell.Value;
                        intColIndex++;
                    }
                    dgvCompraFinal.Rows.Add(row);
                }
                dgvCompraFinal.AllowUserToAddRows = false;
                dgvCompraFinal.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ha habido un error -> " + ex.Message);
                this.Dispose();
            }
            
        }

        private void abrir_conexion()
        {
            conexion.Open();
            mitransaccion = conexion.BeginTransaction();
            comandosql.Connection = conexion;
            comandosql.Transaction = mitransaccion;
        }
        private void cerrar_conexion()
        {
            mitransaccion.Dispose();
            conexion.Close();
        }
        private void btPagar_Click(object sender, EventArgs e)
        {
            /*
            var frm = Form.ActiveForm;
            using (var bmp = new Bitmap(frm.Width, frm.Height))
            {
                frm.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@"..\screenshot.png");
            }
            */
            if (string.IsNullOrEmpty(tbCVV.Text) || string.IsNullOrEmpty(tbFechaVenc.Text) || string.IsNullOrEmpty(tbNumeroTarjeta.Text) || string.IsNullOrEmpty(tbTitular.Text))
            {
                MessageBox.Show("Hay campos vacios");
                return;
            }
           
            foreach (DataGridViewRow iRow in dgvCompraFinal.Rows)
            {
               
                Random rnd = new Random();
                int month = rnd.Next(1, 13);

               
                abrir_conexion();
                try
                {
                    
                    comandosql.CommandText = "INSERT INTO [dbo].[Usuario_compra_ingrediente] ([ingrediente_id], [usuario_id], [fec_compra], [fec_cad]) VALUES ( \'" + iRow.Cells[0].Value + "\' ,  \'" + usuarioActual.usuario_id + "\' , \'" + DateTime.Now.ToString("yyyy-MM-dd") + "\', \'" + DateTime.Now.AddMonths(month).ToString("yyyy-MM-dd") + "\')";
                    comandosql.ExecuteNonQuery();
                    mitransaccion.Commit();
                    cerrar_conexion();
                }
                catch (Exception ex) // si ocurre una excepcion es por que ya existe 
                {

                    //MessageBox.Show("eroor al insertar -> " + ex.Message);
                    try
                    {
                        comandosql.CommandText = "UPDATE [dbo].[Usuario_compra_ingrediente] SET cantidad = cantidad +1  WHERE ingrediente_id = \'"+ iRow.Cells[0].Value +"\' AND usuario_id = \'" + usuarioActual.usuario_id +"\'";
                        comandosql.ExecuteNonQuery();
                        mitransaccion.Commit();
                        cerrar_conexion();
                    }
                    catch
                    {
                        MessageBox.Show("Ha habido un error con el insert ->" + ex.Message);
                        mitransaccion.Rollback();
                        cerrar_conexion();
                    }


                }
                
                

            }
            foreach (DataGridViewRow iRow2 in dgvCompraFinal.Rows)
            {
                conexion.Open();
                mitransaccion = conexion.BeginTransaction();
                comandosql.Connection = conexion;
                comandosql.Transaction = mitransaccion;
                Random rnd1 = new Random();
                int month1 = rnd1.Next(1, 13);
                //MessageBox.Show("se han añadido estos meses     " + month1 + " la fecha actual es: "+ DateTime.Now.ToString("yyyy-MM-dd") + "la fecha de caducidad es:   "+ DateTime.Now.AddMonths(month1).ToString("yyyy-MM-dd"));
                comandosql.CommandText = "INSERT INTO [dbo].[Historico_compra] ([ingrediente_id], [usuario_id], [fec_compra], [fec_cad]) VALUES ( '" + iRow2.Cells[0].Value + "' ,  '" + usuarioActual.usuario_id + "' , '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.AddMonths(month1).ToString("yyyy-MM-dd") + "')";

                try
                {
                    comandosql.ExecuteNonQuery();
                    mitransaccion.Commit();
                    mitransaccion.Dispose();
                    conexion.Close();
                }
                catch (Exception ex1)
                {

                    MessageBox.Show("Ha habido un error con el insert ->" + ex1.Message);
                    mitransaccion.Rollback();
                    mitransaccion.Dispose();
                    conexion.Close();
                }
            }

            ImprimirPDF pdf = new ImprimirPDF(dgvCompraFinal, usuarioActual, float.Parse(tbTotalPago.Text));
            Dispose();
        }

        private void btEliminiar_Click(object sender, EventArgs e)
        {
            if (dgvCompraFinal.Rows.Count == 0)
            {
                MessageBox.Show("no Queda nada para comprar");
                this.Dispose();
            }
            foreach (DataGridViewRow iRow in dgvCompraFinal.SelectedRows)
            {
                float precio = float.Parse(iRow.Cells[4].Value.ToString());
                float total = float.Parse(tbTotalPago.Text);
                total = total - precio;
                tbTotalPago.Text = total.ToString();
                dgvCompraFinal.Rows.RemoveAt(iRow.Index);

            }
        }

        private void tbCVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }else if (tbCVV.Text.Length >2)
            {
                e.Handled = true;
            }
        }

        private void tbNumeroTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (tbNumeroTarjeta.Text.Length > 15)
            {
                e.Handled = true;
            }
        }
    }
}
