using System.Drawing;

namespace BenMakesGames.RetroPalettes
{
    /// <summary>
    /// Game Boy Pocket/Light palette.
    /// </summary>
    public static class GameBoyPocket
    {
        public static readonly Color Black = Color.FromArgb(0, 0, 0);
        public static readonly Color DarkGray = Color.FromArgb(85, 85, 85);
        public static readonly Color LightGray = Color.FromArgb(170, 170, 170);
        public static readonly Color White = Color.FromArgb(255, 255, 255);

        public static readonly Color[] Palette =
        {
            Black,
            DarkGray,
            LightGray,
            White
        };
    }
}