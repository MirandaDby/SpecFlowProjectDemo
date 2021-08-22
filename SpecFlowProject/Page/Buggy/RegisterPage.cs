using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.Page.Buggy
{
    public class RegisterPage : Basepage
    {
        private WebDriverWait wait;
        #region Web Elements
        
        private IWebElement userName => Driver.FindElement(By.Id("username"));
        private IWebElement firstName => Driver.FindElement(By.Id("firstName")); 
        private IWebElement lastName => Driver.FindElement(By.Id("lastName"));
        private IWebElement password => Driver.FindElement(By.Id("password"));
        private IWebElement confirmPassword => Driver.FindElement(By.Id("confirmPassword")); 
        private IWebElement RegisterButton => Driver.FindElement(By.XPath("//button[text()='Register']"));
        private IWebElement RegisterResult => Driver.FindElement(By.XPath("//div[contains(text(),'Registration is successful')]"));

        #endregion Web Elements

        public RegisterPage()
        {

        }

        public void FillUserName(string username)
        {
            userName.SendKeys(username); 
        }

        public void FillFirstName(string firstname)
        {
            firstName.SendKeys(firstname);
        }
        public void FillLastName(string lastname)
        {
            lastName.SendKeys(lastname);
        }
        public void FillPassword(string psd)
        {
            password.SendKeys(psd);
        }
        public void FillConfirmPassword(string cpsd)
        {
            confirmPassword.SendKeys(cpsd);
        }

        public void ClickRegister()
        {
            WaitUntilElementPresent(RegisterButton);
            RegisterButton.Click();
            WaitUntilElementPresent(RegisterResult);
        }

        public bool PageIsDisplayed()
        {
            bool displayed = false;
            if (userName.Displayed)
            {
                displayed = true;
            }
            else
            {
                wait.Until(d => userName.Displayed);

            }
            return displayed;

        }
    }
}
