using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace LibraryManagement.Security
{
    public static class RsaHelper
    {
        private const string PrivateKeyPath = "rsa_private.xml";
        private const string PublicKeyPath = "rsa_public.xml";

        /// <summary>
        /// Tạo cặp khóa RSA 2048-bit nếu chưa tồn tại
        /// </summary>
        public static void GenerateAndSaveKeys()
        {
            if (File.Exists(PrivateKeyPath) && File.Exists(PublicKeyPath)) return;

            using var rsa = new RSACryptoServiceProvider(2048);
            // Lưu Private Key (Dùng để giải mã - Cần bảo mật tuyệt đối)
            File.WriteAllText(PrivateKeyPath, rsa.ToXmlString(true));
            // Lưu Public Key (Dùng để mã hóa)
            File.WriteAllText(PublicKeyPath, rsa.ToXmlString(false));
        }

        public static byte[] EncryptKey(byte[] data)
        {
            using var rsa = new RSACryptoServiceProvider(2048);
            rsa.FromXmlString(File.ReadAllText(PublicKeyPath));
            return rsa.Encrypt(data, false);
        }

        public static byte[] DecryptKey(byte[] encryptedData)
        {
            if (!File.Exists(PrivateKeyPath))
                throw new FileNotFoundException("Không tìm thấy file RSA Private Key để giải mã khóa AES!");

            using var rsa = new RSACryptoServiceProvider(2048);
            rsa.FromXmlString(File.ReadAllText(PrivateKeyPath));
            return rsa.Decrypt(encryptedData, false);
        }
    }
}