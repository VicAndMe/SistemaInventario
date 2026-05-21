using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using SistemaInventario.Database;
using System.Data;

namespace SistemaInventario.Services
{
    public class ProductoService
    {
        private readonly ConexionDB conexionDB;

        public ProductoService()
        {
            conexionDB = new ConexionDB();
        }

        public DataTable ObtenerProductos()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = conexionDB.ObtenerConexion())
            {
                conexion.Open();

                string query = "SELECT * FROM vista_productos";

                SqlDataAdapter adapter =
                    new SqlDataAdapter(query, conexion);

                adapter.Fill(tabla);
            }

            return tabla;
        }

        public void AgregarProducto(
    string nombre,
    string descripcion,
    int cantidad,
    decimal precio,
    int idAlmacen)
        {
            using (SqlConnection conexion =
                conexionDB.ObtenerConexion())
            {
                conexion.Open();

                string query = @"
            INSERT INTO productos
            (
                nombre,
                descripcion,
                cantidad,
                precio,
                almacen_id,
                fecha_hora_creacion,
                ultimo_usuario_en_modificar
            )
            VALUES
            (
                @nombre,
                @descripcion,
                @cantidad,
                @precio,
                @idAlmacen,
                GETDATE(),
                'ADMIN'
            )";

                SqlCommand cmd =
                    new SqlCommand(query, conexion);

                cmd.Parameters.AddWithValue(
                    "@nombre", nombre);

                cmd.Parameters.AddWithValue(
                    "@descripcion", descripcion);

                cmd.Parameters.AddWithValue(
                    "@cantidad", cantidad);

                cmd.Parameters.AddWithValue(
                    "@precio", precio);

                cmd.Parameters.AddWithValue(
                    "@idAlmacen", idAlmacen);

                cmd.ExecuteNonQuery();
            }
        }


        public void ModificarProducto(
    int id,
    string nombre,
    string descripcion,
    int cantidad,
    decimal precio,
    int idAlmacen)
        {
            using (SqlConnection conexion =
                conexionDB.ObtenerConexion())
            {
                conexion.Open();

                string query = @"
        UPDATE productos
        SET
            nombre = @nombre,
            descripcion = @descripcion,
            cantidad = @cantidad,
            precio = @precio,
            almacen_id = @idAlmacen,
            fecha_hora_ultima_modificacion = GETDATE(),
            ultimo_usuario_en_modificar = 'ADMIN'
        WHERE id = @id";

                SqlCommand comando =
                    new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue(
                    "@id", id);

                comando.Parameters.AddWithValue(
                    "@nombre", nombre);

                comando.Parameters.AddWithValue(
                    "@descripcion", descripcion);

                comando.Parameters.AddWithValue(
                    "@cantidad", cantidad);

                comando.Parameters.AddWithValue(
                    "@precio", precio);

                comando.Parameters.AddWithValue(
                    "@idAlmacen", idAlmacen);

                comando.ExecuteNonQuery();
            }
        }

        public void EliminarProducto(int id)
        {
            using (SqlConnection conexion =
                conexionDB.ObtenerConexion())
            {
                conexion.Open();

                string query =
                    "DELETE FROM productos WHERE id = @id";

                SqlCommand comando =
                    new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue(
                    "@id", id);

                comando.ExecuteNonQuery();
            }
        }

    }
}