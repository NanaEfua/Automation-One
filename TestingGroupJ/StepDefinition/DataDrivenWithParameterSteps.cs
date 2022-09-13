using System;
using TechTalk.SpecFlow;
using TestingGroupJ.PageObject;

namespace TestingGroupJ.StepDefinition
{
    


    [Binding]
    public class DataDrivenWithParameterSteps
    {
        DataDrivenWithParameterPage dataDrivenWithParameterPage;

        public DataDrivenWithParameterSteps()
        {
            dataDrivenWithParameterPage = new DataDrivenWithParameterPage();
        }


        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            dataDrivenWithParameterPage.NavigateToWebsite(url);
        }
        
        [Given(@"I enter my Username ""(.*)""")]
        public void GivenIEnterMyUsername(string username)
        {
            dataDrivenWithParameterPage.EnterUsername(username);
        }
        
        [Given(@"I enter my email ""(.*)""")]
        public void GivenIEnterMyEmail(string email)
        {
            dataDrivenWithParameterPage.EnterEmail(email);
        }
        
        [Given(@"I enter my password  ""(.*)""")]
        public void GivenIEnterMyPassword(string password)
        {
            dataDrivenWithParameterPage.EnterPassword(password);
        }
    }
}
