using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SpecFlowProject.Page.Buggy;
using SpecFlowProject.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.Page
{
    public class HomePage: Basepage
    {
         
        private IWebElement RegisterButton => Driver.FindElement(By.LinkText("Register"));
        private IWebElement LoginButton => Driver.FindElement(By.XPath("//button[@type='submit']"));        
        private IWebElement userName => Driver.FindElement(By.Name("login"));
        private IWebElement password => Driver.FindElement(By.Name("password"));

        private IWebElement popularMakeLink => Driver.FindElement(By.XPath("//h2[text()='Popular Make']/following-sibling::a")); 
        private IWebElement popularModelLink => Driver.FindElement(By.XPath("//h2[text()='Popular Model']/following-sibling::a")); 
        private IWebElement overallRatingLink => Driver.FindElement(By.XPath("//h2[text()='Overall Rating']/following-sibling::a"));  

  

        public HomePage()
        {
             
        }

        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(PageUrl);
        }

        public void GoToRegister()
        {
            RegisterButton.Click();
        }

        public void FillUserName(string username)
        {
            userName.SendKeys(username);
        }
        public void FillPassword(string psd)
        {
            password.SendKeys(psd);
        }
        public void Login()
        {
            LoginButton.Click();  
        }
        public void GoToPopularMake()
        { 
            popularMakeLink.Click(); 
        }
        public void GoToPopularModelPage()
        {
            popularModelLink.Click();
        }

        public void GoToOverralRatingPage()
        {
            overallRatingLink.Click();
        }
    }
}
