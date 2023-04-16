using Microsoft.Xna.Framework;

namespace BenMakesGames.MonoGame.Palettes;

public static class GameBoy
{
    public static readonly Color Black = new(8, 24, 32);
    public static readonly Color DarkGreen = new(52, 104, 86);
    public static readonly Color Green = new(136, 192, 112);
    public static readonly Color White = new(224, 248, 208);

    public static readonly Color[] Palette =
    {
        Black,
        DarkGreen,
        Green,
        White
    };
}