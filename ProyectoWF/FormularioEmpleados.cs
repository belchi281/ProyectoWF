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

    /// <summary>
    /// Clase principal del formulario de empleados.
    /// Esta clase contiene todos los métodos necesarios para la gestión de empleados.
    /// Dispone de atributos privados que forman las sentencias SQL necesarias además de los
    /// métodos donde se ejecutan para poder insertar, modificar o listar empleados.
    /// </summary>
    public partial class FormularioEmpleados : Form {

        /// <summary>
        /// Atributos.
        /// Modo: Es el modo en el que el formulario se iniciara. Puede ser como “Alta, Modificación o Listado”.
        /// Pk: Clave primaria recibida por parámetro en el constructor, utilizada para listar o modificar un empleado en concreto.
        /// conn: Conexión a la base de datos, se utiliza un singleton para asegurar qué la conexión a la base de datos se realiza solo una vez y que no es nula.
        /// insertarEmpleado: Comando que contiene la sentencia SQL necesaria para insertar un empleado en la base de datos.
        /// modificarEmpleado: Comando que contiene la sentencia SQL necesaria para modificar un empleado en concreto en la base de datos.
        /// insertarEmpleadoSinFoto: Sentencia SQL similar a la de insertar empleado pero quitando el campo Foto para introducir un nulo.
        /// modificarEmpleadoSinFoto. Sentencia SQL similar a la de modificar empleado pero quitando el campo Foto para introducir un nulo.
        /// consultarEmpleado: Sentencia SQL que ejecuta una QUERY que devuelve todos los datos de un empleado en concreto, si existe.
        /// imagen: contiene la ruta de la imagen que se desea almacenar en la base de datos;
        /// </summary>
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
        /// <summary>
        /// constructor principal sobrecargado del formulario empleados.
        /// </summary>
        /// <param name="modo"> modo en el que se puede ejecutar el formulario.</param>
        /// <param name="pk">clave primaria del empleado para realizar uan consulta.</param>
        public FormularioEmpleados(int modo, int pk)
        {
            this.modo = modo;
            this.pk = pk;

            InitializeComponent();

            // Base de datos
            conn = Conexion.getConexion();
            if (conn != null) // Si la conexión a base de datos se ha realizado correctamente, preparamos las sentencias SQL necesarias.
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
            } else if (modo == 1) {
                // Modificacion
                this.Text = "Modificacion de empleado";
                datosEmpleado();
                
            } else if (modo == 2) {

                // Vista de datos
                // Deshabilita todos los campos para evitar la modificación de los mismos.
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

        /// <summary>
        /// Acción que recoge el evento de “Click” del botón buscar foto.
        /// Muestra un dialogo de búsqueda de ficheros en el cual se aplica un filtro para solo poder seleccionar imágenes.
        /// </summary>
        /// <param name="sender">Parámetro de tipo "object" que representa una referencia al objeto que lanza ese evento.</param>
        /// <param name="e">Parámetro de tipo "EventArgs" que contiene el evento generado.</param>
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

        /// <summary>
        /// Método que comprueba que los campos obligatorios “Nombre, Apellidos, Usuario y Contraseña están rellenados”.
        /// </summary>
        /// <returns>Devuelve true en caso de que los campos estén completos, y false en caso de que no.</returns>
        private Boolean faltanDatosObligatorios()
        {
            if (tbNombre.Text.Length == 0 || tbApellidos.Text.Length == 0 || tbUsuario.Text.Length == 0 || tbContraseña.Text.Length == 0)
                return true;
            return false;
        }

        /// <summary>
        /// Método que recoge el evento “Click” del botón aceptar.
        /// Comprueba si la conexión es nula y dependiendo del modo en el que se haya creado el formulario ejecutara una acción u otra.
        /// </summary>
        /// <param name="sender">//</param>
        /// <param name="e">//</param>
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

                        /*
                         * Dependiendo de la longitud de la ruta de la imagen ejecutaremos una insert u otra.
                         */
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
                            insertarEmpleado.Parameters.AddWithValue("@Usuario", tbUsuario.Text);

                            // Encriptamos la contraseña
                            byte[] data = new byte[tbContraseña.Text.Length];
                            byte[] contraseña;
                            SHA512 shaM = new SHA512Managed();
                            contraseña = shaM.ComputeHash(data);
                            insertarEmpleado.Parameters.AddWithValue("@Password", contraseña);

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
                            insertarEmpleadoSinFoto.Parameters.AddWithValue("@Usuario", tbUsuario.Text);
                            // Encriptamos la contraseña
                            byte[] data = new byte[tbContraseña.Text.Length];
                            byte[] contraseña;
                            SHA512 shaM = new SHA512Managed();
                            contraseña = shaM.ComputeHash(data);
                            insertarEmpleadoSinFoto.Parameters.AddWithValue("@Password", contraseña);

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
                            modificarEmpleado.Parameters.AddWithValue("@Usuario", tbUsuario.Text);

                            // Encriptamos la contraseña
                            byte[] data = new byte[tbContraseña.Text.Length];
                            byte[] contraseña;
                            SHA512 shaM = new SHA512Managed();
                            contraseña = shaM.ComputeHash(data);
                            modificarEmpleado.Parameters.AddWithValue("@Password", contraseña);
                            modificarEmpleado.Parameters.AddWithValue("@id", pk);

                            try
                            {
                                modificarEmpleado.ExecuteNonQuery();
                                MessageBox.Show("Empleado modificado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiarCampos();
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

                            modificarEmpleadoSinFoto.Parameters.AddWithValue("@Usuario", tbUsuario.Text);
                            // Encriptamos la contraseña
                            byte[] data = new byte[tbContraseña.Text.Length];
                            byte[] contraseña;
                            SHA512 shaM = new SHA512Managed();
                            contraseña = shaM.ComputeHash(data);
                            modificarEmpleadoSinFoto.Parameters.AddWithValue("@Password", contraseña);

                            modificarEmpleadoSinFoto.Parameters.AddWithValue("@id", pk);
                            try
                            {
                                modificarEmpleadoSinFoto.ExecuteNonQuery();
                                MessageBox.Show("Empleado modificado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiarCampos();
                            }
                            catch (SqlException sqlEx)
                            {
                                MessageBox.Show(sqlEx.ToString());
                            }
                        }
                        
                    }
                    break;
                case 2: // Esta opcion no realiza ninguna acción, asique simplemente cierra el formulario.
                    {
                        limpiarCampos();
                        Close();
                    }
                    break;
            }
        }

        /// <summary>
        /// Método que vacía los campos del formulario y lo cierra.
        /// </summary>
        /// <param name="sender">//</param>
        /// <param name="e">//</param>
        private void btCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            Close();
        }

        /// <summary>
        /// Método que ejecuta la sentencia SQL para obtener los datos de un empleado en concreto de la base de datos.
        /// </summary>
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
                        
                        if (!dr.IsDBNull(11))
                        {
                            byte[] imageData;
                            imageData = (byte[])dr[11];
                            pbFoto.Image = Image.FromStream(new MemoryStream(imageData));
                        }

                        tbObservaciones.Text = dr.GetString(12);
                        // fotoPath                        
                    } catch (SqlNullValueException sqlN) {
                    } catch (InvalidOperationException ioe) {
                    }

                    tbUsuario.Text = dr.GetString(15);
                    tbContraseña.Text = dr.GetString(16);

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

        /// <summary>
        /// Vacía todos los campos del formulario.
        /// </summary>
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
            tbUsuario.Text = "";
            tbContraseña.Text = "";
            // fotoPath, no es necesario limpiarlo ni añadirlo.
        }
    }
}
