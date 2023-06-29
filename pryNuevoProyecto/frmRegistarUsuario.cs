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
    public partial class frmRegistarUsuario : Form
    {
        string contra, confirmarContra;
        public frmRegistarUsuario()
        {
            InitializeComponent();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            contra = txtContrasena.Text;
            confirmarContra = txtConfirmar.Text;
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
                                if (contra == confirmarContra)
                                {

                                }
                                else
                                {
                                    MessageBox.Show("Las contraseñas no couinciden","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                            }
                            else
                            {
                                MessageBox.Show("Confirme la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtConfirmar.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Coloque una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtContrasena.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Coloque un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsuario.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Coloque un apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtApellido.Focus();
                }
            }
            else
            {
                MessageBox.Show("Coloque un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
