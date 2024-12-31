using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace FileHandling2
{
    internal class PersonJson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }


        public static void WriteDetails()
        {

            string path = @"C:\Users\HP\source\repos\FileHandling2\FileHandling2\JsonDemo.json";
            var records = new List<PersonJson>
            {
                new PersonJson { Id = 1, Name = "Shri", Email = "shri@gmail.com" },
                new PersonJson { Id = 2, Name = "Tom", Email = "tom@gmail.com" },
                new PersonJson { Id = 3, Name = "Jerry", Email = "jerry@gmail.com" }
            };
            //File.Create(path);
            string jsonData = JsonConvert.SerializeObject(records, Formatting.Indented);
            File.WriteAllText(path, jsonData);

            Console.WriteLine("Data added successfully");
            string jsonRead = File.ReadAllText(path);
            var deserializedData = JsonConvert.DeserializeObject<List<PersonJson>>(jsonRead);
            foreach (var person in deserializedData)
            {
                Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, Email: {person.Email}");
            }
        }
    }
}
