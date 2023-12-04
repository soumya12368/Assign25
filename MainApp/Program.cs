using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySharedLibrary;

namespace MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate modules
            UserManagementModule userModule = new UserManagementModule();
            FileProcessingModule fileModule = new FileProcessingModule();

            // Demonstrate User Management Module
            Console.WriteLine("=== User Management Module ===");
            userModule.AddUser("Soumya");
            userModule.RemoveUser("Soumya");
            userModule.AddUser(""); // Invalid username to test validation

            // Use File Processing Module
            Console.WriteLine("\n=== Shared Library Functionality ===");
            fileModule.ProcessFile("D:\\Mphasis-B2\\Day-20\\example.txt");
            fileModule.GenerateReport("D:\\Mphasis-B2\\Day-20\\example.txt");

            // Add other functionality as needed
            
            Console.ReadLine(); // Keep console window open
        }
    }
}
