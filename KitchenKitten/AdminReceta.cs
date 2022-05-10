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
    public partial class AdminReceta : Form
    {
        public AdminReceta()
        {
            InitializeComponent();
        }

        private void recetaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.recetaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void AdminReceta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Receta' Puede moverla o quitarla según sea necesario.
            this.recetaTableAdapter.Fill(this.masterDataSet.Receta);

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
