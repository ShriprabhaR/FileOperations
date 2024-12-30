using System;

namespace FileOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicFiles.CheckExists();

            BasicFiles.FileWrite();

            BasicFiles.AppendText();

            BasicFiles.ReadAllLines();

            BasicFiles.ReadAllTexts();

            BasicFiles.CopyFile();

            BasicFiles.DeleteFile();


            CsvFiles.CreateCsv();

            CsvFiles.FileWrite();

            CsvFiles.AppendText();

            CsvFiles.ReadAllLines();

            CsvFiles.ReadAllTexts();

            CsvFiles.CopyFile();

            CsvFiles.DeleteFile();


            JsonFiles.CreateJson();

            JsonFiles.FileWrite();

            JsonFiles.AppendText();

            JsonFiles.ReadAllLines();

            JsonFiles.ReadAllTexts();

            JsonFiles.CopyFile();

            JsonFiles.DeleteFile();






        }
    }
}
