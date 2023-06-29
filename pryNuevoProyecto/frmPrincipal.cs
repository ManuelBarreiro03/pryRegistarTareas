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
        static public string[,] matrizMostrar = new string[5,5];
        static public string[,] MatrizUsuario = new string[2,5];
        int indiceFilas = 0, indiceColumnas = 0;


        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            while (indiceFilas<= MatrizUsuario.GetLength(0))
            {
                indiceColumnas = 0;
                while (indiceColumnas <= MatrizUsuario.GetLength(1))
                {
                    MatrizUsuario[indiceFilas, indiceColumnas] = "";
                    indiceColumnas++;
                }
                indiceFilas++;
            }
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            frmLogin ventanaLogin = new frmLogin();
            ventanaLogin.ShowDialog();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistarUsuario ventanaregistrar = new frmRegistarUsuario();
            ventanaregistrar.ShowDialog();
        }
    }
}
