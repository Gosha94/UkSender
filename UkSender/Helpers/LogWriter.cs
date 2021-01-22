using System;
using System.IO;

namespace UkSender.Helpers
{
    /// <summary>
    /// Класс записывает логи (отправка письма для УК) в текстовый файл
    /// </summary>
    public class LogWriter
    {
        /// <summary>
        /// Запись логов
        /// </summary>
        /// <param name="message"></param>
        public static void LogWrite(string message, string pathFile)
        {
            using (var log = File.AppendText(pathFile))
            {
                log.WriteLine($"\n{DateTime.Now.ToString()}: { message }");
            }
        }
    }
}
