using System;
using TechTalk.SpecFlow;

namespace AutoSauceDemoTest.BDD.Steps
{
    [Binding]
    public class Sauce_LoginStepDefinitions
    {
        [Given(@"I enter a correct username and a correct password")]
        public void GivenIEnterACorrectUsernameAndACorrectPassword()
        {
            throw new PendingStepException();
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            throw new PendingStepException();
        }

        [Then(@"I should be taken to the products page")]
        public void ThenIShouldBeTakenToTheProductsPage()
        {
            throw new PendingStepException();
        }

        [Given(@"I enter a correct username and an incorrect password")]
        public void GivenIEnterACorrectUsernameAndAnIncorrectPassword()
        {
            throw new PendingStepException();
        }

        [Then(@"I should get an exception thrown")]
        public void ThenIShouldGetAnExceptionThrown()
        {
            throw new PendingStepException();
        }

        [Given(@"I enter an incorrect username and a correct password")]
        public void GivenIEnterAnIncorrectUsernameAndACorrectPassword()
        {
            throw new PendingStepException();
        }
    }
}
