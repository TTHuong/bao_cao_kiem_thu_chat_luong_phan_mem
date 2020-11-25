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
    public class MuaHang
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
        public void Muahang()
        {
            driver.Navigate().GoToUrl(baseURL);
            //driver.Manage().Window.Size = new System.Drawing.Size(1207, 831);
            Thread.Sleep(3000);
            string tendangnhap = "test01";
            string matkhau = "Test@123";
            driver.FindElement(By.Id("TenDangNhap")).SendKeys(tendangnhap);
            driver.FindElement(By.Id("MatKhau")).SendKeys(matkhau);
            driver.FindElement(By.XPath("//*[@id='page-top']/div[1]/div/div/form/div[5]/button")).Click();
        }

        [Test]
        public void TC_Muahang_01()
        {
            Muahang();
            driver.FindElement(By.XPath("//*[@id='page-top']/section/div/ul/li[1]/div/form/input")).Click();
            driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[6]/a")).Click();
            driver.FindElement(By.XPath("//*[@id='page-top']/div[1]/a/button")).Click();
            Assert.That(driver.FindElement(By.XPath("//*[@id='page-top']/h1")).Text, Is.EqualTo("Thanh Toán Thành Công"));
        }

        [Test]
        public void TC_Muahang_02()
        {
            Muahang();
            driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[6]/a")).Click();

            Assert.That(driver.FindElement(By.XPath("//*[@id='page-top']/h1")).Text, Is.EqualTo("Giỏ hàng rỗng"));
        }
    }
}
