using System;
using System.Collections;
using System.Collections.Generic;
using ClientConfig;
using Entitas;
using UnityEngine;
using UnityEngine.Analytics;

public class StateViewSystem : ReactiveSystem<GameEntity>
{
    public StateViewSystem(Contexts contexts)
        : base(contexts.game)
    {
        
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.State);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasIdentifier && entity.hasState;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            string id = e.identifier.name;
            var characterItem = ConfigManager.Instance.GetItem<CharacterItem>(Consts.ASSET_NAME_CHARACTER, id);

            string[] sprites = GetSpriteAnimate(characterItem, e.state.state);
            e.ReplaceSpriteAnimate(sprites);

            float duration = Consts.Sprite_Gap_Time * sprites.Length;

            bool loop = e.state.state == CharacterState.Idle || e.state.state == CharacterState.Run;
            e.ReplaceTween(0.0f, 1.0f, duration, loop);
        }
    }

    private string[] GetSpriteAnimate(CharacterItem config, CharacterState state)
    {
        switch (state)
        {
            case CharacterState.Idle:
                return config.actionIdle;

            case CharacterState.Run:
                return config.actionRun;

            case CharacterState.LightAttack1:
                return config.actionLightAttack1;

            case CharacterState.LightAttack2:
                return config.actionLightAttack2;

            case CharacterState.HeavyAttack1:
                return config.actionHeavyAttack1;

            case CharacterState.HeavyAttack2:
                return config.actionHeavyAttack2;

            case CharacterState.LevelUp:
                return config.actionLevelUp;

            case CharacterState.Die:
                return config.actionDie;

            default:
                throw new Exception("!!! invalid state: " + state);
        }
    }
}
