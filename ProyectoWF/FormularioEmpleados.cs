using System;
using System.Data;
using System.Data.SqlClient;
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
            }

            if (modo == 0) {
                // Alta
                this.Text = "Alta de empleado";
            } else if (modo == 1) {
                // Modificacion
                this.Text = "Modificacion de empleado";
                
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
            if (tbNombre.Text.Length == 0 || tbApellidos.Text.Length == 0 || tbUsuario.Text.Length == 0 || tbContraseña.Text.Length == 0)
                return true;
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
                        } else
                        {
                            insertarEmpleado.Parameters.AddWithValue("@Telefono", DBNull.Value);
                        }

                        if (imagen.Length > 0)
                        {
                            byte[] imageData;
                            imageData = File.ReadAllBytes(@imagen);
                            insertarEmpleado.Parameters.Add("@Foto", SqlDbType.Image).Value = imageData;
                        } else
                        {
                            // otra consulta.
                        }

                        insertarEmpleado.Parameters.AddWithValue("@Observaciones", tbObservaciones.Text);

                        insertarEmpleado.Parameters.AddWithValue("@FotoPath", "alguien");

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
                            MessageBox.Show("Empleado dado de alta","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        catch (SqlException sql)
                        {
                            MessageBox.Show(sql.ToString());
                        }                        

                    }
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void datosEmpleado()
        {
            try
            {

                SqlCommand consultarEmpleado = new SqlCommand("Select * From empleados WHERE id = @id", conn);
                consultarEmpleado.Parameters.AddWithValue("@id", pk);
                SqlDataReader dr = consultarEmpleado.ExecuteReader();

                if (dr.Read())
                {
                    
                }
            } catch (SqlException sql)
            {
                MessageBox.Show(sql.ToString());
            }
        }

        private void checkUsuario_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
