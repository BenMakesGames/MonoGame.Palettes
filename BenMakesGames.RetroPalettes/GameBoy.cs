using System.Drawing;

namespace BenMakesGames.RetroPalettes
{
    /// <summary>
    /// Game Boy palette.
    /// </summary>
    public static class GameBoy
    {
        public static readonly Color Black = Color.FromArgb(8, 24, 32);
        public static readonly Color DarkGreen = Color.FromArgb(52, 104, 86);
        public static readonly Color Green = Color.FromArgb(136, 192, 112);
        public static readonly Color White = Color.FromArgb(224, 248, 208);

        public static readonly Color[] Palette =
        {
            Black,
            DarkGreen,
            Green,
            White
        };
    }
}