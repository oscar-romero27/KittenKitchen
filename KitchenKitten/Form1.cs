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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            
            this.Visible = false;

            log.ShowDialog();

            this.Dispose();

        }

        private void btRegistro_Click(object sender, EventArgs e)
        {
            Registrar reg = new Registrar();
            
            this.Visible = false;

            reg.ShowDialog();

            this.Dispose();

        }
    }
}
