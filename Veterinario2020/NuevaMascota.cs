using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinario2020
{
    public partial class NuevaMascota : Form
    {
        private VentanaPrincipal mainForm = null;

        Conexion conexion = new Conexion();
        public NuevaMascota(Form callingForm)
        {
            InitializeComponent();
        }

        private void insertaMascota_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conexion.insertaMascota(textBoxNombre.Text, edadMascota.Value, textBoxDueno.Text, textBoxVacunado.Text));
        }
    }
}
