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
    public class RatingSteps
    {
        readonly PopularMakePage popularMakePage = new PopularMakePage();
        readonly OverralRatingPage ratingPage = new OverralRatingPage();   
         
        [Then(@"I see the top car")]
        public void ThenISeeTheTopCar()
        { 
            popularMakePage.PageIsDisplayed();
        }

        [Then(@"I see the top car maker")]
        public void ThenISeeTheTopCarMaker()
        { 
            popularMakePage.PageIsDisplayed();
        }
          

        [Then(@"I see the top car rating")]
        public void ThenISeeTheTopCarRating()
        { 
            ratingPage.PageIsDisplayed();
        }

        [Then(@"I click the first one")]
        public void ThenIClickTheFirstOne()
        { 
            popularMakePage.ClickTopOne();
        }


    }
}
