using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SpecFlowProject2.Pages
{
    public class popuppage
    {
        private AppiumDriver<AndroidElement> driver;

        public popuppage(AppiumDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }
        By yes = By.ClassName("android.view.ViewGroup");
        By ok = By.ClassName("android.widget.TextView");

        public void popup()//used to handle popups
        {
            if (driver.FindElementByClassName("android.view.ViewGroup").Displayed)
            {
                driver.FindElement(yes).Click();
            }
            else
            {
                driver.FindElement(ok).Click();
            }
            AndroidElement yess = driver.FindElement(By.ClassName("android.view.ViewGroup"));
            yess.Click();
        }
    }
}
