using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySharedLibrary;

namespace MainApp
{
    public class FileProcessingModule
    {
        public void ProcessFile(string filePath)
        {
            // Your file processing logic here
            Console.WriteLine($"Processing file at '{filePath}'.");
        }

        public void GenerateReport(string filePath)
        {
            // Your report generation logic here
            Console.WriteLine($"Generating report for file at '{filePath}'.");
        }

    }
}
