using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using UkSender.Models;

namespace UkSender.Helpers
{
    public class CredentialLoader
    {
        private DbLoader _dbLoader;
        public CredentialLoader()
        {
            this._dbLoader = new DbLoader();
        }

        public EmailModel GetEmailCredentialsFromDb()
        {
            // Получаем шифрованные данные из БД
            EmailModel secretDataFromDb = this._dbLoader.GetEmailDataFromDb();

            EmailModel finalDataForEmail = new EmailModel();

            finalDataForEmail.FromAddress = Decrypt(secretDataFromDb.FromAddress);
            finalDataForEmail.FromName = Decrypt(secretDataFromDb.FromName);
            finalDataForEmail.ToAddress = Decrypt(secretDataFromDb.ToAddress);
            finalDataForEmail.SecondToAddress = Decrypt(secretDataFromDb.SecondToAddress);
            finalDataForEmail.SubjectPiece = Decrypt(secretDataFromDb.SubjectPiece);
            finalDataForEmail.Lg = Decrypt(secretDataFromDb.Lg);
            finalDataForEmail.Pw = Decrypt(secretDataFromDb.Pw);

            return finalDataForEmail;
        }
        
        /// <summary>
        /// Метод занимается сверкой вводимых в форму данных с данными в БД
        /// </summary>
        /// <returns></returns>
        public bool CheckUserCredentialDataInDb(UserAuthorizeModel userAuthorizDataNoCrypt)
        {
            var usersDataEncryptedList = this._dbLoader.GetAllUserDataFromPostgre();
            
            List<int> successList = new List<int>();

            foreach(var oneUserData in usersDataEncryptedList.Where(x => Decrypt(x.Login) == userAuthorizDataNoCrypt.Login && Decrypt(x.Pwd) == userAuthorizDataNoCrypt.Pwd))
            {
                successList.Add(1);
            }

            if (successList.Count > 0 && successList.Count < 2) 
            {
                return true;
            }
            return false;
        }

        public static string GetConnStringFromDb(string connName)
        {
            var connectData = DbLoader.GetConnectStringFromDb(connName);
            return Decrypt(connectData.ConnectionString);
        }

        private static byte[] IV = { 12, 21, 43, 17, 57, 35, 67, 27 };
        private static string EncryptionKey = "asf56hjk";
        private static string Encrypt(string clearText)
        {
            Random rand = new Random();
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                byte[] IV = new byte[15];
                rand.NextBytes(IV);
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, IV);
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(IV) + Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
        private static string Decrypt(string codedText)
        {
            byte[] IV = Convert.FromBase64String(codedText.Substring(0, 20));
            codedText = codedText.Substring(20).Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(codedText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, IV);
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    codedText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return codedText;
        }

    }
}
