using Microsoft.Xna.Framework;

namespace BenMakesGames.MonoGame.Palettes;

/// <summary>
/// Game Boy Pocket/Light palette.
/// </summary>
public static class GameBoyPocket
{
    public static readonly Color Black = new(0, 0, 0);
    public static readonly Color DarkGray = new(85, 85, 85);
    public static readonly Color LightGray = new(170, 170, 170);
    public static readonly Color White = new(255, 255, 255);

    public static readonly Color[] Palette =
    [
        Black,
        DarkGray,
        LightGray,
        White
    ];
}