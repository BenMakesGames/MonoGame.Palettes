using System.Drawing;

namespace BenMakesGames.RetroPalettes
{
    /// <summary>
    /// Fun16 palette.
    /// Source: https://lospec.com/palette-list/fun16
    /// </summary>
    public sealed class Fun16
    {
        public static readonly Color Black = Color.FromArgb(0x08, 0x00, 0x08);
        public static readonly Color DarkGrey = Color.FromArgb(0x5e, 0x66, 0x60);
        public static readonly Color DarkestBlue = Color.FromArgb(0x2a, 0x34, 0x43);
        public static readonly Color DarkBrown = Color.FromArgb(0x5d, 0x46, 0x32);
        public static readonly Color DarkBlue = Color.FromArgb(0x44, 0x50, 0x8c);
        public static readonly Color Red = Color.FromArgb(0xa6, 0x41, 0x4d);
        public static readonly Color Orange = Color.FromArgb(0xc8, 0x6b, 0x36);
        public static readonly Color Lavender = Color.FromArgb(0x83, 0x75, 0xaf);
        public static readonly Color Green = Color.FromArgb(0x52, 0x90, 0x3c);
        public static readonly Color Pink = Color.FromArgb(0xdb, 0x7e, 0xbd);
        public static readonly Color Blue = Color.FromArgb(0x5b, 0x99, 0xf4);
        public static readonly Color Peach = Color.FromArgb(0xde, 0xac, 0x85);
        public static readonly Color LightGreen = Color.FromArgb(0x94, 0xcc, 0x4e);
        public static readonly Color LightBlue = Color.FromArgb(0x84, 0xdb, 0xfc);
        public static readonly Color Yellow = Color.FromArgb(0xf2, 0xde, 0x70);
        public static readonly Color White = Color.FromArgb(0xfc, 0xff, 0xfe);

        public static readonly Color[] Palette = new[]
        {
            Black,
            DarkGrey,
            DarkestBlue,
            DarkBrown,
            DarkBlue,
            Red,
            Orange,
            Lavender,
            Green,
            Pink,
            Blue,
            Peach,
            LightGreen,
            LightBlue,
            Yellow,
            White
        };
    }
}
