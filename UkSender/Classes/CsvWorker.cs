using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using CsvHelper;
using UkSender.Models;
using System.Collections.Generic;

namespace UkSender.Classes
{
    class CsvWorker
    {
        // Класс проверяет наличие файла по пути, если его нет, создает
        // Вносит показания приборов в файл

        public CsvWorker(string pathToDir, string pathToFile, string[] meteringData)
        {
            try
            {
                if (!Directory.Exists(pathToDir)) { CreateDirectory(pathToDir); WorkWithCSV(pathToFile, meteringData); }
                else WorkWithCSV(pathToFile, meteringData);
            }

            catch (Exception undefinedDirectory)
            {
                MessageBox.Show(undefinedDirectory.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
        }

        private void WorkWithCSV(string filePath, string[] meteringData)
        {
            if (!File.Exists(filePath))
            {
                CreateEmptyFile(filePath);
                WriteDataInFile(filePath, meteringData);
            }
            else WriteDataInFile(filePath, meteringData, ReadFile(filePath));
        }

        private void CreateEmptyFile(string filePath)
        {
            var records = new List<DataForUkModel>();

            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }
        }

        private List<DataForUkModel> ReadFile(string filePath)
        {
            List<DataForUkModel> dataFromFile = new List<DataForUkModel>();

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.HasHeaderRecord = true;
                var records = csv.GetRecords<DataForUkModel>();
                foreach (var item in records)
                {
                    dataFromFile.Add(item);
                }
                return dataFromFile;
            }            
        }

        private void WriteDataInFile(string filePath, string[] dataFromForm)
        {
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                var records = new List<DataForUkModel>()
                    {
                      new DataForUkModel {
                          MeteringDevice = "ColdWater",
                          Value = dataFromForm[0],
                          Date = DateTime.Now,
                          EmailedStatus = "false" },

                        new DataForUkModel {
                          MeteringDevice = "HotWater",
                          Value = dataFromForm[1],
                          Date = DateTime.Now,
                          EmailedStatus = "false" },

                        new DataForUkModel {
                          MeteringDevice = "Heater",
                          Value = dataFromForm[2],
                          Date = DateTime.Now,
                          EmailedStatus = "false" },

                        new DataForUkModel {
                          MeteringDevice = "Electro",
                          Value = dataFromForm[3],
                          Date = DateTime.Now,
                          EmailedStatus = "false" },
                    };

                csv.WriteRecords(records);

            }
        }

        private void WriteDataInFile(string filePath, string[] dataFromForm, List<DataForUkModel> oldMeteringDataFromFile)
        {
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                var records = oldMeteringDataFromFile;

                records.Add( new DataForUkModel { MeteringDevice = "ColdWater", Value = dataFromForm[0], Date = DateTime.Now, EmailedStatus = "false" } );
                records.Add( new DataForUkModel { MeteringDevice = "HotWater", Value = dataFromForm[1], Date = DateTime.Now, EmailedStatus = "false" } );
                records.Add( new DataForUkModel { MeteringDevice = "Heater", Value = dataFromForm[2], Date = DateTime.Now, EmailedStatus = "false" } );
                records.Add( new DataForUkModel { MeteringDevice = "Electro", Value = dataFromForm[3], Date = DateTime.Now, EmailedStatus = "false" } );

                csv.WriteRecords(records);
            }
        }
    }
}
