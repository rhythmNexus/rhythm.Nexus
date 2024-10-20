using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osuTK;
using osuTK.Graphics;
using rhythmNexus.Game.Graphics;

public partial class MainMenu : CompositeDrawable {
    public MainMenu() {
        // Create a container to contain the buttons
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

        AddInternal(buttonContainer);
    }
}
