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

        public static bool RegisterUser(User user, SqlConnection sqlConnection)
        {
            // Replace with the user id, this is going to be necessary for the cars
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;

                cmd.CommandText =  "IF EXISTS " +
                  "(SELECT TOP 1 SellerID FROM Sellers " +
                      "WHERE FirstName = @FirstName " +
                      "AND WHERE LastName = @LastName " +
                      "AND WHERE Email=@Email " +
                      "AND WHERE Password==HASHBYTES('SHA2_512', @Password))\r\n    " +
                   "BEGIN\r\n       " +
                   "SET @SellerID=(SELECT SellerID FROM Sellers " +
                        "WHERE FirstName = @FirstName " +
                        "AND WHERE LastName = @LastName " +
                        "AND WHERE Email=@Email " +
                        "AND WHERE Password==HASHBYTES('SHA2_512', @Password))";

                cmd.Parameters.AddWithValue("@SellerID", user.userID);
                cmd.Parameters.AddWithValue("@FirstName", user.firstName);
                cmd.Parameters.AddWithValue("@LastName", user.lastName);
                cmd.Parameters.AddWithValue("@Email", user.email);
                cmd.Parameters.AddWithValue("@Password", user.password);

                bool REPLACE_WITH_SQL_CODE_TO_CHECK_IF_EXISTS = true;
                
                if (REPLACE_WITH_SQL_CODE_TO_CHECK_IF_EXISTS)
                    return false;

                cmd.CommandText = "INSERT Sellers (SellerID, CarVIN, FirstName, LastName, Email, Password  " +
                    "VALUES (@SellerID, @CarVIN, @FirstName, @LastName, @Email, HASHBYTES('SHA2_512', @Password)";

                cmd.Parameters.AddWithValue("@SellerID", user.userID);
                cmd.Parameters.AddWithValue("@CarVIN", user.carVIN);
                cmd.Parameters.AddWithValue("@FirstName", user.firstName);
                cmd.Parameters.AddWithValue("@LastName", user.lastName);
                cmd.Parameters.AddWithValue("@Email", user.email);
                cmd.Parameters.AddWithValue("@Password", user.password);

                sqlConnection.Open();

                return true;
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

        public static void VerifyLoginUser(User user, SqlConnection sqlConnection)
        {
            try
            {
                // Replace with a query or a stored procedure
                SqlCommand cmd = new SqlCommand(
                   "IF EXISTS " +
                   "(SELECT TOP 1 SellerID FROM Sellers WHERE Email=@Email AND WHERE Password==HASHBYTES('SHA2_512', @Password))\r\n    " +
                    "BEGIN\r\n       " +
                    "SET @SellerID=(SELECT SellerID FROM Sellers WHERE Email=@Email AND WHERE Password==HASHBYTES('SHA2_512', @Password))",
                    sqlConnection);

                // TShould use query to assign the user id?
                cmd.Parameters.AddWithValue("@SellerID", user.userID);
                cmd.Parameters.AddWithValue("@Email", user.email);
                cmd.Parameters.AddWithValue("@Password", user.password);

                // Hopefully it retusn SellerID?
                sqlConnection.Open();
                cmd.ExecuteScalar();
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
