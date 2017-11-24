using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ProyectoWF {
    public partial class FormularioEmpleados : Form {
        // Atributos
        private int modo;
        private int pk;
        private SqlConnection conn;
        private SqlCommand insertarEmpleado;

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
                insertarEmpleado = new SqlCommand("INSERT INTO empleados VALUES(@Id, @Apellidos, @Nombre, @FecNac, @FecCont, @Direccion, @Ciudad, @Region, @Cp, @Pais, @Telefono, @Observaciones" +
                    ", @EsUsuario, @Usuario, @Password)", conn);
                insertarEmpleado.Parameters.AddWithValue("@Id", SqlDbType.Int);
                insertarEmpleado.Parameters.AddWithValue("@Apellidos", SqlDbType.NVarChar);
                insertarEmpleado.Parameters.AddWithValue("@Nombre", SqlDbType.NVarChar);
                insertarEmpleado.Parameters.AddWithValue("@FecNac", SqlDbType.DateTime);
                insertarEmpleado.Parameters.AddWithValue("@FecCont", SqlDbType.DateTime);
                insertarEmpleado.Parameters.AddWithValue("@Direccion", SqlDbType.NVarChar);
                insertarEmpleado.Parameters.AddWithValue("@Ciudad", SqlDbType.NVarChar);
                insertarEmpleado.Parameters.AddWithValue("@Region", SqlDbType.NVarChar);
                insertarEmpleado.Parameters.AddWithValue("@Cp", SqlDbType.NVarChar);
                insertarEmpleado.Parameters.AddWithValue("@Pais", SqlDbType.NVarChar);
                insertarEmpleado.Parameters.AddWithValue("@Telefono", SqlDbType.NVarChar);

                insertarEmpleado.Parameters.AddWithValue("@Foto", SqlDbType.Image);

                insertarEmpleado.Parameters.AddWithValue("@Observaciones", SqlDbType.NText);

                insertarEmpleado.Parameters.AddWithValue("@FotoPath", SqlDbType.Image);

                insertarEmpleado.Parameters.AddWithValue("@EsUsuario", SqlDbType.Bit);
                insertarEmpleado.Parameters.AddWithValue("@Usuario", SqlDbType.NVarChar);
                insertarEmpleado.Parameters.AddWithValue("@Password", SqlDbType.NVarChar);                
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
                mtbFecNac.Enabled = false;
                tbDireccion.Enabled = false;
                tbCiudad.Enabled = false;
                tbCp.Enabled = false;
                tbRegion.Enabled = false;
                tbPais.Enabled = false;
                mtbFecContr.Enabled = false;
                mtbTelefono.Enabled = false;
                checkUsuario.Enabled = false;
                tbObservaciones.Enabled = false;
                tbUsuario.Enabled = false;
                tbContraseña.Enabled = false;
                btBuscarFoto.Enabled = false;
                btFotoPath.Enabled = false;

            }
        }

        private void btBuscarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFile.FileName;
                    pbFoto.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido " + ex.ToString());
            }
        }

        private void btFotoPath_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFile.FileName;
                    pbFotoPath.Image = Image.FromFile(imagen);
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
                        MessageBox.Show(mtbFecNac.Text);
                        insertarEmpleado.Parameters["@Id"].Value = "1";
                        insertarEmpleado.Parameters["@Apellidos"].Value = tbApellidos.Text;
                        insertarEmpleado.Parameters["@Nombre"].Value = tbNombre.Text;
                        insertarEmpleado.Parameters["@FecNac"].Value = mtbFecNac.Text;
                        insertarEmpleado.Parameters["@FecCont"].Value = mtbFecContr.Text;
                        insertarEmpleado.Parameters["@Direccion"].Value = tbDireccion.Text;
                        insertarEmpleado.Parameters["@Ciudad"].Value = tbCiudad.Text;
                        insertarEmpleado.Parameters["@Region"].Value = tbRegion.Text;
                        insertarEmpleado.Parameters["@Cp"].Value = tbCp.Text;
                        insertarEmpleado.Parameters["@Pais"].Value = tbPais.Text;
                        insertarEmpleado.Parameters["@Telefono"].Value = mtbTelefono.Text;
                        //string ruta = Application.StartupPath + pbFoto.ImageLocation;
                        //FileStream fs = new FileStream(ruta, FileMode.Open);
                        //BinaryReader br = new BinaryReader(fs);
                        //byte[] imagen = new byte[(int)fs.Length];
                        //br.Read(imagen, 0, (int)fs.Length);
                        //br.Close();
                        //fs.Close();


                        insertarEmpleado.Parameters["@Foto"].Value = "";

                        insertarEmpleado.Parameters["@Observaciones"].Value = tbObservaciones.Text;

                        insertarEmpleado.Parameters["@FotoPath"].Value = pbFotoPath.Image;

                        insertarEmpleado.Parameters["@EsUsuario"].Value = checkUsuario.Checked;
                        insertarEmpleado.Parameters["@Usuario"].Value = tbUsuario.Text;                        
                        insertarEmpleado.Parameters["@Password"].Value = tbContraseña.Text;

                        try
                        {
                            insertarEmpleado.ExecuteNonQuery();
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
    }
}
