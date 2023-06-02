using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Numerics;
using System.Xml.Linq;
using System.Data;

namespace CarLibrary
{
    // We're going to need the database to also hold information on users
    // Probably going to have a foreign key to link the car and user
    public static class UserDB
    {
        // Register a user and ask them to provide login username and password. Make sure
        // the user doesn't already exist. Can you save the password in encrypted format in
        // your database? Use your creativity here.

        // https://stackoverflow.com/questions/18114458/fastest-way-to-determine-if-record-exists
        // If exists for SQL query

        public static void RegisterUser(User user)
        {
            // Replace with the user id, this is going to be necessary for the cars
            try
            {
                string hashPassword = "";

                if (user.password != "")
                    hashPassword = HashPassword(user.password);

                // Store the hashed password in the query by adding it
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (DataException ex)
            {
                throw ex;
            }
            finally
            {

            }
        }

        public static string HashPassword(string password)
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
