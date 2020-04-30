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
using MySql.Data.MySqlClient;

namespace Veterinario2020
{
    public partial class VentanaPrincipal : Form
    {
        Conexion conexion = new Conexion();
        DataTable mascota = new DataTable();
        DataTable citas = new DataTable();

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
            try
            {
                idActual++;
                if (idActual >= 100)
                {
                    idActual = 2;

                }

                infoMascota(idActual);
            }
            catch
            {
                errorMascotas.Text = ("No hay más mascotas pendientes");
            }
            
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

        public void infoCitas(int id)
        {
            citas = conexion.buscaCitasPorId(id);
            nombreCita.Text = "Tipo : " + citas.Rows[0]["Tipo"].ToString();
            fechaCita.Text = "Fecha : " + citas.Rows[0]["fecha_cita"].ToString();
            
        }

        private void retrocesoBoton_Click(object sender, EventArgs e)
        {
            try
            {
                if (idActual <= 0)
                {
                    idActual = 1;
                    
                }

                infoMascota(idActual);
            }
            catch
            {
                errorMascotas.Text = ("No hay más mascotas pendientes");
            }
            
        }

        private void revisionCita_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conexion.insertaFecha("Revisión", fechaRevision.Value));
        }

        private void peluqueriaCita_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conexion.insertaFecha("Peluquería", fechaRevision.Value));
        }

        private void citaVacunas_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conexion.insertaFecha("Vacunas", fechaRevision.Value));
        }

        private void spaCitas_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conexion.insertaFecha("Spa", fechaRevision.Value));
        }

        private void siguienteCita_Click(object sender, EventArgs e)
        {

            try
            {
                idActual++;
                if (idActual >= 100)
                {
                    idActual = 2;
                    siguienteCita.Hide();
                    previoCita.Show();
                }

                infoCitas(idActual);
            }
            catch 
            {
                errorCitas.Text = ("No hay más citas pendientes");
            }
           
        }

        private void previoCita_Click(object sender, EventArgs e)
        {
            try
            {
                idActual--;
                if (idActual <= 1)
                {
                    idActual = 1;
                    previoCita.Hide();
                    siguienteCita.Show();
                }


                infoCitas(idActual);
            }
            catch 
            {
                errorCitas.Text = ("No hay más citas pendientes");
            }
           
            
            
        }

        private void nuevoMascota_Click(object sender, EventArgs e)
        {
            NuevaMascota m = new NuevaMascota(this);
            m.Show();
        }
    }
}
