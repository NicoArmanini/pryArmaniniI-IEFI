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
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {
            clsCodigo cls = new clsCodigo();
            cls.CargarPaises(cmbPais);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool sexo = true;
            if (optHombre.Checked == true)
            {
                sexo = true;
            }
            else
            {
                if (optMujer.Checked == true)
                {
                    sexo = false;
                }
            }

            //llamo el objeto de la clase conexion para escribir un nuevo socio en la base de datos
            clsCodigo obj = new clsCodigo();
            obj.RegistrarSocio(txtNombre.Text, txtApellido.Text, cmbPais.Text, Convert.ToInt32(txtEdad.Text),
                                 sexo, Convert.ToDecimal(txtIngreso.Text), Convert.ToInt32(txtPuntaje.Text));

            MessageBox.Show("Cliente registrado con Exito!!", "", MessageBoxButtons.OK);

            LimpiarDatos();
        }

        private void btnRegPais_Click(object sender, EventArgs e)
        {
            frmPais frm = new frmPais();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void LimpiarDatos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            cmbPais.SelectedIndex = -1;
            txtEdad.Clear();
            txtIngreso.Clear();
            txtPuntaje.Clear();
            txtEdad.Enabled = false;
            optHombre.Enabled = false;
            optHombre.Checked = false;
            optMujer.Checked = false;
            optMujer.Enabled = false;

        }

        private void optHombre_CheckedChanged(object sender, EventArgs e)
        {
            if (optHombre.Checked == true)
            {
                txtIngreso.Text = "1000";
                txtPuntaje.Enabled = true;
            }
        }

        private void optMujer_CheckedChanged(object sender, EventArgs e)
        {
            if (optMujer.Checked == true)
            {
                txtIngreso.Text = "1000";
                txtPuntaje.Enabled = true;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text != "" && txtApellido.Text != null)
            {
                cmbPais.Enabled = true;
            }
        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPais.SelectedIndex != -1)
            {
                txtEdad.Enabled = true;
            }
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            if (txtEdad.Text != "" && txtEdad.Text != null)
            {
                optHombre.Enabled = true;

                optMujer.Enabled = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtNombre.Text != null)
            {
                txtApellido.Enabled = true;
               
            }
        }

        private void txtPuntaje_TextChanged(object sender, EventArgs e)
        {
            if (txtPuntaje.Text != "" && Convert.ToInt32(txtPuntaje.Text) > 129)
            {
                btnRegistrar.Enabled = true;

            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // toma solo numeros
            }
        }

        private void txtPuntaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
