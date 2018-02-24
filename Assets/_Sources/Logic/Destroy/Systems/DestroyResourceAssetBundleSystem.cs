using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class DestroyResourceAssetBundleSystem : ReactiveSystem<GameEntity>
{
    public DestroyResourceAssetBundleSystem(Contexts contexts)
        : base(contexts.game)
    { }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Destroy.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasResourceAssetBundle;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach(var e in entities)
        {
            string path = e.resourceAssetBundle.assetBundlePath;
            object owner = e.resourceAssetBundle.owner;

            ResourceManager.Instance.DestroyAssetBundle(path, owner);
        }
    }

}
