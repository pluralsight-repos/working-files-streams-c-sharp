using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessor
{
    class FileProcessor
    {
        public string InputFilePath { get; }

        public FileProcessor(string filePath) => InputFilePath = filePath;
       
        public void Processor()
        {
            Console.WriteLine($"Begin process of { InputFilePath}");

            // Check if file exists
            //if (!File.Exists())
            //{

            //}
        }
    }
}
