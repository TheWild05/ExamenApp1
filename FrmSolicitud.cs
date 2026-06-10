using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenApp1
{
    public partial class FrmSolicitud : Form
    {
        public FrmSolicitud()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)

        { 
          
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonResumen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || txtNombre.Text.Length < 3)
            {
                MessageBox.Show("El valor debe tener minimo 3 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtDni.Text) || txtDni.Text.Length != 13)
            {
                MessageBox.Show("El DNI debe tener 13 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("El campo esta vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
                MessageBox.Show($"Nombre: {txtNombre.Text}\nDNI: {txtDni.Text}\nTelefono: {txtTelefono.Text}\n Tipo de solicitud: {cmbVehiculo.SelectedItem}", "Resumen", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void buttonlimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            txtNombre.Focus();
        }
    }
}
