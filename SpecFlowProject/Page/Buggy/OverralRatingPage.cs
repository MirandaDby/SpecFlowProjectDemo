using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.Page.Buggy
{
    public class OverralRatingPage : Basepage
    {
         
        private WebDriverWait wait;
        private IWebElement tableElement => Driver.FindElement(By.XPath("//*/table/tbody")); //not including header..............
        public OverralRatingPage()
        {

        }
        public bool PageIsDisplayed()
        {
            bool displayed = false;
            if (tableElement.Displayed)
            {
                displayed = true;
            }
            else
            {
                wait.Until(d => tableElement.Displayed);

            }
            return displayed;

        }
    }
}
