using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SpecFlowProject.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.Page
{
    public abstract class Basepage
    {

        public virtual string PageUrl => "https://buggy.justtestit.org/";
          
        public Basepage()
        {
            PageFactory.InitElements(Driver, this);
        }
        public IWebDriver Driver
        {
            get { return Singlton.Driver; }
            set { Singlton.SetDriver(value); }

        }

        protected virtual void WaitUntilElementPresent(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(60));
            try
            {
                wait.Until(d => element.Displayed);
            }
            catch (Exception e)
            {
                Loggers.Log("Wait unitl element is displayed: " + e.Message, "Error");
            }
        }

    }
}
