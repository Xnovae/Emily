using System.Collections;
using System.Collections.Generic;
using Entitas.Unity;
using UnityEngine;

public interface IViewController
{
    tk2dSprite displaySprite { get; set; }

    Vector3 position { get; set; }

    GameObject gameObject { get; }

    void Destroy();
}

public class ViewController : MonoBehaviour, IViewController
{
    public tk2dSprite displaySprite { get; set; }

    public Vector3 position
    {
        get { return transform.localPosition; }
        set { transform.localPosition = value; }
    }

    void Awake()
    {
        displaySprite = GetComponent<tk2dSprite>();
    }

    public void Destroy()
    {
        EntityLink link = gameObject.GetEntityLink();
        link.Unlink();

        displaySprite.SetSprite(Consts.Tk2dSprite_Not_Exist);

        gameObject.name = "spriteTemplate(Clone)";
        gameObject.SetActive(false);
        PoolManager.Instance.ReleaseObject(gameObject);
    }
}
