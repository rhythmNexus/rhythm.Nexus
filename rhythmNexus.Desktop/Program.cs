using osu.Framework.Platform;
using osu.Framework;
using rhythmNexus.Game;

namespace rhythmNexus.Desktop
{
    public static class Program
    {
        public static void Main()
        {
            using (GameHost host = Host.GetSuitableDesktopHost(@"rhythmNexus"))
            using (osu.Framework.Game game = new rhythmNexusGame())
                host.Run(game);
        }
    }
}
