using Microsoft.Xna.Framework;

namespace BenMakesGames.MonoGame.Palettes;

/// <summary>
/// PICO-8 palette.
/// Source: https://pico-8.fandom.com/wiki/Palette
/// </summary>
public static class PICO8
{
    public static readonly Color Black = new(0, 0, 0);
    public static readonly Color DarkBlue = new(29, 43, 83);
    public static readonly Color DarkPurple = new(126, 37, 83);
    public static readonly Color DarkGreen = new(0, 135, 81);
    public static readonly Color Brown = new(171, 82, 54);
    public static readonly Color DarkGrey = new(95, 87, 79);
    public static readonly Color LightGrey = new(194, 195, 199);
    public static readonly Color White = new(255, 241, 232);
    public static readonly Color Red = new(255, 0, 77);
    public static readonly Color Orange = new(255, 163, 0);
    public static readonly Color Yellow = new(255, 236, 39);
    public static readonly Color Green = new(0, 228, 53);
    public static readonly Color Blue = new(41, 173, 255);
    public static readonly Color Lavender = new(131, 118, 156);
    public static readonly Color Pink = new(255, 119, 168);
    public static readonly Color LightPeach = new(255, 204, 170);

    public static readonly Color[] Palette =
    [
        Black,
        DarkBlue,
        DarkPurple,
        DarkGreen,
        Brown,
        DarkGrey,
        LightGrey,
        White,
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Lavender,
        Pink,
        LightPeach
    ];
}
