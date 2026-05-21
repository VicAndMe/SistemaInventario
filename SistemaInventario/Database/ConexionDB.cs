using Microsoft.Data.SqlClient;

namespace SistemaInventario.Database
{
    public class ConexionDB
    {
        private readonly string connectionString =
            "Server=Ariel\\SQLEXPRESS;" +
            "Database=InventarioDB;" +
            "User Id=inventario_admin;" +
            "Password=Inventario123;" +
            "TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(connectionString);
        }
    }
}