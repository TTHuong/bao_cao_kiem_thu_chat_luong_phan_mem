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
    public class Test_TK
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
        public void TimKiem(String txt)
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Size = new System.Drawing.Size(1207, 831);
            Thread.Sleep(3000);
            driver.FindElement(By.Id("txttimkiem")).Click();
            driver.FindElement(By.Id("txttimkiem")).SendKeys(txt);
            driver.FindElement(By.Id("txttimkiem")).SendKeys(Keys.Enter);
            Thread.Sleep(3000);
            

        }
        [Test]
        public void TC_TimKiem_01()
        {
            //tk null
            TimKiem("");
            Assert.That(driver.FindElement(By.CssSelector(".properties_list > div")).Text, Is.EqualTo("Số Kết Quả Cho Tìm Kiếm \" \" Là 4"));
        }

        [Test]
        public void TC_TimKiem_02()
        {
            //tk sp nam
            TimKiem("nam");
            Assert.That(driver.FindElement(By.CssSelector(".properties_list > div")).Text, Is.EqualTo("Số Kết Quả Cho Tìm Kiếm \" nam \" Là 2"));
        }

        [Test]
        public void TC_TimKiem_03()
        {
            //tk sp nữ
            TimKiem("nữ");
            Assert.That(driver.FindElement(By.CssSelector(".properties_list > div")).Text, Is.EqualTo("Số Kết Quả Cho Tìm Kiếm \" nữ \" Là"));
        }

        [Test]
        public void TC_TimKiem_04()
        {
            //tk tiền
            TimKiem("11000000");
            Assert.That(driver.FindElement(By.CssSelector(".properties_list > div")).Text, Is.EqualTo("Số Kết Quả Cho Tìm Kiếm \" 11000000 \" Là"));
        }

        [Test]
        public void TC_TimKiem_05()
        {
            //tk loại
            TimKiem("Puma");
            Assert.That(driver.FindElement(By.CssSelector(".properties_list > div")).Text, Is.EqualTo("Số Kết Quả Cho Tìm Kiếm \" Puma \" Là 1"));
        }


    }
}
