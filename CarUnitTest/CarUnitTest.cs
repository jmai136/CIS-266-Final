using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CarDealership;
using CarLibrary;
using System.Data;
using System.Data.SqlClient;

namespace CarUnitTest
{
    [TestClass]
    public class CarUnitTest
    {
        // https://stackoverflow.com/questions/21853793/how-can-i-access-to-an-internal-static-class-from-another-assembly
        UserDB userDB = new UserDB();
        ListingDB listingDB = new ListingDB();

        // The terrible way but oh well, if you can figure it out, then optimize it.
        static SqlConnection sqlConnection = new SqlConnection() { 
            ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=GroupFinal266;Integrated Security=True"
        };

        /*******************************************
         ************** USER REGISTRATION ************
         *******************************************/
        [TestMethod]
        public void UserSuccessfulRegistrationWithUniqueProperties()
        {
            User user = new User() {
                email = "gatocaceujeu-6803@yopmail.com",
                password = "UTqNC*5kF@12",
                firstName = "Ezekiel",
                lastName = "Byllaid"
            };

            Assert.IsTrue(userDB.Upload(user, sqlConnection), "Should be true due to non-existent user and correct types");
        }

        // Why are these failing? According to some Stack Overflow threads,
        // different encoding can change the hashes even with the same input?
        [TestMethod]
        public void UserFailedRegistrationBecauseOfAlreadyExistingUser()
        {
            // Make sure to already have this in the database.
            User user = new User()
            {
                email = "zzm4h94sr1a@icznn.com",
                password = "u3AeOX ^ 686 & h",
                firstName = "Hoshi",
                lastName = "Kask"
            };

            Assert.IsFalse(userDB.Upload(user, sqlConnection), "Should be false due to already existing user regardless of user's name.");
        }

        [TestMethod]
        public void UserFailedRegistrationBecauseShareSameEmailAndPassword()
        {
            // Make sure to already have this in the database.
            User user = new User()
            {
                email = "xullowebratre-1583@yopmail.com",
                password = "$07*R2E1Vc9*",
                firstName = "Junebug",
                lastName = "Kimishima"
            };

            Assert.IsFalse(userDB.Upload(user, sqlConnection), "Should be false due to not being able to register with the same email and password for two different users.");
        }

        [TestMethod]
        public void UserFailedRegistrationBecauseOfNullOrEmptyUserProperties()
        {
            // Make sure to already have this in the database.
            User user = new User();

            Assert.IsFalse(userDB.Upload(user, sqlConnection), "Should be false due to null or empty user properties.");
        }

        /*******************************************
         ************** USER LOGIN *******************
         *******************************************/

        [TestMethod]
        public void UserSuccessfulLoginWithExistingUserViaBusinessModel()
        {
            User user = new User()
            {
                email = "zzm4h94sr1a@icznn.com",
                password = "u3AeOX ^ 686 & h",
                firstName = "Hoshi",
                lastName = "Kask"
            };

            Assert.IsTrue(userDB.VerifyLoginUser(user, sqlConnection), "Should be true due to Hoshi Kask's existence.");
        }

        [TestMethod]
        public void UserFailedLoginWrongPassword()
        {
            User user = new User()
            {
                email = "zzm4h94sr1a@icznn.com",
                password = "774m&RGPnNzi",
                firstName = "Hoshi",
                lastName = "Kask"
            };

            Assert.IsFalse(userDB.VerifyLoginUser(user, sqlConnection), "Should be false due to wrong password.");
        }

        [TestMethod]
        public void UserSuccessfulLoginWithExistingUserViaSellerID()
        {
            Assert.IsTrue(userDB.VerifyLoginUser(1, sqlConnection), "Should be true due to seller ID existing for Hoshi Kask.");
        }

        [TestMethod]
        public void UserFailedLoginBecauseIncorrectSellerID()
        {
            Assert.IsFalse(userDB.VerifyLoginUser(-1, sqlConnection), "Should be false due to seller ID not existing.");
        }

        /*******************************************
         ***************** LISTING *******************
         *******************************************/
        [TestMethod]
        public void ListingFailedUploadBecauseMissingProperties()
        {
            Listing listing = new Listing()
            {
                car = new BMW<string>()
                {
                    carVIN = "N/A",
                    userId = 1,
                    make = "BMW",
                    model = "BMW 2001",
                    color = "Black",
                    age = 2003,
                    price = 394.45M,
                    miles = 5034,
                    engine = "N/A"
                },
                creationDateTime = DateTime.Now
            };

            Assert.IsFalse(listingDB.Upload(listing, sqlConnection), "Should be false due to missing a sellerID and a description.");
        }

        [TestMethod]
        public void ListingSucceededUploadBecauseExistingCarVIN()
        {
            Listing listing = new Listing()
            {
                sellerID = 1,
                car = new BMW<string>()
                {
                    carVIN = "4JGBB5GB6BA625034"
                },
                description = "BMW car listing for Hoshi Kask.",
                creationDateTime = DateTime.Now
            };

            Assert.IsTrue(listingDB.Upload(listing, sqlConnection), "Should be true due to existing CarVIN.");
        }

        [TestMethod]
        public void ListingFailedUploadBecauseNonexistingCarVIN()
        {
            Listing listing = new Listing()
            {
                sellerID = 1,
                car = new BMW<string>()
                {
                    carVIN = "N/A"
                },
                description = "BMW car listing for Hoshi Kask",
                creationDateTime = DateTime.Now
            };

            Assert.IsFalse(listingDB.Upload(listing, sqlConnection), "Should be false due to inexistent CarVIN.");
        }

        /**********************************************/
        /******************** CAR **********************/
        /**********************************************/
        [TestMethod]
        public void GetAllCarsSucceeded()
        {
            // Check to make sure that the count of cars is correct
        }


        [TestMethod]
        public void CarSucceededUploadDueToUniqueProperties()
        {
            Car car = new BMW<string>()
            {
                carVIN = "WBABS53403EV90123",
                // userId = 1,
                make = "BMW",
                model = "2024 BMW M3",
                color = "Black",
                age = 2024,
                price = 394.45M,
                miles = 5034,
                engine = "BMW N54"
            };
        }

        [TestMethod]
        public void CarFailedUploadDueToExistingCar()
        {
            Car car = new BMW<string>()
            {
                carVIN = "WBABS53403EV90123",
                // userId = 1,
                make = "BMW",
                model = "2023 BMW M5",
                color = "Red",
                age = 2023,
                price = 5630.45M,
                miles = 2895,
                engine = "BMW OHV V8 Engine"
            };
        }
    }
}
