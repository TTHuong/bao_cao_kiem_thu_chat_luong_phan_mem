using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Nhom6_TestCase_Dangnhap_Muahang
{
    [TestFixture]
    public class Test_Them_sp
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;


        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "http://webbannon.somee.com/";
            verificationErrors = new StringBuilder();
            //driver.Manage().Window.Maximize();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
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

        public void Add_user(String tendn, String tenkh, String mk, String email)
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Size = new System.Drawing.Size(1207, 831);
            Thread.Sleep(4000);
            driver.FindElement(By.CssSelector(".fa-opencart")).Click();
            driver.FindElement(By.Id("TenDangNhap")).Click();
            driver.FindElement(By.Id("TenDangNhap")).SendKeys("heotranthanh");
            driver.FindElement(By.Id("MatKhau")).SendKeys("Heo@0905963271");
            driver.FindElement(By.Name("sbdangnhap")).Click();
            driver.FindElement(By.LinkText("Quản Lý Người Dùng")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.LinkText("Người Dùng")).Click();
            driver.FindElement(By.LinkText("Thêm")).Click();
            driver.FindElement(By.Id("TenDangNhap_T")).Click();

            driver.FindElement(By.Id("TenDangNhap_T")).SendKeys(tendn);
            driver.FindElement(By.Id("MatKhau_T")).Click();

            driver.FindElement(By.Id("MatKhau_T")).SendKeys(mk);
            driver.FindElement(By.Id("Email_T")).Click();
            driver.FindElement(By.Id("Email_T")).SendKeys(email);
            driver.FindElement(By.Id("TenKhachHang_T")).Click();
            driver.FindElement(By.Id("TenKhachHang_T")).SendKeys(tenkh);
            driver.FindElement(By.Id("NgaySinh_T")).Click();
   
            driver.FindElement(By.Id("NgaySinh_T")).SendKeys("1995-08-02");
            driver.FindElement(By.Id("DiaChi_T")).Click();
            driver.FindElement(By.Id("DiaChi_T")).SendKeys("eded");
            driver.FindElement(By.Id("SDT_T")).Click();
            driver.FindElement(By.Id("SDT_T")).SendKeys("0773654033");
            driver.FindElement(By.Id("QuyenHan_T")).Click();
            driver.FindElement(By.Id("QuyenHan_T")).Click();
            driver.FindElement(By.CssSelector(".btn:nth-child(6)")).Click();


        }

        [Test]
        public void TC_AddUser_01()
        {
            //add user valid
            Add_user("Nam02", "Nam Test", "Nam@0773654031", "npn01081@gmail.com");
            Assert.That(driver.FindElement(By.CssSelector(".mt-3 > .mb-2")).Text, Is.EqualTo("(LƯU THÀNH CÔNG)"));
        }

        [Test]
        public void TC_AddUser_02()
        {
            //add user tendn null
            Add_user("", "Nam Test", "Nam@0773654031", "npn010823@gmail.com");
            Assert.That(driver.FindElement(By.CssSelector(".form-row:nth-child(1) > .form-group:nth-child(1) > label")).Text, Is.EqualTo("Tên Đăng Nhập ( Tên Đăng Nhập Không Được Bỏ Trống )"));
        }

        [Test]
        public void TC_AddUser_03()
        {
            //add user pass null
            Add_user("Nam03", "Nam Test", "", "npn0108233@gmail.com");
            Assert.That(driver.FindElement(By.CssSelector(".form-row:nth-child(1) > .form-group:nth-child(2) > label")).Text, Is.EqualTo("Mật Khẩu ( Mật Khẩu Không Được Bỏ Trống )"));
        }

        [Test]
        public void TC_AddUser_04()
        {
            //add user email null
            Add_user("Nam03", "Nam Test", "Nam@0773654031", "");
            Assert.That(driver.FindElement(By.CssSelector("form > .form-group:nth-child(2) > label")).Text, Is.EqualTo("Email ( Email Không Được Bỏ Trống )"));
        }

        [Test]
        public void TC_AddUser_05()
        {
            //add tenkh null
            Add_user("Nam03", "", "Nam@0773654031", "npn0108233@gmail.com");
            Assert.That(driver.FindElement(By.CssSelector(".form-row:nth-child(3) > .form-group:nth-child(1) > label")).Text, Is.EqualTo("Ten Khách Hàng ( Tên Khách Hàng Không Được Bỏ Trống )"));
        }
    }
}
