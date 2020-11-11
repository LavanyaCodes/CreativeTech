using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace CreativeTech
{
    public static class SeleniumUtility
    {
        public static IWebDriver driver;
        public static IWebElement elem;

        public static void fnGetDriver(string strBrowserType)
        {
            //Launching the browser
            if (strBrowserType.ToLower() == "chrome")
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("--start-maximized");
                driver = new ChromeDriver(options);
            }
        }

        public static void fnOpenUrl(string strURL)
        {
            //Navigate to the URL
            if (strURL.ToLower() == "selenium test")
                driver.Navigate().GoToUrl("https://9a2cdb3e.azurewebsites.net/customerlist");
            else
                driver.Navigate().GoToUrl(strURL);
        }

        public static void fnCloseBrowser()
        {
            driver.Close();
            driver.Quit();
        }

        public static void fnWaitForPageLoading()
        {

            try
            {
                //Wait for element to be visible
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("App-logo")));
            }
            catch
            {
                elem = null;
            }
        }

        public static void fnWaitForElement(IWebElement element)
        {
            try
            {
                //Wait for element to be visible
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(900));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
            }
            catch
            {
                elem = null;
            }            
        }

        public static void fnVerifyPageOpened(string strTitle)
        {
            try
            {
                fnWaitForPageLoading();
                HomePage homepage = new HomePage();
                elem = homepage.statictxtSeleniumTest;
                if (elem != null)
                    Assert.IsTrue(elem.Text.Contains(strTitle));
                Console.WriteLine(strTitle + " page is opened");
            }
            catch (Exception e)
            {
                fnCloseBrowser();
                throw new SystemException("Unable to find Element " + e.Message);
            }

        }

        public static void fnVerifyCustDetails(string strCustName, string strCustEmail, string strCustPhNum)
        {
            try
            {
                fnWaitForPageLoading();
                //Initialising page objects
                JohnSmithPage jsPage = new JohnSmithPage();
                JeffBridgesPage jbPage = new JeffBridgesPage();
                SteveJonesPage sjPage = new SteveJonesPage();
                if (strCustName == "John Smith")
                {
                    //Verify if customer details of John Smith are displayed
                    fnWaitForElement(jsPage.statictxtName);
                    Assert.AreEqual(strCustName, jsPage.statictxtName.Text);
                    Assert.AreEqual(strCustEmail, jsPage.statictxtEmail.Text);
                    Assert.AreEqual(strCustPhNum, jsPage.statictxtPhNum.Text);
                    Console.WriteLine("Customer details of " + strCustName + "are displayed");
                }
                else if (strCustName == "Jeff Bridges")
                {
                    //Verify if customer details of Jeff Bridges are displayed
                    fnWaitForElement(jbPage.statictxtName);
                    Assert.AreEqual(strCustName, jbPage.statictxtName.Text);
                    Assert.AreEqual(strCustEmail, jbPage.statictxtEmail.Text);
                    Assert.AreEqual(strCustPhNum, jbPage.statictxtPhNum.Text);
                    Console.WriteLine("Customer details of " + strCustName + "are displayed");
                }
                else if (strCustName == "Steve Jones")
                {
                    //Verify if customer details of Steve Jones are displayed
                    fnWaitForElement(sjPage.statictxtName);
                    Assert.AreEqual(strCustName, sjPage.statictxtName.Text);
                    Assert.AreEqual(strCustEmail, sjPage.statictxtEmail.Text);
                    Assert.AreEqual(strCustPhNum, sjPage.statictxtPhNum.Text);
                    Console.WriteLine("Customer details of " + strCustName + "are displayed");
                }
            }
            catch (Exception e)
            {
                fnCloseBrowser();
                throw new SystemException("Unable to find Element " + e.Message);
            }
        }

        public static void fnClickOnBtn(string strCustName)
        {
            try
            {
                fnWaitForPageLoading();
                //Initialising page objects
                JohnSmithPage jsPage = new JohnSmithPage();
                JeffBridgesPage jbPage = new JeffBridgesPage();
                SteveJonesPage sjPage = new SteveJonesPage();
                if (strCustName == "John Smith")
                {
                    fnWaitForElement(jsPage.btnCheckDetails);
                    jsPage.btnCheckDetails.Click();
                    fnWaitForElement(jsPage.statictxtCity);
                    fnWaitForElement(jsPage.statictxtCountry);
                }
                else if (strCustName == "Jeff Bridges")
                {
                    fnWaitForElement(jbPage.btnCheckDetails);
                    jbPage.btnCheckDetails.Click();
                    fnWaitForElement(jsPage.statictxtCity);
                    fnWaitForElement(jsPage.statictxtCountry);
                }
                else if (strCustName == "Steve Jones")
                {
                    fnWaitForElement(sjPage.btnCheckDetails);
                    sjPage.btnCheckDetails.Click();
                    fnWaitForElement(jsPage.statictxtCity);
                    fnWaitForElement(jsPage.statictxtCountry);
                }
            }
            catch (Exception e)
            {
                fnCloseBrowser();
                throw new SystemException("Unable to find Element " + e.Message);
            }
        }

        public static void fnVerifyCustDetailsAreDisplayed(string strCustName)
        {
            try
            {
                fnWaitForPageLoading();
                //Initialising page objects
                JohnSmithPage jsPage = new JohnSmithPage();
                JeffBridgesPage jbPage = new JeffBridgesPage();
                SteveJonesPage sjPage = new SteveJonesPage();
                if (strCustName == "John Smith")
                {
                    //Wait for Element
                    fnWaitForElement(jsPage.statictxtCustName);
                    elem = jsPage.statictxtCustName;
                    //Assert if Customer Name is Displayed
                    Assert.AreEqual(strCustName, elem.Text);
                    Console.WriteLine("Customer Details of corresponding customer " + strCustName + " are displayed");
                }
                else if (strCustName == "Jeff Bridges")
                {
                    //Wait for Element
                    fnWaitForElement(jbPage.statictxtCustName);
                    elem = jbPage.statictxtCustName;
                    //Assert if Customer Name is Displayed
                    Assert.AreEqual(strCustName, elem.Text);
                    Console.WriteLine("Customer Details of corresponding customer " + strCustName + " are displayed");
                }
                else if (strCustName == "Steve Jones")
                {
                    //Wait for Element
                    fnWaitForElement(sjPage.statictxtCustName);
                    elem = sjPage.statictxtCustName;
                    //Assert if Customer Name is Displayed
                    Assert.AreEqual(strCustName, elem.Text);
                    Console.WriteLine("Customer Details of corresponding customer " + strCustName + " are displayed");
                }
            }
            catch (Exception e)
            {
                fnCloseBrowser();
                throw new SystemException("Unable to find Element " + e.Message);
            }

        }

        public static void fnValidateCustDetails(string strName,string strCity, string strState, string strCountry, string strOrg, string strJob, string strAddInfo)
        {
            try
            {
                fnWaitForPageLoading();
                JohnSmithPage jsPage = new JohnSmithPage();
                JeffBridgesPage jbPage = new JeffBridgesPage();
                SteveJonesPage sjPage = new SteveJonesPage();
                string strCustName="", strCustEmail="",strCustPhNum = "";
                int count = 0;
                if (strName == "John Smith")
                {
                    //Wait for element
                    fnWaitForElement(jsPage.statictxtName);
                    //Get Customer Name, Email and Phone Number
                    strCustName = jsPage.statictxtName.Text;
                    strCustEmail = jsPage.statictxtEmail.Text;
                    strCustPhNum = jsPage.statictxtPhNum.Text;
                    //Wait for button to be clickable
                    fnWaitForElement(jsPage.btnCheckDetails);
                    //Click on button
                    jsPage.btnCheckDetails.Click();                    
                }
                else if (strName == "Jeff Bridges")
                {
                    //Wait for element
                    fnWaitForElement(jsPage.statictxtName);
                    //Get Customer Name, Email and Phone Number
                    strCustName = jbPage.statictxtName.Text;
                    strCustEmail = jbPage.statictxtEmail.Text;
                    strCustPhNum = jbPage.statictxtPhNum.Text;
                    //Wait for button to be clickable
                    fnWaitForElement(jbPage.btnCheckDetails);
                    //Click on button
                    jbPage.btnCheckDetails.Click();
                 }
                else if (strName == "Steve Jones")
                {
                    //Wait for element
                    fnWaitForElement(jsPage.statictxtName);
                    //Get Customer Name, Email and Phone Number
                    strCustName = sjPage.statictxtName.Text;
                    strCustEmail = sjPage.statictxtEmail.Text;
                    strCustPhNum = sjPage.statictxtPhNum.Text;
                    //Wait for button to be clickable
                    fnWaitForElement(sjPage.btnCheckDetails);
                    //Click on button
                    sjPage.btnCheckDetails.Click();
                }
                //Validate details of the customer
                elem = jsPage.statictxtCustName;
                //Assert if Customer Name is Displayed
                Assert.AreEqual(strCustName, elem.Text);
                count = jsPage.custDetails.FindElements(By.XPath("//div/div/p")).Count;
                Assert.Greater(count, 0);    
                Assert.AreEqual(strCustName, jsPage.statictxtCusName.Text.Split(':').GetValue(1).ToString().Trim());
                Assert.AreEqual(strCustEmail, jsPage.statictxtCustEmail.Text.Split(':').GetValue(1).ToString().Trim());
                Assert.AreEqual(strCustPhNum, jsPage.statictxtCustPhNum.Text.Split(':').GetValue(1).ToString().Trim());
                Assert.AreEqual(strCity, jsPage.statictxtCity.Text.Split(':').GetValue(1).ToString().Trim());
                Assert.AreEqual(strState, jsPage.statictxtState.Text.Split(':').GetValue(1).ToString().Trim());
                Assert.AreEqual(strCountry, jsPage.statictxtCountry.Text.Split(':').GetValue(1).ToString().Trim());
                Assert.AreEqual(strOrg, jsPage.statictxtOrg.Text.Split(':').GetValue(1).ToString().Trim());
                Assert.AreEqual(strJob, jsPage.statictxtJobProf.Text.Split(':').GetValue(1).ToString().Trim());
                Assert.That(jsPage.statictxtAddInfo.Text.Split(':').GetValue(1).ToString().Trim(), Does.Contain(strAddInfo));
                Console.WriteLine("Customer info is validated successfully");
            }
            catch (Exception e)
            {
                fnCloseBrowser();
                throw new SystemException("Unable to find Element " + e.Message);
            }
        }
    }
}