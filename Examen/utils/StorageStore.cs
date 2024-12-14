using System;
using System.IO;
using System.Security.Cryptography;

namespace Examen.utils
{
    internal class StorageStore
    {
        public static void SaveEncryptedDataToFile(string filePath, string encryptedData)
        {
            try
            {
                string encryptedDataTemp = EncrypterHelper.Encrypt(encryptedData);
                File.WriteAllText(filePath, encryptedDataTemp);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error al guardar los datos en el archivo: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }
        }

        public static string LoadEncryptedDataFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    string dataTemp = File.ReadAllText(filePath);
                    return EncrypterHelper.Decrypt(dataTemp);
                }
                catch (CryptographicException ex)
                {
                    Console.WriteLine($"Error al desencriptar los datos: {ex.Message}");
                    return null;
                }
                catch (IOException ex)
                {
                    Console.WriteLine($"Error al leer el archivo: {ex.Message}");
                    return null;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error inesperado: {ex.Message}");
                    return null;
                }
            }
            else
            {
                Console.WriteLine("El archivo no existe.");
                return null;
            }
        }
    }
}
