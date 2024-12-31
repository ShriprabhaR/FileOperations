using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using CsvHelper;

namespace FileHandling2
{
    internal class PersonCsv
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }


        public static void WriteDetails()
        {
            
            string path = @"C:\Users\HP\source\repos\FileHandling2\FileHandling2\csvDemo.csv";
            var records = new List<PersonCsv>
            {
                new PersonCsv { Id = 1, Name = "Shri", Email = "shri@gmail.com" },
                new PersonCsv { Id = 2, Name = "Tom", Email = "tom@gmail.com" },
                new PersonCsv { Id = 3, Name = "Jerry", Email = "jerry@gmail.com" }
            };

            if (File.Exists(path))
            {
                //Writing
                using (var writer = new StreamWriter(path))
                using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvWriter.WriteRecords(records);
                }
                Console.WriteLine("Data added successfully");
                //Reading
                using (var readers = new StreamReader(path))
                using (var csvReader = new CsvReader(readers, CultureInfo.InvariantCulture))
                {
                    var readRecords = csvReader.GetRecords<PersonCsv>();
                    foreach (var record in readRecords)
                    {
                        Console.WriteLine($"Id: {record.Id}, Name: {record.Name}, Email: {record.Email}");
                    }
                }
            }
            else
            {
                File.Create(path);
                Console.WriteLine("File doesn't exist");
            }
            
        }
    }
}
