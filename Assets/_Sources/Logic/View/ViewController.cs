using System.Collections;
using System.Collections.Generic;
using Entitas.Unity;
using UnityEngine;

public interface IViewController
{
    tk2dSprite tk2dSprite { get; set; }

    Vector3 position { get; set; }

    GameObject gameObject { get; }

    void Destroy();
}

public class ViewController : MonoBehaviour, IViewController
{
    public tk2dSprite tk2dSprite { get; set; }

    public Vector3 position
    {
        get { return transform.localPosition; }
        set { transform.localPosition = value; }
    }

    void Awake()
    {
        tk2dSprite = GetComponent<tk2dSprite>();
    }

    public void Destroy()
    {
        EntityLink link = gameObject.GetEntityLink();
        link.Unlink();

        gameObject.name = "spriteTemplate(Clone)";
        gameObject.SetActive(false);
        PoolManager.Instance.releaseObject(gameObject);
    }
}
