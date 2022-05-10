using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace KitchenKitten
{
    public partial class ImprimirPDF : Form
    {
        Usuario miUsuario;
        public ImprimirPDF(DataGridView dgv, Usuario mUsuario, float total)
        {

            InitializeComponent();
            copiarDGV(dgv);
            miUsuario = mUsuario;
            lblTitular.Text = lblTitular.Text + miUsuario.nombre;
            lblTotal.Text = lblTotal.Text + total.ToString();

            this.Show();
            // pdf.Visible = false;
            


            var frm = Form.ActiveForm;
            using (var bmp = new Bitmap(frm.Width, frm.Height))
            {
                frm.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@"..\screenshot.png");
            }
            
                imprimirImagen();
            this.Dispose();
        }

        private void imprimirImagen()
        {
            if(saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            try
            {
                Document doc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
                string pdfFilePath = saveFileDialog1.FileName;
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(pdfFilePath, FileMode.Create));
                doc.Open();
                iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@"..\screenshot.png");
                doc.Add(jpg);
                doc.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ImprimirPDF_Load(object sender, EventArgs e)
        {

        }

        private void copiarDGV(DataGridView dgv)
        {

            try
            {
                if (dataGridView1.Columns.Count == 0)
                {
                    foreach (DataGridViewColumn dgvc in dgv.Columns)
                    {
                        dataGridView1.Columns.Add(dgvc.Clone() as DataGridViewColumn);
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
                    dataGridView1.Rows.Add(row);
                }
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
                dataGridView1.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ha habido un error -> " + ex.Message);
                this.Dispose();
            }

        }
    }
}
