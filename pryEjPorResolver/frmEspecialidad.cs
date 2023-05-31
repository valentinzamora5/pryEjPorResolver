using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEjPorResolver
{
    public partial class frmEspecialidad : Form
    {
        public frmEspecialidad()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ClassEspecialidad objEspecialidad = new ClassEspecialidad();

            objEspecialidad.RegistrarEspecialidad(int.Parse(txtCodigo.Text), txtNombre.Text);

            

        }
    }
}
