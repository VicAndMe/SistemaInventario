using System.Security.Cryptography;
using System.Text;

namespace SistemaInventario.Utils
{
    public static class HashHelper
    {
        public static string ObtenerMD5(
            string texto)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes =
                    Encoding.UTF8.GetBytes(texto);

                byte[] hashBytes =
                    md5.ComputeHash(inputBytes);

                StringBuilder sb =
                    new StringBuilder();

                foreach (byte b in hashBytes)
                {
                    sb.Append(
                        b.ToString("x2"));
                }

                return sb.ToString();
            }
        }
    }
}