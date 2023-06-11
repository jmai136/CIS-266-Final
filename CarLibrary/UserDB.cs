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
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;

                cmd.CommandText = 
                    "IF EXISTS " +
                        "(SELECT TOP 1 SellerID FROM Sellers " +
                            "WHERE FirstName = @FirstName " +
                            "AND LastName = @LastName " +
                            "AND Email=@Email " +
                            "AND Password=HASHBYTES('SHA2_512', @Password)) " +
                        "BEGIN " +
                            "SET @SellerID=(SELECT SellerID FROM Sellers " +
                            "WHERE FirstName = @FirstName " +
                            "AND LastName = @LastName " +
                            "AND Email=@Email " +
                            "AND Password =HASHBYTES('SHA2_512', @Password)) " +
                        "END " +
                    "ELSE " +
                    "SET @SellerID = -1";

                cmd.Parameters.AddWithValue("@SellerID", user.userID);
                cmd.Parameters.AddWithValue("@FirstName", user.firstName);
                cmd.Parameters.AddWithValue("@LastName", user.lastName);
                cmd.Parameters.AddWithValue("@Email", user.email);
                cmd.Parameters.AddWithValue("@Password", user.password);

                // Check if the user already exists
                // If they already exist, which means the id cannot be -1, you'd then insert that information into the sellers table
                if (user.userID != -1)
                    return false;

                // Why do we have a CarVIN for the seller?
                // Shouldn't the car hold the data for the CarVIN since one seller can have multiple CarVIN?
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
                      "(SELECT TOP 1 SellerID FROM Sellers WHERE Email=@Email AND Password=HASHBYTES('SHA2_512', @Password)) " +
                          "BEGIN " +
                          "SET @SellerID=(SELECT SellerID FROM Sellers WHERE Email=@Email AND Password=HASHBYTES('SHA2_512', @Password)) " +
                      "END " +
                  "ELSE " +
                  "SET @SellerID = -1",
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
