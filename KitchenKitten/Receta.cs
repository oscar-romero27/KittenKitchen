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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace KitchenKitten
{
    public partial class Receta : Form
    {
        //Inicio de conexion con la base de datos
        SqlConnection conexion = new SqlConnection("server=(local)\\SQLEXPRESS;database=master;Integrated Security = SSPI");
        SqlCommand comandosql = new SqlCommand();
        //Fin de inicio de conexion con la base de datos
        Usuario usuarioActual;
        string nombre_receta;
        string video_receta;
        int id_receta;

        public Receta(int id, Usuario usuario)
        {
            InitializeComponent();
            id_receta = id;
            usuarioActual = usuario;
            //Mostrar ingredientes en el lbIngredientes
            conexion.Open();
            comandosql.Connection = conexion;
            comandosql.CommandText = "SELECT Ingrediente.nombre FROM Ingrediente_tiene_Receta INNER JOIN Ingrediente ON Ingrediente.Id_ingrediente= Ingrediente_tiene_Receta.ingrediente_id INNER JOIN Receta ON Receta.receta_id = Ingrediente_tiene_Receta.receta_id WHERE Receta.receta_id = '"+id+"'";
            SqlDataReader midatareader = comandosql.ExecuteReader();
            string dato1;
            
            while (midatareader.Read())
            {
                dato1 = midatareader.GetString(0); //nombre del ingrediente
                listViewIngredientes.Items.Add(dato1);
                
            }
            midatareader.Close();
            conexion.Close();
            //Fin mostrar recetas en el lbrecetas

            

            //Inicio mostrar pasos de receta
            conexion.Open();
            comandosql.Connection = conexion;
            comandosql.CommandText = "SELECT descripcion_receta,nombre_receta,url_video FROM Receta WHERE receta_id= '" + id + "'";
            SqlDataReader midatareader2 = comandosql.ExecuteReader();
            string dato2;

            while (midatareader2.Read())
            {
                dato2 = midatareader2.GetString(0); //descripcion de la receta
                string text = dato2;
                string[] separatingStrings = { "::" };
                string[] frases = text.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
                tbPasos.Text = frases[1];

                nombre_receta = midatareader2.GetString(1); //nombre de la receta que se utilizra para generar el pdf
                video_receta = midatareader2.GetString(2);// url del video de la receta
            }
            midatareader2.Close();
            conexion.Close();
            //Fin mostrar descripcion de receta

            tbPasos.SelectionStart = tbPasos.Text.Length; //estas lineas son para que el texto no salga seleccionado al cambiar de ventana
            tbPasos.SelectionLength = 0; 

            //COMPROBACION DE QUE INGREDIENTES TIENE DE LA RECETA
            conexion.Open();
            comandosql.Connection = conexion;
            comandosql.CommandText = "SELECT i.nombre  FROM Usuario_compra_ingrediente u, Ingrediente i where u.usuario_id = " + usuarioActual.usuario_id + "" + " AND i.Id_ingrediente = u.ingrediente_id"; ;
            SqlDataReader midatareader3 = comandosql.ExecuteReader();
            string dato3;
            
            while (midatareader3.Read())
            {
                dato3 = midatareader3.GetString(0); //nombre del ingrediente
                //este bucle detecta los ingredientes que tiene el cliente 
                for (int i = 0; i < listViewIngredientes.Items.Count; i++)
                {
                    
                    if (listViewIngredientes.Items[i].Text.Equals(dato3))
                    {
                        listViewIngredientes.Items[i].ForeColor = Color.Green;
                    }
                }


            }
            midatareader3.Close();
            conexion.Close();
            //FIN COMPROBACION DE QUE INGREDIENTES TIENE DE LA RECETA

            //COMPROBACION DE SI HAY AL MENOS UN INGREDIENTE EN VERDE
            int contador = 0;
            for (int i = 0; i < listViewIngredientes.Items.Count; i++)
            {

                if (listViewIngredientes.Items[i].ForeColor == Color.Green)
                {
                    contador++;
                }
            }
            if (contador == 0)
            {
                btImprimir.Enabled = false;
            }
        }

        //IMPRESION DE LA RECETA
        private void btConfReceta_Click(object sender, EventArgs e)
        {

            conexion.Open();
            comandosql.Connection = conexion;
            comandosql.CommandText = "SELECT i.nombre,u.Cantidad, u.ingrediente_id  FROM Usuario_compra_ingrediente u, Ingrediente i where u.usuario_id = " + usuarioActual.usuario_id + "" + " AND i.Id_ingrediente = u.ingrediente_id"; ;
            SqlDataReader midatareader4 = comandosql.ExecuteReader();
            
            List<string> nombre_ingredientes = new List<string>();
            List<int> cantidad = new List<int>();
            List<int> ingrediente_id = new List<int>();
            while (midatareader4.Read())
            {
                nombre_ingredientes.Add(midatareader4.GetString(0)); //nombre del ingrediente
                cantidad.Add(midatareader4.GetInt32(1));
                ingrediente_id.Add(midatareader4.GetInt32(2));
            }

            midatareader4.Close();
            conexion.Close();

            //este bucle detecta los ingredientes que tiene el cliente 
            for (int j = 0; j < cantidad.Count; j++)
            {

                for (int i = 0; i < listViewIngredientes.Items.Count; i++)
                {
                    conexion.Open();
                    comandosql.Connection = conexion;

                    if (listViewIngredientes.Items[i].Text.Equals(nombre_ingredientes[j]))
                    {
                        if (cantidad[j] == 1)
                        {
                            try
                            {
                                comandosql.CommandText = "DELETE FROM Usuario_compra_ingrediente WHERE usuario_id= " + usuarioActual.usuario_id + " AND ingrediente_id= " + ingrediente_id[j] + " ";
                                comandosql.ExecuteNonQuery();
                            }
                            catch (Exception error)
                            {
                                MessageBox.Show("falla el delete: " + error);
                            }
                        }

                        if (cantidad[j] > 1)
                        {
                            try
                            {
                                comandosql.CommandText = "UPDATE Usuario_compra_ingrediente SET Cantidad = Cantidad - 1 WHERE usuario_id= " + usuarioActual.usuario_id + " AND ingrediente_id= " + ingrediente_id[j] + " ";
                                comandosql.ExecuteNonQuery();
                            }
                            catch (Exception error)
                            {
                                MessageBox.Show("falla el update: " + error);
                            }

                        }
                    }

                    conexion.Close();
                }
            }
            

            Document doc = new Document(PageSize.LETTER); //crea un objeto document con el que se va a trabajar para añadirle contenido
            try
            {


                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"" + nombre_receta + ".pdf", FileMode.Create)); //se crea un objeto de escritura en pdf
                doc.AddTitle("Receta"); //esto es un metadato que no se visualiza en el pdf
                doc.AddCreator("DREAM TEAM"); //esto es otro metadato

                doc.Open(); //abre el doc para modificarlo

                iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK); //da el formato de letra

                // Escribimos el encabezamiento en el documento
                doc.Add(new Phrase("Ingredientes:"));
                doc.Add(Chunk.NEWLINE);

                //este bucle añade los ingredientes al documento que se convertira en pdf
                for (int i = 0; i < listViewIngredientes.Items.Count; i++)
                {
                    doc.Add(new Phrase(listViewIngredientes.Items[i].Text));
                    doc.Add(Chunk.NEWLINE); //esto sirve para que no de el pro culo al añadir contenido
                }


                doc.Add(new Phrase(""));
                doc.Add(Chunk.NEWLINE);
                doc.Add(new Paragraph(tbPasos.Text)); //se le añaden los pasos de la receta
                doc.Add(Chunk.NEWLINE);
                doc.Close();
                writer.Close();

            }
            catch
            {
                MessageBox.Show("Estás intentando guardar un archivo que ya existe, prueba con otra receta");

            }
            Valoracion ventana = new Valoracion(usuarioActual, id_receta); //se abre la ventana de valoracion
            ventana.ShowDialog();
        }
        //FIN IMPRESION DE LA RECETA

        private void btVideoReceta_Click(object sender, EventArgs e)
        {
            VideoReceta vidReceta = new VideoReceta(video_receta);
        
            //this.Visible = false;

            vidReceta.ShowDialog();

            //this.Dispose();

        }

       
    }
}
