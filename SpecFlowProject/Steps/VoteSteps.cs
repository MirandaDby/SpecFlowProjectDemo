using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class VoteSteps
    {
        readonly VotePage votePage=new VotePage();
        
        [Then(@"I see the top car model")]
        public void ThenISeeTheTopCarModel()
        { 
            votePage.PageIsDisplayed();
        }

        [When(@"I fill the vote comment")]
        public void WhenIFillTheVoteComment()
        {
            votePage.FillComment();

        }

        [When(@"I click vote button")]
        public void WhenIClickVoteButton()
        {
            votePage.ClickVote();
        }

        [Then(@"I vote successfully")]
        public void ThenIVoteSuccessfully()
        { 
            Assert.IsTrue(votePage.VoteFeedback());
        }

    }
}
