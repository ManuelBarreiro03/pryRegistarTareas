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
        int indiceFilas = 1;
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
                                if (cboNacionalidad.Text != "")
                                {
                                    if (contra == confirmarContra)
                                    {
                                        while (frmPrincipal.MatrizUsuario[indiceFilas,0] != null)
                                        {
                                            indiceFilas++;
                                        }
                                        frmPrincipal.MatrizUsuario[indiceFilas, 0] = txtUsuario.Text;
                                        frmPrincipal.MatrizUsuario[indiceFilas, 1] = txtContrasena.Text;
                                        MessageBox.Show("Usuario cargado", "", MessageBoxButtons.OK);
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Las contraseñas no couinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Coloque un País", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    cboNacionalidad.Focus();
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

        private void frmRegistarUsuario_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
