using System;
using System.IO;

namespace FileOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer.ReadDetails();

            Customer.Filestream();

            Customer.BinaryFiles();

            BasicFiles.CheckExists();

            BasicFiles.FileWrite();

            BasicFiles.AppendText();

            BasicFiles.ReadAllLines();

            BasicFiles.ReadAllTexts();

            BasicFiles.CopyFile();

            BasicFiles.DeleteFile();

        }
    }
}
