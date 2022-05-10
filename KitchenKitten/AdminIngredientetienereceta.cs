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
    public partial class AdminIngredientetienereceta : Form
    {
        public AdminIngredientetienereceta()
        {
            InitializeComponent();
        }

        private void ingrediente_tiene_RecetaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ingrediente_tiene_RecetaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void AdminIngredientetienereceta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Ingrediente_tiene_Receta' Puede moverla o quitarla según sea necesario.
            this.ingrediente_tiene_RecetaTableAdapter.Fill(this.masterDataSet.Ingrediente_tiene_Receta);

        }
    }
}
