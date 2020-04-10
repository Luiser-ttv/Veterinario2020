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
    public partial class VentanaLogin : Form
    {
        
        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("fraxito") && textBox2.Text.Contains("babyyoda"))
            {
                VentanaPrincipal ventana = new VentanaPrincipal(this);
                ventana.Show();
                this.Hide();
            }
            else 
            {
                label4.Text = "Usuario o contraseña incorrecto por favor intentalo de nuevo";
            }
            
            
            
        }
    }
}
