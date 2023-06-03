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
    public static class UserDB
    {
        // https://stackoverflow.com/questions/18114458/fastest-way-to-determine-if-record-exists
        // If exists for SQL query

        public static void RegisterUser(User user, SqlConnection sqlConnection)
        {
            // Replace with the user id, this is going to be necessary for the cars
            try
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT Sellers (SellerID, CarVIN, FirstName, LastName, Email, Password  " +
                    "VALUES (@SellerID, @CarVIN, @FirstName, @LastName, @Email, HASHBYTES('SHA2_512', @Password)",
                    sqlConnection);

                cmd.Parameters.AddWithValue("@SellerID", user.userID);
                cmd.Parameters.AddWithValue("@CarVIN", user.carVIN);
                cmd.Parameters.AddWithValue("@FirstName", user.firstName);
                cmd.Parameters.AddWithValue("@LastName", user.lastName);
                cmd.Parameters.AddWithValue("@Email", user.email);
                cmd.Parameters.AddWithValue("@Password", user.password);

                sqlConnection.Open();
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
                sqlConnection.Close();
            }
        }
    }
}
