using Microsoft.Xna.Framework;

namespace BenMakesGames.MonoGame.Palettes;

// from http://mrob.com/pub/xapple2/colors.html
public static class AppleIILoRes
{
    public static readonly Color Black = new(0, 0, 0);
    public static readonly Color Red = new(227, 30, 96);
    public static readonly Color DarkBlue = new(96, 78, 189);
    public static readonly Color Purple = new(255, 68, 253);
    public static readonly Color DarkGreen = new(0, 163, 96);
    public static readonly Color Grey = new(156, 156, 156);
    public static readonly Color MediumBlue = new(20, 207, 253);
    public static readonly Color LightBlue = new(208, 196, 255);
    public static readonly Color Brown = new(96, 114, 3);
    public static readonly Color Orange = new(255, 106, 60);
    //public static readonly Color Grey2 = new(0x80, 0x80, 0x80);
    public static readonly Color Pink = new(255, 160, 208);
    public static readonly Color LightGreen = new(20, 245, 60);
    public static readonly Color Yellow = new(208, 221, 141);
    public static readonly Color Aqua = new(114, 255, 208);
    public static readonly Color White = new(255, 255, 255);

    public static readonly Color[] Palette =
    {
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
    };
}