using System.Diagnostics;
using UkSender.Classes;
using NUnit.Framework;
using UkSender.Helpers;
using UkSender.Models;
using System.Collections.Generic;
using System;

namespace UkSender.NUnitTests
{
    [TestFixture]
    public class UkSenderTests
    {
        // TODO Реализовать тест получения данных из БД
        [Test]
        public void GetCryptoCredentialsFromDbase_Test()
        {
            //List<string> inputList = new List<string>() {
            //    ""               
            //};
            //List<string> codedList = new List<string>();

            //foreach (var str in inputList)
            //{
            //    codedList.Add(CredentialLoader.Encrypt(str));
            //}
            //Console.WriteLine();
            Assert.AreEqual(true, false);
        }

        // TODO Реализовать тест расшифровки данных
        [Test]
        public void DectyptCredentialsFromDbase_Test()
        {
            Assert.AreEqual(true, false);
        }

        // TODO Реализовать тест отправки письма
        [Test]
        public void SendEmail_Test()
        {
            string pathToCatalog = @"E:\";
            int month = 11;
            // Отправляем письмо
            //EmailSender emailSender = new EmailSender(pathToCatalog, true, month );

            //Debug.WriteLine("OK");
            Assert.AreEqual(true, false);
        }
        
        /// <summary>
        /// Тест записи показаний в БД
        /// </summary>
        [Test]
        public void InsertMeteringDataToDbase_Test()
        {
            List<MeteringDataModel> testMeteringData = new List<MeteringDataModel>()
            {
                new MeteringDataModel()
                {
                    MeteringDeviceType = 100, 
                    Value = "Test value -999", 
                    CombineDtm = DateTime.Now, 
                    SendDtm = DateTime.Now
                }                
            };

            bool actual = DbLoader.InsertMeteringDataToDbase(testMeteringData);
            
            Assert.AreEqual(true, actual);
        }
    }
}
