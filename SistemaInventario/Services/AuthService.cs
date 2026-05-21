using Microsoft.Data.SqlClient;
using SistemaInventario.Database;
using SistemaInventario.Utils;

namespace SistemaInventario.Services
{
    public class AuthService
    {
        private readonly ConexionDB conexionDB;

        public AuthService()
        {
            conexionDB = new ConexionDB();
        }

        public bool Login(string usuario, string password)
        {
            string passwordEncriptado = HashHelper.ObtenerMD5(password);

            using (SqlConnection conexion = conexionDB.ObtenerConexion())
            {
                conexion.Open();

                string query = @"
                    SELECT COUNT(*)
                    FROM usuarios
                    WHERE nombre = @usuario
                    AND password = @password";

                SqlCommand cmd = new SqlCommand(query, conexion);

                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@password", passwordEncriptado);

                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }

        public string ObtenerRol(string usuario)
        {
            using (SqlConnection conexion =
                conexionDB.ObtenerConexion())
            {
                conexion.Open();

                string query =
                    "SELECT rol FROM usuarios WHERE nombre = @usuario";

                SqlCommand comando =
                    new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue(
                    "@usuario", usuario);

                object resultado =
                    comando.ExecuteScalar();

                return resultado?.ToString() ?? "";
            }
        }

    }
}