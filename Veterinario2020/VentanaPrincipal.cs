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
    public partial class VentanaPrincipal : Form
    {
        Conexion conexion = new Conexion();

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
        }

        private VentanaLogin mainForm = null;
        public VentanaPrincipal(Form callingForm)
        {
           
            InitializeComponent();
            

        }

        
        private void muestraMascota_Click(object sender, EventArgs e)
        {
            conexion.mascotas(label1.Text, label2.Text, label3.Text, label4.Text, label5.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario(this);
            u.Show();
        }
    }
}
