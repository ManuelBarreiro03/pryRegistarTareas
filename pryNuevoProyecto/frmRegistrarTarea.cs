﻿using System;
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
        string varReunion="";
        string varTareas="";
        int indiceFilas=0;
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
                        if (optSi.Checked == true)
                        {
                            varTareas = "SI";
                        }
                        else
                        {
                            varTareas = "NO";
                        }
                        if (chkDebate.Checked)
                        {
                            varReunion = "Debate, ";
                        }
                        if (chkInvestigacion.Checked)
                        {
                            varReunion = varReunion + "Investigacion, ";
                        }
                        if (chkNotasReunion.Checked)
                        {
                            varReunion = varReunion + "Reunion, ";
                        }
                        if (chkRepositorio.Checked)
                        {
                            varReunion = varReunion + "repositorio.";
                        }
                        if (indiceFilas < 5)
                        {
                            frmPrincipal ventanaprincipal = new frmPrincipal();
                            frmPrincipal.matrizMostrar[indiceFilas, 0] = dtpFecha.Text;
                            frmPrincipal.matrizMostrar[indiceFilas, 1] = cboTipo.Text;
                            frmPrincipal.matrizMostrar[indiceFilas, 2] = txtDetalle.Text;
                            frmPrincipal.matrizMostrar[indiceFilas, 3] = varTareas;
                            frmPrincipal.matrizMostrar[indiceFilas, 4] = varReunion;
                            indiceFilas++;
                            MessageBox.Show("Tarea grabada", "Tareas", MessageBoxButtons.OK);
                        }
                        else
                        {
                            cmdAgregar.Enabled = false;
                            MessageBox.Show("Maximo alcanzado", "limite", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
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

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            frmMostrar ventanaMostar = new frmMostrar();
            ventanaMostar.ShowDialog();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
