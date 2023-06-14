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
using System.Reflection;

namespace CarLibrary
{
    public class UserDB : IDatabase
    {
        // https://stackoverflow.com/questions/18114458/fastest-way-to-determine-if-record-exists
        // If exists for SQL query

        public bool Upload(object obj, SqlConnection sqlConnection)
        {
            try
            {
                User user = (User)obj;

                foreach (PropertyInfo property in user.GetType().GetProperties())
                    if (property.GetValue(user) != null && string.IsNullOrEmpty(property.GetValue(user).ToString()))
                        return false;

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
                    "INSERT Sellers (SellerID, FirstName, LastName, Email, Password)  " +
                    "VALUES (@SellerID, @FirstName, @LastName, @Email, HASHBYTES('SHA2_512', @Password))";

                cmd.Parameters.AddWithValue("@SellerID", user.userID);
                cmd.Parameters.AddWithValue("@FirstName", user.firstName);
                cmd.Parameters.AddWithValue("@LastName", user.lastName);
                cmd.Parameters.AddWithValue("@Email", user.email);
                cmd.Parameters.AddWithValue("@Password", user.password);

                // Check if the user already exists
                if (string.IsNullOrEmpty(user.userID.ToString()) || string.IsNullOrWhiteSpace(user.userID.ToString()))
                    return false;

                sqlConnection.Open();
                cmd.ExecuteNonQuery();

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

        public static void VerifyLoginUser(User user, SqlConnection sqlConnection, out string msgText, out string msgCaption)
        {
            try
            {
                msgText = "";
                msgCaption = "";

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
                cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                msgText = ex.Message;
                msgCaption = ex.GetType().ToString();
            }
            /*catch (SqlException ex)
            {
                msgText = ex.Message;
                msgCaption = ex.GetType().ToString();
            }
            catch (DataException ex)
            {
                msgText = ex.Message;
                msgCaption = ex.GetType().ToString();
            }*/
            finally
            {
                sqlConnection.Close();
            }
        }

        public bool Delete(object obj, SqlConnection sqlConnection)
        {
            return true;
        }
    }
}
