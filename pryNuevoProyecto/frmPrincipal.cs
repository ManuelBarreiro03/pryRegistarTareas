using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryNuevoProyecto
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            frmLogin ventanaLogin = new frmLogin();
            ShowDialog(ventanaLogin);
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistar ventanaregistrar = new frmRegistar();
            ShowDialog(ventanaregistrar);
        }
    }
}
