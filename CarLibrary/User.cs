using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.Intrinsics.X86;

namespace CarLibrary
{
    // We're going to need the database to also hold information on users
    // Probably going to have a foreign key to link the car and user
    public class User
    {
        // Register a user and ask them to provide login username and password. Make sure
        // the user doesn't already exist. Can you save the password in encrypted format in
        // your database? Use your creativity here.
        public string EncryptPassword(string password)
        {
            // https://www.c-sharpcorner.com/article/compute-sha256-hash-in-c-sharp/
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
