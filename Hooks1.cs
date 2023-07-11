using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using TechTalk.SpecFlow;
using BoDi;
using SpecFlowProject2.StepDefinitions;
using OpenQA.Selenium.Remote;

namespace SpecFlowProject2.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        
       
       
        private AppiumDriver<AndroidElement> driver;
        private readonly IObjectContainer _container;//declares a private field named _container of type IObjectContainer

        public Hooks1(IObjectContainer container)//iobject container allows sharing of objects within specflow scenarios ,Constructor for the "Hooks1" class which takes an "IObjectContainer" parameter
        {
            _container = container;
        }
        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("platformName", "Android");
            appiumOptions.AddAdditionalCapability("deviceName", "OnePlus 9R");
            appiumOptions.AddAdditionalCapability("platform Version", "12");
            appiumOptions.AddAdditionalCapability("udid", "0e760502");
            appiumOptions.AddAdditionalCapability("Appium Server Address", "127.0.0.1:4723");
            appiumOptions.AddAdditionalCapability("app", "C:\\Users\\iray\\Desktop\\smart3d\\dk.resound.smart3d-Signed.apk");
            appiumOptions.AddAdditionalCapability("appPackage", "dk.resound.smart3d");
            var httpClient = new HttpClient();
            httpClient.Timeout = TimeSpan.FromSeconds(120);
            var commandExecutor = new HttpCommandExecutor(new Uri("http://localhost:4723/wd/hub"),TimeSpan.FromSeconds(120));
            var driver = new AndroidDriver<AndroidElement>(commandExecutor, appiumOptions);
            _container.RegisterInstanceAs<AppiumDriver<AndroidElement>>(driver);//This allows other parts of the code to access and use the registered driver instance 
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
           


            steps step = new steps(driver);
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            // Example of ordering the execution of hooks
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order
            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}