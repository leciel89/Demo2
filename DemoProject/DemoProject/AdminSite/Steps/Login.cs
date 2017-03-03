using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;


namespace DemoProject
{
    [Binding]
     public class Login
    {
        public IWebDriver driver;
        [Given(@"I am at the Admin Login Page")]
        public void GivenToAdminLoginPage()
        {
            driver = new FirefoxDriver();
            driver.Url = "http://localhost/admin"; }

            [Given(@"I have entered valid credentials")]  
     public void EnterUserNamePassWord()
       { 
            driver.FindElement(By.Name("login")).SendKeys("almond.dh@gmail.com");
            driver.FindElement(By.Name("password")).SendKeys("honghanh");
        }
	        [When(@"I press log in button")]
          public void ClickLoginButtin()
         { 
            driver.FindElement(By.XPath("//*[@id='login_form']/table/tbody[2]/tr/td/button")).Click();
            System.Threading.Thread.Sleep(6000);
        }

    [Then(@"I am directed to Manage Page")]
   public void GivenManagePage()
    {
            true.Equals(driver.FindElement(By.Id("top-links")).Displayed);
        }
    }
}
