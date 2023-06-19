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

            try
            {
                if (obj is User == false)
                    throw new ArgumentException("Argument passed in isn't correct type User", "object");

                foreach (PropertyInfo property in obj.GetType().GetProperties())
                    if (property.GetValue(obj) == null || string.IsNullOrEmpty(property.GetValue(obj).ToString()))
                        throw new ArgumentNullException(property.Name, char.ToUpper(property.Name[0]) + property.Name.Substring(1) + " not found");
                
                SqlCommand cmd = new SqlCommand("spRegisterUser", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                // If there's time to salt, typically you'd salt the original password, then hash it
                byte[] salt = new byte[256];
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                rng.GetNonZeroBytes(salt);

                cmd.Parameters.AddWithValue("@FirstName", obj.firstName);
                cmd.Parameters.AddWithValue("@LastName", obj.lastName);
                cmd.Parameters.AddWithValue("@Email", obj.email);
                cmd.Parameters.AddWithValue("@Password", obj.password);
                cmd.Parameters.AddWithValue("@Salt", salt);

                sqlConnection.Open();

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                    if (reader.GetInt32(reader.GetOrdinal("SellerID")) > 0)
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
                        "(SELECT TOP 1 SellerID FROM Sellers WHERE Hash = HASHBYTES('SHA2_512', CONCAT(@Password, (SELECT [Salt] FROM [GroupFinal266].[dbo].[Sellers] WHERE Email=@Email)))) " +
                      "BEGIN " +
                        "SELECT TOP 1 SellerID FROM Sellers WHERE Hash = HASHBYTES('SHA2_512', CONCAT(@Password, (SELECT [Salt] FROM [GroupFinal266].[dbo].[Sellers] WHERE Email=@Email))) " +
                      "END",
                    sqlConnection);

                // TShould use query to assign the user id?
                cmd.Parameters.AddWithValue("@SellerID", user.userID);
                cmd.Parameters.AddWithValue("@Email", user.email);
                cmd.Parameters.AddWithValue("@Password", user.password);

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

        // There's no need to delete users, only listing according to instructions
        public bool Delete(User obj, SqlConnection sqlConnection)
        {
            bool isDeleted = true;

            try
            {
                if (obj is User == false)
                    throw new ArgumentException("Argument passed in isn't correct type User", "object");

                if (string.IsNullOrEmpty(obj.email))
                    throw new DataException("No email to look up correct user to delete.");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;

                cmd.CommandText = "DELETE FROM [GroupFinal266].[dbo].[Sellers] WHERE Email=@Email";

                cmd.Parameters.AddWithValue("@Email", obj.email);

                sqlConnection.Open();

                int recordsAmount = Convert.ToInt32(cmd.ExecuteScalar());

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
