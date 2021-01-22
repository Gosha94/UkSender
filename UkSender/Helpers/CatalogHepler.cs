using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkSender.Helpers
{
    /// <summary>
    /// Статический класс для работы с директориями
    /// </summary>
    public static class CatalogHepler
    {
        public static string CombinePathToCatalog()
        {
            string catalog = AppDomain.CurrentDomain.BaseDirectory;
            return catalog + "MeteringData\\";
        }

        public static string CombinePathToAttach()
        {
            string catalog = CombinePathToCatalog();
            return catalog + "Attachments\\";
        }

        public static string CombinePathToFile(string pathDir)
        {
            int localDate = DateTime.Today.Year;
            return pathDir + localDate + ".csv";
        }
    }
}
