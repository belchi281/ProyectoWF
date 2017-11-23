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
    }
}
