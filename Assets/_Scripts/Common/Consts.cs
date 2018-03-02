using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Consts
{
    public const int TexturePixelsPerUnit = 100;

    // https://en.wikipedia.org/wiki/Machine_epsilon
    // pow(2, -24) -> 5.96e-08, magic minimal number
    public static readonly float Epsilon_Float = 5.96e-08f;

    public static readonly float Sprite_Gap_Time = 1.0f / 12.0f;

    public static readonly string Tk2dSprite_Template = "tk2dSprite_template";

    public static readonly string Tk2dSprite_Character_Template = "tk2dSprite_character_template";

    public static readonly string ID_HERO_ARCHER = "heroes_archer";

    // Asset names
    public const string ASSET_NAME_CHARACTER = "character";

    // Tags
    public const string TAG_PLAYER = "Player";
    public const string TAG_MAIN_CAMERA = "MainCamera";
}
