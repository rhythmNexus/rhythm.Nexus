using osu.Framework.Graphics;
using osu.Framework.Screens;
using osuTK.Graphics;

namespace rhythmNexus.Game.Screens.MainMenuScreen {
    public partial class MainMenuScreen : Screen {
        public MainMenuScreen() {
            AddInternal(new MainMenu {
                Origin = Anchor.Centre,
                Anchor = Anchor.Centre
            });
        }
    }
}
