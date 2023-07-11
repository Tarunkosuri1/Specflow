
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using OpenQA.Selenium.Appium.MultiTouch;
using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium.Appium.Interfaces;
using System.Drawing;
using SpecFlowProject2.Support;

namespace SpecFlowProject2.Pages
{
    public class AllRound : programcards

    {
        private AppiumDriver<AndroidElement> driver;

        public AllRound(AppiumDriver<AndroidElement> driver) : base(driver)
        {
            this.driver = driver;
        }
        By verify = By.Id("dk.resound.smart3d:id/card_title");
        By split = By.Id("dk.resound.smart3d:id/SplitImageView_bottom");
        By slide1 = By.XPath("(//android.widget.ImageView[@index='2'])[2]");
        By slide2 = By.XPath("(//android.view.ViewGroup[@index = '1'])[4]");
        By merge = By.XPath("//android.widget.ImageView[@content-desc=\"icon_split1_s\"]");
        By slider = By.Id("dk.resound.smart3d:id/seekBar_bottom");
        By speechclarity = By.XPath("//android.widget.TextView[@content-desc='SmartButtonAllAroundSpeechClarity']");
        By noisefilter = By.XPath("//android.widget.TextView[@content-desc=\'SmartButtonAllAroundNoiseFilter\']");
        By bass = By.XPath("(//android.view.View[@index='0'])[1]");
        By Middlegain = By.XPath("(//android.view.View[@index=0])[2]");
        By Treblegain = By.XPath("(//android.view.View[@index=0])[3]");
        By calmingwaves = By.XPath("//android.widget.Button[@content-desc=\"TsgNatureSoundsCalmingWaves\"]");
        By breakingwaves = By.XPath("//android.widget.Button[@content-desc=\"TsgNatureSoundsBreakingWaves\"]");
        By allaround = By.XPath("//android.widget.ImageView[@content-desc=\"prg_allaround_m\"]");

        public string GetTitle()
        {
            return driver.FindElement(verify).Text;
        }
        public void clicksplit()
        {
            
            driver.FindElement(split).Click();
        }

