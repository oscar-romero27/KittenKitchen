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
    public partial class AdminValoracion : Form
    {
        public AdminValoracion()
        {
            InitializeComponent();
        }

        private void valoracionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.valoracionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void AdminValoracion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Valoracion' Puede moverla o quitarla según sea necesario.
            this.valoracionTableAdapter.Fill(this.masterDataSet.Valoracion);

        }
    }
}
