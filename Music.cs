using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using SpecFlowProject2.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SpecFlowProject2.Pages
{
    public class Music : programcards
    {
        private AppiumDriver<AndroidElement> driver;

        public Music(AppiumDriver<AndroidElement> driver) : base(driver)
        {
            this.driver = driver;
        }
        By music = By.XPath("//android.widget.ImageView[@content-desc='prg_music_m']");

        public void musicclick(String p0)
        {
            driver.FindElement(music).Click();  
        }
    }
}