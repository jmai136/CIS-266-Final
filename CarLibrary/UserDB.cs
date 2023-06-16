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
        public string MsgText { get; set; } = "";
        public string MsgCaption { get; set; } = "";

        // https://stackoverflow.com/questions/18114458/fastest-way-to-determine-if-record-exists
        // If exists for SQL query

        public bool Upload(object obj, SqlConnection sqlConnection)
        {
            bool canUpload = true;

            try
            {
                if (obj is User == false)
                    throw new ArgumentException("Argument passed in isn't correct type User", "object");

                List<object> userProperties = new List<object>();

                foreach (PropertyInfo property in obj.GetType().GetProperties())
                    if (property.GetValue(obj) == null || string.IsNullOrEmpty(property.GetValue(obj).ToString()))
                        throw new ArgumentNullException(property.Name, char.ToUpper(property.Name[0]) + property.Name.Substring(1) + " not found");
                    else
                        userProperties.Add(property.GetValue(obj));
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;

                cmd.CommandText =
                    "IF EXISTS " +
                        "(SELECT TOP 1 SellerID FROM Sellers " +
                            "WHERE Email=@Email " +
                             "AND Password=HASHBYTES('SHA2_512', @Password)) " + 
                        "BEGIN " +
                            "SELECT SellerID FROM Sellers " +
                            "WHERE FirstName = @FirstName " +
                            "AND LastName = @LastName " +
                            "AND Email=@Email " +
                            "AND Password =HASHBYTES('SHA2_512', @Password) " +
                        "END " +
                     "ELSE " +
                     "INSERT INTO Sellers (FirstName, LastName, Email, Password)  " +
                     "VALUES (@FirstName, @LastName, @Email, HASHBYTES('SHA2_512', @Password))";

                cmd.Parameters.AddWithValue("@FirstName", userProperties[1]);
                cmd.Parameters.AddWithValue("@LastName", userProperties[2]);
                cmd.Parameters.AddWithValue("@Email", userProperties[3]);
                cmd.Parameters.AddWithValue("@Password", userProperties[4]);

                sqlConnection.Open();
                
                if (cmd.ExecuteScalar() != null)
                    throw new DataException("User already exists");
            }
            catch (Exception ex)
            {
                MsgText = ex.Message;
                MsgCaption = ex.GetType().ToString();

                canUpload = false;
            }
            finally
            {
                sqlConnection.Close();
            }

            return canUpload;
        }

        public bool VerifyLoginUser(User user, SqlConnection sqlConnection)
        {
            bool canLogin = true;

            try
            {
                // Replace with a query or a stored procedure
                SqlCommand cmd = new SqlCommand(
                  "IF EXISTS " +
                        "(SELECT TOP 1 SellerID FROM Sellers WHERE Email=@Email AND Password=HASHBYTES('SHA2_512', @Password)) " +
                      "BEGIN " +
                        "SELECT TOP 1 SellerID FROM Sellers WHERE Email=@Email AND Password=HASHBYTES('SHA2_512', @Password) " +
                      "END",
                    sqlConnection);

                // TShould use query to assign the user id?
                cmd.Parameters.AddWithValue("@SellerID", user.userID);
                cmd.Parameters.AddWithValue("@Email", user.email);
                cmd.Parameters.AddWithValue("@Password", user.password);

                // Hopefully it retusn SellerID?
                sqlConnection.Open();

                user.userID = Convert.ToInt32(cmd.ExecuteScalar());

                if (string.IsNullOrEmpty(user.userID.ToString()) || user.userID == -1)
                    throw new DataException("User doesn't exist");
            }
            catch (Exception ex)
            {
                MsgText = ex.Message;
                MsgCaption = ex.GetType().ToString();

                canLogin = false;
            }
            finally
            {
                sqlConnection.Close();
            }

            return canLogin;
        }

        public bool VerifyLoginUser(int sellerID, SqlConnection sqlConnection)
        {
            bool isLoggedIn = true;

            try
            {
                // Replace with a query or a stored procedure
                SqlCommand cmd = new SqlCommand(
                    "SELECT TOP 1 SellerID FROM Sellers WHERE SellerID=@SellerID",
                    sqlConnection);

                cmd.Parameters.AddWithValue("@SellerID", sellerID);

                // Hopefully it retusn SellerID?
                sqlConnection.Open();

                if (Convert.ToInt32(cmd.ExecuteScalar()) != sellerID)
                    throw new DataException("User doesn't exist");
            }
            catch (Exception ex)
            {
                MsgText = ex.Message;
                MsgCaption = ex.GetType().ToString();

                isLoggedIn = false;
            }
            finally
            {
                sqlConnection.Close();
            }

            return isLoggedIn;
        }

        public bool Delete(object obj, SqlConnection sqlConnection)
        {
            bool isDeleted = true;

            try
            {
                if (obj is User == false)
                    throw new ArgumentException("Argument passed in isn't correct type User", "object");

                List<object> userProperties = new List<object>();

                foreach (PropertyInfo property in obj.GetType().GetProperties())
                    if (property.GetValue(obj) == null || string.IsNullOrEmpty(property.GetValue(obj).ToString()))
                        throw new ArgumentNullException(property.Name, char.ToUpper(property.Name[0]) + property.Name.Substring(1) + " not found");
                    else
                        userProperties.Add(property.GetValue(obj));

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;

                cmd.CommandText = "DELETE FROM Sellers WHERE Email=@Email AND Password=@Password";

                cmd.Parameters.AddWithValue("@Email", userProperties[3]);
                cmd.Parameters.AddWithValue("@Password", userProperties[4]);

                sqlConnection.Open();

                int recordsAmount = cmd.ExecuteNonQuery();

                if (recordsAmount > 1)
                    throw new DataException("Too many records for the same user");

                if (recordsAmount != 1)
                    throw new DataException("No user to delete");
            }
            catch (Exception ex)
            {
                MsgText = ex.Message;
                MsgCaption = ex.GetType().ToString();

                isDeleted = false;
            }
            finally
            {
                sqlConnection.Close();
            }

            return isDeleted;
        }
    }
}
