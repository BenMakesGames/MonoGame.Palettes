using System.Drawing;

namespace BenMakesGames.RetroPalettes
{
    /// <summary>
    /// CGA 16 color palette.
    /// Source: https://moddingwiki.shikadi.net/wiki/EGA_Palette#Default_Palette
    /// </summary>
    public static class CGA16
    {
        public static readonly Color Black = Color.FromArgb(0, 0, 0);
        public static readonly Color Blue = Color.FromArgb(0, 0, 0xAA);
        public static readonly Color Green = Color.FromArgb(0, 0xAA, 0);
        public static readonly Color Cyan = Color.FromArgb(0, 0xAA, 0xAA);
        public static readonly Color Red = Color.FromArgb(0xAA, 0, 0);
        public static readonly Color Magenta = Color.FromArgb(0xAA, 0, 0xAA);
        public static readonly Color Brown = Color.FromArgb(0xAA, 0x55, 0);
        public static readonly Color LightGray = Color.FromArgb(0xAA, 0xAA, 0xAA);
        public static readonly Color DarkGray = Color.FromArgb(0x55, 0x55, 0x55);
        public static readonly Color BrightBlue = Color.FromArgb(0x55, 0x55, 0xFF);
        public static readonly Color BrightGreen = Color.FromArgb(0x55, 0xFF, 0x55);
        public static readonly Color BrightCyan = Color.FromArgb(0x55, 0xFF, 0xFF);
        public static readonly Color BrightRed = Color.FromArgb(0xFF, 0x55, 0x55);
        public static readonly Color BrightMagenta = Color.FromArgb(0xFF, 0x55, 0xFF);
        public static readonly Color Yellow = Color.FromArgb(0xFF, 0xFF, 0x55);
        public static readonly Color White = Color.FromArgb(0xFF, 0xFF, 0xFF);
    }
}