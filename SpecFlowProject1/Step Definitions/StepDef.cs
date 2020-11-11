using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using TechTalk.SpecFlow.Assist;

namespace CreativeTech
{
    [Binding]
    public class PerformOnScreen
    {
       

        [Given(@"launch ""(.*)"" browser")]
        public void GivenLaunch(string strBrowserType)
        {
            SeleniumUtility.fnGetDriver(strBrowserType);            
        }
        
        [When(@"I navigate to ""(.*)"" website")]
        public void WhenEnterWebsite(string strURL)
        {
            SeleniumUtility.fnOpenUrl(strURL);
        }        
              
        [Then(@"I verify ""(.*)"" page is opened")]
        public void ThenVerifyPageIsOpened(string strTitle)
        {
            SeleniumUtility.fnVerifyPageOpened(strTitle);
        }

        [Then(@"I verify ""(.*)"" ""(.*)"" ""(.*)"" are displayed")]
        public void ThenIVerifyAreDisplayed(string strName, string strEmail, string strPhNum)
        { 
            SeleniumUtility.fnVerifyCustDetails(strName,strEmail,strPhNum);
        }


        [Then(@"close the browser")]
        public void ThenCloseTheBrowser()
        {
            SeleniumUtility.fnCloseBrowser();

        }

        [When(@"I click on button for customer ""(.*)""")]
        public void WhenIClickOnButtonForCustomer(string strName)
        {
            SeleniumUtility.fnClickOnBtn(strName);
        }

        [Then(@"I verify details of the customer ""(.*)"" are displayed")]
        public void ThenIVerifyDetailsOfTheCustomerAreDisplayed(string strName)
        {
            SeleniumUtility.fnVerifyCustDetailsAreDisplayed(strName);
        }

        [Then(@"I validate ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" of the customer")]
        public void ThenIValidateOfTheCustomer(string strName,string strCity, string strState, string strCountry, string strOrg, string strJob, string strAddInfo)
        {
            SeleniumUtility.fnValidateCustDetails(strName,strCity, strState, strCountry, strOrg, strJob, strAddInfo);
        }

    }
}
