using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
                    new MySqlCommand("SELECT * FROM cuenta WHERE DNI = @DNI AND pass = @pass", conexion);
                consulta.Parameters.AddWithValue("@DNI", DNI);
                consulta.Parameters.AddWithValue("@pass", pass);
                MySqlDataReader resultado = consulta.ExecuteReader();

                if (resultado.Read())
                {
                   
                    return true;
                }

                conexion.Close();
                return false;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }

        public Boolean mascotas(String nombre, String edad, String dueño, String vacunado, String foto)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM mascota WHERE nombre = @nombre AND edad = @edad AND dueño = @dueño AND vacunado = @vacunado AND foto = @foto ", conexion);
                consulta.Parameters.AddWithValue("@nombre", nombre);
                consulta.Parameters.AddWithValue("@edad", edad);
                consulta.Parameters.AddWithValue("@dueño", dueño);
                consulta.Parameters.AddWithValue("@vacunado", vacunado);
                consulta.Parameters.AddWithValue("@foto", foto);

                MySqlDataReader resultado = consulta.ExecuteReader();

                if (resultado.Read())
                {

                    return true;
                }

                conexion.Close();
                return false;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }
    }
}
