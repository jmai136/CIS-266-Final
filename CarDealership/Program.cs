using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealership
{
    internal static class Program
    {
        public static SqlConnection sqlConnection = new SqlConnection();
        public static string connectionString { get; } = System.Configuration.ConfigurationManager.ConnectionStrings["CarDealership.Properties.Settings.GroupFinal266ConnectionString"].ConnectionString;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Use the connection string already present in the app config.
            sqlConnection.ConnectionString = connectionString;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmUsers());
        }
    }
}
