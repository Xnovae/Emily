using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;
using UnityEngine.Assertions;

public class SpriteAnimateSystem : IExecuteSystem
{
    private GameContext _context;
    private IGroup<GameEntity> _tweenValueElements;

    public SpriteAnimateSystem(Contexts contexts)
    {
        _context = contexts.game;

        _tweenValueElements = _context.GetGroup(GameMatcher.AllOf(
                                                    GameMatcher.TweenResult,
                                                    GameMatcher.SpriteAnimate,
                                                    GameMatcher.View,
                                                    GameMatcher.ViewAsset));
    }

    public void Execute()
    {
        foreach (var e in _tweenValueElements)
        {
            var viewController = e.view.viewController;
            string spriteName = null;

            bool success = GetSpriteName(e.tweenResult.value, e.spriteAnimate.sprites, ref spriteName);
            if (success)
            {
                var collection = e.viewAsset.collectionData;
                viewController.tk2dSprite.SetSprite(collection, spriteName);
            }
        }
    }

    private bool GetSpriteName(float value, string[] spriteNames, ref string spriteName)
    {
        Assert.IsTrue(0 <= value && value < 1.0f);
        Assert.IsNotNull(spriteNames);
        Assert.IsTrue(spriteNames.Length > 0);

        int length = spriteNames.Length;
        float inverseGap = length; // -> 1 / (1.0f / length);

        int spriteIndex = Mathf.FloorToInt(value * inverseGap);
        if (!(0 <= spriteIndex && spriteIndex < length))
        {
            return false;
        }

        spriteName = spriteNames[spriteIndex];
        return true;
    }
}
