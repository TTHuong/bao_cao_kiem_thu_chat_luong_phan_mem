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
    public class DangKyTest
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }

        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void TC_DangKy_02()
        {
            driver.Navigate().GoToUrl("http://webbannon.somee.com/DangKy/Dangky");
            driver.Manage().Window.Size = new System.Drawing.Size(1103, 621);
            driver.FindElement(By.Id("yourname")).Click();
            driver.FindElement(By.Id("yourname")).SendKeys("");
            driver.FindElement(By.Id("birthday")).Click();
            driver.FindElement(By.Id("birthday")).SendKeys("25-08-1960");
            driver.FindElement(By.Id("username")).Click();
            driver.FindElement(By.Id("username")).SendKeys("test02");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys("Test@123");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("test01@gmail.com");
            driver.FindElement(By.Id("number")).Click();
            driver.FindElement(By.Id("number")).SendKeys("0918224935");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).SendKeys("Hiệp Thành");
            driver.FindElement(By.Id("sbdangky")).Click();
            IWebElement thongbao_hovaten = driver.FindElement(By.XPath("//*[@id='page-top']/div[1]/div/div/form[2]/div[2]"));
            String validationMessage = thongbao_hovaten.GetAttribute("data-validate");
            Assert.That(validationMessage, Is.EqualTo("Họ Và Tên Không Được Bỏ Trống"));
            driver.Close();
        }

        [Test]
        public void TC_DangKy_03()
        {
            driver.Navigate().GoToUrl("http://webbannon.somee.com/DangKy/Dangky");
            driver.Manage().Window.Size = new System.Drawing.Size(1103, 621);
            driver.FindElement(By.Id("yourname")).Click();
            driver.FindElement(By.Id("yourname")).SendKeys("Nguyễn Văn A");
            driver.FindElement(By.Id("birthday")).Click();
            driver.FindElement(By.Id("birthday")).SendKeys("");
            driver.FindElement(By.Id("username")).Click();
            driver.FindElement(By.Id("username")).SendKeys("test02");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys("Test@123");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("test01@gmail.com");
            driver.FindElement(By.Id("number")).Click();
            driver.FindElement(By.Id("number")).SendKeys("0918224935");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).SendKeys("Hiệp Thành");
            driver.FindElement(By.Id("sbdangky")).Click();
            IWebElement thongbao4_ngaysinh = driver.FindElement(By.XPath("//*[@id='page-top']/div[1]/div/div/form[2]/div[4]"));
            String validationMessage = thongbao4_ngaysinh.GetAttribute("data-validate");
            Assert.That(validationMessage, Is.EqualTo("Ngày Sinh Không Được Bỏ Trống"));
            driver.Close();
        }


        [Test]
        public void TC_DangKy_04()
        {
            driver.Navigate().GoToUrl("http://webbannon.somee.com/DangKy/Dangky");
            driver.Manage().Window.Size = new System.Drawing.Size(1103, 621);
            driver.FindElement(By.Id("yourname")).Click();
            driver.FindElement(By.Id("yourname")).SendKeys("Nguyễn Văn A");
            driver.FindElement(By.Id("birthday")).Click();
            driver.FindElement(By.Id("birthday")).SendKeys("25-08-1960");
            driver.FindElement(By.Id("username")).Click();
            driver.FindElement(By.Id("username")).SendKeys("");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys("Test@123");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("test01@gmail.com");
            driver.FindElement(By.Id("number")).Click();
            driver.FindElement(By.Id("number")).SendKeys("0918224935");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).SendKeys("Hiệp Thành");
            driver.FindElement(By.Id("sbdangky")).Click();
            IWebElement thongbao5 = driver.FindElement(By.XPath("//*[@id='page-top']/div[1]/div/div/form[2]/div[6]"));
            String validationMessage = thongbao5.GetAttribute("data-validate");
            Assert.That(validationMessage, Is.EqualTo("Tên Đăng Nhập Không Được Bỏ Trống"));
            driver.Close();
        }
        [Test]
        public void TC_DangKy_05()
        {
            driver.Navigate().GoToUrl("http://webbannon.somee.com/DangKy/Dangky");
            driver.Manage().Window.Size = new System.Drawing.Size(1103, 621);
            driver.FindElement(By.Id("yourname")).Click();
            driver.FindElement(By.Id("yourname")).SendKeys("Nguyễn Văn A");
            driver.FindElement(By.Id("birthday")).Click();
            driver.FindElement(By.Id("birthday")).SendKeys("25-08-1960");
            driver.FindElement(By.Id("username")).Click();
            driver.FindElement(By.Id("username")).SendKeys("test02");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys("");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("test01@gmail.com");
            driver.FindElement(By.Id("number")).Click();
            driver.FindElement(By.Id("number")).SendKeys("0918224935");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).SendKeys("Hiệp Thành");
            driver.FindElement(By.Id("sbdangky")).Click();
            IWebElement thongbao6 = driver.FindElement(By.XPath("//*[@id='page-top']/div[1]/div/div/form[2]/div[8]"));
            String validationMessage = thongbao6.GetAttribute("data-validate");
            Assert.That(validationMessage, Is.EqualTo("Mật Khẩu Không Được Bỏ Trống"));
            driver.Close();
        }
        [Test]
        public void TC_DangKy_06()
        {
            driver.Navigate().GoToUrl("http://webbannon.somee.com/DangKy/Dangky");
            driver.Manage().Window.Size = new System.Drawing.Size(1103, 621);
            driver.FindElement(By.Id("yourname")).Click();
            driver.FindElement(By.Id("yourname")).SendKeys("Nguyễn Văn A");
            driver.FindElement(By.Id("birthday")).Click();
            driver.FindElement(By.Id("birthday")).SendKeys("25-08-1960");
            driver.FindElement(By.Id("username")).Click();
            driver.FindElement(By.Id("username")).SendKeys("test02");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys("Test@123");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("");
            driver.FindElement(By.Id("number")).Click();
            driver.FindElement(By.Id("number")).SendKeys("0918224935");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).SendKeys("Hiệp Thành");
            driver.FindElement(By.Id("sbdangky")).Click();
            IWebElement thongbao7 = driver.FindElement(By.XPath("//*[@id='page-top']/div[1]/div/div/form[2]/div[10]"));
            String validationMessage = thongbao7.GetAttribute("data-validate");
            Assert.That(validationMessage, Is.EqualTo("Email Không Được Bỏ Trống"));
            driver.Close();
        }

        [Test]
        public void TC_DangKy_07()
        {
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://webbannon.somee.com/DangKy/Dangky");
            driver.Manage().Window.Size = new System.Drawing.Size(1103, 621);
            driver.FindElement(By.Id("yourname")).Click();
            driver.FindElement(By.Id("yourname")).SendKeys("Nguyễn Văn A");
            driver.FindElement(By.Id("birthday")).Click();
            driver.FindElement(By.Id("birthday")).SendKeys("25-08-1999");
            driver.FindElement(By.Id("username")).Click();
            driver.FindElement(By.Id("username")).SendKeys("test02");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys("Test@123");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("test01@gmail.com");
            driver.FindElement(By.Id("number")).Click();
            driver.FindElement(By.Id("number")).SendKeys("");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).SendKeys("Hiệp Thành");
            driver.FindElement(By.Id("sbdangky")).Click();
            IWebElement thongbao_8 = driver.FindElement(By.XPath("//*[@id='page-top']/div[1]/div/div/form[2]/div[12]"));
            String validationMessage = thongbao_8.GetAttribute("data-validate");
            Assert.That(validationMessage, Is.EqualTo("Số Điện Thoại Không Được Bỏ Trống"));
            driver.Close();
        }
        [Test]
        public void TC_DangKy_08()
        {
            driver.Navigate().GoToUrl("http://webbannon.somee.com/DangKy/Dangky");
            driver.Manage().Window.Size = new System.Drawing.Size(1103, 621);
            driver.FindElement(By.Id("yourname")).Click();
            driver.FindElement(By.Id("yourname")).SendKeys("Nguyễn Văn A");
            driver.FindElement(By.Id("birthday")).Click();
            driver.FindElement(By.Id("birthday")).SendKeys("25-08-1960");
            driver.FindElement(By.Id("username")).Click();
            driver.FindElement(By.Id("username")).SendKeys("test02");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys("Test@123");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("test01@gmail.com");
            driver.FindElement(By.Id("number")).Click();
            driver.FindElement(By.Id("number")).SendKeys("0918224935");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).SendKeys("");
            driver.FindElement(By.Id("sbdangky")).Click();
            IWebElement thongbao9 = driver.FindElement(By.XPath("//*[@id='page-top']/div[1]/div/div/form[2]/div[14]"));
            string validationmessage = thongbao9.GetAttribute("data-validate");
            Assert.That(validationmessage, Is.EqualTo("Đại Chỉ Không Được Bỏ Trống"));
            driver.Close();
        }



        [Test]
        public void TC_DangKy_09()
        {
            driver.Navigate().GoToUrl("http://webbannon.somee.com/DangKy/Dangky");
            driver.Manage().Window.Size = new System.Drawing.Size(1103, 621);
            driver.FindElement(By.Id("yourname")).Click();
            driver.FindElement(By.Id("yourname")).SendKeys("Nguyễn Văn A");
            driver.FindElement(By.Id("birthday")).Click();
            driver.FindElement(By.Id("birthday")).SendKeys("25-08-1960");
            driver.FindElement(By.Id("username")).Click();
            driver.FindElement(By.Id("username")).SendKeys("test02");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys("Test@123");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("test01@gmail.com");
            driver.FindElement(By.Id("number")).Click();
            driver.FindElement(By.Id("number")).SendKeys("0918224935");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).SendKeys("Hiệp Thành");
            driver.FindElement(By.Id("sbdangky")).Click();
            IWebElement thongbao10 = driver.FindElement(By.XPath("//*[@id='birthday']"));
            String validationMessage = thongbao10.GetAttribute("data-val-date");
            Assert.That(validationMessage, Is.EqualTo("The field NgaySinh must be a date."));
            driver.Close();
        }


        [Test]
        public void TC_DangKy_10()
        {
            driver.Navigate().GoToUrl("http://webbannon.somee.com/DangKy/Dangky");
            driver.Manage().Window.Size = new System.Drawing.Size(1103, 621);
            driver.FindElement(By.Id("yourname")).Click();
            driver.FindElement(By.Id("yourname")).SendKeys("Nguyễn Văn A");
            driver.FindElement(By.Id("birthday")).Click();
            driver.FindElement(By.Id("birthday")).SendKeys("25-08-1999");
            driver.FindElement(By.Id("username")).Click();
            driver.FindElement(By.Id("username")).SendKeys("test02");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys("test123");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("test01@gmail.com");
            driver.FindElement(By.Id("number")).Click();
            driver.FindElement(By.Id("number")).SendKeys("0918224935");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).SendKeys("Hiệp Thành");
            driver.FindElement(By.Id("sbdangky")).Click();
            IWebElement thongbao_hovaten = driver.FindElement(By.XPath("//*[@id='page-top']/div[1]/div/div/form[2]/div[8]"));
            String validationMessage = thongbao_hovaten.GetAttribute("data-validate");
            Assert.That(validationMessage, Is.EqualTo("Mật Khẩu (Mật Khẩu Không Đủ Mạnh,Mật Khẩu Phải Trên 8 Ký Tự,Có Ký 1 Tự Hoa,Thường,Số,Và Ký Tự Đặc Biệt Vd: NguyenVanA@&5674)"));
            driver.Close();
        }

        [Test]
        public void TC_DangKy_11()
        {
            driver.Navigate().GoToUrl("http://webbannon.somee.com/DangKy/Dangky");
            driver.Manage().Window.Size = new System.Drawing.Size(1103, 621);
            driver.FindElement(By.Id("yourname")).Click();
            driver.FindElement(By.Id("yourname")).SendKeys("Nguyễn Văn A");
            driver.FindElement(By.Id("birthday")).Click();
            driver.FindElement(By.Id("birthday")).SendKeys("25-08-1999");
            driver.FindElement(By.Id("username")).Click();
            driver.FindElement(By.Id("username")).SendKeys("test02");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys("test12345");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("test01@gmail.com");
            driver.FindElement(By.Id("number")).Click();
            driver.FindElement(By.Id("number")).SendKeys("0918224935");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).SendKeys("Hiệp Thành");
            driver.FindElement(By.Id("sbdangky")).Click();
            IWebElement thongbao_hovaten = driver.FindElement(By.XPath("//*[@id='page-top']/div[1]/div/div/form[2]/div[8]"));
            String validationMessage = thongbao_hovaten.GetAttribute("data-validate");
            Assert.That(validationMessage, Is.EqualTo("Mật Khẩu (Mật Khẩu Không Đủ Mạnh,Mật Khẩu Phải Trên 8 Ký Tự,Có Ký 1 Tự Hoa,Thường,Số,Và Ký Tự Đặc Biệt Vd: NguyenVanA@&5674)"));
            driver.Close();
        }

        [Test]
        public void TC_DangKy_12()
        {
            driver.Navigate().GoToUrl("http://webbannon.somee.com/DangKy/Dangky");
            driver.Manage().Window.Size = new System.Drawing.Size(1103, 621);
            driver.FindElement(By.Id("yourname")).Click();
            driver.FindElement(By.Id("yourname")).SendKeys("Nguyễn Văn A");
            driver.FindElement(By.Id("birthday")).Click();
            driver.FindElement(By.Id("birthday")).SendKeys("25-08-1999");
            driver.FindElement(By.Id("username")).Click();
            driver.FindElement(By.Id("username")).SendKeys("test02");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys("Test12345");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("test01@gmail.com");
            driver.FindElement(By.Id("number")).Click();
            driver.FindElement(By.Id("number")).SendKeys("0918224935");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).SendKeys("Hiệp Thành");
            driver.FindElement(By.Id("sbdangky")).Click();
            IWebElement thongbao_hovaten = driver.FindElement(By.XPath("//*[@id='page-top']/div[1]/div/div/form[2]/div[8]"));
            String validationMessage = thongbao_hovaten.GetAttribute("data-validate");
            Assert.That(validationMessage, Is.EqualTo("Mật Khẩu (Mật Khẩu Không Đủ Mạnh,Mật Khẩu Phải Trên 8 Ký Tự,Có Ký 1 Tự Hoa,Thường,Số,Và Ký Tự Đặc Biệt Vd: NguyenVanA@&5674)"));
            driver.Close();
        }
        [Test]
        public void TC_DangKy_13()
        {
            driver.Navigate().GoToUrl("http://webbannon.somee.com/DangKy/Dangky");
            driver.Manage().Window.Size = new System.Drawing.Size(1103, 621);
            driver.FindElement(By.Id("yourname")).Click();
            driver.FindElement(By.Id("yourname")).SendKeys("Nguyễn Văn A");
            driver.FindElement(By.Id("birthday")).Click();
            driver.FindElement(By.Id("birthday")).SendKeys("25-08-1999");
            driver.FindElement(By.Id("username")).Click();
            driver.FindElement(By.Id("username")).SendKeys("test02");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys("Test12345");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("test01@gmail.com");
            driver.FindElement(By.Id("number")).Click();
            driver.FindElement(By.Id("number")).SendKeys("0918224935");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).SendKeys("Hiệp Thành");
            driver.FindElement(By.Id("sbdangky")).Click();
            IWebElement thongbao_hovaten = driver.FindElement(By.XPath("//*[@id='page-top']/div[1]/div/div/form[2]/div[8]"));
            String validationMessage = thongbao_hovaten.GetAttribute("data-validate");
            Assert.That(validationMessage, Is.EqualTo("Mật Khẩu (Mật Khẩu Không Đủ Mạnh,Mật Khẩu Phải Trên 8 Ký Tự,Có Ký 1 Tự Hoa,Thường,Số,Và Ký Tự Đặc Biệt Vd: NguyenVanA@&5674)"));
            driver.Close();
        }
        [Test]
        public void TC_DangKy_14()
        {
            driver.Navigate().GoToUrl("http://webbannon.somee.com/DangKy/Dangky");
            driver.Manage().Window.Size = new System.Drawing.Size(1103, 621);
            driver.FindElement(By.Id("yourname")).Click();
            driver.FindElement(By.Id("yourname")).SendKeys("Nguyễn Văn A");
            driver.FindElement(By.Id("birthday")).Click();
            driver.FindElement(By.Id("birthday")).SendKeys("25-08-1999");
            driver.FindElement(By.Id("username")).Click();
            driver.FindElement(By.Id("username")).SendKeys("test02");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys("Test@123");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("test01");
            driver.FindElement(By.Id("number")).Click();
            driver.FindElement(By.Id("number")).SendKeys("0918224935");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).SendKeys("Hiệp Thành");
            driver.FindElement(By.Id("sbdangky")).Click();
            IWebElement thongbao_hovaten = driver.FindElement(By.XPath("//*[@id='email']"));
            String validationMessage = thongbao_hovaten.GetAttribute("data-validate");
            Assert.That(validationMessage, Is.EqualTo("Vui lòng bao gồm '@' trong địa chỉ email."));
            driver.Close();
        }


    }
}