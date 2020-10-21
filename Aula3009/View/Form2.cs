using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula3009
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void txtCod_Enter(object sender, EventArgs e)
        {
            if (txtCod.Text == "Código do Cliente")
            {
                txtCod.Text = "";
            }
        }

        private void txtCod_Leave(object sender, EventArgs e)
        {
            if (txtCod.Text == "")
            {
                txtCod.Text = "Código do Cliente";
            }
        }
    }
}
