using osu.Framework.Graphics;
using osu.Framework.Graphics.UserInterface;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.Textures;
using osuTK;
using osuTK.Graphics;

public partial class MainMenu : CompositeDrawable {
    public MainMenu() {
        // Create a container to contain the buttons
        var buttonContainer = new Container {
            Size = new Vector2(200, 50),
            Anchor = Anchor.Centre,
            Origin = Anchor.Centre,
            Position = new Vector2(0, 0)
        };

        buttonContainer.Add(new BasicButton {
            Text = "Start",
            Action = null,
            Size = new Vector2(160, 40),
            Position = new Vector2(0, 0),
            Colour = Color4.LightGreen
        });

        buttonContainer.Add(new BasicButton {
            Text = "Settings",
            Action = null,
            Size = new Vector2(160, 40),
            Position = new Vector2(180, 0),
            Colour = Color4.Aqua
        });

        buttonContainer.Add(new BasicButton {
            Text = "Exit",
            Action = null,
            Size = new Vector2(160, 40),
            Position = new Vector2(-180, 0),
            Colour = Color4.HotPink
        });

        AddInternal(buttonContainer);
    }
}
