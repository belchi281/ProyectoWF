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
            this.lbFecNac = new System.Windows.Forms.Label();
            this.lbFoto = new System.Windows.Forms.Label();
            this.btBuscarFoto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.dtpFecNac = new System.Windows.Forms.DateTimePicker();
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbFecCon = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbObservaciones = new System.Windows.Forms.Label();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecCon = new System.Windows.Forms.DateTimePicker();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.tblAcceso = new System.Windows.Forms.TableLayoutPanel();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbContraseña = new System.Windows.Forms.Label();
            this.checkUsuario = new System.Windows.Forms.CheckBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCamposObligatorios = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.tblPrincipal.SuspendLayout();
            this.gbDatosPersonales.SuspendLayout();
            this.tblDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.gbDireccion.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbDatosEmpresa.SuspendLayout();
            this.tblDatosEmpresa.SuspendLayout();
            this.gbLogin.SuspendLayout();
            this.tblAcceso.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPrincipal
            // 
            this.tblPrincipal.ColumnCount = 3;
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPrincipal.Controls.Add(this.gbDatosPersonales, 0, 0);
            this.tblPrincipal.Controls.Add(this.gbDireccion, 1, 0);
            this.tblPrincipal.Controls.Add(this.gbDatosEmpresa, 0, 1);
            this.tblPrincipal.Controls.Add(this.gbLogin, 1, 1);
            this.tblPrincipal.Controls.Add(this.lbCamposObligatorios, 0, 2);
            this.tblPrincipal.Controls.Add(this.btCancelar, 1, 2);
            this.tblPrincipal.Controls.Add(this.btAceptar, 2, 2);
            this.tblPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tblPrincipal.MinimumSize = new System.Drawing.Size(640, 460);
            this.tblPrincipal.Name = "tblPrincipal";
            this.tblPrincipal.RowCount = 3;
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPrincipal.Size = new System.Drawing.Size(764, 521);
            this.tblPrincipal.TabIndex = 0;
            // 
            // gbDatosPersonales
            // 
            this.gbDatosPersonales.Controls.Add(this.tblDatosPersonales);
            this.gbDatosPersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDatosPersonales.Location = new System.Drawing.Point(3, 3);
            this.gbDatosPersonales.Name = "gbDatosPersonales";
            this.gbDatosPersonales.Size = new System.Drawing.Size(369, 240);
            this.gbDatosPersonales.TabIndex = 0;
            this.gbDatosPersonales.TabStop = false;
            this.gbDatosPersonales.Text = "Datos personales";
            // 
            // tblDatosPersonales
            // 
            this.tblDatosPersonales.ColumnCount = 4;
            this.tblDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDatosPersonales.Controls.Add(this.lbNombre, 0, 0);
            this.tblDatosPersonales.Controls.Add(this.lbApellidos, 0, 1);
            this.tblDatosPersonales.Controls.Add(this.lbFecNac, 0, 2);
            this.tblDatosPersonales.Controls.Add(this.lbFoto, 0, 3);
            this.tblDatosPersonales.Controls.Add(this.btBuscarFoto, 1, 3);
            this.tblDatosPersonales.Controls.Add(this.label1, 3, 0);
            this.tblDatosPersonales.Controls.Add(this.label2, 3, 1);
            this.tblDatosPersonales.Controls.Add(this.pbFoto, 2, 3);
            this.tblDatosPersonales.Controls.Add(this.tbNombre, 2, 0);
            this.tblDatosPersonales.Controls.Add(this.tbApellidos, 2, 1);
            this.tblDatosPersonales.Controls.Add(this.dtpFecNac, 2, 2);
            this.tblDatosPersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDatosPersonales.Location = new System.Drawing.Point(3, 16);
            this.tblDatosPersonales.Name = "tblDatosPersonales";
            this.tblDatosPersonales.RowCount = 4;
            this.tblDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDatosPersonales.Size = new System.Drawing.Size(363, 221);
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
            this.lbNombre.Text = "Nombre ";
            // 
            // lbApellidos
            // 
            this.lbApellidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Location = new System.Drawing.Point(3, 32);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(93, 13);
            this.lbApellidos.TabIndex = 1;
            this.lbApellidos.Text = "Apellidos ";
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
            // btBuscarFoto
            // 
            this.btBuscarFoto.Location = new System.Drawing.Point(102, 81);
            this.btBuscarFoto.Name = "btBuscarFoto";
            this.btBuscarFoto.Size = new System.Drawing.Size(40, 25);
            this.btBuscarFoto.TabIndex = 9;
            this.btBuscarFoto.Text = "...";
            this.btBuscarFoto.UseVisualStyleBackColor = true;
            this.btBuscarFoto.Click += new System.EventHandler(this.btBuscarFoto_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(344, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(344, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "*";
            // 
            // pbFoto
            // 
            this.pbFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFoto.Location = new System.Drawing.Point(148, 81);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(190, 137);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 7;
            this.pbFoto.TabStop = false;
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombre.Location = new System.Drawing.Point(148, 3);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(190, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbApellidos.Location = new System.Drawing.Point(148, 29);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(190, 20);
            this.tbApellidos.TabIndex = 2;
            // 
            // dtpFecNac
            // 
            this.dtpFecNac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFecNac.Location = new System.Drawing.Point(148, 55);
            this.dtpFecNac.Name = "dtpFecNac";
            this.dtpFecNac.Size = new System.Drawing.Size(190, 20);
            this.dtpFecNac.TabIndex = 13;
            // 
            // gbDireccion
            // 
            this.tblPrincipal.SetColumnSpan(this.gbDireccion, 2);
            this.gbDireccion.Controls.Add(this.tableLayoutPanel1);
            this.gbDireccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDireccion.Location = new System.Drawing.Point(378, 3);
            this.gbDireccion.Name = "gbDireccion";
            this.gbDireccion.Size = new System.Drawing.Size(383, 240);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(377, 221);
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
            this.tbDireccion.Size = new System.Drawing.Size(316, 20);
            this.tbDireccion.TabIndex = 4;
            // 
            // tbCiudad
            // 
            this.tbCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCiudad.Location = new System.Drawing.Point(61, 29);
            this.tbCiudad.Name = "tbCiudad";
            this.tbCiudad.Size = new System.Drawing.Size(316, 20);
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
            this.tbPais.Size = new System.Drawing.Size(316, 20);
            this.tbPais.TabIndex = 8;
            // 
            // tbRegion
            // 
            this.tbRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRegion.Location = new System.Drawing.Point(61, 81);
            this.tbRegion.Name = "tbRegion";
            this.tbRegion.Size = new System.Drawing.Size(316, 20);
            this.tbRegion.TabIndex = 7;
            // 
            // tbCp
            // 
            this.tbCp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCp.Location = new System.Drawing.Point(61, 55);
            this.tbCp.Name = "tbCp";
            this.tbCp.Size = new System.Drawing.Size(316, 20);
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
            this.gbDatosEmpresa.Location = new System.Drawing.Point(3, 249);
            this.gbDatosEmpresa.Name = "gbDatosEmpresa";
            this.gbDatosEmpresa.Size = new System.Drawing.Size(369, 240);
            this.gbDatosEmpresa.TabIndex = 2;
            this.gbDatosEmpresa.TabStop = false;
            this.gbDatosEmpresa.Text = "groupBox1";
            // 
            // tblDatosEmpresa
            // 
            this.tblDatosEmpresa.ColumnCount = 3;
            this.tblDatosEmpresa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDatosEmpresa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDatosEmpresa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDatosEmpresa.Controls.Add(this.lbId, 0, 0);
            this.tblDatosEmpresa.Controls.Add(this.tbId, 1, 0);
            this.tblDatosEmpresa.Controls.Add(this.lbFecCon, 0, 1);
            this.tblDatosEmpresa.Controls.Add(this.lbTelefono, 0, 2);
            this.tblDatosEmpresa.Controls.Add(this.lbObservaciones, 0, 4);
            this.tblDatosEmpresa.Controls.Add(this.tbObservaciones, 1, 4);
            this.tblDatosEmpresa.Controls.Add(this.mtbTelefono, 1, 2);
            this.tblDatosEmpresa.Controls.Add(this.label3, 2, 0);
            this.tblDatosEmpresa.Controls.Add(this.dtpFecCon, 1, 1);
            this.tblDatosEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDatosEmpresa.Location = new System.Drawing.Point(3, 16);
            this.tblDatosEmpresa.Name = "tblDatosEmpresa";
            this.tblDatosEmpresa.RowCount = 5;
            this.tblDatosEmpresa.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDatosEmpresa.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDatosEmpresa.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDatosEmpresa.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDatosEmpresa.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDatosEmpresa.Size = new System.Drawing.Size(363, 221);
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
            // tbId
            // 
            this.tbId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(123, 3);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(215, 20);
            this.tbId.TabIndex = 9;
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
            // lbObservaciones
            // 
            this.lbObservaciones.AutoSize = true;
            this.lbObservaciones.Location = new System.Drawing.Point(3, 83);
            this.lbObservaciones.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbObservaciones.Name = "lbObservaciones";
            this.lbObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lbObservaciones.TabIndex = 7;
            this.lbObservaciones.Text = "Observaciones";
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbObservaciones.Location = new System.Drawing.Point(123, 81);
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(215, 140);
            this.tbObservaciones.TabIndex = 13;
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbTelefono.Location = new System.Drawing.Point(123, 55);
            this.mtbTelefono.Mask = "999-999-999";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.Size = new System.Drawing.Size(215, 20);
            this.mtbTelefono.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(344, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "*";
            // 
            // dtpFecCon
            // 
            this.dtpFecCon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFecCon.Location = new System.Drawing.Point(123, 29);
            this.dtpFecCon.Name = "dtpFecCon";
            this.dtpFecCon.Size = new System.Drawing.Size(215, 20);
            this.dtpFecCon.TabIndex = 17;
            // 
            // gbLogin
            // 
            this.tblPrincipal.SetColumnSpan(this.gbLogin, 2);
            this.gbLogin.Controls.Add(this.tblAcceso);
            this.gbLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbLogin.Location = new System.Drawing.Point(378, 249);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(383, 240);
            this.gbLogin.TabIndex = 3;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Datos de acceso";
            // 
            // tblAcceso
            // 
            this.tblAcceso.ColumnCount = 3;
            this.tblAcceso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblAcceso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblAcceso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblAcceso.Controls.Add(this.lbUsuario, 0, 1);
            this.tblAcceso.Controls.Add(this.lbContraseña, 0, 2);
            this.tblAcceso.Controls.Add(this.checkUsuario, 0, 0);
            this.tblAcceso.Controls.Add(this.tbUsuario, 1, 1);
            this.tblAcceso.Controls.Add(this.tbContraseña, 1, 2);
            this.tblAcceso.Controls.Add(this.label4, 2, 1);
            this.tblAcceso.Controls.Add(this.label5, 2, 2);
            this.tblAcceso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblAcceso.Location = new System.Drawing.Point(3, 16);
            this.tblAcceso.Name = "tblAcceso";
            this.tblAcceso.RowCount = 3;
            this.tblAcceso.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblAcceso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblAcceso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblAcceso.Size = new System.Drawing.Size(377, 221);
            this.tblAcceso.TabIndex = 0;
            // 
            // lbUsuario
            // 
            this.lbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(3, 66);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(75, 13);
            this.lbUsuario.TabIndex = 0;
            this.lbUsuario.Text = "Usuario ";
            // 
            // lbContraseña
            // 
            this.lbContraseña.AutoSize = true;
            this.lbContraseña.Location = new System.Drawing.Point(3, 127);
            this.lbContraseña.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbContraseña.Name = "lbContraseña";
            this.lbContraseña.Size = new System.Drawing.Size(61, 13);
            this.lbContraseña.TabIndex = 1;
            this.lbContraseña.Text = "Contraseña";
            // 
            // checkUsuario
            // 
            this.checkUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkUsuario.AutoSize = true;
            this.checkUsuario.Location = new System.Drawing.Point(3, 3);
            this.checkUsuario.Name = "checkUsuario";
            this.checkUsuario.Size = new System.Drawing.Size(75, 17);
            this.checkUsuario.TabIndex = 12;
            this.checkUsuario.Text = "Es usuario";
            this.checkUsuario.UseVisualStyleBackColor = true;
            this.checkUsuario.CheckedChanged += new System.EventHandler(this.checkUsuario_CheckedChanged);
            // 
            // tbUsuario
            // 
            this.tbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUsuario.Location = new System.Drawing.Point(84, 62);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(268, 20);
            this.tbUsuario.TabIndex = 2;
            // 
            // tbContraseña
            // 
            this.tbContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbContraseña.Location = new System.Drawing.Point(84, 125);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.PasswordChar = '*';
            this.tbContraseña.Size = new System.Drawing.Size(268, 20);
            this.tbContraseña.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(358, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(358, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "*";
            // 
            // lbCamposObligatorios
            // 
            this.lbCamposObligatorios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCamposObligatorios.AutoSize = true;
            this.lbCamposObligatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCamposObligatorios.ForeColor = System.Drawing.Color.Red;
            this.lbCamposObligatorios.Location = new System.Drawing.Point(5, 499);
            this.lbCamposObligatorios.Margin = new System.Windows.Forms.Padding(5, 0, 3, 5);
            this.lbCamposObligatorios.Name = "lbCamposObligatorios";
            this.lbCamposObligatorios.Size = new System.Drawing.Size(166, 17);
            this.lbCamposObligatorios.TabIndex = 4;
            this.lbCamposObligatorios.Text = "* Campos obligatorios";
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.Location = new System.Drawing.Point(604, 495);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAceptar.Location = new System.Drawing.Point(685, 495);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 6;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // FormularioEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 521);
            this.Controls.Add(this.tblPrincipal);
            this.MinimumSize = new System.Drawing.Size(780, 560);
            this.Name = "FormularioEmpleados";
            this.tblPrincipal.ResumeLayout(false);
            this.tblPrincipal.PerformLayout();
            this.gbDatosPersonales.ResumeLayout(false);
            this.tblDatosPersonales.ResumeLayout(false);
            this.tblDatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.gbDireccion.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbDatosEmpresa.ResumeLayout(false);
            this.tblDatosEmpresa.ResumeLayout(false);
            this.tblDatosEmpresa.PerformLayout();
            this.gbLogin.ResumeLayout(false);
            this.tblAcceso.ResumeLayout(false);
            this.tblAcceso.PerformLayout();
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
        private System.Windows.Forms.Label lbFecNac;
        private System.Windows.Forms.Label lbFoto;
        private System.Windows.Forms.GroupBox gbDatosEmpresa;
        private System.Windows.Forms.TableLayoutPanel tblDatosEmpresa;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbFecCon;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.CheckBox checkUsuario;
        private System.Windows.Forms.Label lbObservaciones;
        private System.Windows.Forms.TextBox tbObservaciones;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btBuscarFoto;
        private System.Windows.Forms.MaskedTextBox mtbTelefono;
        private System.Windows.Forms.GroupBox gbDireccion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbCiudad;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbCiudad;
        private System.Windows.Forms.Label lbPais;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.TextBox tbRegion;
        private System.Windows.Forms.TextBox tbCp;
        private System.Windows.Forms.Label lbCp;
        private System.Windows.Forms.Label lbRegion;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.TableLayoutPanel tblAcceso;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCamposObligatorios;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecNac;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFecCon;
    }
}