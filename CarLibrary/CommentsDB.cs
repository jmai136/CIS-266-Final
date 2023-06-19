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

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandText =
                   "IF NOT EXISTS " +
                       "(SELECT TOP 1 CommentID FROM Comments " +
                           "WHERE CommentText = @CommentText " +
                           "AND ListingID = @ListingID) " +
                       "BEGIN " +
                           "INSERT INTO Comments (CommentText, ListingID)  " +
                           "VALUES (@CommentText, @ListingID)" +
                       "END ";

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

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandText = "DELETE FROM Comments WHERE CommentID = @CommentID AND ListingID = @ListingID AND CommentText = @CommentText";

                cmd.Parameters.AddWithValue("@CommentText", obj.CommentText);
                cmd.Parameters.AddWithValue("@CommentID", obj.CommentText);
                cmd.Parameters.AddWithValue("@ListingID", obj.CommentText);

                sqlConnection.Open();

                int recordsAmount = cmd.ExecuteNonQuery();

                if (recordsAmount > 1)
                    throw new DataException("Too many records for the same comment.");

                if (recordsAmount != 1)
                    throw new DataException("No comment to delete.");
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
