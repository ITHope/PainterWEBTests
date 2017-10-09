using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Safari;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace PainterWEBTests
{

    [TestFixture]
    public class SeleniumTests
    {
        //[TestFixture]
        //public class UnitTestSafari : UnitTest1
        //{
        //    internal override IWebDriver MakeDriver()
        //    {
        //        return new SafariDriver();
        //    }
        //}
        [TestFixture]
        public class UnitTestChrome : UnitTest1
        {
            internal override IWebDriver MakeDriver()
            {
                return new ChromeDriver();
            }
        }
        //[TestFixture]
        //public class UnitTestOpera : UnitTest1
        //{
        //    internal override IWebDriver MakeDriver()
        //    {
        //        OperaOptions srv = new OperaOptions();
        //        srv.BinaryLocation = @"C:\Program Files\Opera\launcher.exe";
        //        return new OperaDriver();
        //    }
        //}
        //[TestFixture]
        //public class UnitTestFirefox : UnitTest1
        //{
        //    internal override IWebDriver MakeDriver()
        //    {
        //        FirefoxOptions options = new FirefoxOptions();
        //        FirefoxProfile firefoxProfile = new FirefoxProfile();
        //        firefoxProfile.AcceptUntrustedCertificates = true;
        //        firefoxProfile.AssumeUntrustedCertificateIssuer = false;
        //        options.BrowserExecutableLocation = "C:/Program Files/Mozilla Firefox/firefox.exe";
        //        return new FirefoxDriver();
        //    }
        //}

        //[TestFixture]
        //public class UnitTestPhantomJS : UnitTest1
        //{
        //    internal override IWebDriver MakeDriver()
        //    {
        //        return new PhantomJSDriver();
        //    }
        //}



        [TestFixture]
        public abstract class UnitTest1
        {
            internal abstract IWebDriver MakeDriver();

            //public static IWebDriver driver;

            public UnitTest1()
            {
                driver = MakeDriver();
                obj = new POM(driver);
                driver.Navigate().GoToUrl(@"E:\CSharpDev\2017.10.09\Painter WEB\index.html");

            }

            public IWebDriver driver;
            POM obj;

            [OneTimeSetUp]
            public static void ClassSetUp()
            {
                //Chrome
                //driver = new ChromeDriver();

                //Opera
                //OperaOptions srv = new OperaOptions();
                //srv.BinaryLocation = @"C:\Program Files\Opera\launcher.exe";
                //driver = new OperaDriver(srv);

                //Firefox
                //FirefoxOptions options = new FirefoxOptions();
                //FirefoxProfile firefoxProfile = new FirefoxProfile();
                //firefoxProfile.AcceptUntrustedCertificates = true;
                //firefoxProfile.AssumeUntrustedCertificateIssuer = false;
                //options.BrowserExecutableLocation = "C:/Program Files/Mozilla Firefox/firefox.exe";
                //driver = new FirefoxDriver();

                //PhantomJS
                //driver = new PhantomJSDriver();

                //InternetExplorer
                //driver = new InternetExplorerDriver();

                //Safari
                //driver = new SafariDriver();


                //driver.Navigate().GoToUrl("");
            }

            [OneTimeTearDown]
            public void ClassTearDown()
            {
                driver.Quit();
            }

            [SetUp]
            public void SetUp()
            {
                driver.Navigate().Refresh();
            }

            [TestCase("newTabToolbarItem", "New")]
            [TestCase("openNewTabToolbarItem", "Open")]
            [TestCase("saveToolbarItem", "Save")]
            [TestCase("openCloudToolbarItem", "Load from cloud")]
            [TestCase("saveCloudToolbarItem", "Save in cloud")]
            [TestCase("paintTypeToolbarItem", "Paint Type")]
            [TestCase("lineWidthToolbarItem", "Line width")]
            [TestCase("colorToolbarItem", "Paint color")]
            [TestCase("colorToolboxItem", "Color")]
            public void TestGetAllElem(string id, string exp)
            {
                string res = driver.FindElement(By.Id(id)).GetAttribute("value");
                Assert.AreEqual(exp, res);
            }


            [TestCase("fileMenuItem", "File")]
            [TestCase("viewMenuItem", "View")]
            [TestCase("pluginsMenuItem", "Plugins")]
            [TestCase("tabsMenuItem", "Tabs")]
            [TestCase("propertiesMenuItem", "Properties")]
            [TestCase("preferencesMenuItem", "Preferences")]
            [TestCase("helpMenuItem", "Help")]
            public void TestGetMenuElem(string id, string exp)
            {
                string res = driver.FindElement(By.Id(id)).GetAttribute("name");
                Assert.AreEqual(exp, res);
            }

            [TestCase("newTabMenuItem", "New tab")]
            [TestCase("openNewTabMenuItem", "Open")]
            [TestCase("saveMenuItem", "Save")]
            [TestCase("saveAsMenuItem", "Save as...")]
            [TestCase("closeTabMenuItem", "Close tab")]
            [TestCase("renameTabMenuItem", "Rename tab")]
            [TestCase("openCloudMenuItem", "Open from cloud")]
            public void TestGetMenuFileElem(string id, string exp)
            {
                driver.FindElement(By.Id(id)).Click();
                string res = driver.FindElement(By.Id(id)).GetAttribute("name");
                Assert.AreEqual(exp, res);
            }

            //[TestCase("newTabMenuItem", "New tab")]
            //[TestCase("openNewTabMenuItem", "Open")]
            //[TestCase("saveMenuItem", "Save")]
            //[TestCase("saveAsMenuItem", "Save as...")]
            //[TestCase("closeTabMenuItem", "Close tab")]
            //[TestCase("renameTabMenuItem", "Rename tab")]
            //[TestCase("openCloudMenuItem", "Open from cloud")]
            //public void TestGetMenuFileClick(string id, string exp)
            //{
            //    driver.FindElement(By.Id("File")).Click();
            //    driver.FindElement(By.Id(id)).Click();
            //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
            //    IWebElement myDynamicElement = wait.Until(ExpectedConditions.AlertIsPresent());
            //}

        }
    }
}
