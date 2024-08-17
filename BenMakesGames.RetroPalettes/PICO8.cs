using System.Drawing;

namespace BenMakesGames.RetroPalettes;

/// <summary>
/// PICO-8 palette.
/// Source: https://pico-8.fandom.com/wiki/Palette
/// </summary>
public static class PICO8
{
    public static readonly Color Black = Color.FromArgb(0, 0, 0);
    public static readonly Color DarkBlue = Color.FromArgb(29, 43, 83);
    public static readonly Color DarkPurple = Color.FromArgb(126, 37, 83);
    public static readonly Color DarkGreen = Color.FromArgb(0, 135, 81);
    public static readonly Color Brown = Color.FromArgb(171, 82, 54);
    public static readonly Color DarkGrey = Color.FromArgb(95, 87, 79);
    public static readonly Color LightGrey = Color.FromArgb(194, 195, 199);
    public static readonly Color White = Color.FromArgb(255, 241, 232);
    public static readonly Color Red = Color.FromArgb(255, 0, 77);
    public static readonly Color Orange = Color.FromArgb(255, 163, 0);
    public static readonly Color Yellow = Color.FromArgb(255, 236, 39);
    public static readonly Color Green = Color.FromArgb(0, 228, 53);
    public static readonly Color Blue = Color.FromArgb(41, 173, 255);
    public static readonly Color Lavender = Color.FromArgb(131, 118, 156);
    public static readonly Color Pink = Color.FromArgb(255, 119, 168);
    public static readonly Color LightPeach = Color.FromArgb(255, 204, 170);

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