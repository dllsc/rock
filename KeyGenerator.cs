using System.Security.Cryptography;

namespace ConsoleCase
{
    public class KeyGenerator
    {
        public static string GenerateKey()
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            var key = new byte[16];
            provider.GetBytes(key);
            return key.BytesToString();
        }
    }
}