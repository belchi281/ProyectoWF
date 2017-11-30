using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ProyectoWF {
    public partial class FormularioEmpleados : Form {
        // Atributos
        private int modo;
        private int pk;
        private SqlConnection conn;
        private SqlCommand insertarEmpleado;
        private SqlCommand modificarEmpleado;
        private SqlCommand insertarEmpleadoSinFoto;
        private SqlCommand modificarEmpleadoSinFoto;
        SqlCommand consultarEmpleado;
        private string imagen = "";

        // Constructor
        public FormularioEmpleados(int modo, int pk)
        {
            this.modo = modo;
            this.pk = pk;

            InitializeComponent();

            // Base de datos
            conn = Conexion.getConexion();
            if (conn != null)
            {
                insertarEmpleado = new SqlCommand("INSERT INTO empleados VALUES(@Apellidos, @Nombre, @FecNac, @FecCont, @Direccion, @Ciudad, @Region, @Cp, @Pais, @Telefono," +
                    "@Foto, @Observaciones, @FotoPath, @EsUsuario, @Usuario, @Password)", conn);

                insertarEmpleadoSinFoto = new SqlCommand("INSERT INTO empleados (Apellidos, Nombre, FechaNacimiento, FechaContratacion," +
                    "Direccion, Ciudad, Region, CodigoPostal, Pais, Telefono, Observaciones, esUsuario," +
                    "Usuario, Password) VALUES(@Apellidos, @Nombre, @FecNac, @FecCont, @Direccion, @Ciudad, @Region, @Cp, @Pais, @Telefono," +
                    "@Observaciones, @EsUsuario, @Usuario, @Password)", conn);

                modificarEmpleado = new SqlCommand("UPDATE empleados SET Apellidos = @Apellidos, Nombre = @Nombre, FechaNacimiento = @FecNac, FechaContratacion = @FecCont," +
                    "Direccion = @Direccion, Ciudad = @Ciudad, Region = @Region, CodigoPostal = @Cp, Pais = @Pais, Telefono = @Telefono, Foto = @Foto, Observaciones = @Observaciones, esUsuario = @EsUsuario," +
                    "Usuario = @Usuario, Password = @Password WHERE EmpleadoId = @id", conn);

                modificarEmpleadoSinFoto = new SqlCommand("UPDATE empleados SET Apellidos = @Apellidos, Nombre = @Nombre, FechaNacimiento = @FecNac, FechaContratacion = @FecCont," +
                    "Direccion = @Direccion, Ciudad = @Ciudad, Region = @Region, CodigoPostal = @Cp, Pais = @Pais, Telefono = @Telefono, Observaciones = @Observaciones, esUsuario = @EsUsuario," +
                    "Usuario = @Usuario, Password = @Password WHERE EmpleadoId = @id", conn);

                consultarEmpleado = new SqlCommand("Select * From empleados WHERE EmpleadoID = @id", conn);
            }

            if (modo == 0) {
                // Alta
                this.Text = "Alta de empleado";
                tbUsuario.Enabled = false;
                tbContraseña.Enabled = false;
            } else if (modo == 1) {
                // Modificacion
                this.Text = "Modificacion de empleado";
                datosEmpleado();
                
            } else if (modo == 2) {
                // Vista de datos
                this.Text = "Datos de empleado";
                tbNombre.Enabled = false;
                tbApellidos.Enabled = false;
                dtpFecNac.Enabled = false;
                tbDireccion.Enabled = false;
                tbCiudad.Enabled = false;
                tbCp.Enabled = false;
                tbRegion.Enabled = false;
                tbPais.Enabled = false;
                dtpFecCon.Enabled = false;
                mtbTelefono.Enabled = false;
                checkUsuario.Enabled = false;
                tbObservaciones.Enabled = false;
                tbUsuario.Enabled = false;
                tbContraseña.Enabled = false;
                btBuscarFoto.Enabled = false;
                datosEmpleado();

            }
        }

        private void btBuscarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    imagen = openFile.FileName;
                    pbFoto.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido " + ex.ToString());
            }
        }

        private Boolean faltanDatosObligatorios()
        {
            if (tbNombre.Text.Length == 0 || tbApellidos.Text.Length == 0)
                return true;
            if (checkUsuario.Checked)
            {
                if (tbUsuario.Text.Length == 0 || tbContraseña.Text.Length == 0)
                    return true;
            }
            return false;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (conn == null)
            {
                MessageBox.Show("Error! No hay conexion!");
                return;
            }

            switch (modo)
            {
                case 0: // Alta
                    {
                        if (faltanDatosObligatorios())
                        {
                            MessageBox.Show("Error! Rellena todos los campos obligatorios!");
                            return;
                        }
                        

                        if (imagen.Length > 0)
                        {
                            insertarEmpleado.Parameters.Clear();
                            insertarEmpleado.Parameters.AddWithValue("@Apellidos", tbApellidos.Text);
                            insertarEmpleado.Parameters.AddWithValue("@Nombre", tbNombre.Text);
                            insertarEmpleado.Parameters.AddWithValue("@FecNac", SqlDbType.DateTime).Value = dtpFecNac.Value;
                            insertarEmpleado.Parameters.AddWithValue("@FecCont", SqlDbType.DateTime).Value = dtpFecCon.Value;
                            insertarEmpleado.Parameters.AddWithValue("@Direccion", tbDireccion.Text);
                            insertarEmpleado.Parameters.AddWithValue("@Ciudad", tbCiudad.Text);
                            insertarEmpleado.Parameters.AddWithValue("@Region", tbRegion.Text);

                            insertarEmpleado.Parameters.AddWithValue("@Cp", tbCp.Text);
                            insertarEmpleado.Parameters.AddWithValue("@Pais", tbPais.Text);

                            if (mtbTelefono.MaskFull)
                            {
                                insertarEmpleado.Parameters.AddWithValue("@Telefono", mtbTelefono.Text);
                            }
                            else
                            {
                                insertarEmpleado.Parameters.AddWithValue("@Telefono", DBNull.Value);
                            }

                            byte[] imageData;
                            imageData = File.ReadAllBytes(@imagen);
                            insertarEmpleado.Parameters.Add("@Foto", SqlDbType.Image).Value = imageData;
                            insertarEmpleado.Parameters.AddWithValue("@Observaciones", tbObservaciones.Text);

                            insertarEmpleado.Parameters.AddWithValue("@FotoPath", "");

                            insertarEmpleado.Parameters.AddWithValue("@EsUsuario", checkUsuario.Checked ? true : false);
                            if (checkUsuario.Checked)
                            {
                                insertarEmpleado.Parameters.AddWithValue("@Usuario", tbUsuario.Text);
                                // Encriptamos la contraseña
                                byte[] data = new byte[tbContraseña.Text.Length];
                                byte[] contraseña;
                                SHA512 shaM = new SHA512Managed();
                                contraseña = shaM.ComputeHash(data);
                                insertarEmpleado.Parameters.AddWithValue("@Password", contraseña);
                            }
                            else
                            {
                                insertarEmpleado.Parameters.AddWithValue("@Usuario", DBNull.Value);
                                insertarEmpleado.Parameters.AddWithValue("@Password", DBNull.Value);
                            }

                            try
                            {
                                insertarEmpleado.ExecuteNonQuery();
                                MessageBox.Show("Empleado dado de alta", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiarCampos();
                            }
                            catch (SqlException sql)
                            {
                                MessageBox.Show(sql.ToString());
                            }
                        } else
                        {
                            insertarEmpleadoSinFoto.Parameters.Clear();
                            insertarEmpleadoSinFoto.Parameters.AddWithValue("@Apellidos", tbApellidos.Text);
                            insertarEmpleadoSinFoto.Parameters.AddWithValue("@Nombre", tbNombre.Text);
                            insertarEmpleadoSinFoto.Parameters.AddWithValue("@FecNac", SqlDbType.DateTime).Value = dtpFecNac.Value;
                            insertarEmpleadoSinFoto.Parameters.AddWithValue("@FecCont", SqlDbType.DateTime).Value = dtpFecCon.Value;
                            insertarEmpleadoSinFoto.Parameters.AddWithValue("@Direccion", tbDireccion.Text);
                            insertarEmpleadoSinFoto.Parameters.AddWithValue("@Ciudad", tbCiudad.Text);
                            insertarEmpleadoSinFoto.Parameters.AddWithValue("@Region", tbRegion.Text);

                            insertarEmpleadoSinFoto.Parameters.AddWithValue("@Cp", tbCp.Text);
                            insertarEmpleadoSinFoto.Parameters.AddWithValue("@Pais", tbPais.Text);

                            if (mtbTelefono.MaskFull)
                            {
                                insertarEmpleadoSinFoto.Parameters.AddWithValue("@Telefono", mtbTelefono.Text);
                            }
                            else
                            {
                                insertarEmpleadoSinFoto.Parameters.AddWithValue("@Telefono", DBNull.Value);
                            }
                            insertarEmpleadoSinFoto.Parameters.AddWithValue("@Observaciones", tbObservaciones.Text);

                            insertarEmpleadoSinFoto.Parameters.AddWithValue("@EsUsuario", checkUsuario.Checked ? true : false);
                            if (checkUsuario.Checked)
                            {
                                insertarEmpleadoSinFoto.Parameters.AddWithValue("@Usuario", tbUsuario.Text);
                                // Encriptamos la contraseña
                                byte[] data = new byte[tbContraseña.Text.Length];
                                byte[] contraseña;
                                SHA512 shaM = new SHA512Managed();
                                contraseña = shaM.ComputeHash(data);
                                insertarEmpleadoSinFoto.Parameters.AddWithValue("@Password", contraseña);
                            } else
                            {
                                insertarEmpleadoSinFoto.Parameters.AddWithValue("@Usuario", DBNull.Value);
                                insertarEmpleadoSinFoto.Parameters.AddWithValue("@Password", DBNull.Value);
                            }
                            

                            

                            try
                            {
                                insertarEmpleadoSinFoto.ExecuteNonQuery();
                                MessageBox.Show("Empleado dado de alta", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiarCampos();
                            }
                            catch (SqlException sql)
                            {
                                MessageBox.Show(sql.ToString());
                            }
                        }

                                              

                    }
                    break;
                case 1: // modificar empleado
                    {                        

                        if (imagen.Length > 0)
                        {
                            modificarEmpleado.Parameters.Clear();
                            modificarEmpleado.Parameters.AddWithValue("@Apellidos", tbApellidos.Text);
                            modificarEmpleado.Parameters.AddWithValue("@Nombre", tbNombre.Text);
                            modificarEmpleado.Parameters.AddWithValue("@FecNac", SqlDbType.DateTime).Value = dtpFecNac.Value;
                            modificarEmpleado.Parameters.AddWithValue("@FecCont", SqlDbType.DateTime).Value = dtpFecCon.Value;
                            modificarEmpleado.Parameters.AddWithValue("@Direccion", tbDireccion.Text);
                            modificarEmpleado.Parameters.AddWithValue("@Ciudad", tbCiudad.Text);
                            modificarEmpleado.Parameters.AddWithValue("@Region", tbRegion.Text);

                            modificarEmpleado.Parameters.AddWithValue("@Cp", tbCp.Text);
                            modificarEmpleado.Parameters.AddWithValue("@Pais", tbPais.Text);

                            if (mtbTelefono.MaskFull)
                            {
                                modificarEmpleado.Parameters.AddWithValue("@Telefono", mtbTelefono.Text);
                            }
                            else
                            {
                                modificarEmpleado.Parameters.AddWithValue("@Telefono", DBNull.Value);
                            }
                            byte[] imageData;
                            imageData = File.ReadAllBytes(@imagen);
                            modificarEmpleado.Parameters.Add("@Foto", SqlDbType.Image).Value = imageData;
                            modificarEmpleado.Parameters.AddWithValue("@Observaciones", tbObservaciones.Text);

                            modificarEmpleado.Parameters.AddWithValue("@FotoPath", "");

                            modificarEmpleado.Parameters.AddWithValue("@EsUsuario", checkUsuario.Checked ? true : false);
                            if (checkUsuario.Checked)
                            {
                                modificarEmpleado.Parameters.AddWithValue("@Usuario", tbUsuario.Text);
                                // Encriptamos la contraseña
                                byte[] data = new byte[tbContraseña.Text.Length];
                                byte[] contraseña;
                                SHA512 shaM = new SHA512Managed();
                                contraseña = shaM.ComputeHash(data);
                                modificarEmpleado.Parameters.AddWithValue("@Password", contraseña);
                            }
                            else
                            {
                                modificarEmpleado.Parameters.AddWithValue("@Usuario", DBNull.Value);
                                modificarEmpleado.Parameters.AddWithValue("@Password", DBNull.Value);
                            }
                            modificarEmpleado.Parameters.AddWithValue("@id", pk);
                            try
                            {
                                modificarEmpleado.ExecuteNonQuery();
                                MessageBox.Show("Empleado modificado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (SqlException sqlEx)
                            {
                                MessageBox.Show(sqlEx.ToString());
                            }
                        }
                        else
                        {
                            modificarEmpleadoSinFoto.Parameters.Clear();
                            modificarEmpleadoSinFoto.Parameters.AddWithValue("@Apellidos", tbApellidos.Text);
                            modificarEmpleadoSinFoto.Parameters.AddWithValue("@Nombre", tbNombre.Text);
                            modificarEmpleadoSinFoto.Parameters.AddWithValue("@FecNac", SqlDbType.DateTime).Value = dtpFecNac.Value;
                            modificarEmpleadoSinFoto.Parameters.AddWithValue("@FecCont", SqlDbType.DateTime).Value = dtpFecCon.Value;
                            modificarEmpleadoSinFoto.Parameters.AddWithValue("@Direccion", tbDireccion.Text);
                            modificarEmpleadoSinFoto.Parameters.AddWithValue("@Ciudad", tbCiudad.Text);
                            modificarEmpleadoSinFoto.Parameters.AddWithValue("@Region", tbRegion.Text);

                            modificarEmpleadoSinFoto.Parameters.AddWithValue("@Cp", tbCp.Text);
                            modificarEmpleadoSinFoto.Parameters.AddWithValue("@Pais", tbPais.Text);

                            if (mtbTelefono.MaskFull)
                            {
                                modificarEmpleadoSinFoto.Parameters.AddWithValue("@Telefono", mtbTelefono.Text);
                            }
                            else
                            {
                                modificarEmpleadoSinFoto.Parameters.AddWithValue("@Telefono", DBNull.Value);
                            }
                            modificarEmpleadoSinFoto.Parameters.AddWithValue("@Observaciones", tbObservaciones.Text);

                            modificarEmpleadoSinFoto.Parameters.AddWithValue("@EsUsuario", checkUsuario.Checked ? true : false);
                            if (checkUsuario.Checked)
                            {
                                modificarEmpleadoSinFoto.Parameters.AddWithValue("@Usuario", tbUsuario.Text);
                                // Encriptamos la contraseña
                                byte[] data = new byte[tbContraseña.Text.Length];
                                byte[] contraseña;
                                SHA512 shaM = new SHA512Managed();
                                contraseña = shaM.ComputeHash(data);
                                modificarEmpleadoSinFoto.Parameters.AddWithValue("@Password", contraseña);
                            }
                            else
                            {
                                modificarEmpleadoSinFoto.Parameters.AddWithValue("@Usuario", DBNull.Value);
                                modificarEmpleadoSinFoto.Parameters.AddWithValue("@Password", DBNull.Value);
                            }
                            modificarEmpleadoSinFoto.Parameters.AddWithValue("@id", pk);
                            try
                            {
                                modificarEmpleadoSinFoto.ExecuteNonQuery();
                                MessageBox.Show("Empleado modificado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (SqlException sqlEx)
                            {
                                MessageBox.Show(sqlEx.ToString());
                            }
                        }
                        
                    }
                    break;
                case 2:
                    break;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            Close();
        }

        private void datosEmpleado()
        {
            SqlDataReader dr = null;
            try
            {
                
                consultarEmpleado.Parameters.AddWithValue("@id", pk);
                dr = consultarEmpleado.ExecuteReader();

                if (dr.Read())
                {
                    tbId.Text = dr.GetInt32(0) + "";
                    tbApellidos.Text = dr.GetString(1);
                    tbNombre.Text = dr.GetString(2);
                    try
                    {
                        dtpFecNac.Text = dr.GetDateTime(3).ToLongDateString();
                        dtpFecCon.Text = dr.GetDateTime(4).ToLongDateString();
                        tbDireccion.Text = dr.GetString(5);
                        tbCiudad.Text = dr.GetString(6);
                        tbRegion.Text = dr.GetString(7);
                        tbCp.Text = dr.GetString(8);
                        tbPais.Text = dr.GetString(9);
                        mtbTelefono.Text = dr.GetString(10);
                        // foto
                        tbObservaciones.Text = dr.GetString(12);
                        // fotoPath                        
                    } catch (SqlNullValueException sqlN) {
                    } catch (InvalidOperationException ioe) {
                    }

                    if (dr.GetBoolean(14)) {
                        checkUsuario.Checked = true;
                        tbUsuario.Text = dr.GetString(15);
                        tbContraseña.Text = dr.GetString(16);
                        tbUsuario.Enabled = true;
                        tbContraseña.Enabled = true;
                    } else {
                        checkUsuario.Checked = false;
                        tbUsuario.Enabled = false;
                        tbContraseña.Enabled = false;
                    }

                }
            } catch (SqlException sql)
            {
                MessageBox.Show(sql.ToString());
            } finally
            {
                if (dr != null)
                {
                    dr.Close();
                }
            }
        }

        private void checkUsuario_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkUsuario = (CheckBox) sender;
            if (checkUsuario.Checked)
            {
                tbUsuario.Enabled = true;
                tbContraseña.Enabled = true;
            } else
            {
                tbUsuario.Enabled = false;
                tbContraseña.Enabled = false;
            }
        }

        private void limpiarCampos()
        {
            tbId.Text = "";
            tbApellidos.Text = "";
            tbNombre.Text = "";
            dtpFecNac.Text = "";
            dtpFecCon.Text = "";
            tbDireccion.Text = "";
            tbCiudad.Text = "";
            tbRegion.Text = "";
            tbCp.Text = "";
            tbPais.Text = "";
            mtbTelefono.Text = "";
            pbFoto.Image = null;
            tbObservaciones.Text = "";
            // fotoPath 
        }
    }
}
