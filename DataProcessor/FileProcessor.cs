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
        private const string BackupDirectoryName = "backup";
        private const string InProgressDirectoryName = "processing";
        private const string CompletedDirectoryName = "complete";

        public string InputFilePath { get; }

        public FileProcessor(string filePath) => InputFilePath = filePath;
       
        public void Processor()
        {
            Console.WriteLine($"Begin process of { InputFilePath}");

            // Check if file exists
            if (!File.Exists(InputFilePath))
            {
                Console.WriteLine($"ERROR: file {InputFilePath} does not exist.");
                return;
            }

            string rootDirectoryPath = new DirectoryInfo(InputFilePath).Parent.Parent.FullName;
            Console.WriteLine($"Root data path is {rootDirectoryPath}");

            // Check if backup dir exists
            //string backupDirectoryPath = rootDirectoryPath + "/" + BackupDirectoryName;
            string backupDirectoryPath = Path.Combine(rootDirectoryPath, BackupDirectoryName); //Better way with Class Path
             
            if (!Directory.Exists(backupDirectoryPath))
            {
                Console.WriteLine($"Attempting to create {backupDirectoryPath}");
                Directory.CreateDirectory(backupDirectoryPath);
            }
        }
    }
}
