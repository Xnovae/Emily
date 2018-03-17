using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Profiling;

public class SpriteAnimateSystem : IExecuteSystem
{
    private GameContext _context;
    private IGroup<GameEntity> _tweenValueElements;

    private List<GameEntity> _entityCache = new List<GameEntity>();

    public SpriteAnimateSystem(Contexts contexts)
    {
        _context = contexts.game;

        _tweenValueElements = _context.GetGroup(GameMatcher.AllOf(
                                                    GameMatcher.TweenResult,
                                                    GameMatcher.SpriteAnimate,
                                                    GameMatcher.ViewAsset));
    }

    public void Execute()
    {
        foreach (var e in _tweenValueElements.GetEntities(_entityCache))
        {
            string spriteName = null;

            bool success = GetSpriteName(e.tweenResult.value, e.spriteAnimate.sprites, ref spriteName);
            if (success && spriteName != e.viewAsset.spriteName)
            {
                var collection = e.viewAsset.collectionData;
                e.ReplaceViewAsset(collection, spriteName);
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
