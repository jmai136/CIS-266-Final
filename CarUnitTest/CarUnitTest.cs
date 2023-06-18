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
                email = "wosita5469@aaorsi.com",
                password = "z85ArZ0R@80#",
                firstName = "Zachariah",
                lastName = "Nasato"
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
                email = "zzm4h94sr1a@icznn.com",
                password = "u3AeOX ^ 686 & h",
                firstName = NameGenerator.GetGeneratedName(),
                lastName = NameGenerator.GetGeneratedName()
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
    }
}
