using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private Systems _systems;

    void Start()
    {
        var contexts = Contexts.sharedInstance;

        _systems = CreateSystems(contexts);

        _systems.Initialize();
    }

    private Systems CreateSystems(Contexts contexts)
    {
       return new Feature("Systems")

            // Debug
            .Add(new DebugSystems(contexts))

            // Create
            .Add(new InitializeSystems(contexts))

            // Input
            .Add(new InputSystems(contexts))

            // Control
            .Add(new ControlSystems(contexts))

            // Tween
            .Add(new TweenSystems(contexts))

            // View
            .Add(new ViewSystems(contexts))

            // Destroy
            .Add(new DestroySystems(contexts))

            // TearDown
            .Add(new TearDownSystems(contexts))
            ; 
    }

    void Update()
    {
        _systems.Execute();
        _systems.Cleanup();
    }

    void OnDestroy()
    {
        _systems.TearDown();
    }

}
