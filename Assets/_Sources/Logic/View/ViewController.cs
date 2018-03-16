using System.Collections;
using System.Collections.Generic;
using Entitas.Unity;
using UnityEngine;

public interface IViewController
{
    tk2dSprite displaySprite { get; set; }
    Renderer displayRenderer { get; set; }

    Vector3 position { get; set; }

    GameObject gameObject { get; }

    void Destroy();
}

public class ViewController : MonoBehaviour, IViewController
{
    public tk2dSprite displaySprite { get; set; }
    public Renderer displayRenderer { get; set; }

    public Vector3 position
    {
        get { return transform.localPosition; }
        set { transform.localPosition = value; }
    }

    void Awake()
    {
        displaySprite = GetComponent<tk2dSprite>();
        displayRenderer = GetComponent<Renderer>();
    }

    public void Destroy()
    {
        EntityLink link = gameObject.GetEntityLink();
        link.Unlink();

        gameObject.name = "tk2dSprite_template(Clone)";

        gameObject.SetActive(false);
        PoolManager.Instance.ReleaseObject(gameObject);
    }
}
