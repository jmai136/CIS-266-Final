using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Numerics;
using System.Xml.Linq;

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

        // NOTE: THESE FUNCTIONS ARE PROBABLY GOING TO BE MOVED TO A DIFFERENT CLASS
        // OR THIS CLASS WILL BE RENAMED TO USERDB
        // AS USER SHOULD HOLD PROPERTIES, NOT NECESSARILY VALIDATE

        public static int RegisterUser(User user)
        {
            // Replace with the user id, this is going to be necessary for the cars
            try
            {
                return 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {

            }
        }

        // OR put these two into one 
        public static User VerifyLoginUser(string username, string password, out string msgText, out string msgCaption)
        {
            // Temporary
            User user = new User();

            // Put in validation here to see if it exists in the SQL database
            try
            {
                if (username == null)
                {
                    msgText = "Please input a username";
                    msgCaption = "Username not found";

                    return user;
                }

                if (password == null)
                {
                    msgText = "Please input a password";
                    msgCaption = "Password not found";

                    return user;
                }

                // Insert query here
            }
            catch (Exception ex)
            {
                msgText = ex.Message;
                msgCaption = ex.GetType().ToString();
            }

            msgText = "";
            msgCaption = "";

            return user;
        }

        public static string EncryptPassword(string password)
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
