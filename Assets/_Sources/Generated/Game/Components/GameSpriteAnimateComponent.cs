//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public SpriteAnimateComponent spriteAnimate { get { return (SpriteAnimateComponent)GetComponent(GameComponentsLookup.SpriteAnimate); } }
    public bool hasSpriteAnimate { get { return HasComponent(GameComponentsLookup.SpriteAnimate); } }

    public void AddSpriteAnimate(string[] newSprites) {
        var index = GameComponentsLookup.SpriteAnimate;
        var component = CreateComponent<SpriteAnimateComponent>(index);
        component.sprites = newSprites;
        AddComponent(index, component);
    }

    public void ReplaceSpriteAnimate(string[] newSprites) {
        var index = GameComponentsLookup.SpriteAnimate;
        var component = CreateComponent<SpriteAnimateComponent>(index);
        component.sprites = newSprites;
        ReplaceComponent(index, component);
    }

    public void RemoveSpriteAnimate() {
        RemoveComponent(GameComponentsLookup.SpriteAnimate);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherSpriteAnimate;

    public static Entitas.IMatcher<GameEntity> SpriteAnimate {
        get {
            if (_matcherSpriteAnimate == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SpriteAnimate);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSpriteAnimate = matcher;
            }

            return _matcherSpriteAnimate;
        }
    }
}
