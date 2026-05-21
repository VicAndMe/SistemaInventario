using Microsoft.Data.SqlClient;

namespace SistemaInventario.Database
{
    public class ConexionDB
    {
        private readonly string connectionString =
            "Server=localhost\\SQLEXPRESS;" +
            "Database=InventarioDB;" +
            "User Id=inventario_admin;" +
            "Trusted_Connection=True;" +
            "TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(connectionString);
        }
    }
}