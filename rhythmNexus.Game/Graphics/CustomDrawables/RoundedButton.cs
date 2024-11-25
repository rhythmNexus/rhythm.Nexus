using osu.Framework.Graphics;
using osu.Framework.Graphics.UserInterface;

namespace rhythmNexus.Game.Graphics
{
    public partial class RoundedButton : BasicButton {
        private float cornerRadius = 15f;
        private float borderThickness = 2f;

        public RoundedButton(float cornerRadius = 15f) {
            Masking = true;
            CornerRadius = this.cornerRadius;
            BorderThickness = borderThickness;
            BorderColour = Colour4.White;
            Anchor = Anchor.Centre;
            Origin = Anchor.Centre;
        }
    }
}
