using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace Veterinario2020
{
    public partial class Usuario : Form
    {
        Conexion conexion = new Conexion();

        private VentanaPrincipal mainForm = null;

        public Usuario(Form callingForm)
        {

            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoUsuario n = new NuevoUsuario(this);
            n.Show();
        }

        private void insertaDatos_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(conexion.insertaDatosUsuario(textBoxNom.Text, textBoxApellido.Text, textBoxCP.Text, textBoxCalle.Text, textBoxCiudad.Text, textBoxProv.Text));
        }
    }
}
