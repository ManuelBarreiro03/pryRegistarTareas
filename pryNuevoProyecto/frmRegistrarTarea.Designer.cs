namespace pryNuevoProyecto
{
    partial class frmRegistrarTarea
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarTarea));
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.mrcTareas = new System.Windows.Forms.GroupBox();
            this.chkNotasReunion = new System.Windows.Forms.CheckBox();
            this.chkInvestigacion = new System.Windows.Forms.CheckBox();
            this.chkDebate = new System.Windows.Forms.CheckBox();
            this.chkRepositorio = new System.Windows.Forms.CheckBox();
            this.mrcReunion = new System.Windows.Forms.GroupBox();
            this.optNo = new System.Windows.Forms.RadioButton();
            this.optSi = new System.Windows.Forms.RadioButton();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdMostrar = new System.Windows.Forms.Button();
            this.mrcTareas.SuspendLayout();
            this.mrcReunion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(14, 22);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(245, 20);
            this.dtpFecha.TabIndex = 0;
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(14, 72);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(245, 21);
            this.cboTipo.TabIndex = 1;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(14, 119);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(245, 110);
            this.txtDetalle.TabIndex = 2;
            // 
            // mrcTareas
            // 
            this.mrcTareas.Controls.Add(this.chkNotasReunion);
            this.mrcTareas.Controls.Add(this.chkInvestigacion);
            this.mrcTareas.Controls.Add(this.chkDebate);
            this.mrcTareas.Controls.Add(this.chkRepositorio);
            this.mrcTareas.Location = new System.Drawing.Point(13, 288);
            this.mrcTareas.Name = "mrcTareas";
            this.mrcTareas.Size = new System.Drawing.Size(246, 69);
            this.mrcTareas.TabIndex = 4;
            this.mrcTareas.TabStop = false;
            this.mrcTareas.Text = "Tareas";
            // 
            // chkNotasReunion
            // 
            this.chkNotasReunion.AutoSize = true;
            this.chkNotasReunion.Location = new System.Drawing.Point(103, 42);
            this.chkNotasReunion.Name = "chkNotasReunion";
            this.chkNotasReunion.Size = new System.Drawing.Size(97, 17);
            this.chkNotasReunion.TabIndex = 3;
            this.chkNotasReunion.Text = "Notas Reunion";
            this.chkNotasReunion.UseVisualStyleBackColor = true;
            // 
            // chkInvestigacion
            // 
            this.chkInvestigacion.AutoSize = true;
            this.chkInvestigacion.Location = new System.Drawing.Point(6, 42);
            this.chkInvestigacion.Name = "chkInvestigacion";
            this.chkInvestigacion.Size = new System.Drawing.Size(89, 17);
            this.chkInvestigacion.TabIndex = 2;
            this.chkInvestigacion.Text = "Investigacion";
            this.chkInvestigacion.UseVisualStyleBackColor = true;
            // 
            // chkDebate
            // 
            this.chkDebate.AutoSize = true;
            this.chkDebate.Location = new System.Drawing.Point(103, 19);
            this.chkDebate.Name = "chkDebate";
            this.chkDebate.Size = new System.Drawing.Size(61, 17);
            this.chkDebate.TabIndex = 1;
            this.chkDebate.Text = "Debate";
            this.chkDebate.UseVisualStyleBackColor = true;
            // 
            // chkRepositorio
            // 
            this.chkRepositorio.AutoSize = true;
            this.chkRepositorio.Location = new System.Drawing.Point(6, 19);
            this.chkRepositorio.Name = "chkRepositorio";
            this.chkRepositorio.Size = new System.Drawing.Size(79, 17);
            this.chkRepositorio.TabIndex = 0;
            this.chkRepositorio.Text = "Repositorio";
            this.chkRepositorio.UseVisualStyleBackColor = true;
            // 
            // mrcReunion
            // 
            this.mrcReunion.Controls.Add(this.optNo);
            this.mrcReunion.Controls.Add(this.optSi);
            this.mrcReunion.Location = new System.Drawing.Point(14, 235);
            this.mrcReunion.Name = "mrcReunion";
            this.mrcReunion.Size = new System.Drawing.Size(245, 47);
            this.mrcReunion.TabIndex = 5;
            this.mrcReunion.TabStop = false;
            this.mrcReunion.Text = "Tareas";
            // 
            // optNo
            // 
            this.optNo.AutoSize = true;
            this.optNo.Location = new System.Drawing.Point(132, 19);
            this.optNo.Name = "optNo";
            this.optNo.Size = new System.Drawing.Size(41, 17);
            this.optNo.TabIndex = 1;
            this.optNo.TabStop = true;
            this.optNo.Text = "NO";
            this.optNo.UseVisualStyleBackColor = true;
            // 
            // optSi
            // 
            this.optSi.AutoSize = true;
            this.optSi.Checked = true;
            this.optSi.Location = new System.Drawing.Point(74, 19);
            this.optSi.Name = "optSi";
            this.optSi.Size = new System.Drawing.Size(35, 17);
            this.optSi.TabIndex = 0;
            this.optSi.TabStop = true;
            this.optSi.Text = "SI";
            this.optSi.UseVisualStyleBackColor = true;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(11, 6);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(11, 52);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "Tipo";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(11, 103);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(40, 13);
            this.lblDetalle.TabIndex = 8;
            this.lblDetalle.Text = "Detalle";
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(12, 363);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(70, 28);
            this.cmdAgregar.TabIndex = 9;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(88, 363);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(81, 28);
            this.cmdCancelar.TabIndex = 10;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.Location = new System.Drawing.Point(175, 363);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(81, 28);
            this.cmdMostrar.TabIndex = 12;
            this.cmdMostrar.Text = "Mostar";
            this.cmdMostrar.UseVisualStyleBackColor = true;
            this.cmdMostrar.Click += new System.EventHandler(this.cmdMostrar_Click);
            // 
            // frmRegistrarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 407);
            this.Controls.Add(this.cmdMostrar);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.mrcReunion);
            this.Controls.Add(this.mrcTareas);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.dtpFecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistrarTarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Tarea";
            this.mrcTareas.ResumeLayout(false);
            this.mrcTareas.PerformLayout();
            this.mrcReunion.ResumeLayout(false);
            this.mrcReunion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.GroupBox mrcTareas;
        private System.Windows.Forms.CheckBox chkNotasReunion;
        private System.Windows.Forms.CheckBox chkInvestigacion;
        private System.Windows.Forms.CheckBox chkDebate;
        private System.Windows.Forms.CheckBox chkRepositorio;
        private System.Windows.Forms.GroupBox mrcReunion;
        private System.Windows.Forms.RadioButton optNo;
        private System.Windows.Forms.RadioButton optSi;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdMostrar;
    }
}