using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArmaniniI_IEFI
{
    public partial class frmPais : Form
    {
        public frmPais()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //llamo al objeto de la clase conexion para registrar un nuevo pais en la base de datos
            clsCodigo cls = new clsCodigo();
            cls.RegistrarPais(Convert.ToInt32(txtCodigo.Text), txtPais.Text);

            txtPais.Clear();
            txtCodigo.Clear();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistrar frm = new frmRegistrar();
            frm.Show();
        }

        private void txtPais_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string texto = textBox.Text;

            if (!string.IsNullOrEmpty(texto))
            {
                // Convertir la primera letra a mayúscula y el resto a minúsculas
                texto = texto.Substring(0, 1).ToUpper() + texto.Substring(1).ToLower();

                // Actualizar el texto en el TextBox
                textBox.Text = texto;

                // Colocar el cursor al final del texto
                textBox.SelectionStart = texto.Length;
            }

            if (txtPais.Text != "" && txtPais.Text != null)
            {
                btnRegistrar.Enabled = true;
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
