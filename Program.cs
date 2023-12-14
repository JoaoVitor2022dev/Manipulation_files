using System;
using System.IO;

namespace monipula_arquivo {
    class Program {
        static void Main(string[] args) {

            string sourcePath = @"c:\Downloads\arquivo.txt"; 
            string targePath = @"c:\Downloads\arquivo2.txt";
             
             try
             {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targePath);

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
             }
             catch (IOException e)
             {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
             }
 
        }
    }
}