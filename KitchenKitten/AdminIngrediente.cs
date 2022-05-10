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
    public partial class AdminIngrediente : Form
    {
        public AdminIngrediente()
        {
            InitializeComponent();
        }

        private void ingredienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ingredienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void AdminIngrediente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Ingrediente' Puede moverla o quitarla según sea necesario.
            this.ingredienteTableAdapter.Fill(this.masterDataSet.Ingrediente);

        }
    }
}
