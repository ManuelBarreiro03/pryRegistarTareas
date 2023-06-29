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
    public partial class frmRegistar : Form
    {
        public frmRegistar()
        {
            InitializeComponent();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                if (txtApellido.Text != "")
                {
                    if (txtUsuario.Text != "")
                    {
                        if (txtContrasena.Text != "")
                        {
                            if (txtConfirmar.Text != "")
                            {
                                
                            }
                        }
                    }
                }
            }
        }
    }
}
