using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using SpecFlowProject2.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.MultiTouch;
using NUnit.Framework;

namespace SpecFlowProject2.Pages
{
    public class Outdoor : programcards// Define a class named "Outdoor" which inherits from the "programcards" class
    {
        private AppiumDriver<AndroidElement> driver;// Declare a private field named "driver" of type "AppiumDriver<AndroidElement>"

        public Outdoor(AppiumDriver<AndroidElement> driver) : base(driver)// Define a constructor which has "AppiumDriver<AndroidElement>" parameter and calls the base class constructor 
        {
            this.driver = driver;
        }
        By outdoor = By.Id("dk.resound.smart3d:id/card_title");
        By windnoise = By.XPath("(//android.view.View[@index='0'])[5]");
        By outdoor2 = By.XPath("//android.widget.ImageView[@content-desc=\"prg_outdoor_m\"]");
        public string getTitle()//validate title
        {
            return driver.FindElement(outdoor).Text;
        }
        public void movetostrong()//change windoise to strong
        {
            TouchAction touchAction = new TouchAction(driver);
            AndroidElement strong = driver.FindElement(windnoise);
            touchAction.Press(325, 1944)
                       .MoveTo(815, 1944)
                       .Release()
                       .Perform();

        }
        public void validatemovetostrong(String volume)//validate if windnoise is strong
        {
            TouchAction touchAction = new TouchAction(driver);
            AndroidElement strong = driver.FindElement(windnoise);
            touchAction.Press(815, 1944)
                       .MoveTo(820, 1944)
                       .Perform();
            string actual_value = driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup[2]/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout[4]/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.TextView")).Text;
            Assert.AreEqual(actual_value, volume);
            touchAction.Release().Perform();

        }
        public void outdoorclick(string p0)//used to click on outdoor on top ribbon
        {
            driver.FindElement(outdoor2).Click();
        }
    }
}
