using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.PhantomJS;
using System;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Safari;

namespace PainterWEBTests
{
    public class POM
    {
        public string newTabMenuItem = "newTab";
        public string openNewTabMenuItem = "openNewTabMenuItem";
        public string saveMenuItem = "saveMenuItem";
        public string saveAsMenuItem = "saveAsMenuItem";
        public string closeTabMenuItem = "closeTabMenuItem";
        public string renameTabMenuItem = "renameTabMenuItem";
        public string openCloudMenuItem = "openCloudMenuItem";
        public string saveCloudMenuItem = "saveCloudMenuItem";
        public string exitMenuItem = "exitMenuItem";
        public string showElementsMenuItem = "showElementsMenuItem";
        public string showPropertiesMenuItem = "showPropertiesMenuItem";
        public string showAboutMenuItem = "showAboutMenuItem";
        public string newTabToolbarItem = "newTabToolbarItem";
        public string openNewTabToolbarItem = "openNewTabToolbarItem";
        public string saveToolbarItem = "saveToolbarItem";
        public string openCloudToolbarItem = "openCloudToolbarItem";
        public string saveCloudToolbarItem = "saveCloudToolbarItem";
        public string paintTypeToolbarItem = "paintTypeToolbarItem";
        public string lineWidthToolbarItem = "lineWidthToolbarItem";
        public string colorToolbarItem = "colorToolbarItem";
        public string colorToolboxBtn = "colorToolboxBtn";
       

        IWebDriver driver;
        public POM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public POM()
        {

        }


        //public IWebElement GetButton(string id)
        //{
        //    IWebElement flag = null;
        //    if (id == nameof(btn1))
        //        flag = driver.FindElement(By.Id(btn1));
        //    else if (id == nameof(btn2))
        //        flag = driver.FindElement(By.Id(btn2));
        //    else if (id == nameof(btn3))
        //        flag = driver.FindElement(By.Id(btn3));
        //    else if (id == nameof(btn4))
        //        flag = driver.FindElement(By.Id(btn4));
        //    else if (id == nameof(btn5))
        //        flag = driver.FindElement(By.Id(btn5));
        //    else if (id == nameof(btn6))
        //        flag = driver.FindElement(By.Id(btn6));
        //    else if (id == nameof(btn7))
        //        flag = driver.FindElement(By.Id(btn7));
        //    else if (id == nameof(btn8))
        //        flag = driver.FindElement(By.Id(btn8));
        //    else if (id == nameof(btn9))
        //        flag = driver.FindElement(By.Id(btn9));
        //    else if (id == nameof(btn0))
        //        flag = driver.FindElement(By.Id(btn0));
        //    else if (id == nameof(btnMinus))
        //        flag = driver.FindElement(By.Id(btnMinus));
        //    else if (id == nameof(btnPlus))
        //        flag = driver.FindElement(By.Id(btnPlus));
        //    else if (id == nameof(btnDiv))
        //        flag = driver.FindElement(By.Id(btnDiv));
        //    else if (id == nameof(btnRes))
        //        flag = driver.FindElement(By.Id(btnRes));
        //    else if (id == nameof(btnMult))
        //        flag = flag = driver.FindElement(By.Id(btnMult));
        //    else if (id == nameof(tbCalc))
        //        flag = flag = driver.FindElement(By.Id(tbCalc));
        //    return flag;
        //}

        //public IWebElement GetTextBox(string s)
        //{
        //    IWebElement flag = null;
        //    if (s == nameof(tbCalc))
        //        flag = driver.FindElement(By.Id(tbCalc));
        //    return flag;
        //}
    }
}
