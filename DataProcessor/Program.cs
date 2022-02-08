using System;
using System.IO;

namespace DataProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parsing command line options");

            // Command line validation omitted for brevity

            var command = args[0];

            if (command == "--file")
            {
                var filePath = args[1];
                // Check if path is absolute
                if(!Path.IsPathFullyQualified(filePath))
                {
                    Console.WriteLine($"ERROR: path '{filePath}' must be fully qualified.");
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine($"Single file {filePath} selected");
                ProcessSingleFile(filePath);
            }
            else if (command == "--dir")
            {
                var directoryPath = args[1];
                var fileType = args[2];
                Console.WriteLine($" Directory {directoryPath} selected for {fileType} files");
                ProcessDirectory(directoryPath, fileType);
            }
            else
            {
                Console.WriteLine("Invalid command line oprions");
            }
            Console.WriteLine("Press enter to quit.");
            Console.ReadLine();
        }


        private static void ProcessSingleFile(string filePath)
        {
            var fileProcessor = new FileProcessor(filePath);
            fileProcessor.Processor();
        }

        private static void ProcessDirectory(string directoryPath, string fileType)
        {
            
        }
    }
}
