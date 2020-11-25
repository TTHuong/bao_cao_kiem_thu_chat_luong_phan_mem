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
using System.Windows.Forms;

namespace Nhom6_TestCase_Dangnhap_Muahang
{
    [TestFixture]
    public class Test
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
                //driver.Quit();
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
            string tendangnhap = "heotranthanh";
            string matkhau = "Heo@0905963271";
            driver.FindElement(By.Id("TenDangNhap")).SendKeys(tendangnhap);
            driver.FindElement(By.Id("MatKhau")).SendKeys(matkhau);
            driver.FindElement(By.XPath("//*[@id='page-top']/div[1]/div/div/form/div[5]/button")).Click();
        }

        [Test]
        public void TC_Muahang_01()
        {
            Muahang();
            driver.Navigate().GoToUrl("http://webbannon.somee.com/Admin_QLACT/QuanLyAnhChiTiet_Them");
            string filePath = @"‪C:\Users\Admin\Desktop\maxresdefault.jpg";

            IJavaScriptExecutor jsx = (IJavaScriptExecutor)driver;
            jsx.ExecuteScript("document.getElementById('AnhChiTiet').value='" + filePath + "';");


            //SendKeys.SendWait(filePath);
            //SendKeys.SendWait(@"{Enter}");

            //driver.FindElement(By.XPath("//button[@type='button']")).Click();

            //driver.FindElement(By.XPath("//*[@id='content-wrapper']/div/div/div/div/form/button")).Click();
            //Assert.That(driver.FindElement(By.XPath("//*[@id='page-top']/h1")).Text, Is.EqualTo("Thanh Toán Thành Công"));
        }
    }
}
