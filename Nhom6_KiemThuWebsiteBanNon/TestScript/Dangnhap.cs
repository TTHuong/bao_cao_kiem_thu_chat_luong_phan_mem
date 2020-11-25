using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Windows;

namespace Nhom6_TestCase_Dangnhap_Muahang
{
    [TestFixture]
    public class Dangnhap
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "http://webbannon.somee.com/DangNhap/DangNhap";
            verificationErrors = new StringBuilder();
            //driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        public void Login(String tendangnhap, String matkhau)
        {
            driver.Navigate().GoToUrl(baseURL);
            //driver.Manage().Window.Size = new System.Drawing.Size(1207, 831);
            Thread.Sleep(3000);
            driver.FindElement(By.Id("TenDangNhap")).SendKeys(tendangnhap);
            driver.FindElement(By.Id("MatKhau")).SendKeys(matkhau);
            driver.FindElement(By.XPath("//*[@id='page-top']/div[1]/div/div/form/div[5]/button")).Click();
        }

        [Test]
        public void TC_Login_01()
        {
            Login("heotranthanh", "Heo@0905963271");
            Assert.That(driver.FindElement(By.XPath("//*[@id='page-top']/div[1]/div/div/form/span")).Text, Is.EqualTo("Đăng nhập thành công"));
        }

        [Test]
        public void TC_Login_02()
        {
            Login("", "Heo@0905963271");
            IWebElement thongbao_tendangnhap = driver.FindElement(By.XPath("//*[@id='page-top']/div[1]/div/div/form/div[2]"));
            String validationMessage = thongbao_tendangnhap.GetAttribute("data-validate");
            Assert.That(validationMessage, Is.EqualTo("Tên Đăng Nhập Không Được Bỏ Trống !"));
        }

        [Test]
        public void TC_Login_03()
        {
            Login("heotranthanh", "");
            IWebElement thongbao_matkhau = driver.FindElement(By.XPath("//*[@id='page-top']/div[1]/div/div/form/div[4]"));
            String validationMessage = thongbao_matkhau.GetAttribute("data-validate");
            Assert.That(validationMessage, Is.EqualTo("Mật Khẩu Không Được Bỏ Trống !"));
        }

        [Test]
        public void TC_Login_04()
        {
            Login("heotranthanh1", "Heo@049583473673");
            String validationMessage = driver.FindElement(By.XPath("//*[@id='page-top']/div[1]/div/div/form/span")).Text;
            Assert.That(validationMessage, Is.EqualTo("ĐĂNG NHẬP (TÀI KHOẢN KHÔNG TỒN TẠI)"));
        }

        [Test]
        public void TC_Login_05()
        {
            Login("heotranthanh", "Heo@049583473673");
            String validationMessage = driver.FindElement(By.XPath("//*[@id='page-top']/div[1]/div/div/form/span")).Text;
            Assert.That(validationMessage, Is.EqualTo("ĐĂNG NHẬP (TÀI KHOẢN VÀ MẬT KHẨU KHÔNG ĐÚNG)"));
        }

        [Test]
        public void TC_Login_06()
        {
            Login("heotranthanh", "Heo@0");
            String validationMessage = driver.FindElement(By.XPath("//*[@id='page-top']/div[1]/div/div/form/span")).Text;
            Assert.That(validationMessage, Is.EqualTo("ĐĂNG NHẬP ( MẬT KHẨU CÓ ÍT NHẤT 8 KÝ TỰ, VÀ CÓ KÝ TỰ HOA,THƯỜNG,SỐ ĐẶC BIỆT )"));
        }

        [Test]
        public void TC_Login_07()
        {
            Login("heotranthanh", "heo@0905963271");
            String validationMessage = driver.FindElement(By.XPath("//*[@id='page-top']/div[1]/div/div/form/span")).Text;
            Assert.That(validationMessage, Is.EqualTo("ĐĂNG NHẬP ( MẬT KHẨU CÓ ÍT NHẤT 8 KÝ TỰ, VÀ CÓ KÝ TỰ HOA,THƯỜNG,SỐ ĐẶC BIỆT )"));
        }

        [Test]
        public void TC_Login_08()
        {
            Login("heotranthanh", "HEO@0905963271");
            String validationMessage = driver.FindElement(By.XPath("//*[@id='page-top']/div[1]/div/div/form/span")).Text;
            Assert.That(validationMessage, Is.EqualTo("ĐĂNG NHẬP ( MẬT KHẨU CÓ ÍT NHẤT 8 KÝ TỰ, VÀ CÓ KÝ TỰ HOA,THƯỜNG,SỐ ĐẶC BIỆT )"));
        }

        [Test]
        public void TC_Login_09()
        {
            Login("heotranthanh", "Heo@hhhhhhh");
            String validationMessage = driver.FindElement(By.XPath("//*[@id='page-top']/div[1]/div/div/form/span")).Text;
            Assert.That(validationMessage, Is.EqualTo("ĐĂNG NHẬP ( MẬT KHẨU CÓ ÍT NHẤT 8 KÝ TỰ, VÀ CÓ KÝ TỰ HOA,THƯỜNG,SỐ ĐẶC BIỆT )"));
        }

        [Test]
        public void TC_Login_10()
        {
            Login("heotranthanh", "Heo0905963271");
            String validationMessage = driver.FindElement(By.XPath("//*[@id='page-top']/div[1]/div/div/form/span")).Text;
            Assert.That(validationMessage, Is.EqualTo("ĐĂNG NHẬP ( MẬT KHẨU CÓ ÍT NHẤT 8 KÝ TỰ, VÀ CÓ KÝ TỰ HOA,THƯỜNG,SỐ ĐẶC BIỆT )"));
        }

        [Test]
        public void TC_Login_11()
        {
            Login("heotranthanh", "Heo@09059632711111");
            String validationMessage = driver.FindElement(By.XPath("//*[@id='page-top']/div[1]/div/div/form/span")).Text;
            Assert.That(validationMessage, Is.EqualTo("ĐĂNG NHẬP (TÀI KHOẢN VÀ MẬT KHẨU KHÔNG ĐÚNG)"));
        }

        [Test]
        public void TC_Login_12()
        {
            Login("heotranthanh1", "Heo@0905963271");
            String validationMessage = driver.FindElement(By.XPath("//*[@id='page-top']/div[1]/div/div/form/span")).Text;
            Assert.That(validationMessage, Is.EqualTo("ĐĂNG NHẬP (TÀI KHOẢN VÀ MẬT KHẨU KHÔNG ĐÚNG)"));
        }

        [Test]
        public void TC_Login_13()
        {
            Login("heotranthanh+", "Heo@0905963271");
            String validationMessage = driver.FindElement(By.XPath("//*[@id='page-top']/div[1]/div/div/form/span")).Text;
            Assert.That(validationMessage, Is.EqualTo("ĐĂNG NHẬP (TÀI KHOẢN VÀ MẬT KHẨU KHÔNG ĐÚNG)"));
        }
    }
}
