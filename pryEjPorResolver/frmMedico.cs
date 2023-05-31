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
    public partial class frmMedico : Form
    {
        public frmMedico()
        {
            InitializeComponent();
        }

        private void frmMedico_Load(object sender, EventArgs e)
        {
            //buscar las especialidad
            ClassEspecialidad objEspecialidad = new ClassEspecialidad();

            objEspecialidad.ListarEspecialidad(cboEspecialidad);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }
    }
}
