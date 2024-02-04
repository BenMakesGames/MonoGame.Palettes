using System.Drawing;

namespace BenMakesGames.RetroPalettes;

/// <summary>
/// Apple II lo-res palette.
/// Source: http://mrob.com/pub/xapple2/colors.html
/// </summary>
public static class AppleIILoRes
{
    public static readonly Color Black = Color.FromArgb(0, 0, 0);
    public static readonly Color Red = Color.FromArgb(227, 30, 96);
    public static readonly Color DarkBlue = Color.FromArgb(96, 78, 189);
    public static readonly Color Purple = Color.FromArgb(255, 68, 253);
    public static readonly Color DarkGreen = Color.FromArgb(0, 163, 96);
    public static readonly Color Grey = Color.FromArgb(156, 156, 156);
    public static readonly Color MediumBlue = Color.FromArgb(20, 207, 253);
    public static readonly Color LightBlue = Color.FromArgb(208, 196, 255);
    public static readonly Color Brown = Color.FromArgb(96, 114, 3);
    public static readonly Color Orange = Color.FromArgb(255, 106, 60);
    //public static readonly Color Grey2 = new(0x80, 0x80, 0x80);
    public static readonly Color Pink = Color.FromArgb(255, 160, 208);
    public static readonly Color LightGreen = Color.FromArgb(20, 245, 60);
    public static readonly Color Yellow = Color.FromArgb(208, 221, 141);
    public static readonly Color Aqua = Color.FromArgb(114, 255, 208);
    public static readonly Color White = Color.FromArgb(255, 255, 255);

    public static readonly Color[] Palette =
    [
        Black,
        Red,
        DarkBlue,
        Purple,
        DarkGreen,
        Grey,
        MediumBlue,
        LightBlue,
        Brown,
        Orange,
        Grey, // Grey 2
        Pink,
        LightGreen,
        Yellow,
        Aqua,
        White
    ];
}