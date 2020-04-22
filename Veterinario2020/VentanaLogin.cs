using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Veterinario2020
{
    public partial class VentanaLogin : Form
    {
        Conexion conexion = new Conexion();

        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conexion.loginUsuario(textBox1.Text, textBox2.Text))
            {
                this.Hide();
                VentanaPrincipal v = new VentanaPrincipal(this);
                v.Show();
            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrectos");
            }
        }



    }
}

