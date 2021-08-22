using SpecFlowProject.Page;
using SpecFlowProject.Page.Buggy;
using SpecFlowProject.Tools;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.Steps
{
    [Binding]
    public class BuggyCarSteps
    {
        readonly HomePage homepage  = new HomePage();  
        string TestUsername;
        string TestPassword;

        public BuggyCarSteps(ScenarioContext scenarioContext)
        { 
            TestUsername = (string)scenarioContext["Username"];
            TestPassword = (string)scenarioContext["Password"];
        }

        [Given(@"user is in homepage")]
        public void GivenUserIsInHomepage()
        { 
            homepage.NavigateTo();
            Loggers.Log("Navigate To Home page");
        } 
 

        [When(@"I register as a new user")]
        public void WhenIRegisterAsANewUser()
        { 
            homepage.GoToRegister();
            Loggers.Log("Navigate To Register page");
        }
           

        [When(@"I login with (.*) and (.*)")]
        public void WhenILoginWithAnd(string p0, string p1)
        { 
            homepage.FillUserName(p0); 
            Loggers.Log("Enter username: " + p0);
            homepage.FillPassword(p1);
            Loggers.Log("Enter password:" + p1);
        }

        [When(@"I click Login button")]
        [Then(@"I click Login button")]
        public void ThenIClickLoginButton()
        { 
            homepage.Login();
            Loggers.Log("ClickLoginButton");
        }

        [Then(@"I login successfully")]
        public void ThenILoginSuccessfully()
        {
             //login verification
        }

        [When(@"I navigate to PopularMake Page")]
        public void WhenINavigateToPopularMakePage()
        { 
            homepage.GoToPopularMake();
        }


        [When(@"I navigate to PopularModel Page")]
        public void WhenINavigateToPopularModelPage()
        {
            homepage.GoToPopularModelPage();
        }

        [When(@"I navigate to OverralRating Page")]
        public void WhenINavigateToOverralRatingPage()
        {
            homepage.GoToOverralRatingPage();
        }
           

        [When(@"I login")]
        public void WhenILogin()
        {

            homepage.NavigateTo();
            homepage.FillUserName(TestUsername);
            homepage.FillPassword(TestPassword);
            homepage.Login();
             
        }

    }
}
