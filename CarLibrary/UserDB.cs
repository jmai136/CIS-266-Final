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
    public class UserDB : IDatabase<User>
    {
        public string MsgText { get; set; } = "";
        public string MsgCaption { get; set; } = "";

        // https://stackoverflow.com/questions/18114458/fastest-way-to-determine-if-record-exists
        // If exists for SQL query

        public bool Upload(User obj, SqlConnection sqlConnection)
        {
            bool canUpload = true;

            string msgHash = "";

            try
            {
                if (obj is User == false)
                    throw new ArgumentException("Argument passed in isn't correct type User", "object");

                foreach (PropertyInfo property in obj.GetType().GetProperties())
                    if (property.GetValue(obj) == null || string.IsNullOrEmpty(property.GetValue(obj).ToString()))
                        throw new ArgumentNullException(property.Name, char.ToUpper(property.Name[0]) + property.Name.Substring(1) + " not found");
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;

                cmd.CommandText =
                    "IF EXISTS " +
                        "(SELECT TOP 1 SellerID FROM Sellers " +
                            "WHERE Email=@Email " +
                             "AND Password = @Password " +
                             "AND Hash = @Hash) " +
                        "BEGIN " +
                            "SELECT SellerID FROM Sellers " +
                            "WHERE Email=@Email " +
                            "AND Password =@Password " +
                            "AND Hash = @Hash " +
                        "END " +
                     "ELSE " +
                     "INSERT INTO Sellers (FirstName, LastName, Email, Password, Hash) " +
                     "VALUES (@FirstName, @LastName, @Email, @Password, HASHBYTES('SHA2_512', @Password))";

                byte[] hash = SHA512.Create().ComputeHash(Encoding.Unicode.GetBytes(obj.password));

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                    sb.Append(b.ToString("X2"));

                msgHash = sb.ToString();
                MsgText = msgHash;

                // If there's time to salt, typically you'd salt the original password, then hash it
                /*
                byte[] salt = new byte[256];
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                rng.GetNonZeroBytes(salt);
                */

                cmd.Parameters.AddWithValue("@FirstName", obj.firstName);
                cmd.Parameters.AddWithValue("@LastName", obj.lastName);
                cmd.Parameters.AddWithValue("@Email", obj.email);
                cmd.Parameters.AddWithValue("@Password", obj.password);
                cmd.Parameters.AddWithValue("@Hash", hash);

                sqlConnection.Open();
                
                if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                    throw new DataException("User already exists");
            }
            catch (Exception ex)
            {
                MsgText = ex.Message + "\nHash: " + msgHash;
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
                        "(SELECT TOP 1 SellerID FROM Sellers WHERE Email=@Email AND Password=@Password AND Hash=@Hash) " +
                      "BEGIN " +
                        "SELECT TOP 1 SellerID FROM Sellers WHERE Email=@Email AND Password=@Password AND Hash=@Hash " +
                      "END",
                    sqlConnection);

                // TShould use query to assign the user id?
                cmd.Parameters.AddWithValue("@SellerID", user.userID);
                cmd.Parameters.AddWithValue("@Email", user.email);
                cmd.Parameters.AddWithValue("@Password", user.password);
                cmd.Parameters.AddWithValue("@Hash", SHA512.Create().ComputeHash(Encoding.Unicode.GetBytes(user.password)));

                // Hopefully it retusn SellerID?
                sqlConnection.Open();

                user.userID = Convert.ToInt32(cmd.ExecuteScalar());

                if (string.IsNullOrEmpty(user.userID.ToString()) || user.userID <= 0)
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

        public bool Delete(User obj, SqlConnection sqlConnection)
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
