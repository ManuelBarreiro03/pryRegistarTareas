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
    public partial class frmLogin : Form
    {
        string usuario, contrasena, usuarioRegistrado, contrasenaRegistrada;
        int indicefilas = 0, ubicacion = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuarios.Text != "")
            {
                usuario = txtUsuarios.Text;
                if (txtContrasena.Text != "")
                {
                    contrasena = txtContrasena.Text;
                    while (indicefilas < frmPrincipal.MatrizUsuario.GetLength(0))
                    {
                        if (usuario == frmPrincipal.MatrizUsuario[indicefilas,0])
                        {
                            ubicacion = indicefilas;
                        }
                        indicefilas++;
                    }
                    contrasenaRegistrada = frmPrincipal.MatrizUsuario[ubicacion, 1];
                    usuarioRegistrado = frmPrincipal.MatrizUsuario[ubicacion, 0];
                    if (contrasenaRegistrada == contrasena && usuarioRegistrado == usuario)
                    {
                       frmRegistrarTarea ventanaRegistrarTarea = new frmRegistrarTarea();
                       ventanaRegistrarTarea.ShowDialog();
                    }
                    else
                    {
                       MessageBox.Show("Usuario y/o Contraseña incorectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Coloque contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasena.Focus();
                }
            } 
            else 
            {
                MessageBox.Show("Coloque usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuarios.Focus();
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
