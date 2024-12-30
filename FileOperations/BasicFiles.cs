using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace FileOperations
{
    internal class BasicFiles
    {
        public static void CheckExists()
        {
            string path = @"C:\Users\HP\source\repos\FileOperations\FileOperations\demo.txt";

            bool result = File.Exists(path);

            if (result)
            {
                Console.WriteLine("File exists");
            }
            else
            {
                File.Create(path);
                Console.WriteLine("file didn't exist, created new one");
            }
        }


        public static void FileWrite()
        {
            string path = @"C:\Users\HP\source\repos\FileOperations\FileOperations\demo.txt";

            Console.WriteLine("Enter text to the file");
            string txt = Console.ReadLine();

            File.WriteAllText(path, txt+"\n");
        }

        public static void AppendText()
        {
            string path = @"C:\Users\HP\source\repos\FileOperations\FileOperations\demo.txt";

            Console.WriteLine("Enter text to the file");
            string txt = Console.ReadLine();
            File.AppendAllText(path, txt);

        }

        public static void ReadAllLines()
        {
            try
            {
                string path = @"C:\Users\HP\source\repos\FileOperations\FileOperations\demo.txt";
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
            string path = @"C:\Users\HP\source\repos\FileOperations\FileOperations\demo.txt";
            string lines;

            lines = File.ReadAllText(path);
            Console.WriteLine("Texts are: \n"+lines);

        }

        public static void CopyFile()
        {
            try
            {
                string path = @"C:\Users\HP\source\repos\FileOperations\FileOperations\demo.txt";

                string newPath = @"C:\Users\HP\source\repos\FileOperations\FileOperations\Newdemo.txt";

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
                string path = @"C:\Users\HP\source\repos\FileOperations\FileOperations\Newdemo.txt";
                File.Delete(path);
                Console.WriteLine("File deleted");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

    }
}
