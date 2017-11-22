namespace ProyectoWF {
    partial class FormularioEmpleados {
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
            this.tblPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.gbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.tblDatosPersonales = new System.Windows.Forms.TableLayoutPanel();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbFecNac = new System.Windows.Forms.TextBox();
            this.lbFecNac = new System.Windows.Forms.Label();
            this.lbFoto = new System.Windows.Forms.Label();
            this.gbDireccion = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbCiudad = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbCiudad = new System.Windows.Forms.TextBox();
            this.tbRegion = new System.Windows.Forms.TextBox();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.lbRegion = new System.Windows.Forms.Label();
            this.lbPais = new System.Windows.Forms.Label();
            this.tblPrincipal.SuspendLayout();
            this.gbDatosPersonales.SuspendLayout();
            this.tblDatosPersonales.SuspendLayout();
            this.gbDireccion.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPrincipal
            // 
            this.tblPrincipal.ColumnCount = 2;
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPrincipal.Controls.Add(this.gbDatosPersonales, 0, 0);
            this.tblPrincipal.Controls.Add(this.gbDireccion, 1, 0);
            this.tblPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tblPrincipal.Name = "tblPrincipal";
            this.tblPrincipal.RowCount = 2;
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPrincipal.Size = new System.Drawing.Size(639, 461);
            this.tblPrincipal.TabIndex = 0;
            // 
            // gbDatosPersonales
            // 
            this.gbDatosPersonales.Controls.Add(this.tblDatosPersonales);
            this.gbDatosPersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDatosPersonales.Location = new System.Drawing.Point(3, 3);
            this.gbDatosPersonales.Name = "gbDatosPersonales";
            this.gbDatosPersonales.Size = new System.Drawing.Size(313, 224);
            this.gbDatosPersonales.TabIndex = 0;
            this.gbDatosPersonales.TabStop = false;
            this.gbDatosPersonales.Text = "Datos personales";
            // 
            // tblDatosPersonales
            // 
            this.tblDatosPersonales.ColumnCount = 2;
            this.tblDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDatosPersonales.Controls.Add(this.lbNombre, 0, 0);
            this.tblDatosPersonales.Controls.Add(this.lbApellidos, 0, 1);
            this.tblDatosPersonales.Controls.Add(this.tbNombre, 1, 0);
            this.tblDatosPersonales.Controls.Add(this.tbApellidos, 1, 1);
            this.tblDatosPersonales.Controls.Add(this.tbFecNac, 1, 2);
            this.tblDatosPersonales.Controls.Add(this.lbFecNac, 0, 2);
            this.tblDatosPersonales.Controls.Add(this.lbFoto, 0, 3);
            this.tblDatosPersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDatosPersonales.Location = new System.Drawing.Point(3, 16);
            this.tblDatosPersonales.Name = "tblDatosPersonales";
            this.tblDatosPersonales.RowCount = 4;
            this.tblDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDatosPersonales.Size = new System.Drawing.Size(307, 205);
            this.tblDatosPersonales.TabIndex = 0;
            // 
            // lbNombre
            // 
            this.lbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(3, 6);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(93, 13);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre";
            // 
            // lbApellidos
            // 
            this.lbApellidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Location = new System.Drawing.Point(3, 32);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(93, 13);
            this.lbApellidos.TabIndex = 1;
            this.lbApellidos.Text = "Apellidos";
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombre.Location = new System.Drawing.Point(102, 3);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(202, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbApellidos.Location = new System.Drawing.Point(102, 29);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(202, 20);
            this.tbApellidos.TabIndex = 3;
            // 
            // tbFecNac
            // 
            this.tbFecNac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFecNac.Location = new System.Drawing.Point(102, 55);
            this.tbFecNac.Name = "tbFecNac";
            this.tbFecNac.Size = new System.Drawing.Size(202, 20);
            this.tbFecNac.TabIndex = 4;
            // 
            // lbFecNac
            // 
            this.lbFecNac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFecNac.AutoSize = true;
            this.lbFecNac.Location = new System.Drawing.Point(3, 58);
            this.lbFecNac.Name = "lbFecNac";
            this.lbFecNac.Size = new System.Drawing.Size(93, 13);
            this.lbFecNac.TabIndex = 5;
            this.lbFecNac.Text = "Fecha Nacimiento";
            // 
            // lbFoto
            // 
            this.lbFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFoto.AutoSize = true;
            this.lbFoto.Location = new System.Drawing.Point(6, 77);
            this.lbFoto.Name = "lbFoto";
            this.lbFoto.Size = new System.Drawing.Size(100, 23);
            this.lbFoto.TabIndex = 6;
            this.lbFoto.Text = "Foto";
            // 
            // gbDireccion
            // 
            this.gbDireccion.Controls.Add(this.tableLayoutPanel1);
            this.gbDireccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDireccion.Location = new System.Drawing.Point(322, 3);
            this.gbDireccion.Name = "gbDireccion";
            this.gbDireccion.Size = new System.Drawing.Size(314, 224);
            this.gbDireccion.TabIndex = 1;
            this.gbDireccion.TabStop = false;
            this.gbDireccion.Text = "Dirección";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lbDireccion, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbCiudad, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbDireccion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbCiudad, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbRegion, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbPais, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbRegion, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbPais, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(308, 205);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbDireccion
            // 
            this.lbDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(3, 6);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(52, 13);
            this.lbDireccion.TabIndex = 0;
            this.lbDireccion.Text = "Dirección";
            // 
            // lbCiudad
            // 
            this.lbCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCiudad.AutoSize = true;
            this.lbCiudad.Location = new System.Drawing.Point(3, 32);
            this.lbCiudad.Name = "lbCiudad";
            this.lbCiudad.Size = new System.Drawing.Size(52, 13);
            this.lbCiudad.TabIndex = 1;
            this.lbCiudad.Text = "Ciudad";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDireccion.Location = new System.Drawing.Point(61, 3);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(244, 20);
            this.tbDireccion.TabIndex = 2;
            // 
            // tbCiudad
            // 
            this.tbCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCiudad.Location = new System.Drawing.Point(61, 29);
            this.tbCiudad.Name = "tbCiudad";
            this.tbCiudad.Size = new System.Drawing.Size(244, 20);
            this.tbCiudad.TabIndex = 3;
            // 
            // tbRegion
            // 
            this.tbRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRegion.Location = new System.Drawing.Point(61, 55);
            this.tbRegion.Name = "tbRegion";
            this.tbRegion.Size = new System.Drawing.Size(244, 20);
            this.tbRegion.TabIndex = 4;
            // 
            // tbPais
            // 
            this.tbPais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPais.Location = new System.Drawing.Point(61, 131);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(244, 20);
            this.tbPais.TabIndex = 5;
            // 
            // lbRegion
            // 
            this.lbRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRegion.AutoSize = true;
            this.lbRegion.Location = new System.Drawing.Point(3, 58);
            this.lbRegion.Name = "lbRegion";
            this.lbRegion.Size = new System.Drawing.Size(52, 13);
            this.lbRegion.TabIndex = 6;
            this.lbRegion.Text = "Región";
            // 
            // lbPais
            // 
            this.lbPais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPais.AutoSize = true;
            this.lbPais.Location = new System.Drawing.Point(3, 135);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(52, 13);
            this.lbPais.TabIndex = 7;
            this.lbPais.Text = "País";
            // 
            // FormularioEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 461);
            this.Controls.Add(this.tblPrincipal);
            this.Name = "FormularioEmpleados";
            this.Text = "FormularioEmpleados";
            this.tblPrincipal.ResumeLayout(false);
            this.gbDatosPersonales.ResumeLayout(false);
            this.tblDatosPersonales.ResumeLayout(false);
            this.tblDatosPersonales.PerformLayout();
            this.gbDireccion.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPrincipal;
        private System.Windows.Forms.GroupBox gbDatosPersonales;
        private System.Windows.Forms.TableLayoutPanel tblDatosPersonales;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbFecNac;
        private System.Windows.Forms.Label lbFecNac;
        private System.Windows.Forms.Label lbFoto;
        private System.Windows.Forms.GroupBox gbDireccion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbCiudad;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbCiudad;
        private System.Windows.Forms.TextBox tbRegion;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.Label lbRegion;
        private System.Windows.Forms.Label lbPais;
    }
}