
using System.Security.Cryptography;
using System.Text;

public class CryptoUtils
{
    public static byte[] GenerateKey()
    {
        using (var rng = new RNGCryptoServiceProvider())
        {
            var key = new byte[32]; // 256 bits
            rng.GetBytes(key);
            return key;
        }
    }

    public static string CalculateHMAC(string message, byte[] key)
    {
        using (var hmac = new HMACSHA256(key))
        {
            var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(message));
            return Convert.ToBase64String(hash);
        }
    }
}
