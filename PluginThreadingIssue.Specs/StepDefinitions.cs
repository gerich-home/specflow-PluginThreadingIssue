using System.Threading;
using PluginThreadingIssue.SamplePlugin.SpecFlowPlugin;
using TechTalk.SpecFlow;

namespace PluginThreadingIssue.Specs
{
    [Binding]
    public class StepDefinitions
    {
        private readonly ScenarioDependencyFromPlugin _scenarioDependencyFromPlugin;
        private readonly TestThreadDependencyFromPlugin _testThreadDependencyFromPlugin;
        private readonly GlobalDependencyFromPlugin _globalDependencyFromPlugin;

        public StepDefinitions(ScenarioDependencyFromPlugin scenarioDependencyFromPlugin, TestThreadDependencyFromPlugin testThreadDependencyFromPlugin, GlobalDependencyFromPlugin globalDependencyFromPlugin)
        {
            _scenarioDependencyFromPlugin = scenarioDependencyFromPlugin;
            _testThreadDependencyFromPlugin = testThreadDependencyFromPlugin;
            _globalDependencyFromPlugin = globalDependencyFromPlugin;
        }

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
