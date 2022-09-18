using Microsoft.Xna.Framework;

namespace BenMakesGames.MonoGame.Palettes;

// from https://moddingwiki.shikadi.net/wiki/EGA_Palette#Default_Palette
public static class CGA16
{
    public static readonly Color Black = new(0, 0, 0);
    public static readonly Color Blue = new(0, 0, 0xAA);
    public static readonly Color Green = new(0, 0xAA, 0);
    public static readonly Color Cyan = new(0, 0xAA, 0xAA);
    public static readonly Color Red = new(0xAA, 0, 0);
    public static readonly Color Magenta = new(0xAA, 0, 0xAA);
    public static readonly Color Brown = new(0xAA, 0x55, 0);
    public static readonly Color LightGray = new(0xAA, 0xAA, 0xAA);
    public static readonly Color DarkGray = new(0x55, 0x55, 0x55);
    public static readonly Color BrightBlue = new(0x55, 0x55, 0xFF);
    public static readonly Color BrightGreen = new(0x55, 0xFF, 0x55);
    public static readonly Color BrightCyan = new(0x55, 0xFF, 0xFF);
    public static readonly Color BrightRed = new(0xFF, 0x55, 0x55);
    public static readonly Color BrightMagenta = new(0xFF, 0x55, 0xFF);
    public static readonly Color Yellow = new(0xFF, 0xFF, 0x55);
    public static readonly Color White = new(0xFF, 0xFF, 0xFF);
}