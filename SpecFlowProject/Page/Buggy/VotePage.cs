using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.Page.Buggy
{
    public class VotePage : Basepage
    {


        private WebDriverWait wait;
        private IWebElement comment => Driver.FindElement(By.Id("comment"));   
        private IWebElement voteButton => Driver.FindElement(By.XPath("//button[text()='Vote!']"));
        private IWebElement voteFeedbackText => Driver.FindElement(By.ClassName("card-text"));
        private IWebElement tableElement => Driver.FindElement(By.XPath("//*/table/tbody")); //not including header..............

        public VotePage()
        {
            
        }
        public void FillComment()
        {
            comment.SendKeys("test"); 
        }
        public void ClickVote()
        {
            voteButton.Click();
        }
        public bool VoteFeedback()
        {
            if (voteFeedbackText.Displayed)
            {
                return true;
            }
            else 
            { 
                return false; 
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
