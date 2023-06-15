using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CarLibrary
{
    struct FilterByMake : IFilter
    {
        public void FilterBy(string filterProperty, SqlConnection sqlConnection, out List<string> options)
        {
            throw new NotImplementedException();
        }

        public void GetAll(object obj)
        {
            throw new NotImplementedException();
        }
    }

    struct FilterByColor : IFilter
    {
        public void FilterBy(string filterProperty, SqlConnection sqlConnection, out List<string> options)
        {
            throw new NotImplementedException();
        }

        public void GetAll(object obj)
        {
            throw new NotImplementedException();
        }
    }

    struct FilterByAge : IFilter
    {
        public void FilterBy(string filterProperty, SqlConnection sqlConnection, out List<string> options)
        {
            throw new NotImplementedException();
        }

        public void GetAll(object obj)
        {
            throw new NotImplementedException();
        }
    }

    struct FilterByPrice : IFilter
    {
        public void FilterBy(string filterProperty, SqlConnection sqlConnection, out List<string> options)
        {
            options = new List<string>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;

            switch (filterProperty)
            {
                case "$5000-":
                    break;
                case "$5000 - 9,999":
                    break;
                case "$10,000+":
                    break;
                default:
                    break;
            }

            throw new NotImplementedException();
        }

        public void GetAll(object obj)
        {
            throw new NotImplementedException();
        }
    }

    public class ListingDB : IDatabase
    {
        public string MsgText { get; set; } = "";
        public string MsgCaption { get; set; } = "";

        /*
         * Change the code so you use Interfaces instead.
         * Create your own custom interfaces.
         * Use the in-built interfaces that help you compare different listings while filtering.
         * (Hint: IComparable)
         */

        // Select statements here or grab the query created in the designer
        // Should have all three methods somewhere: creating query through designer, execute scalar, and stored procedures
        
        public static void GetAllListings(SqlConnection sqlConnection)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
               
                sqlConnection.Open();

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {

                }
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
        
        // Put GetAll in a separate CarsDB in order to use interfaces
        public static void GetAllCars(int sellerID, SqlConnection sqlConnection)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;

                sqlConnection.Open();

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {

                }
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

        // Insert in the parameters here

        /*
         * When a filter option is selected, the application should show subsections with
         * titles in ascending order.
         * The titles can include the different makes in ascending order if make is
         * selected. Then display appropriate car listings underneath each title
         * ordered by listings' creation times.
         * There is no need to filter by model so you can skip that.
         * If color is selected, figure out how many different colors are in your saved
         * car listings data and create that many subsections with titles as those
         * colors in ascending order. Then display the cars under the appropriate
         * color ordered by listings' creation times.
         * 
         * The age and price should have ranges. For example: price under $5000,
         * between $5000 to $9,999, and $10,000+ as the titles for the subsections.
         * Then display the appropriate car listings in those subsections ordered by
         * listings' creation times. 
         */

        public static void GetCarPropertyFilteredByComboBoxValues(string filterProperty, SqlConnection sqlConnection, out List<string> options)
        {
            try
            {
                options = new List<string>();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                // Use this command for colors and make specifically
                cmd.CommandText = String.Format("SELECT DISTINCT {0} FROM Cars WHERE {0} IS NOT NULL", filterProperty);

                sqlConnection.Open();

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    // https://stackoverflow.com/questions/24557550/sql-c-sharp-cant-convert-int32-to-string
                    options.Add(reader[0].ToString());
                }
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

        public static void GetCarFilteredBy()
        {
            // Use IComparable by age, etc
        }

        public bool Upload(object obj, SqlConnection sqlConnection)
        {
            return true;
        }

        public bool Delete(object obj, SqlConnection sqlConnection)
        {
            return true;
        }

        // Comment section where a potential buyer can ask questions to the seller.
        // Save in text file?
        public static void GetComment()
        {

        }
    }
}
