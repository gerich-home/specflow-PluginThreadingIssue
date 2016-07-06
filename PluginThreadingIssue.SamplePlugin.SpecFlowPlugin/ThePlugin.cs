using TechTalk.SpecFlow.Plugins;

namespace PluginThreadingIssue.SamplePlugin.SpecFlowPlugin
{
    public class ThePlugin : IRuntimePlugin
    {
        public void Initialize(RuntimePluginEvents runtimePluginEvents, RuntimePluginParameters runtimePluginParameters)
        {
            runtimePluginEvents.CustomizeScenarioDependencies += (sender, args) =>
            {
                args.ObjectContainer.RegisterTypeAs<ScenarioDependencyFromPlugin>(typeof(ScenarioDependencyFromPlugin));
            };
        }
    }
}
