using Microsoft.Data.SqlClient;
using SistemaInventario.Database;
using System.Data;

namespace SistemaInventario.Services
{
    public class AlmacenService
    {
        private readonly ConexionDB conexionDB;

        public AlmacenService()
        {
            conexionDB = new ConexionDB();
        }

        public DataTable ObtenerAlmacenes()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion =
                conexionDB.ObtenerConexion())
            {
                conexion.Open();

                string query =
                    "SELECT * FROM almacenes";

                SqlDataAdapter adapter =
                    new SqlDataAdapter(query, conexion);

                adapter.Fill(tabla);
            }

            return tabla;
        }

        public void AgregarAlmacen(
            string nombre,
            string ubicacion)
        {
            using (SqlConnection conexion =
                conexionDB.ObtenerConexion())
            {
                conexion.Open();

                string query = @"
                INSERT INTO almacenes
                (
                    nombre,
                    ubicacion,
                    fecha_hora_creacion,
                    ultimo_usuario_en_modificar
                )
                VALUES
                (
                    @nombre,
                    @ubicacion,
                    GETDATE(),
                    'ADMIN'
                )";

                SqlCommand comando =
                    new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue(
                    "@nombre", nombre);

                comando.Parameters.AddWithValue(
                    "@ubicacion", ubicacion);

                comando.ExecuteNonQuery();
            }
        }

        public void ModificarAlmacen(
            int id,
            string nombre,
            string ubicacion)
        {
            using (SqlConnection conexion =
                conexionDB.ObtenerConexion())
            {
                conexion.Open();

                string query = @"
                UPDATE almacenes
                SET
                    nombre = @nombre,
                    ubicacion = @ubicacion,
                    fecha_hora_ultima_modificacion =
                        GETDATE(),
                    ultimo_usuario_en_modificar =
                        'ADMIN'
                WHERE id = @id";

                SqlCommand comando =
                    new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue(
                    "@id", id);

                comando.Parameters.AddWithValue(
                    "@nombre", nombre);

                comando.Parameters.AddWithValue(
                    "@ubicacion", ubicacion);

                comando.ExecuteNonQuery();
            }
        }

        public void EliminarAlmacen(int id)
        {
            using (SqlConnection conexion =
                conexionDB.ObtenerConexion())
            {
                conexion.Open();

                string query =
                    "DELETE FROM almacenes WHERE id = @id";

                SqlCommand comando =
                    new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue(
                    "@id", id);

                comando.ExecuteNonQuery();
            }
        }
    }
}