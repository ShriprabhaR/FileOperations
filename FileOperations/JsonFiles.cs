using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileOperations
{
    internal class JsonFiles
    {
        public static void CreateJson()
        {
            string path = @"C:\Users\HP\source\repos\FileOperations\FileOperations\JsonFile.json";

            bool result = File.Exists(path);

            if (result)
            {
                Console.WriteLine("File exists");
            }
            else
            {
                File.Create(path);
                Console.WriteLine("File created");
            }
        }

        public static void FileWrite()
        {
            string path = @"C:\Users\HP\source\repos\FileOperations\FileOperations\JsonFile.json";

            Console.WriteLine("Enter text to the file");
            string txt = Console.ReadLine();

            File.WriteAllText(path, txt+"\n");
        }

        public static void AppendText()
        {
            string path = @"C:\Users\HP\source\repos\FileOperations\FileOperations\JsonFile.json";
            Console.WriteLine("Enter text to the file");
            string txt = Console.ReadLine();
            Console.WriteLine();
            File.AppendAllText(path, txt);
        }


        public static void ReadAllLines()
        {
            try
            {
                string path = @"C:\Users\HP\source\repos\FileOperations\FileOperations\JsonFile.json";
                string[] lines;

                lines = File.ReadAllLines(path);
                Console.WriteLine(lines[0]);
                Console.WriteLine(lines[1]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void ReadAllTexts()
        {
            string path = @"C:\Users\HP\source\repos\FileOperations\FileOperations\JsonFile.json";
            string lines;

            lines = File.ReadAllText(path);
            Console.WriteLine("Texts are: \n" + lines);

        }

        public static void CopyFile()
        {
            try
            {
                string path = @"C:\Users\HP\source\repos\FileOperations\FileOperations\JsonFile.json";

                string newPath = @"C:\Users\HP\source\repos\FileOperations\FileOperations\newJsonFile.json";

                File.Copy(path, newPath);
                Console.WriteLine("File copied");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public static void DeleteFile()
        {
            try
            {
                string path = @"C:\Users\HP\source\repos\FileOperations\FileOperations\newJsonFile.json";
                File.Delete(path);
                Console.WriteLine("File deleted");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
    }
}
