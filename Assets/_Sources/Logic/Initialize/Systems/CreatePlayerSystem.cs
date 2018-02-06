using System.Collections;
using System.Collections.Generic;
using ClientConfig;
using Entitas;
using UnityEngine;
using UnityEngine.Assertions;

public class CreatePlayerSystem : ReactiveSystem<GameEntity>
{
    private GameContext _gameContext;

    public CreatePlayerSystem(Contexts contexts)
        : base(contexts.game)
    {
        _gameContext = contexts.game;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.ResourceInitialize.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return true;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        var e = entities.SingleEntity();
        Assert.IsNotNull(e);

        CreatePlayer(Consts.ID_HERO_ARCHER);
    }

    private void CreatePlayer(string id)
    {
        var characterItem = ConfigManager.Instance.GetItem<Character, CharacterItem>(Consts.ASSET_NAME_CHARACTER, id);
        string path = Utils.GetBundlePathForLoadFromFile(characterItem.path);

        ResourceManager.Instance.GetAssetBundleAsset(path, id)
            .Then(result =>
            {
                var e = _gameContext.CreateEntity();

                e.AddIdentifier(id);
                e.isControllable = true;
                e.AddPosition(new Vector2(21.5f, 31.5f));

                string assetName = id;
                e.AddView(null, assetName);

                e.AddState(CharacterState.LevelUp);
                e.AddDirection(CharacterDirection.Right);

                var asset = result as GameObject;
                Assert.IsNotNull(asset);

                var collectionData = asset.GetComponent<tk2dSpriteCollectionData>();
                e.AddViewAsset(collectionData, characterItem.initSpriteName);
            })
            .Catch(ex => { Debug.LogException(ex); });
    }
}
