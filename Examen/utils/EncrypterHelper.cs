using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Examen.utils
{
    internal class EncrypterHelper
    {
        public static string Encrypt(string data)
        {
            byte[] encryptedData = ProtectedData.Protect(Encoding.UTF8.GetBytes(data), null, DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(encryptedData);
        }

        public static string Decrypt(string encryptedData)
        {
            byte[] data = Convert.FromBase64String(encryptedData);
            byte[] decryptedData = ProtectedData.Unprotect(data, null, DataProtectionScope.CurrentUser);
            return Encoding.UTF8.GetString(decryptedData);
        }

        public static string CreateSHA256Hash(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convertir la entrada en un arreglo de bytes
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Convertir el arreglo de bytes a una cadena hexadecimal
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2")); // Cada byte se convierte a hexadecimal
                }
                return builder.ToString();
            }
        }
    }
}
