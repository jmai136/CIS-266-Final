using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class CommentsDB : IDatabase<Comments>
    {
        public string MsgText { get; set; } = "";
        public string MsgCaption { get; set; } = "";

        public bool Upload(Comments obj, SqlConnection sqlConnection)
        {
            try
            {
                if (obj is Comments == false)
                    throw new ArgumentException("Argument passed in isn't correct type Comments",
                        "object");

                // Just for validation's sake, we don't actually need the else statement but check validation
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandText =
                   "IF NOT EXISTS " +
                       "(SELECT TOP 1 CommentID FROM Comments " +
                           "WHERE CommentText = @CommentText " +
                           "AND ListingID = @ListingID) " +
                       "BEGIN " +
                           "INSERT INTO Comments (CommentText, ListingID)  " +
                           "VALUES (@CommentText, @ListingID) " +
                       "END " +
                        "ELSE " +
                            "SELECT TOP 1 CommentID FROM Comments " +
                            "WHERE CommentText = @CommentText " +
                            "AND ListingID = @ListingID ";

                cmd.Parameters.AddWithValue("@CommentText", obj.CommentText);
                cmd.Parameters.AddWithValue("@ListingID", obj.ListingID);

                sqlConnection.Open();
                if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                    throw new DataException("Comments already exists");
            }
            catch (Exception ex)
            {
                MsgText = ex.Message;
                MsgCaption = ex.GetType().ToString();

                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool Delete(Comments obj, SqlConnection sqlConnection)
        {
            try
            {
                if (obj is Comments == false)
                    throw new ArgumentException("Argument passed in isn't correct type Comments",
                        "object");

                // Yea, you really should only be able to delete the comment if the seller id matches the one you're currently as
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM [GroupFinal266].[dbo].[Comments] " +
                    "OUTPUT DELETED.[CommentID] " +
                    "WHERE CommentID = @CommentID AND ListingID = @ListingID AND CommentText = @CommentText",
                    sqlConnection);

                cmd.Parameters.AddWithValue("@CommentText", obj.CommentText);
                cmd.Parameters.AddWithValue("@CommentID", obj.CommentsID);
                cmd.Parameters.AddWithValue("@ListingID", obj.ListingID);

                sqlConnection.Open();

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    int commentID = reader.GetInt32(reader.GetOrdinal("CommentID"));

                    if (commentID <= 0)
                        throw new DataException("Comment doesn't exist.");
                }
            }
            catch (Exception ex)
            {
                MsgText = ex.Message;
                MsgCaption = ex.GetType().ToString();

                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

    }
}
