using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.Page.Buggy
{
    public class PopularMakePage : Basepage
    {

        private readonly WebDriverWait wait; 
        private IWebElement tableElement => Driver.FindElement(By.XPath("//*/table/tbody")); //not including header..............

        public PopularMakePage()
        { 
             
        }
        public void GoToPage()
        {
            //firstModel.ElementAt(1).Click();
        }

        public void ClickTopOne()
        {
            IList<IWebElement> ListOfElements = tableElement.FindElements(By.TagName("tr"));
            foreach (var item in ListOfElements)
            {

                if (item.FindElement(By.TagName("a")).Displayed)
                {
                    item.FindElement(By.TagName("a")).Click();
                    break;

                }
            }

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
