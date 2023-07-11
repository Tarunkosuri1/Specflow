using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SpecFlowProject2.Support;

namespace SpecFlowProject2.Pages
{
    public class Hearinnoise : programcards
    {
        private AppiumDriver<AndroidElement> driver;

        public Hearinnoise(AppiumDriver<AndroidElement> driver) : base(driver) 
        {
            this.driver = driver;
        }
        By noise = By.Id("dk.resound.smart3d:id/card_title");
        By slightvariation = By.XPath("//android.widget.Button[@content-desc=\"TsgWhiteNoiseVariationsSlight\"]");
        By reset = By.XPath("//android.widget.TextView[@content-desc=\"FineTuneButtonReset\"]");
        By hearinnoise = By.XPath("//android.widget.ImageView[@content-desc=\'prg_hearinnoise_m\']");
        public string getTitle()//validate title
        {
            return driver.FindElement(noise).Text;
        }
        public void whitenoise(String p0)//click on slightvariation
        {
            AndroidElement Slightvariation= driver.FindElement(slightvariation);
            Slightvariation.Click();
        }
        public void Reset(String p0)//click on reset
        {

            AndroidElement RESET = driver.FindElement(reset);
            RESET.Click();
        }
        public void hearinnoiseclick(string p0)//click on hearinnoise on top ribbon
        {
            driver.FindElement(hearinnoise).Click();
        }
    }
}
