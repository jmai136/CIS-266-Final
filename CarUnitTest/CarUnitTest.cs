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
                lastName = "Kask"
            };

            Assert.IsFalse(userDB.Upload(user, Program.sqlConnection), "Should be false due to already existing user regardless of user's name");
        }

        public void UserFailedRegistrationBecauseShareSameEmailAndPassword()
        {
            // Make sure to already have this in the database.
            User user = new User()
            {
                email = "zzm4h94sr1a@icznn.com",
                password = "u3AeOX ^ 686 & h",
                firstName = "Narric",
                lastName = "Maric"
            };

            Assert.IsFalse(userDB.Upload(user, Program.sqlConnection), "Should be false due to not being able to register with the same email and password for two different users");
        }

        [TestMethod]
        public void UserFailedRegistrationBecauseOfNullOrEmptyUserProperties()
        {
            // Make sure to already have this in the database.
            User user = new User();

            Assert.IsFalse(userDB.Upload(user, Program.sqlConnection), "Should be false due to null or empty user properties");
        }

        [TestMethod]
        public void UserFailedRegistrationBecauseIncorrectArgumentType()
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4, 5};

            Assert.IsFalse(userDB.Upload(arr, Program.sqlConnection), "Should be false due to not being of type User");
        }

        /*******************************************
         ************** USER LOGIN *******************
         *******************************************/
    }
}
