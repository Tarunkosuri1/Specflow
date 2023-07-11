using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject2.Pages
{
    public class Demo1
    {
        private AppiumDriver<AndroidElement> driver;

        public Demo1(AppiumDriver<AndroidElement> driver)
        { 
            this.driver = driver; 
        }
        By clickdemo =By.Id("dk.resound.smart3d:id/demo_button");
        
        public popuppage demomode()//clicks on take me to demo mode
        {
            driver.FindElement(clickdemo).Click();
            return new popuppage(driver);
        }
        
    }
}
