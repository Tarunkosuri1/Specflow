using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.MultiTouch;
using SpecFlowProject2.Pages;

namespace SpecFlowProject2.Support
{
    public class programcards
    {
        private AppiumDriver<AndroidElement> driver;

        public programcards(AppiumDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }
        By SwipeLeft = By.XPath(" (//android.view.View[@index='0'])[2]");
        By verify = By.Id("dk.resound.smart3d:id/card_title");

        public void swipe(string p0)//for swiping program cards
        {
            
                AndroidElement screenSize = driver.FindElement(SwipeLeft);
                int screenWidth = screenSize.Size.Width;
                int screenHeight = screenSize.Size.Height;
                int endX = 0;
                int y = screenHeight / 2;
                TouchAction action = new TouchAction(driver);
                AndroidElement swipeleft = driver.FindElement(SwipeLeft);
                action.Press(screenWidth, y).MoveTo(endX, y).Release().Perform();
        }
        public void Soundenhancer(string p0)//for clicking soundenhancer
        {
            
                AndroidElement soundenhancer = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"HomeButtonLabelFineTune\"]"));
                soundenhancer.Click();
           
        }

        public void tinnitus(String p0)//for clicking tinnitus manager
        {

          
                AndroidElement tinnnitus = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\'FineTuneSwitchButtonTitleTinnitusManager\']"));
                tinnnitus.Click();
           
        }
        public void Exit(String p0)//for clicking on exit 
        {
            

                AndroidElement exit = driver.FindElement(By.XPath("//android.widget.ImageView[@content-desc=\"icon_close_m\"]"));
                 exit.Click();
        }
        public string Title()//for validating title
        {
            return driver.FindElement(verify).Text;
        }


    }
}
 

