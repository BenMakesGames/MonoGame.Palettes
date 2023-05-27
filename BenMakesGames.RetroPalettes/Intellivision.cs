using System.Drawing;

namespace BenMakesGames.RetroPalettes
{
    /// <summary>
    /// Intellivision palette.
    /// Source: https://en.wikipedia.org/wiki/List_of_video_game_console_palettes
    /// </summary>
    public sealed class Intellivision
    {
        public static readonly Color Black = Color.FromArgb(0x0C, 0, 0x05);
        public static readonly Color DarkBlue = Color.FromArgb(0x00, 0x2D, 0xFF);
        public static readonly Color Red = Color.FromArgb(0xFF, 0x3E, 0x00);
        public static readonly Color Beige = Color.FromArgb(0xC9, 0xD4, 0x64);

        public static readonly Color DarkGreen = Color.FromArgb(0x00, 0x78, 0x0F);
        public static readonly Color Green = Color.FromArgb(0x00, 0xA7, 0x20);
        public static readonly Color Yellow = Color.FromArgb(0xFA, 0xEA, 0x27);
        public static readonly Color White = Color.FromArgb(0xFF, 0xFC, 0xFF);

        public static readonly Color Gray = Color.FromArgb(0xA7, 0xA8, 0xA8);
        public static readonly Color LightBlue = Color.FromArgb(0x5A, 0xCB, 0xFF);
        public static readonly Color Orange = Color.FromArgb(0xFF, 0xA6, 0x00);
        public static readonly Color DarkerGreen = Color.FromArgb(0x3C, 0x58, 0x00);

        public static readonly Color HotPink = Color.FromArgb(0xFF, 0x32, 0x76);
        public static readonly Color Periwinkle = Color.FromArgb(0xBD, 0x95, 0xFF);
        public static readonly Color LightGreen = Color.FromArgb(0x6C, 0xCD, 0x30);
        public static readonly Color Purple = Color.FromArgb(0xC8, 0x1A, 0x7D);

        public static readonly Color[] Palette =
        {
            Black,
            DarkBlue,
            Red,
            Beige,
            DarkGreen,
            Green,
            Yellow,
            White,
            Gray,
            LightBlue,
            Orange,
            DarkerGreen,
            HotPink,
            Periwinkle,
            LightGreen,
            Purple
        };

    }
}