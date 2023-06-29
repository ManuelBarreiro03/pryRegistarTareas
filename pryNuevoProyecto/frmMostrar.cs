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
        int columna = 0;
        int filas =0;
        public frmMostrar()
        {
            InitializeComponent();
        }
        private void frmMostar_Load(object sender, EventArgs e)
        {
            dgvMostrar.Rows.Clear();
            dgvMostrar.Rows.Add(frmPrincipal.matrizMostrar.GetLength(0));
            while (filas < frmPrincipal.matrizMostrar.GetLength(0))
            {
                columna = 0;
                while (columna < frmPrincipal.matrizMostrar.GetLength(1))
                {
                    dgvMostrar.Rows[filas].Cells[columna].Value = frmPrincipal.matrizMostrar[filas, columna];
                    columna++;
                }
                filas++;
            }
            filas = 0;
            columna = 0;
        }
    }
}
