using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySharedLibrary;

namespace MainApp
{
    public class UserManagementModule
    {
        public void AddUser(string username)
        {
            // Validate username using the shared library method
            if (MySharedLibrary.MyUtilityClass.ValidateData(username))
            {
                // Your user management logic here
                Console.WriteLine($"User '{username}' added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid username. Please provide a valid username.");
            }
        }

        public void RemoveUser(string username)
        {
            // Validate username using the shared library method
            if (MySharedLibrary.MyUtilityClass.ValidateData(username))
            {
                // Your user management logic here
                Console.WriteLine($"User '{username}' removed successfully.");
            }
            else
            {
                Console.WriteLine("Invalid username. Please provide a valid username.");
            }
        }
    }
}
