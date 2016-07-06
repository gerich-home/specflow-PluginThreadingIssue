using System.Threading;
using TechTalk.SpecFlow;

namespace PluginThreadingIssue.Specs
{
    [Binding]
    public class StepDefinitions
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            LongAction();
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            LongAction();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            LongAction();
        }

        private static void LongAction()
        {
            Thread.Sleep(1000);
        }
    }
}
