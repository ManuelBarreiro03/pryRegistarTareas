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
    public partial class frmMostrar : Form
    {
        int columna;
        int filas =0;
        public frmMostrar()
        {
            InitializeComponent();
        }
        private void frmMostar_Load(object sender, EventArgs e)
        {
            frmPrincipal ventanaPrincipal = new frmPrincipal();
            dgvMostrar.Rows.Clear();
            dgvMostrar.Rows.Add(4);
            while (filas <5)
            {
                columna = 0;
                while (columna <5) 
                {
                    dgvMostrar.Rows[filas].Cells[columna].Value = ventanaPrincipal.matrizMostrar[filas, columna];
                    columna++;
                }
                filas++;
            }
        }
    }
}
