using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoWF {
    public partial class FormularioEmpleados : Form {
        // Atributos
        private int modo;
        private int pk;

        // Constructor
        public FormularioEmpleados(int modo, int pk)
        {
            this.modo = modo;
            this.pk = pk;

            if (modo == 0) {
                // Alta
            } else if (modo == 1) {
                // Modificacion
            } else if (modo == 2) {
                // Vista de datos
            }
        }

        public FormularioEmpleados()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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

        private void tblAcceso_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormularioEmpleados_Load(object sender, EventArgs e)
        {

        }
    }
}
