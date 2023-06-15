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

        /*******************************************
         ************** USER REGISTRATION ************
         *******************************************/
        [TestMethod]
        public void UserSuccessfulRegistrationWithUniqueProperties()
        {
            User user = new User() {
                email = "wosita5469@aaorsi.com",
                password = "z85ArZ0R@80#",
                firstName = "Zachariah",
                lastName = "Nasato"
            };

            Assert.IsTrue(userDB.Upload(user, Program.sqlConnection), "Should be true due to non-existent user and correct types");
        }

        [TestMethod]
        public void UserFailedRegistrationBecauseOfAlreadyExistingUser()
        {
            // Make sure to already have this in the database.
            User user = new User()
            {
                email = "zzm4h94sr1a@icznn.com",
                password = "u3AeOX ^ 686 & h",
                firstName = "Hoshi",
                lastName = "Kash"
            };

            Assert.IsFalse(userDB.Upload(user, Program.sqlConnection), "Should be false due to already existing user regardless of user's name");
        }

        [TestMethod]
        public void UserFailedRegistrationBecauseOfNullOrEmptyUserProperties()
        {
            // Make sure to already have this in the database.
            User user = new User();

            Assert.IsFalse(userDB.Upload(user, Program.sqlConnection), "Should be false due to null or empty user properties");
        }

        /*******************************************
         ************** USER LOGIN *******************
         *******************************************/
    }
}
