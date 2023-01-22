using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using System.Text;

namespace UrnaEletronica.Domain.Security
{
    public static class PasswordHash
    {
        private const int KeySize = 64;
        private const int IterationsForHash = 1000;
        private static readonly HashAlgorithmName HashAlgorithm = HashAlgorithmName.SHA512;

        public static (string, byte[]) HashPassword(string plainPassword)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(KeySize);

            var passwordHash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(plainPassword),
                salt,
                IterationsForHash,
                HashAlgorithm,
                KeySize);

            return (Convert.ToHexString(passwordHash), salt);
        }

        public static bool VerifyPassword(byte[] salt, string passwordHash, string plainPassword)
        {
            if (salt is null || passwordHash is null || plainPassword is null)
                return false;

            var hashToCompare = Rfc2898DeriveBytes.Pbkdf2(plainPassword, salt, IterationsForHash, HashAlgorithm, KeySize);
            return hashToCompare.SequenceEqual(Convert.FromHexString(passwordHash));
        }
    }
}
