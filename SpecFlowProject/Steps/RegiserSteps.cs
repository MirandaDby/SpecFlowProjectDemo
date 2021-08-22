using SpecFlowProject.Page.Buggy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowProject.Steps
{
    [Binding]
    public class RegiserSteps
    {
        readonly RegisterPage registerPage = new RegisterPage();

        string TestUsername;
        string TestPassword;

        public RegiserSteps(ScenarioContext scenarioContext)
        {
            TestUsername = (string)scenarioContext["Username"]; 
            TestPassword = (string)scenarioContext["Password"];

        }

        [Then(@"I see Register Page")]
        public void ThenISeeRegisterPage()
        { 
            registerPage.PageIsDisplayed();
        }
         
        [When(@"I fill username as (.*)")]
        [Then(@"I fill username as (.*)")]
        public void ThenIFillUserNameAs(string username)
        { 
            registerPage.PageIsDisplayed();
            registerPage.FillUserName(username + DateTime.Now.ToString("yyyyMMdd'T'HHmmss"));
        }

        [When(@"I fill (.*) and (.*)")]
        [Then(@"I fill (.*) and (.*)")]
        public void ThenIFillFirstNameAndLastName(string firstName, string lastName)//Table table)
        { 
            //string firstName = table.Rows[0]["firstName"].ToString();
            //string lastName = table.Rows[0]["lastName"].ToString();

            registerPage.FillFirstName(firstName);
            registerPage.FillLastName(lastName);

        }

        [When(@"I fill Password as (.*)")]
        [Then(@"I fill Password as (.*)")]
        public void ThenIFillPasswordAs(string p0)
        { 
            registerPage.FillPassword(p0);
        }

        [When(@"I fill ConfirmPassword as (.*)")]
        [Then(@"I fill ConfirmPassword as (.*)")]
        public void ThenIFillConfirmPasswordAs(string p0)
        { 
            registerPage.FillConfirmPassword(p0);
        }

        [When(@"I click Register button")]
        [Then(@"I click Register button")]
        public void ThenIClickRegisterButton()
        { 
            registerPage.ClickRegister(); 
        }
         
 
        [Then(@"I login successfully")]
        public void ThenILoginSuccessfully()
        {
            //login verification
        }

        [When(@"I register")]
        public void WhenIRegister()
        { 
            registerPage.PageIsDisplayed();
             
            registerPage.FillUserName(TestUsername);
            registerPage.FillFirstName("firstName");
            registerPage.FillLastName("lastName");
            registerPage.FillPassword(TestPassword);
            registerPage.FillConfirmPassword(TestPassword);

            registerPage.ClickRegister();
        }




    }
}
