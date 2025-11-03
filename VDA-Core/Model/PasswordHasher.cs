using System;
using System.Security.Cryptography;
using System.Text;


namespace VDA_Core.Model
{
    public static class PasswordHasher
    {
        // Configurable parameters
        private const int SaltSize = 16; // 128-bit salt
        private const int KeySize = 32;  // 256-bit hash
        private const int Iterations = 100_000; // Recommended minimum: 100k

        private static readonly HashAlgorithmName HashAlgorithm = HashAlgorithmName.SHA256;

        
        public static (string passHash, string salt) Hash(string password)
        {
            using var rng = RandomNumberGenerator.Create();
            byte[] salt = new byte[SaltSize];
            rng.GetBytes(salt);

            // Derive a key (the hash)
            var hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(password),
                salt,
                Iterations,
                HashAlgorithm,
                KeySize);


            return (passHash: Convert.ToBase64String(hash), salt: Convert.ToBase64String(salt));
        }


        public static bool Verify(string password, string storedHash, string storedSalt)
        {

            var salt = Convert.FromBase64String(storedSalt);
            var hash = Convert.FromBase64String(storedHash);

            var keyToCheck = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(password),
                salt,
                Iterations,
                HashAlgorithm,
                KeySize);

            return CryptographicOperations.FixedTimeEquals(hash, keyToCheck);
        }
    }

}