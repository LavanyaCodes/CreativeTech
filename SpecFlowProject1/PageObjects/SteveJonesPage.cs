using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CreativeTech
{
    public class SteveJonesPage
    {
        public SteveJonesPage()
        {
            PageFactory.InitElements(SeleniumUtility.driver, this);
        }

        //To get the objects on the Customer Details page

        [FindsBy(How = How.XPath, Using = "//*[@id='root']/div/div/div[1]/div[3]/div[1]/h3")]
        public IWebElement statictxtName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='root']/div/div/div[1]/div[3]/div[2]/p[1]")]
        public IWebElement statictxtEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='root']/div/div/div[1]/div[3]/div[2]/p[2]")]
        public IWebElement statictxtPhNum { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='root']/div/div/div[1]/div[3]/div[2]/button")]
        public IWebElement btnCheckDetails { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='customerdetails']/div/div/h3")]
        public IWebElement statictxtCustName { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='customerdetails']")]
        public IWebElement CustInfoOfJohn { get; set; }
    }
}
