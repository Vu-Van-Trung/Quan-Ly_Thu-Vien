using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace LibraryManagement.Security
{
    public static class CryptoHelper
    {
        // === CẤU HÌNH DEMO ===
        // true: Dữ liệu sẽ được mã hóa AES và bảo vệ bằng RSA khi lưu vào DB.
        // false: Dữ liệu sẽ được lưu dưới dạng văn bản thuần (Plain Text).
        public static bool IsEncryptionEnabled = true;

        private static readonly byte[] AesKey;
        private static readonly byte[] AesIV;
        private const string EncryptedKeyPath = "aes.key.enc";
        private const string IvPath = "aes.iv";

        static CryptoHelper()
        {
            try
            {
                // 1. Đảm bảo RSA Keys đã được khởi tạo để bảo vệ khóa AES
                RsaHelper.GenerateAndSaveKeys();

                if (File.Exists(EncryptedKeyPath) && File.Exists(IvPath))
                {
                    // 2. Đọc khóa AES đã bị mã hóa RSA từ ổ đĩa
                    byte[] encryptedAesKey = File.ReadAllBytes(EncryptedKeyPath);

                    // 3. Giải mã bằng RSA Private Key để lấy lại khóa AES gốc vào bộ nhớ RAM
                    AesKey = RsaHelper.DecryptKey(encryptedAesKey);
                    AesIV = File.ReadAllBytes(IvPath);
                }
                else
                {
                    // 4. Tạo mới hoàn toàn bộ khóa AES nếu chạy lần đầu
                    using var aes = Aes.Create();
                    aes.KeySize = 256;
                    aes.GenerateKey();
                    aes.GenerateIV();

                    AesKey = aes.Key;
                    AesIV = aes.IV;

                    // 5. Dùng RSA Public Key để "phong bì" (Encrypt) AES Key trước khi ghi xuống file
                    byte[] encryptedKeyForStorage = RsaHelper.EncryptKey(AesKey);

                    File.WriteAllBytes(EncryptedKeyPath, encryptedKeyForStorage);
                    File.WriteAllBytes(IvPath, AesIV);
                }
            }
            catch (Exception ex)
            {
                // Nếu lỗi hệ thống bảo mật, ta thông báo để xử lý thay vì im lặng
                throw new Exception("Lỗi nghiêm trọng khi khởi tạo hệ thống bảo mật: " + ex.Message);
            }
        }

        /// <summary>
        /// Mã hóa văn bản. Nếu IsEncryptionEnabled = false, trả về văn bản gốc.
        /// </summary>
        public static string Encrypt(string plainText)
        {
            // Kiểm tra trạng thái demo hoặc dữ liệu trống
            if (string.IsNullOrEmpty(plainText) || !IsEncryptionEnabled)
                return plainText;

            using var aes = Aes.Create();
            aes.Key = AesKey;
            aes.IV = AesIV;

            using var encryptor = aes.CreateEncryptor();
            using var ms = new MemoryStream();
            using var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write);
            using (var sw = new StreamWriter(cs))
            {
                sw.Write(plainText);
            }

            return Convert.ToBase64String(ms.ToArray());
        }

        /// <summary>
        /// Giải mã văn bản. Nếu IsEncryptionEnabled = false hoặc lỗi, trả về văn bản gốc.
        /// </summary>
        public static string Decrypt(string cipherText)
        {
            // Kiểm tra trạng thái demo hoặc dữ liệu trống
            if (string.IsNullOrWhiteSpace(cipherText) || !IsEncryptionEnabled)
                return cipherText;

            try
            {
                // Kiểm tra sơ bộ xem có phải định dạng Base64 không để tránh lỗi xử lý text thuần
                byte[] buffer = Convert.FromBase64String(cipherText);

                using var aes = Aes.Create();
                aes.Key = AesKey;
                aes.IV = AesIV;

                using var decryptor = aes.CreateDecryptor();
                using var ms = new MemoryStream(buffer);
                using var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read);
                using var sr = new StreamReader(cs);

                return sr.ReadToEnd();
            }
            catch
            {
                // Trả về text gốc nếu không phải dữ liệu mã hóa (đảm bảo tương thích dữ liệu cũ)
                return cipherText;
            }
        }
    }
}