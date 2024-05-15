
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using CarsAdviser;
using CarsAdviser.Forms;
using System.Globalization;
using System.Threading;
using System.Linq;
using Guna.UI2.WinForms;
using CarsAdviser.Database;

namespace Unit_Tests
{
    [TestClass]
    public class RegisterFormTests
    {
        private static AuthorizationForm authForm = new AuthorizationForm();
        private static RegisterForm regForm = new RegisterForm(authForm);
        private static MainForm mainForm = new MainForm(authForm, 1);

        [TestMethod]
        public void IsValidEmail_ValidEmail_ReturnsTrue()
        {
            Assert.IsTrue(regForm.IsValidEmail("test@mail.ru"));
        }

        [TestMethod]
        public void IsValidEmail_InvalidEmail_ReturnsFalse()
        {
            Assert.IsFalse(regForm.IsValidEmail("test@example"));
        }

        [TestMethod]
        public void IsValidPhone_ValidPhone_ReturnsTrue()
        {
            Assert.IsTrue(regForm.IsValidPhone("+79174325490"));
        }

        [TestMethod]
        public void IsValidPhone_InvalidPhone_ReturnsFalse()
        {
            Assert.IsFalse(regForm.IsValidPhone("0194292495"));
        }

        [TestMethod]
        public void IsValidPhone_InvalidPhoneWithLetter_ReturnsFalse()
        {
            Assert.IsFalse(regForm.IsValidPhone("12345678di"));
        }

        [TestMethod]
        public void GenerateRandomCode_ReturnsCorrectLength()
        {
            var changePasswordForm = new ChangePasswordForm(new AccountForm(mainForm, 1), 1);
            string code = changePasswordForm.GenerateRandomCode(5);
            Assert.AreEqual(5, code.Length);
        }

        [TestMethod]
        public void PriceTextBox_KeyPress_PreventsNonNumericCharacters()
        {
            var announcementForm = new AnnouncementForm(mainForm, 1);
            Guna2TextBox textBox = announcementForm.Controls.Find("priceFromTextBox", true).FirstOrDefault() as Guna2TextBox;
            textBox.KeyPress += new KeyPressEventHandler((sender, args) => { args.KeyChar = 'a'; });

            Assert.IsFalse(textBox.Text.Contains("a"));
        }

        [TestMethod]
        public void GetStampImageLocation_ReturnsCorrectPath()
        {
            var helper = new Helper();
            string expectedPath = "../../Images/CarsBrands/bmw_logo.png";
            string result = helper.GetStampImageLocation("BMW");
            Assert.AreEqual(expectedPath, result);
        }

        [TestMethod]
        public void Logout_ClosesMainFormAndShowsAuthorizationForm()
        {
            mainForm.Show();

            mainForm.Logout();

            Assert.IsFalse(mainForm.Visible);
            Assert.IsTrue(authForm.Visible);
        }

        [TestMethod]
        public void GetCurrentUICulture_ReturnsCorrectCulture()
        {
            CultureInfo expectedCulture = new CultureInfo("ru-RU");
            Thread.CurrentThread.CurrentUICulture = expectedCulture;

            CultureInfo result = mainForm.GetCurrentUICulture();

            Assert.AreEqual(expectedCulture, result);
        }
    }
}
