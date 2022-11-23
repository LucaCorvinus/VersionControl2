using NUnit.Framework;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample.Controllers;

namespace UnitTestExample.Test
{
    public class AccountControllerTestFixture
    {
        [
         Test,
         TestCase("abcd1234", false),
         TestCase("irf@uni-corvinus", false),
         TestCase("irf.uni-corvinus.hu", false),
         TestCase("irf@uni-corvinus.hu", true)
        ]
        public void TestValidateEmail(string email, bool expectedResult)
        {
            // Arrange
            var accountController = new AccountController();

            // Act
            var actualResult = accountController.ValidateEmail(email);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [
         Test,
         TestCase("Password", false),
         TestCase("PASSWORD1", false),
         TestCase("password1", false),
         TestCase("Passwo1", false),
         TestCase("Password1", true)
        ]
        public void TestValidatePassword(string password, bool expectedResult)
        {
            // Arrange
            var accountController = new AccountController();

            // Act
            var actualResult = accountController.ValidatePassword(password);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [
         Test,
         TestCase("proba@uni-corvinus.hu", "Password1"),
         TestCase("proba@uni-corvinus.hu", "Password1234"),
        ]
        public void TestRegisterHappyPath(string email, string password)
        {
            // Arrange
            var accountController = new AccountController();

            // Act
            var actualResult = accountController.Register(email, password);

            // Assert
            Assert.AreEqual(email, actualResult.Email);
            Assert.AreEqual(password, actualResult.Password);
            Assert.AreNotEqual(Guid.Empty, actualResult.ID);
        }

        [
         Test,
         TestCase("proba@uni-corvinus", "Password1"),
         TestCase("proba.uni-corvinus.hu", "Password1"),
         TestCase("proba@uni-corvinus.hu", "password1"),
         TestCase("proba@uni-corvinus.hu", "PASSWORD1"),
         TestCase("proba@uni-corvinus.hu", "Password"),
         TestCase("proba@uni-corvinus.hu", "Passwo1"),
        ]
        public void TestRegisterValidateException(string email, string password)
        {
            // Arrange
            var accountController = new AccountController();

            // Act
            try
            {
                var actualResult = accountController.Register(email, password);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOf<ValidationException>(ex);
            }

            // Assert
            //ez most nincs kifejtve, összemosódik az előzővel
        }
    }
}
