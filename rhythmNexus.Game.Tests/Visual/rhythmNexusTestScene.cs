using osu.Framework.Testing;

namespace rhythmNexus.Game.Tests.Visual
{
    public abstract partial class rhythmNexusTestScene : TestScene
    {
        protected override ITestSceneTestRunner CreateRunner() => new rhythmNexusTestSceneTestRunner();

        private partial class rhythmNexusTestSceneTestRunner : rhythmNexusGameBase, ITestSceneTestRunner
        {
            private TestSceneTestRunner.TestRunner runner;

            protected override void LoadAsyncComplete()
            {
                base.LoadAsyncComplete();
                Add(runner = new TestSceneTestRunner.TestRunner());
            }

            public void RunTestBlocking(TestScene test) => runner.RunTestBlocking(test);
        }
    }
}
