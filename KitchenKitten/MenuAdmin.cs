using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitchenKitten
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void btIngredientes_Click(object sender, EventArgs e)
        {
            AdminIngrediente dialogo = new AdminIngrediente();

            //this.Visible = false;

            dialogo.ShowDialog();

            //this.Dispose();
        }

        private void btTiene_Click(object sender, EventArgs e)
        {
            AdminIngredientetienereceta dialogo = new AdminIngredientetienereceta();

            //this.Visible = false;

            dialogo.ShowDialog();

            //this.Dispose();
        }

        private void btRecetas_Click(object sender, EventArgs e)
        {
            AdminReceta dialogo = new AdminReceta();

            //this.Visible = false;

            dialogo.ShowDialog();

            //this.Dispose();
        }

        private void btValoracion_Click(object sender, EventArgs e)
        {
            AdminValoracion dialogo = new AdminValoracion();

            //this.Visible = false;

            dialogo.ShowDialog();

            //this.Dispose();
        }

        private void btUsuarios_Click(object sender, EventArgs e)
        {
            AdminUsuario dialogo = new AdminUsuario();

            //this.Visible = false;

            dialogo.ShowDialog();

            //this.Dispose();
        }

        private void btnCargarHistorico_Click(object sender, EventArgs e)
        {
            CargarHistórico dialogo = new CargarHistórico();
            dialogo.ShowDialog();
        }
    }
}
