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
   
    public partial class NuevoUsuario : Form
    {
        private Usuario mainForm = null;

        Conexion conexion = new Conexion();
        public NuevoUsuario(Form callingForm)
        {
            InitializeComponent();
        }

        private void insertaUsuario_Click(object sender, EventArgs e)
        {
            String textoPassword = textBoxPass.Text;
            string myHash = BCrypt.Net.BCrypt.HashPassword(textoPassword, BCrypt.Net.BCrypt.GenerateSalt());
            MessageBox.Show(conexion.insertaUsuario(textBoxDNI.Text, textBoxNombre.Text, myHash));
        }
    }
}
