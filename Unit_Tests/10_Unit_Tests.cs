
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using CarsAdviser;
using CarsAdviser.Forms;
using System.Globalization;
using System.Threading;

namespace Unit_Tests
{
    [TestClass]
    public class RegisterFormTests
    {
        [TestMethod]
        public void IsValidEmail_ValidEmail_ReturnsTrue()
        {
            var registerForm = new RegisterForm(null);
            Assert.IsTrue(registerForm.IsValidEmail("test@example.com"));
        }

        [TestMethod]
        public void IsValidEmail_InvalidEmail_ReturnsFalse()
        {
            var registerForm = new RegisterForm(null);
            Assert.IsFalse(registerForm.IsValidEmail("test@example"));
        }

        [TestMethod]
        public void IsValidPhone_ValidPhone_ReturnsTrue()
        {
            var registerForm = new RegisterForm(null);
            Assert.IsTrue(registerForm.IsValidPhone("+71234567890"));
        }

        [TestMethod]
        public void IsValidPhone_InvalidPhone_ReturnsFalse()
        {
            var registerForm = new RegisterForm(null);
            Assert.IsFalse(registerForm.IsValidPhone("1234567890"));
        }

        [TestMethod]
        public void IsValidPhone_InvalidPhoneWithLetter_ReturnsFalse()
        {
            var registerForm = new RegisterForm(null);
            Assert.IsFalse(registerForm.IsValidPhone("12345678di"));
        }

        [TestMethod]
        public void GenerateRandomCode_ReturnsCorrectLength()
        {
            var changePasswordForm = new ChangePasswordForm(null, 1);
            string code = changePasswordForm.GenerateRandomCode(5);
            Assert.AreEqual(5, code.Length);
        }


        [TestMethod]
        public void PriceTextBox_KeyPress_PreventsNonNumericCharacters()
        {
            var mockForm = new Mock<AnnouncementForm>();
            var keyPressEventArgs = new KeyPressEventArgs((char)Keys.A);
            mockForm.Object.priceTextBox_KeyPress(null, keyPressEventArgs);
            Assert.IsTrue(keyPressEventArgs.Handled);
        }

        [TestMethod]
        public void GetStampImageLocation_ReturnsCorrectPath()
        {
            var mockForm = new Mock<AnnouncementForm>();
            string expectedPath = "path/to/image.png";
            string result = mockForm.Object.GetStampImageLocation("BrandName");
            Assert.AreEqual(expectedPath, result);
        }

        
        [TestMethod]
        public void Logout_ClosesMainFormAndShowsAuthorizationForm()
        {
            // Arrange
            var authorizationForm = new AuthorizationForm();
            var mainForm = new MainForm(authorizationForm, 1);
            mainForm.Show();

            // Act
            mainForm.Logout();

            // Assert
            Assert.IsFalse(mainForm.Visible);
            Assert.IsTrue(authorizationForm.Visible);
        }

        [TestMethod]
        public void GetCurrentUICulture_ReturnsCorrectCulture()
        {
            // Arrange
            var mainForm = new MainForm(null, 1);
            CultureInfo expectedCulture = new CultureInfo("ru-RU");
            Thread.CurrentThread.CurrentUICulture = expectedCulture;

            // Act
            CultureInfo result = mainForm.GetCurrentUICulture();

            // Assert
            Assert.AreEqual(expectedCulture, result);
        }
    }
}
