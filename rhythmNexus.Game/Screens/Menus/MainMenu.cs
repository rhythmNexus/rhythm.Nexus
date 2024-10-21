using System.Security.Cryptography.Pkcs;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.Textures;
using osu.Framework.Screens;
using osuTK;
using osuTK.Graphics;
using rhythmNexus.Game.Graphics;

namespace rhythmNexus.Game.Screens {
    public partial class MainMenu : Screen {
        // Create a container to contain the buttons
        private Sprite logoSprite;

        [BackgroundDependencyLoader]
        private void load(TextureStore textures) {
            var logoTexture = textures.Get("logo.png");

            logoSprite = new Sprite {
                Texture = logoTexture,
                Anchor = Anchor.TopCentre,
                Origin = Anchor.TopCentre,
                RelativeSizeAxes = Axes.None,
                Size = new Vector2(200, 200),
                Position = new Vector2(0,-100)
            };

            var buttonContainer = new Container {
                Anchor = Anchor.Centre,
                Origin = Anchor.Centre,
                Position = new Vector2(0, 0)
            };

            buttonContainer.Add(new RoundedButton {
                Text = "Start",
                Action = null,
                Size = new Vector2(240, 50),
                Position = new Vector2(0, 270),
                Colour = Color4.LightGreen
            });

            buttonContainer.Add(new RoundedButton {
                Text = "Settings",
                Action = null,
                Size = new Vector2(150, 50),
                Position = new Vector2(245, 270),
                Colour = Color4.Aqua
            });

            buttonContainer.Add(new RoundedButton {
                Text = "Exit",
                Action = null,
                Size = new Vector2(100, 50),
                Position = new Vector2(-220, 270),
                Colour = Color4.HotPink
            });

            AddInternal(logoSprite);
            AddInternal(buttonContainer);
        }
    }
}
