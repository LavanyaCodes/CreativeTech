using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CreativeTech
{
    public class JohnSmithPage
    {
        public JohnSmithPage()
        {
            PageFactory.InitElements(SeleniumUtility.driver, this);
        }

        //To get the objects on the Customer Details page

        [FindsBy(How = How.XPath, Using = "//*[@id='root']/div/div/div[1]/div[1]/div[1]/h3")]
        public IWebElement statictxtName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='root']/div/div/div[1]/div[1]/div[2]/p[1]")]
        public IWebElement statictxtEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='root']/div/div/div[1]/div[1]/div[2]/p[2]")]
        public IWebElement statictxtPhNum { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='root']/div/div/div[1]/div[1]/div[2]/button")]
        public IWebElement btnCheckDetails { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='customerdetails']/div/div/h3")]
        public IWebElement statictxtCustName { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='customerdetails']")]
        public IWebElement custDetails { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='customerdetails']/div/div/p[1]")]
        public IWebElement statictxtCusName { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='customerdetails']/div/div/p[2]")]
        public IWebElement statictxtCustEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='customerdetails']/div/div/p[3]")]
        public IWebElement statictxtCustPhNum { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='customerdetails']/div/div/p[4]")]
        public IWebElement statictxtCity { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='customerdetails']/div/div/p[5]")]
        public IWebElement statictxtState { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='customerdetails']/div/div/p[6]")]
        public IWebElement statictxtCountry { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='customerdetails']/div/div/p[7]")]
        public IWebElement statictxtOrg { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='customerdetails']/div/div/p[8]")]
        public IWebElement statictxtJobProf { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='customerdetails']/div/div/p[9]")]
        public IWebElement statictxtAddInfo { get; set; }
    }
}
