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
using System.CodeDom;

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
                if (obj is User)
                {

                    List<object> userProperties = new List<object>();

                    foreach (PropertyInfo property in obj.GetType().GetProperties())
                        if (property.GetValue(obj) == null || string.IsNullOrEmpty(property.GetValue(obj).ToString()))
                        {
                            return false;
                        }
                        else {
                            userProperties.Add(property.GetValue(obj));
                        }

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
                        "INSERT Sellers (FirstName, LastName, Email, Password)  " +
                        "VALUES (@FirstName, @LastName, @Email, HASHBYTES('SHA2_512', @Password))";

                    cmd.Parameters.AddWithValue("@SellerID",userProperties[0]);
                    cmd.Parameters.AddWithValue("@FirstName", userProperties[1]);
                    cmd.Parameters.AddWithValue("@LastName", userProperties[2]);
                    cmd.Parameters.AddWithValue("@Email", userProperties[3]);
                    cmd.Parameters.AddWithValue("@Password", userProperties[4]);

                    // Check if the user already exists
                    if (string.IsNullOrEmpty(userProperties[0].ToString()) || string.IsNullOrWhiteSpace(userProperties[0].ToString()))
                        return false;

                    sqlConnection.Open();
                    cmd.ExecuteNonQuery();

                    return true;
                }
                else
                { return false; }
            }
            catch (Exception ex)
            {
                /*
                msgText = ex.Message;
                msgCaption = ex.GetType().ToString();*/
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public static bool VerifyLoginUser(User user, SqlConnection sqlConnection/*, out string msgText, out string msgCaption*/)
        {
            try
            {
                /*
                msgText = "";
                msgCaption = "";
                */

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

                return (user.userID != -1) ? true : false;
            }
            catch (Exception ex)
            {
                /*
                msgText = ex.Message;
                msgCaption = ex.GetType().ToString();
                */
                throw ex;
            }
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
