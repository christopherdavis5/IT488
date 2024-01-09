using System.Security.Cryptography;

namespace TheBookStore
{
    public static class PasswordUtility
    {
        public static string HashPassword(string password)
        {
            //Changes can be made but just basic security
            int saltSize = 16; //Size of the salt
            int keySize = 20; //Size of the hash
            int iterations = 10000; //How many times the algo is executed

            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[saltSize];
                rng.GetBytes(salt);

                using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations))
                {
                    byte[] key = pbkdf2.GetBytes(keySize);
                    byte[] hash = new byte[saltSize + keySize];
                    Array.Copy(salt, 0, hash, 0, saltSize);
                    Array.Copy(key, 0, hash, saltSize, keySize);

                    return Convert.ToBase64String(hash);
                }
            }
        }
    }
}
