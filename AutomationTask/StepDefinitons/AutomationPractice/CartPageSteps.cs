using System;
using TechTalk.SpecFlow;

namespace AutomationTask.StepDefinitons.AutomationPractice
{
    [Binding]
    public class CartPageSteps
    {
        [Then(@"I am able to view product '(.*)' in cart")]
        public void ThenIAmAbleToViewProductInCart(string p0)
        {
            ScenarioContext.Current.Pending();
        }


    }
}
