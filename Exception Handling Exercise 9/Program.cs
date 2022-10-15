using System;
using System.IO;

namespace Exception_Handling_Exercise_9
{
    internal class Program
    {   
        static void ReadFile (string fileName)
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine("The file does not exist!");
                return;
            }
            else
            {
                StreamReader streamReader = new StreamReader(fileName);
                using (streamReader)
                {
                    while (!streamReader.EndOfStream)
                    {
                        string line = streamReader.ReadLine(); 
                        Console.WriteLine(line);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //ReadFile("TestFile.txt");
            if (File.Exists("TestFile.txt"))
            {
                Console.WriteLine("Its here!");
            }
        }
    }
}
