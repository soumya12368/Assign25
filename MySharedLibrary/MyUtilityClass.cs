using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySharedLibrary
{
    public class MyUtilityClass
    {
        public static bool ValidateData(string data)
        {
            // Your validation logic here
            return !string.IsNullOrEmpty(data);
        }

        public static void LogMessage(string message)
        {
            // Your logging logic here
            Console.WriteLine($"Logging: {message}");
        }

        public static string EncryptData(string data)
        {
            // Your encryption logic here
            // For simplicity, let's just reverse the string as an example
            char[] charArray = data.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static bool ValidateData(object dataToValidate)
        {
            throw new NotImplementedException();
        }

        // Add other utility methods as needed
    }
}
