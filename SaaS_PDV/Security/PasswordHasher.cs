using System.Security.Cryptography;
using System.Text;

namespace SaaS_PDV.Security
{
    public static class PasswordHasher
    {
        // Transforma a senha em um código impossível de ler (Hash SHA256)
        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }
    }
}