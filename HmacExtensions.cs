using Chilkat;

namespace ConsoleCase
{
    public class HmacExtensions
    {
        public static string GenerateHmac(string word, string key)
        {
            Crypt2 crypt = new Crypt2 {EncodingMode = "hex", HashAlgorithm = "sha256"};

            crypt.SetHmacKeyEncoded(key, "ascii");
            var hmacValue = crypt.HmacStringENC(word);
            return hmacValue;
        }
        
    }
    
}