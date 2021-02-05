using System.Collections.Generic;
using System.Linq;
using UkSender.Models;
using AesCryptoLib.DLL.Controller;

namespace UkSender.Helpers
{
    public class CredentialLoader
    {
        private DbLoader _dbLoader;
        private CryptoManager _cryptoManager;

        public CredentialLoader()
        {
            this._dbLoader = new DbLoader();
            this._cryptoManager = new CryptoManager();
        }

        public EmailModel GetEmailCredentialsFromDb()
        {
            // Получаем шифрованные данные из БД
            EmailModel secretDataFromDb = this._dbLoader.GetEmailDataFromDb();

            EmailModel finalDataForEmail = new EmailModel();

            finalDataForEmail.FromAddress =     this._cryptoManager.Decrypt(secretDataFromDb.FromAddress);
            finalDataForEmail.FromName =        this._cryptoManager.Decrypt(secretDataFromDb.FromName);
            finalDataForEmail.ToAddress =       this._cryptoManager.Decrypt(secretDataFromDb.ToAddress);
            finalDataForEmail.SecondToAddress = this._cryptoManager.Decrypt(secretDataFromDb.SecondToAddress);
            finalDataForEmail.SubjectPiece =    this._cryptoManager.Decrypt(secretDataFromDb.SubjectPiece);
            finalDataForEmail.Lg =              this._cryptoManager.Decrypt(secretDataFromDb.Lg);
            finalDataForEmail.Pw =              this._cryptoManager.Decrypt(secretDataFromDb.Pw);

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

            foreach(var oneUserData in usersDataEncryptedList.Where(x => this._cryptoManager.Decrypt(x.Login) == userAuthorizDataNoCrypt.Login && this._cryptoManager.Decrypt(x.Pwd) == userAuthorizDataNoCrypt.Pwd))
            {
                successList.Add(1);
            }

            if (successList.Count > 0 && successList.Count < 2) 
            {
                return true;
            }
            return false;
        }

        //public string GetConnStringFromDb(string connName)
        //{
        //    var connectData = DbLoader.GetConnectStringFromDb(connName);
        //    return this._cryptoManager.Decrypt(connectData.ConnectionString);
        //}
    }
}
