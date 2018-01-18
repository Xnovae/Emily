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
            UnityEngine.Object target = e.resourceAssetBundle.target;
            string path = e.resourceAssetBundle.assetBundlePath;
            ResourceManager.Instance.DestroyAssetBundle(target, path);
        }
    }

}
