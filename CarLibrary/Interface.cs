using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public interface IUtility
    {
        void AssignBusinessObjectData();

        bool PutBusinessObjectData();

        void EnableControls(bool enable = true);
    }

    // Use to verify login user for the user form
    // But also to make sure that when uploading a car, you're actually logged in
    public interface IUser
    {
        void UserAuthentication();
    }

    public interface IFilter
    {
        // Get all listings/all cars/all users, etc.
        void GetAll(object obj);

        // Filter by Make, Color, Age, Price
        void FilterBy(string filterProperty, SqlConnection sqlConnection, out List<string> options);
    }

    public interface ICar
    {
        dynamic GetFeaturesInfo();
    }

    public interface IDatabase
    {
        string MsgText { get; set; }
        string MsgCaption { get; set; }

        bool Upload(object obj, SqlConnection sqlConnection);

        bool Delete(object obj, SqlConnection sqlConnection);
    }
}
