//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ResourceAssetBundleComponent resourceAssetBundle { get { return (ResourceAssetBundleComponent)GetComponent(GameComponentsLookup.ResourceAssetBundle); } }
    public bool hasResourceAssetBundle { get { return HasComponent(GameComponentsLookup.ResourceAssetBundle); } }

    public void AddResourceAssetBundle(string newAssetBundlePath, object newOwner) {
        var index = GameComponentsLookup.ResourceAssetBundle;
        var component = CreateComponent<ResourceAssetBundleComponent>(index);
        component.assetBundlePath = newAssetBundlePath;
        component.owner = newOwner;
        AddComponent(index, component);
    }

    public void ReplaceResourceAssetBundle(string newAssetBundlePath, object newOwner) {
        var index = GameComponentsLookup.ResourceAssetBundle;
        var component = CreateComponent<ResourceAssetBundleComponent>(index);
        component.assetBundlePath = newAssetBundlePath;
        component.owner = newOwner;
        ReplaceComponent(index, component);
    }

    public void RemoveResourceAssetBundle() {
        RemoveComponent(GameComponentsLookup.ResourceAssetBundle);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherResourceAssetBundle;

    public static Entitas.IMatcher<GameEntity> ResourceAssetBundle {
        get {
            if (_matcherResourceAssetBundle == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ResourceAssetBundle);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherResourceAssetBundle = matcher;
            }

            return _matcherResourceAssetBundle;
        }
    }
}
