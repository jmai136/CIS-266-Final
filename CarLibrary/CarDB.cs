using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class CarDB : IDatabase<object>
    {
        public string MsgText { get; set; } = "";
        public string MsgCaption { get; set; } = "";

        public bool Upload(object obj, SqlConnection sqlConnection)
        {
            try
            {
                if (obj is Mercedes<string> == false && obj is BMW<string> == false && obj is Honda<int> == false && obj is Toyota<int> == false)
                    throw new ArgumentException("Argument passed in isn't correct type Car", "object");

                foreach (PropertyInfo property in obj.GetType().GetProperties())
                    if (property.GetValue(obj) == null || string.IsNullOrEmpty(property.GetValue(obj).ToString()))
                        throw new ArgumentNullException(property.Name, char.ToUpper(property.Name[0]) + property.Name.Substring(1) + " not found");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;

                cmd.CommandText =
                    "IF NOT EXISTS " +
                        "(SELECT TOP 1 CarVIN FROM Cars " +
                            "WHERE CarVIN = @CarVIN) " +
                        "BEGIN " +
                            "INSERT INTO Cars (CarVIN, CarYear, CarMake, CarModel, CarPrice, CarColor, CarMiles, CarFeatures) " +
                            "VALUES (@CarVIN, @CarYear, @CarMake, @CarModel, @CarPrice, @CarColor, @CarMiles, @CarFeatures)" +
                        "END " +
                        "ELSE " +
                        "SELECT TOP 1 CarVIN FROM Cars " +
                            "WHERE CarVIN = @CarVIN";

                if (obj is Mercedes<string> mercedes)
                {
                    cmd.Parameters.AddWithValue("@CarVIN", mercedes.carVIN);
                    cmd.Parameters.AddWithValue("@CarYear", mercedes.age);
                    cmd.Parameters.AddWithValue("@CarMake", mercedes.make);
                    cmd.Parameters.AddWithValue("@CarModel", mercedes.model);
                    cmd.Parameters.AddWithValue("@CarPrice", mercedes.price);
                    cmd.Parameters.AddWithValue("@CarColor", mercedes.color);
                    cmd.Parameters.AddWithValue("@CarMiles", mercedes.miles);
                    cmd.Parameters.AddWithValue("@CarFeatures", mercedes.engine);
                }

                if (obj is BMW<string> bmw)
                {
                    cmd.Parameters.AddWithValue("@CarVIN", bmw.carVIN);
                    cmd.Parameters.AddWithValue("@CarYear", bmw.age);
                    cmd.Parameters.AddWithValue("@CarMake", bmw.make);
                    cmd.Parameters.AddWithValue("@CarModel", bmw.model);
                    cmd.Parameters.AddWithValue("@CarPrice", bmw.price);
                    cmd.Parameters.AddWithValue("@CarColor", bmw.color);
                    cmd.Parameters.AddWithValue("@CarMiles", bmw.miles);
                    cmd.Parameters.AddWithValue("@CarFeatures", bmw.engine);
                }

                if (obj is Honda<int> honda)
                {
                    cmd.Parameters.AddWithValue("@CarVIN", honda.carVIN);
                    cmd.Parameters.AddWithValue("@CarYear", honda.age);
                    cmd.Parameters.AddWithValue("@CarMake", honda.make);
                    cmd.Parameters.AddWithValue("@CarModel", honda.model);
                    cmd.Parameters.AddWithValue("@CarPrice", honda.price);
                    cmd.Parameters.AddWithValue("@CarColor", honda.color);
                    cmd.Parameters.AddWithValue("@CarMiles", honda.miles);
                    cmd.Parameters.AddWithValue("@CarFeatures", honda.mileage);
                }

                if (obj is Toyota<int> toyota)
                {
                    cmd.Parameters.AddWithValue("@CarVIN", toyota.carVIN);
                    cmd.Parameters.AddWithValue("@CarYear", toyota.age);
                    cmd.Parameters.AddWithValue("@CarMake", toyota.make);
                    cmd.Parameters.AddWithValue("@CarModel", toyota.model);
                    cmd.Parameters.AddWithValue("@CarPrice", toyota.price);
                    cmd.Parameters.AddWithValue("@CarColor", toyota.color);
                    cmd.Parameters.AddWithValue("@CarMiles", toyota.miles);
                    cmd.Parameters.AddWithValue("@CarFeatures", toyota.mileage);
                }

                sqlConnection.Open();

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                    if (!string.IsNullOrEmpty(reader.GetString(reader.GetOrdinal("CarVIN"))))
                        throw new DataException("Car already exists");
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

        public bool Delete(object obj, SqlConnection sqlConnection)
        {
            try
            {
                if (obj is Mercedes<string> == false && obj is BMW<string> == false && obj is Honda<int> == false && obj is Toyota<int> == false)
                    throw new ArgumentException("Argument passed in isn't correct type Car", "object");

                foreach (PropertyInfo property in obj.GetType().GetProperties())
                    if (property.GetValue(obj) == null || string.IsNullOrEmpty(property.GetValue(obj).ToString()))
                        throw new ArgumentNullException(property.Name, char.ToUpper(property.Name[0]) + property.Name.Substring(1) + " not found");

                // https://www.sqlservercentral.com/articles/the-output-clause-for-insert-and-delete-statements
                // Gotta try this, even though it's deleting ExecuteScalar and ExecuteNonQuery don't work
                // for grabbing deleted rows or the first column's value
                // Notice the syntax, WHERE is at the end.
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM [GroupFinal266].[dbo].[Cars] " +
                    "OUTPUT DELETED.[CarVIN] " +
                    "WHERE CarVIN = @CarVIN", sqlConnection);

                if (obj is Mercedes<string> mercedes)
                {
                    cmd.Parameters.AddWithValue("@CarVIN", mercedes.carVIN);
                    cmd.Parameters.AddWithValue("@CarYear", mercedes.age);
                    cmd.Parameters.AddWithValue("@CarMake", mercedes.make);
                    cmd.Parameters.AddWithValue("@CarModel", mercedes.model);
                    cmd.Parameters.AddWithValue("@CarPrice", mercedes.price);
                    cmd.Parameters.AddWithValue("@CarColor", mercedes.color);
                    cmd.Parameters.AddWithValue("@CarMiles", mercedes.miles);
                    cmd.Parameters.AddWithValue("@CarFeatures", mercedes.engine);
                }

                if (obj is BMW<string> bmw)
                {
                    cmd.Parameters.AddWithValue("@CarVIN", bmw.carVIN);
                    cmd.Parameters.AddWithValue("@CarYear", bmw.age);
                    cmd.Parameters.AddWithValue("@CarMake", bmw.make);
                    cmd.Parameters.AddWithValue("@CarModel", bmw.model);
                    cmd.Parameters.AddWithValue("@CarPrice", bmw.price);
                    cmd.Parameters.AddWithValue("@CarColor", bmw.color);
                    cmd.Parameters.AddWithValue("@CarMiles", bmw.miles);
                    cmd.Parameters.AddWithValue("@CarFeatures", bmw.engine);
                }

                if (obj is Honda<int> honda)
                {
                    cmd.Parameters.AddWithValue("@CarVIN", honda.carVIN);
                    cmd.Parameters.AddWithValue("@CarYear", honda.age);
                    cmd.Parameters.AddWithValue("@CarMake", honda.make);
                    cmd.Parameters.AddWithValue("@CarModel", honda.model);
                    cmd.Parameters.AddWithValue("@CarPrice", honda.price);
                    cmd.Parameters.AddWithValue("@CarColor", honda.color);
                    cmd.Parameters.AddWithValue("@CarMiles", honda.miles);
                    cmd.Parameters.AddWithValue("@CarFeatures", honda.mileage);
                }

                if (obj is Toyota<int> toyota)
                {
                    cmd.Parameters.AddWithValue("@CarVIN", toyota.carVIN);
                    cmd.Parameters.AddWithValue("@CarYear", toyota.age);
                    cmd.Parameters.AddWithValue("@CarMake", toyota.make);
                    cmd.Parameters.AddWithValue("@CarModel", toyota.model);
                    cmd.Parameters.AddWithValue("@CarPrice", toyota.price);
                    cmd.Parameters.AddWithValue("@CarColor", toyota.color);
                    cmd.Parameters.AddWithValue("@CarMiles", toyota.miles);
                    cmd.Parameters.AddWithValue("@CarFeatures", toyota.mileage);
                }

                sqlConnection.Open();

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                    if (string.IsNullOrEmpty(reader.GetString(reader.GetOrdinal("CarVIN"))))
                        throw new DataException("Car doesn't exist");
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
