using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinario2020
{
    public partial class VentanaPrincipal : Form
    {
        Conexion conexion = new Conexion();
        DataTable mascota = new DataTable();

        public static int idActual = 0;

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
            idActual++;
            if (idActual >= 2)
            {
                idActual = 2;
                muestraMascota.Hide();
                retrocesoBoton.Show();
            }
            
            infoMascota(idActual);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario(this);
            u.Show();
        }

        private Image convierteBlobImagenes(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }

        public void infoMascota(int id)
        {
            mascota = conexion.buscaMascotasPorId(id);
            nombreMascota.Text = "Nombre : " + mascota.Rows[0]["nombre"].ToString();
            edadMascota.Text = "Edad : " + mascota.Rows[0]["edad"].ToString();
            dueñoMascota.Text = "Dueño : " + mascota.Rows[0]["dueno"].ToString();
            vacunaMascota.Text = "Vacunado : " + mascota.Rows[0]["vacunado"].ToString();
            pictureBoxMascota.Image = convierteBlobImagenes((byte[])mascota.Rows[0]["foto"]);
        }

        private void retrocesoBoton_Click(object sender, EventArgs e)
        {
            idActual--;
            if (idActual <= 1)
            {
                idActual = 1;
                retrocesoBoton.Hide();
                muestraMascota.Show();
            }
            

            infoMascota(idActual);
        }

        private void revisionCita_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conexion.insertaFecha(fechaRevision.Value));
        }
    }
}
