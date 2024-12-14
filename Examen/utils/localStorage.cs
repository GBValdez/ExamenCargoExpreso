using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.utils
{
    public class localStorage
    {

        private Dictionary<string, string> data = new Dictionary<string, string>();
        public void saveData(string key, string value)
        {
            string keyEncrypted = EncrypterHelper.CreateSHA256Hash(key);
            string valueEncrypted = EncrypterHelper.Encrypt(value);
            data[keyEncrypted] = valueEncrypted;
        }
        public string get(string key) { 
            string keyEncrypted = EncrypterHelper.CreateSHA256Hash(key);
            if (data.ContainsKey(keyEncrypted))
            {
                return EncrypterHelper.Decrypt(data[keyEncrypted]);
            }
            return null;
        }
    }
}
