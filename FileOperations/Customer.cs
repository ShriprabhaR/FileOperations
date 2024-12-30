using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileOperations
{
    internal class Customer
    {
        public static void ReadDetails()
        {

            //DirectoryInfo Currdir = new DirectoryInfo(".");
            //DirectoryInfo Dir = new DirectoryInfo(@"C:\Users\HP\source\repos\FileOperations\FileOperations\demo.txt");
            //Console.WriteLine(Dir.FullName);
            //Console.WriteLine(Dir.Name);
            //Console.WriteLine(Dir.Parent);
            //Console.WriteLine(Dir.Attributes);
            //Console.WriteLine(Dir.CreationTime);


            string path = @"C:\Users\HP\source\repos\FileOperations\FileOperations\Customer.txt";

            string[] customers =
                {
                "Bob Smith",
                "Sallen Smith",
                "Robert"
            };

            File.WriteAllLines(path, customers);

            foreach (string customer in File.ReadLines(path))
            {
                Console.WriteLine($"Customer: {customer} ");
            }
            


            try
            {
                DirectoryInfo myDataDir = new DirectoryInfo(@"C:\Users\HP\source\repos\FileOperations\FileOperations");
                FileInfo[] txtfiles = myDataDir.GetFiles("*.txt", SearchOption.AllDirectories);

                Console.WriteLine($"Matches: {txtfiles.Length}");
                foreach (FileInfo file in txtfiles)
                {
                    Console.WriteLine(file.Name);
                    Console.WriteLine(file.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }

        public static void Filestream()
        {
            string path = @"C:\Users\HP\source\repos\FileOperations\FileOperations\Cust.txt";

            FileStream fs = File.Open(path, FileMode.Create);
            string randStr = "Twinkle Twinkle";

            byte[] resByteArr = Encoding.Default.GetBytes(randStr);

            fs.Write(resByteArr, 0, resByteArr.Length);

            fs.Position = 0;

            byte[] fileBytearr = new byte[resByteArr.Length];

            for(int i = 0; i < resByteArr.Length; i++)
            {
                fileBytearr[i] = (byte)fs.ReadByte();
            }

            Console.WriteLine(Encoding.Default.GetString(fileBytearr));

            fs.Close();

            StreamWriter sw = File.CreateText(path);

            sw.Write("Hii");
            sw.WriteLine("Hello");
            sw.WriteLine("Good morning");

            sw.Close();

            StreamReader sr = File.OpenText(path);
            Console.WriteLine("peek: {0}", Convert.ToChar(sr.Peek()));

            Console.WriteLine("1st string: {0}", sr.ReadLine());

            Console.WriteLine("Everything: {0}", sr.ReadToEnd());

            sr.Close();

        }

        public static void BinaryFiles()
        {
            string path = @"C:\Users\HP\source\repos\FileOperations\FileOperations\Binary.dat";
            FileInfo datfile = new FileInfo(path);

            BinaryWriter bw = new BinaryWriter(datfile.OpenWrite());

            String txt = "Shriprabha";
            int age = 22;
            double height = 5.6;

            bw.Write(txt);
            bw.Write(age);
            bw.Write(height);

            bw.Close();

            BinaryReader br = new BinaryReader(datfile.OpenRead());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());
        }
    }
}
