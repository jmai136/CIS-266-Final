using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace CarLibrary
{
    public class ListingDB : IDatabase<Listing>
    {
        public string MsgText { get; set; } = "";
        public string MsgCaption { get; set; } = "";

        public static Dictionary<string, Func<Car>> carsCreationDictionary = new Dictionary<string, Func<Car>>()
        {
            { "Mercedes", () => new Mercedes<string>() },
            { "BMW", () => new BMW<string>() },
            { "Toyota", () => new Toyota<int>() },
            { "Honda", () => new BMW<int>() }
        };

        public struct FilterByMake : IFilter<Car>
        {
            public List<Car> FilterBy(List<Car> dataGridView, string filterProperty, SqlConnection sqlConnection)
            {
                List<Car> cars = new List<Car>();

                try
                {
                    SqlCommand cmd = new SqlCommand("spSelectCarByMake", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CarMake", filterProperty);

                    sqlConnection.Open();

                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        Car car = carsCreationDictionary[reader.GetString(reader.GetOrdinal("CarMake"))].Invoke();
                        car.carVIN = reader.GetString(reader.GetOrdinal("CarVIN"));
                        car.age = reader.GetInt32(reader.GetOrdinal("CarYear"));
                        car.make = reader.GetString(reader.GetOrdinal("CarMake"));
                        car.model = reader.GetString(reader.GetOrdinal("CarModel"));
                        car.price = reader.GetDecimal(reader.GetOrdinal("CarPrice"));
                        car.color = reader.GetString(reader.GetOrdinal("CarColor"));
                        car.miles = reader.GetInt32(reader.GetOrdinal("CarMiles"));

                        cars.Add(car);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    sqlConnection.Close();
                }

                return cars;
            }

            public void GetAll(object obj)
            {
                throw new NotImplementedException();
            }
        }

        public struct FilterByColor : IFilter<Car>
        {
            public List<Car> FilterBy(List<Car> dataGridView, string filterProperty, SqlConnection sqlConnection)
            {
                List<Car> cars = new List<Car>();

                try
                {
                    SqlCommand cmd = new SqlCommand("spSelectCarByColor", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CarColor", filterProperty);

                    sqlConnection.Open();

                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        Car car = carsCreationDictionary[reader.GetString(reader.GetOrdinal("CarMake"))].Invoke();
                        car.carVIN = reader.GetString(reader.GetOrdinal("CarVIN"));
                        car.age = reader.GetInt32(reader.GetOrdinal("CarYear"));
                        car.make = reader.GetString(reader.GetOrdinal("CarMake"));
                        car.model = reader.GetString(reader.GetOrdinal("CarModel"));
                        car.price = reader.GetDecimal(reader.GetOrdinal("CarPrice"));
                        car.color = reader.GetString(reader.GetOrdinal("CarColor"));
                        car.miles = reader.GetInt32(reader.GetOrdinal("CarMiles"));

                        cars.Add(car);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    sqlConnection.Close();
                }

                return cars;
            }

            public void GetAll(object obj)
            {
                throw new NotImplementedException();
            }
        }

        public struct FilterByAge : IFilter<Car>
        {
            public List<Car> FilterBy(List<Car> dataGridView, string filterProperty, SqlConnection sqlConnection)
            {
                List<Car> cars = new List<Car>();

                try
                {
                    SqlCommand cmd = new SqlCommand("spSelectCarByYear", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CarYear", filterProperty);

                    sqlConnection.Open();

                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        Car car = carsCreationDictionary[reader.GetString(reader.GetOrdinal("CarMake"))].Invoke();
                        car.carVIN = reader.GetString(reader.GetOrdinal("CarVIN"));
                        car.age = reader.GetInt32(reader.GetOrdinal("CarYear"));
                        car.make = reader.GetString(reader.GetOrdinal("CarMake"));
                        car.model = reader.GetString(reader.GetOrdinal("CarModel"));
                        car.price = reader.GetDecimal(reader.GetOrdinal("CarPrice"));
                        car.color = reader.GetString(reader.GetOrdinal("CarColor"));
                        car.miles = reader.GetInt32(reader.GetOrdinal("CarMiles"));

                        cars.Add(car);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    sqlConnection.Close();
                }

                return cars;
            }

            public void GetAll(object obj)
            {
                throw new NotImplementedException();
            }
        }

        public struct FilterByPrice : IFilter<Car>
        {
            public List<Car> FilterBy(List<Car> dataGridView, string filterProperty, SqlConnection sqlConnection)
            {
                // https://www.akadia.com/services/dotnet_find_methods.html

                List<Car> cars = new List<Car>();

                try
                {
                    SqlCommand cmd = new SqlCommand("spSelectCarByPrice", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CarPrice", filterProperty);

                    sqlConnection.Open();

                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        Car car = carsCreationDictionary[reader.GetString(reader.GetOrdinal("CarMake"))].Invoke();
                        car.carVIN = reader.GetString(reader.GetOrdinal("CarVIN"));
                        car.age = reader.GetInt32(reader.GetOrdinal("CarYear"));
                        car.make = reader.GetString(reader.GetOrdinal("CarMake"));
                        car.model = reader.GetString(reader.GetOrdinal("CarModel"));
                        car.price = reader.GetDecimal(reader.GetOrdinal("CarPrice"));
                        car.color = reader.GetString(reader.GetOrdinal("CarColor"));
                        car.miles = reader.GetInt32(reader.GetOrdinal("CarMiles"));

                        cars.Add(car);
                     }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    sqlConnection.Close();
                }

                return cars;
            }

            public void GetAll(object obj)
            {
                throw new NotImplementedException();
            }
        }

        /*
         * Change the code so you use Interfaces instead.
         * Create your own custom interfaces.
         * Use the in-built interfaces that help you compare different listings while filtering.
         * (Hint: IComparable)
         */

        // Select statements here or grab the query created in the designer
        // Should have all three methods somewhere: creating query through designer, execute scalar, and stored procedures

        public static List<Listing> GetAllListings(SqlConnection sqlConnection)
        {
            List<Listing> listings = new List<Listing>();
            try
            {
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = sqlConnection,
                    CommandText = "SELECT * FROM [GroupFinal266].[dbo].[Listing]"
                };

                sqlConnection.Open();

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Listing listing = new Listing()
                    {
                        listingID = reader.GetInt32(reader.GetOrdinal("ListingID")),
                        sellerID = reader.GetInt32(reader.GetOrdinal("SellerID")),
                        carVIN = reader.GetString(reader.GetOrdinal("CarVIN")),
                        description = reader.GetString(reader.GetOrdinal("Description")),
                        creationDateTime = reader.GetDateTime(reader.GetOrdinal("CreationDateTime"))
                    };

                    listings.Add(listing);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }

            return listings;
        }
        
        // Put GetAll in a separate CarsDB in order to use interfaces
        public List<Car> GetAllCars(int sellerID, SqlConnection sqlConnection)
        {
            List<Car> cars = new List<Car>();

            try
            {
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = sqlConnection,
                    CommandText = "SELECT * FROM [GroupFinal266].[dbo].[Cars]"
                 };

                sqlConnection.Open();

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Car car = carsCreationDictionary[reader.GetString(reader.GetOrdinal("CarMake"))].Invoke();
                    car.carVIN = reader.GetString(reader.GetOrdinal("CarVIN"));
                    car.age = reader.GetInt32(reader.GetOrdinal("CarYear"));
                    car.make = reader.GetString(reader.GetOrdinal("CarMake"));
                    car.model = reader.GetString(reader.GetOrdinal("CarModel"));
                    car.price = reader.GetDecimal(reader.GetOrdinal("CarPrice"));
                    car.color = reader.GetString(reader.GetOrdinal("CarColor"));
                    car.miles = reader.GetInt32(reader.GetOrdinal("CarMiles"));

                    cars.Add(car);
                }
            }
            catch (Exception ex)
            {
                MsgText = ex.Message;
                MsgCaption = ex.GetType().ToString();
            }
            finally
            {
                sqlConnection.Close();
            }

            return cars;
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

        public static List<string> GetCarPropertyFilteredByDistinctValues(string filterProperty, SqlConnection sqlConnection)
        {
            try
            {
                List<string> options = new List<string>();

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

                return options;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public bool Upload(Listing obj, SqlConnection sqlConnection)
        {
            try
            {
                if (obj is Listing == false)
                    throw new ArgumentException("Argument passed in isn't correct type Listing", "object");

                foreach(PropertyInfo property in obj.GetType().GetProperties())
                    if (property.GetValue(obj) == null || string.IsNullOrEmpty(property.GetValue(obj).ToString()))
                        throw new ArgumentNullException(property.Name, char.ToUpper(property.Name[0]) + property.Name.Substring(1) + " not found");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;

                cmd.CommandText =
                    "IF NOT EXISTS " +
                        "(SELECT TOP 1 ListingID FROM Listing " +
                            "WHERE CarVIN = @CarVIN) " +
                        "BEGIN " +
                            "INSERT INTO Listing (SellerID, CarVIN, Description) " +
                            "VALUES (@SellerID, @CarVIN, @Description)" +
                        "END " +
                        "ELSE " +
                        "SELECT TOP 1 ListingID FROM Listing " +
                            "WHERE CarVIN = @CarVIN";

                // Pass in Listings
                cmd.Parameters.AddWithValue("@SellerID", obj.sellerID);
                cmd.Parameters.AddWithValue("@CarVIN", obj.carVIN);
                cmd.Parameters.AddWithValue("@Description", obj.description);

                sqlConnection.Open();

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                    if (reader.GetInt32(reader.GetOrdinal("ListingID")) > 0)
                        throw new DataException("Listing already exists");
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

        public bool Delete(Listing obj, SqlConnection sqlConnection)
        {
            try
            {
                if (obj is Listing == false)
                    throw new ArgumentException("Argument passed in isn't correct type Listing", "object");

                foreach (PropertyInfo property in obj.GetType().GetProperties())
                    if (property.GetValue(obj) == null || string.IsNullOrEmpty(property.GetValue(obj).ToString()))
                        throw new ArgumentNullException(property.Name, char.ToUpper(property.Name[0]) + property.Name.Substring(1) + " not found");

                // https://www.sqlservercentral.com/articles/the-output-clause-for-insert-and-delete-statements
                // Gotta try this, even though it's deleting ExecuteScalar and ExecuteNonQuery don't work
                // for grabbing deleted
                // Notice the syntax, WHERE is at the end.
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM [GroupFinal266].[dbo].[Listing] " +
                    "OUTPUT DELETED.[ListingID] " +
                    "WHERE ListingID = @ListingID AND SellerID = @SellerID AND CarVIN = @CarVIN", sqlConnection);

                cmd.Parameters.AddWithValue("@ListingID", obj.listingID);
                cmd.Parameters.AddWithValue("@SellerID", obj.sellerID);
                cmd.Parameters.AddWithValue("@CarVIN", obj.carVIN);

                sqlConnection.Open();

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    int listingID = reader.GetInt32(reader.GetOrdinal("ListingID"));

                    if (listingID <= 0)
                        throw new DataException("Listing doesn't exist.");
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

        // Comment section where a potential buyer can ask questions to the seller.
        // Save in text file?
        public static void GetComment()
        {

        }
    }
}