        public void slider1(string value)
        {

             Actions actions = new Actions(driver);
             AndroidElement upperslide1 = driver.FindElement(slide1);
             actions.ClickAndHold(upperslide1).MoveByOffset(2, 0).Perform();
             string act_value = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc='VolumeChanging']")).Text;
             Assert.AreEqual(act_value, value);
             actions.Release().Perform();
           
        }
        public void slider2(string values)
        {
            Actions actions = new Actions(driver);
            AndroidElement downslide2 = driver.FindElement(slide2);
            actions.ClickAndHold(downslide2).Perform();
            actions.MoveByOffset(1, 0).Perform();
            string actual_value = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc='VolumeChanging']")).Text;
            Assert.AreEqual(actual_value, values);
            actions.Release().Perform();
        }

        public void moveto3(string volume)
        {
            Actions action = new Actions(driver);
            AndroidElement slide3 = driver.FindElement(slide1);
            action.ClickAndHold(slide3).Perform();
            action.MoveByOffset(-325, 0).Release().Perform();
        }
        public void moveto10(String volume)
        {
            Actions action = new Actions(driver);
            AndroidElement slide4 = driver.FindElement(slide2);
            action.ClickAndHold(slide4).Perform();
            action.MoveByOffset(83, 0).Release().Perform();
        }

        public void validate3(string volume)
        {
            Actions action = new Actions(driver);
            AndroidElement slide3 = driver.FindElement(slide1);
            action.ClickAndHold(slide3).Perform();
            action.MoveByOffset(1, 0).Perform();
            string act_value = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc='VolumeChanging']")).Text;
            Assert.AreEqual(act_value, volume);
            action.Release().Perform();
        }
        public void validate10(String volume)
        {
            Actions action = new Actions(driver);
            AndroidElement slide4 = driver.FindElement(slide2);
            action.ClickAndHold(slide4).Perform();
            action.MoveByOffset(1, 0).Perform();
            string actual_value = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"VolumeChanging\"]")).Text;
            Assert.AreEqual(actual_value, volume);
            action.Release().Perform();
        }
        public void merg()
        {
            driver.FindElement(merge).Click();
        }
        public void validatehi(string volume)
        {
            Actions action = new Actions(driver);
            AndroidElement slide = driver.FindElement(slider);
            action.ClickAndHold(slide).Perform();
            action.MoveByOffset(1, 0).Perform();
            string actual_value = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"VolumeChanging\"]")).Text;
            Assert.AreEqual(actual_value, volume);
            action.Release().Perform();
        }
        public void volume13(String volume)
        {
            Actions action = new Actions(driver);
            AndroidElement slide = driver.FindElement(slider);
            action.ClickAndHold(slide).MoveByOffset(280, 0).Perform();
        }
        public void validate13(String volume)
        {
            Actions action = new Actions(driver);
            AndroidElement slide = driver.FindElement(slider);
            action.ClickAndHold(slide).MoveByOffset(1, 0).Perform();
            string actual_value = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"VolumeChanging\"]")).Text;
            Assert.AreEqual(actual_value, volume);
            action.Release().Perform();
        }
        public void Speechclarity(string p0)
        {
            driver.FindElement(speechclarity).Click();
        }
        public void validateSpeechclarity(string p0)
        {

            AndroidElement speech = driver.FindElement(speechclarity);
            bool isClicked = speech.Selected;

            Assert.IsTrue(isClicked, "Button is clicked");


        }

        public void Noisefilter(string p0)
        {
            driver.FindElement(noisefilter).Click();
        }

        public void validatenoisefilter(string p0)
        {
            AndroidElement noise = driver.FindElement(noisefilter);

            bool isClicked = noise.Selected;

            Assert.IsTrue(isClicked, "Button is clicked");

        }
        public void disablespeechclarity(string p0)
        {
            AndroidElement speech = driver.FindElement(speechclarity);
            bool isClicked = !speech.Selected;

            Assert.IsTrue(isClicked, "Button is clicked");
        }
        public void Speechclarity1(string p0)
        {
            driver.FindElement(speechclarity).Click();
        }
        public void disablenoisefilter(string p1)
        {
            AndroidElement noise = driver.FindElement(noisefilter);

            bool isClicked = !noise.Selected;

            Assert.IsTrue(isClicked, "Button is clicked");
        }
        public void validateSpeechclarity1(string p0)
        {

            AndroidElement speech = driver.FindElement(speechclarity);
            bool isClicked = speech.Selected;

            Assert.IsTrue(isClicked, "Button is clicked");


        }

        public void Bass(String p0)
        {
            TouchAction touchAction = new TouchAction(driver);
            AndroidElement BASS = driver.FindElement(bass);

            touchAction.Press(90, 992)
                       .MoveTo(90, 714)
                       .Release()
                       .Perform();

        }
        public void middlegain(String p0)
        {
            TouchAction touchAction = new TouchAction(driver);
            AndroidElement GAIN = driver.FindElement(Middlegain);
            touchAction.Press(450, 992)
                       .MoveTo(450, 1340)
                       .Release()
                       .Perform();

        }
        public void treblegain(String p0)
        {
            TouchAction touchAction = new TouchAction(driver);
            AndroidElement TREBLE = driver.FindElement(Treblegain);
            touchAction.Press(810, 992)
                       .MoveTo(810, 684)
                       .Release()
                       .Perform();

        }
        public void validatebass(String bassgain)
        {
            Actions action = new Actions(driver);
            AndroidElement BASS = driver.FindElement(bass);
            action.ClickAndHold(BASS).MoveByOffset(0, 2).Perform();
            string actual_value = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc='GainChanging']")).Text;
            Assert.AreEqual(actual_value, bassgain);
        }

        public void validatemiddlegain(String gain)
        {

            Actions action = new Actions(driver);
            AndroidElement GAIN = driver.FindElement(Middlegain);
            action.ClickAndHold(GAIN).MoveByOffset(0, 2).Perform();
            string actual_value = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc='GainChanging']")).Text;
            Assert.AreEqual(actual_value, gain);
        }

        public void validatetreble(String treble)
        {
            Actions action = new Actions(driver);
            AndroidElement TREBLE = driver.FindElement(Treblegain);
            action.ClickAndHold(TREBLE).MoveByOffset(0, 2).Perform();
            string actual_value = driver.FindElement(By.XPath("//android.widget.TextView[@content-desc='GainChanging']")).Text;
            Assert.AreEqual(actual_value, treble);
        }


        public void waves(string calm, string breaking)
        {
            AndroidElement wave = driver.FindElement(calmingwaves);
            wave.Click();
            AndroidElement breakingwave = driver.FindElement(breakingwaves);
            breakingwave.Click();
        }

        public void allaroundclick(string p0)
        {
            driver.FindElement(allaround).Click();
        }

    }
    }

    

