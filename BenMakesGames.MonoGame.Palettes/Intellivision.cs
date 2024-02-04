using Microsoft.Xna.Framework;

namespace BenMakesGames.MonoGame.Palettes;

/// <summary>
/// Intellivision palette.
/// Source: https://en.wikipedia.org/wiki/List_of_video_game_console_palettes
/// </summary>
public sealed class Intellivision
{
    public static readonly Color Black = new(0x0C, 0, 0x05);
    public static readonly Color DarkBlue = new(0x00, 0x2D, 0xFF);
    public static readonly Color Red = new(0xFF, 0x3E, 0x00);
    public static readonly Color Beige = new(0xC9, 0xD4, 0x64);

    public static readonly Color DarkGreen = new(0x00, 0x78, 0x0F);
    public static readonly Color Green = new(0x00, 0xA7, 0x20);
    public static readonly Color Yellow = new(0xFA, 0xEA, 0x27);
    public static readonly Color White = new(0xFF, 0xFC, 0xFF);

    public static readonly Color Gray = new(0xA7, 0xA8, 0xA8);
    public static readonly Color LightBlue = new(0x5A, 0xCB, 0xFF);
    public static readonly Color Orange = new(0xFF, 0xA6, 0x00);
    public static readonly Color DarkerGreen = new(0x3C, 0x58, 0x00);

    public static readonly Color HotPink = new(0xFF, 0x32, 0x76);
    public static readonly Color Periwinkle = new(0xBD, 0x95, 0xFF);
    public static readonly Color LightGreen = new(0x6C, 0xCD, 0x30);
    public static readonly Color Purple = new(0xC8, 0x1A, 0x7D);

    public static readonly Color[] Palette =
    [
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
    ];
}