using osu.Framework.Allocation;
using osu.Framework.Platform;
using NUnit.Framework;

namespace rhythmNexus.Game.Tests.Visual
{
    [TestFixture]
    public partial class TestScenerhythmNexusGame : rhythmNexusTestScene
    {
        // Add visual tests to ensure correct behaviour of your game: https://github.com/ppy/osu-framework/wiki/Development-and-Testing
        // You can make changes to classes associated with the tests and they will recompile and update immediately.

        private rhythmNexusGame game;

        [BackgroundDependencyLoader]
        private void load(GameHost host)
        {
            game = new rhythmNexusGame();
            game.SetHost(host);

            AddGame(game);
        }
    }
}
