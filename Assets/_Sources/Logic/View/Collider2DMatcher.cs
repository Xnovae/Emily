using System.Collections;
using System.Collections.Generic;
using Entitas.Unity;
using UnityEngine;

public class Collider2DMatcher : MonoBehaviour
{
    private tk2dSprite _tk2dSprite;
    private BoxCollider2D _boxCollider2D;

    private void Awake()
    {
        _tk2dSprite = GetComponent<tk2dSprite>();
        _boxCollider2D = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (_tk2dSprite.Collection)
        {
            Bounds bounds = _tk2dSprite.GetBounds();

            _boxCollider2D.size = bounds.size;
            _boxCollider2D.offset = bounds.center;
        }
    }
}
