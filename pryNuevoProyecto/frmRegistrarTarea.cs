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
    public partial class frmRegistrarTarea : Form
    {
        public frmRegistrarTarea()
        {
            InitializeComponent();
            cboTipo.Items.Add("Administrativa");
            cboTipo.Items.Add("Aviso");
            cboTipo.Items.Add("Informatica");
        }
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            if(dtpFecha.Value >= DateTime.Today)
            {
                if (cboTipo.SelectedIndex != -1)
                {
                    if (txtDetalle.Text != "")
                    {
                        MessageBox.Show("vamos a grabar");
                    }
                    else
                    {
                        MessageBox.Show("falta Detalle");
                        txtDetalle.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione tipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboTipo.Focus();
                }
            }
            else
            {
                MessageBox.Show("La fecha ingresada ya paso", "Fecha Erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFecha.Focus();
                dtpFecha.Value = DateTime.Today;
            }
        }
    }
}
