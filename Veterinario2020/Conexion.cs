using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Veterinario2020
{
    class Conexion
    {
        public MySqlConnection conexion;
        public Conexion()
        {
            conexion = new MySqlConnection("Server = 127.0.0.1; Database = veterinario2020; Uid = root;Pwd= 1234;Port=3306");

        }

        public Boolean loginUsuario(String DNI, String pass)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM cuenta WHERE DNI = @DNI ", conexion);
                consulta.Parameters.AddWithValue("@DNI", DNI);
                MySqlDataReader resultado = consulta.ExecuteReader();

                if (resultado.Read())
                {
                    string passwordConHash = resultado.GetString("pass");
                    if(BCrypt.Net.BCrypt.Verify(pass, passwordConHash))
                    {
                        return true;
                    }

                }

                conexion.Close();
                return false;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }


        public DataTable buscaMascotasPorId(int id)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM mascota where id = '" + id + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable mascota = new DataTable();
                mascota.Load(resultado);
                conexion.Close();
                return mascota;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable buscaCitasPorId(int id)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM citas where id = '" + id + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable citas = new DataTable();
                citas.Load(resultado);
                conexion.Close();
                return citas;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }


        public String insertaUsuario(String DNI, String Nombre, String pass)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO cuenta (ID, DNI, Nombre, pass) VALUES (NULL, @DNI, @Nombre, @pass)", conexion);
                consulta.Parameters.AddWithValue("@DNI", DNI);
                consulta.Parameters.AddWithValue("@Nombre", Nombre);
                consulta.Parameters.AddWithValue("@pass", pass);

                consulta.ExecuteNonQuery();

                conexion.Close();
                return "Usuario creado correctamente";

            }
            catch (MySqlException e)
            {
                return "error";
            }
        }

       
        public String insertaDatosUsuario(String Nombre, String Apellidos, String CP, String Calle, String Ciudad, String Provincia)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO usuario (Nombre, Apellidos, CP, Calle, Ciudad, Provincia) VALUES (@Nombre, @Apellidos, @CP, @Calle, @Ciudad, @Provincia   )", conexion);
                consulta.Parameters.AddWithValue("@Nombre", Nombre);
                consulta.Parameters.AddWithValue("@Apellidos", Apellidos);
                consulta.Parameters.AddWithValue("@CP", CP);
                consulta.Parameters.AddWithValue("@Calle", Calle);
                consulta.Parameters.AddWithValue("@Ciudad", Ciudad);
                consulta.Parameters.AddWithValue("@Provincia", Provincia);

                consulta.ExecuteNonQuery();

                conexion.Close();
                return "Datos añadidos correctamente";

            }
            catch (MySqlException e)
            {
                return "error";
            }
        }

        public String insertaFecha(String Tipo, DateTime fecha_cita)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO citas (id, Tipo, fecha_cita) VALUES (NULL, @Tipo,@fecha_cita)", conexion);
                consulta.Parameters.AddWithValue("@Tipo", Tipo);
                consulta.Parameters.AddWithValue("@fecha_cita", fecha_cita);


                consulta.ExecuteNonQuery();

                conexion.Close();
                return "Cita añadida correctamente";

            }
            catch (MySqlException e)
            {
                return "error";
            }
        }
    }
}
