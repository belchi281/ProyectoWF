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
            this.lbPais = new System.Windows.Forms.Label();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.tbRegion = new System.Windows.Forms.TextBox();
            this.tbCp = new System.Windows.Forms.TextBox();
            this.lbCp = new System.Windows.Forms.Label();
            this.lbRegion = new System.Windows.Forms.Label();
            this.gbDatosEmpresa = new System.Windows.Forms.GroupBox();
            this.tblDatosEmpresa = new System.Windows.Forms.TableLayoutPanel();
            this.lbId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbFecCon = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkUsuario = new System.Windows.Forms.CheckBox();
            this.lbObservaciones = new System.Windows.Forms.Label();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.tblPrincipal.SuspendLayout();
            this.gbDatosPersonales.SuspendLayout();
            this.tblDatosPersonales.SuspendLayout();
            this.gbDireccion.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbDatosEmpresa.SuspendLayout();
            this.tblDatosEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPrincipal
            // 
            this.tblPrincipal.ColumnCount = 2;
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPrincipal.Controls.Add(this.gbDatosPersonales, 0, 0);
            this.tblPrincipal.Controls.Add(this.gbDireccion, 1, 0);
            this.tblPrincipal.Controls.Add(this.gbDatosEmpresa, 0, 1);
            this.tblPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tblPrincipal.MinimumSize = new System.Drawing.Size(640, 460);
            this.tblPrincipal.Name = "tblPrincipal";
            this.tblPrincipal.RowCount = 2;
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPrincipal.Size = new System.Drawing.Size(640, 461);
            this.tblPrincipal.TabIndex = 0;
            // 
            // gbDatosPersonales
            // 
            this.gbDatosPersonales.Controls.Add(this.tblDatosPersonales);
            this.gbDatosPersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDatosPersonales.Location = new System.Drawing.Point(3, 3);
            this.gbDatosPersonales.Name = "gbDatosPersonales";
            this.gbDatosPersonales.Size = new System.Drawing.Size(314, 224);
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
            this.tblDatosPersonales.Size = new System.Drawing.Size(308, 205);
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
            this.tbNombre.Size = new System.Drawing.Size(203, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbApellidos.Location = new System.Drawing.Point(102, 29);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(203, 20);
            this.tbApellidos.TabIndex = 2;
            // 
            // tbFecNac
            // 
            this.tbFecNac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFecNac.Location = new System.Drawing.Point(102, 55);
            this.tbFecNac.Name = "tbFecNac";
            this.tbFecNac.Size = new System.Drawing.Size(203, 20);
            this.tbFecNac.TabIndex = 3;
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
            this.lbFoto.AutoSize = true;
            this.lbFoto.Location = new System.Drawing.Point(3, 83);
            this.lbFoto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbFoto.Name = "lbFoto";
            this.lbFoto.Size = new System.Drawing.Size(28, 13);
            this.lbFoto.TabIndex = 6;
            this.lbFoto.Text = "Foto";
            // 
            // gbDireccion
            // 
            this.gbDireccion.Controls.Add(this.tableLayoutPanel1);
            this.gbDireccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDireccion.Location = new System.Drawing.Point(323, 3);
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
            this.tableLayoutPanel1.Controls.Add(this.lbPais, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbPais, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbRegion, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbCp, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbCp, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbRegion, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
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
            this.tbDireccion.TabIndex = 4;
            // 
            // tbCiudad
            // 
            this.tbCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCiudad.Location = new System.Drawing.Point(61, 29);
            this.tbCiudad.Name = "tbCiudad";
            this.tbCiudad.Size = new System.Drawing.Size(244, 20);
            this.tbCiudad.TabIndex = 5;
            // 
            // lbPais
            // 
            this.lbPais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPais.AutoSize = true;
            this.lbPais.Location = new System.Drawing.Point(3, 109);
            this.lbPais.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(52, 13);
            this.lbPais.TabIndex = 7;
            this.lbPais.Text = "País";
            // 
            // tbPais
            // 
            this.tbPais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPais.Location = new System.Drawing.Point(61, 107);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(244, 20);
            this.tbPais.TabIndex = 8;
            // 
            // tbRegion
            // 
            this.tbRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRegion.Location = new System.Drawing.Point(61, 81);
            this.tbRegion.Name = "tbRegion";
            this.tbRegion.Size = new System.Drawing.Size(244, 20);
            this.tbRegion.TabIndex = 7;
            // 
            // tbCp
            // 
            this.tbCp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCp.Location = new System.Drawing.Point(61, 55);
            this.tbCp.Name = "tbCp";
            this.tbCp.Size = new System.Drawing.Size(244, 20);
            this.tbCp.TabIndex = 6;
            // 
            // lbCp
            // 
            this.lbCp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCp.AutoSize = true;
            this.lbCp.Location = new System.Drawing.Point(3, 58);
            this.lbCp.Name = "lbCp";
            this.lbCp.Size = new System.Drawing.Size(52, 13);
            this.lbCp.TabIndex = 8;
            this.lbCp.Text = "C.P";
            // 
            // lbRegion
            // 
            this.lbRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRegion.AutoSize = true;
            this.lbRegion.Location = new System.Drawing.Point(3, 84);
            this.lbRegion.Name = "lbRegion";
            this.lbRegion.Size = new System.Drawing.Size(52, 13);
            this.lbRegion.TabIndex = 6;
            this.lbRegion.Text = "Región";
            // 
            // gbDatosEmpresa
            // 
            this.gbDatosEmpresa.Controls.Add(this.tblDatosEmpresa);
            this.gbDatosEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDatosEmpresa.Location = new System.Drawing.Point(3, 233);
            this.gbDatosEmpresa.Name = "gbDatosEmpresa";
            this.gbDatosEmpresa.Size = new System.Drawing.Size(314, 225);
            this.gbDatosEmpresa.TabIndex = 2;
            this.gbDatosEmpresa.TabStop = false;
            this.gbDatosEmpresa.Text = "groupBox1";
            // 
            // tblDatosEmpresa
            // 
            this.tblDatosEmpresa.ColumnCount = 2;
            this.tblDatosEmpresa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDatosEmpresa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDatosEmpresa.Controls.Add(this.lbId, 0, 0);
            this.tblDatosEmpresa.Controls.Add(this.textBox1, 1, 0);
            this.tblDatosEmpresa.Controls.Add(this.textBox2, 1, 1);
            this.tblDatosEmpresa.Controls.Add(this.lbFecCon, 0, 1);
            this.tblDatosEmpresa.Controls.Add(this.lbTelefono, 0, 2);
            this.tblDatosEmpresa.Controls.Add(this.textBox3, 1, 2);
            this.tblDatosEmpresa.Controls.Add(this.checkUsuario, 1, 3);
            this.tblDatosEmpresa.Controls.Add(this.lbObservaciones, 0, 4);
            this.tblDatosEmpresa.Controls.Add(this.tbObservaciones, 1, 4);
            this.tblDatosEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDatosEmpresa.Location = new System.Drawing.Point(3, 16);
            this.tblDatosEmpresa.Name = "tblDatosEmpresa";
            this.tblDatosEmpresa.RowCount = 5;
            this.tblDatosEmpresa.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDatosEmpresa.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDatosEmpresa.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDatosEmpresa.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDatosEmpresa.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDatosEmpresa.Size = new System.Drawing.Size(308, 206);
            this.tblDatosEmpresa.TabIndex = 0;
            // 
            // lbId
            // 
            this.lbId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(3, 6);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(114, 13);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(123, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(123, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbFecCon
            // 
            this.lbFecCon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFecCon.AutoSize = true;
            this.lbFecCon.Location = new System.Drawing.Point(3, 32);
            this.lbFecCon.Name = "lbFecCon";
            this.lbFecCon.Size = new System.Drawing.Size(114, 13);
            this.lbFecCon.TabIndex = 3;
            this.lbFecCon.Text = "Fecha de contratacion";
            // 
            // lbTelefono
            // 
            this.lbTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(3, 58);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(114, 13);
            this.lbTelefono.TabIndex = 4;
            this.lbTelefono.Text = "Teléfono";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(123, 55);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(182, 20);
            this.textBox3.TabIndex = 11;
            // 
            // checkUsuario
            // 
            this.checkUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkUsuario.AutoSize = true;
            this.checkUsuario.Location = new System.Drawing.Point(123, 81);
            this.checkUsuario.Name = "checkUsuario";
            this.checkUsuario.Size = new System.Drawing.Size(182, 17);
            this.checkUsuario.TabIndex = 12;
            this.checkUsuario.Text = "Es usuario";
            this.checkUsuario.UseVisualStyleBackColor = true;
            // 
            // lbObservaciones
            // 
            this.lbObservaciones.AutoSize = true;
            this.lbObservaciones.Location = new System.Drawing.Point(3, 106);
            this.lbObservaciones.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbObservaciones.Name = "lbObservaciones";
            this.lbObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lbObservaciones.TabIndex = 7;
            this.lbObservaciones.Text = "Observaciones";
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbObservaciones.Location = new System.Drawing.Point(123, 104);
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(182, 99);
            this.tbObservaciones.TabIndex = 13;
            // 
            // FormularioEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 461);
            this.Controls.Add(this.tblPrincipal);
            this.MinimumSize = new System.Drawing.Size(655, 500);
            this.Name = "FormularioEmpleados";
            this.Text = "FormularioEmpleados";
            this.tblPrincipal.ResumeLayout(false);
            this.gbDatosPersonales.ResumeLayout(false);
            this.tblDatosPersonales.ResumeLayout(false);
            this.tblDatosPersonales.PerformLayout();
            this.gbDireccion.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbDatosEmpresa.ResumeLayout(false);
            this.tblDatosEmpresa.ResumeLayout(false);
            this.tblDatosEmpresa.PerformLayout();
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
        private System.Windows.Forms.TextBox tbCp;
        private System.Windows.Forms.Label lbCp;
        private System.Windows.Forms.GroupBox gbDatosEmpresa;
        private System.Windows.Forms.TableLayoutPanel tblDatosEmpresa;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbFecCon;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkUsuario;
        private System.Windows.Forms.Label lbObservaciones;
        private System.Windows.Forms.TextBox tbObservaciones;
    }
}