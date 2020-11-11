using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CreativeTech
{
    public class HomePage
    {
        public HomePage()
        {
           PageFactory.InitElements(SeleniumUtility.driver, this);
        }

        //To get the objects on the Home page

        [FindsBy(How = How.ClassName, Using = "App-title")]
        public IWebElement statictxtSeleniumTest { get; set; }

    }
}
