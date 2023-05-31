using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryLeerBaseArchivoTXT
{
    public partial class frmMetodoDeBusqueda : Form
    {
        public frmMetodoDeBusqueda()
        {
            InitializeComponent();
        }

        private void btnLeerArchivo_Click(object sender, EventArgs e)
        {
            int indice = 1;
            decimal suma = 0;

            //File.Exists("baseDatos.csv");

            if (File.Exists("baseDatos.csv"))
            {
                lblEstado.Text = "Se puede leer";
                lblEstado.BackColor = Color.Green;
            }
            else
            {
                lblEstado.Text = "!!! sin acceso !!!";
                lblEstado.BackColor = Color.Red;
            }

            StreamReader lectorArchivo = new StreamReader("baseDatos.csv");

            while (lectorArchivo.EndOfStream==false)
            {
                dgvDatos.Rows.Add(lectorArchivo.ReadLine());
                //1 columna == 0 es el nombre del ìtem
                //las otras columnas hay que sumarlas y dar un resultado - son 19 columnas
          

                //cargar el combo ITEM
                string auxItem = lectorArchivo.ReadLine();

                cboItems.Items.Add(auxItem.Split(';')[0]);


                indice = 1;
                suma = 0;

                //corregir la columna que falta ,y està sumando una sola fila
                while (indice < 19)
                {
                    suma = suma + Convert.ToDecimal(auxItem.Split(';')[indice]);

                    indice++;
                }

                
            }

            lectorArchivo.Close();
            MessageBox.Show(suma.ToString());
        }
    }
}
