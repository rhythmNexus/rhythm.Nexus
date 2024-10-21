using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Screens;
using osu.Framework.IO.Stores;
using rhythmNexus.Game.Screens;

namespace rhythmNexus.Game
{
    public partial class rhythmNexusGame : rhythmNexusGameBase {
        private ScreenStack screenStack;
        [BackgroundDependencyLoader]

        private void load() {
            // Add your top-level game components here.
            // A screen stack and sample screen has been provided for convenience, but you can replace it if you don't want to use screens.
            Child = screenStack = new ScreenStack { RelativeSizeAxes = Axes.Both };
            Resources.AddStore(new DllResourceStore(@"rhythmNexus.dll"));
            AddFont(Resources, @"Resources/Fonts/JetBrainsMono");
            AddFont(Resources, @"Resources/Fonts/JetBrainsMono-ExtraBold");
            AddFont(Resources, @"Resources/Fonts/JetBrainsMono-ExtraLight");
            AddFont(Resources, @"Resources/Fonts/JetBrainsMono-Light");
            AddFont(Resources, @"Resources/Fonts/JetBrainsMono-Medium");
        }

        protected override void LoadComplete() {
            base.LoadComplete();

            screenStack.Push(new MainMenu());
        }
    }
}
