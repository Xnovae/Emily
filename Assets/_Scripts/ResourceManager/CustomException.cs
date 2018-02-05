using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// load完目标被destroy
public class TargetDestroyedException : Exception
{
    public AssetBundle assetBundle;
    public int asset;

    public TargetDestroyedException()
    {
    }

    public TargetDestroyedException(AssetBundle assetBundle, int asset)
    {
        this.assetBundle = assetBundle;
        this.asset = asset;
    }

    public TargetDestroyedException(string message)
        : base(message)
    {
    }

    public TargetDestroyedException(string message, Exception inner)
        : base(message, inner)
    {
    }
}

// AssetBundle load不出来
public class LoadAssetBundleException : Exception
{
    public LoadAssetBundleException()
    {
    }

    public LoadAssetBundleException(string message)
        : base(message)
    {
    }

    public LoadAssetBundleException(string message, Exception inner)
        : base(message, inner)
    {
    }
}

// AssetBundle Asset load不出来
public class LoadAssetBundleAssetException : Exception
{
    public LoadAssetBundleAssetException()
    {
    }

    public LoadAssetBundleAssetException(string message)
        : base(message)
    {
    }

    public LoadAssetBundleAssetException(string message, Exception inner)
        : base(message, inner)
    {
    }
}

// Resources Asset load不出来
public class ResourcesAssetException : Exception
{
    public ResourcesAssetException()
    {
    }

    public ResourcesAssetException(string message)
        : base(message)
    {
    }

    public ResourcesAssetException(string message, Exception inner)
        : base(message, inner)
    {
    }
}

// Resources Asset load不出来
public class WWWAssetException : Exception
{
    public WWWAssetException()
    {
    }

    public WWWAssetException(string message)
        : base(message)
    {
    }

    public WWWAssetException(string message, Exception inner)
        : base(message, inner)
    {
    }
}

// load完成， loader被destroy
public class LoadDoneAndDestroyMainException : Exception
{
    public AssetBundle assetBundle;
    public int asset;

    public LoadDoneAndDestroyMainException()
    {
    }

    public LoadDoneAndDestroyMainException(AssetBundle assetBundle, int asset)
    {
        this.assetBundle = assetBundle;
        this.asset = asset;
    }

    public LoadDoneAndDestroyMainException(string message)
        : base(message)
    {
    }

    public LoadDoneAndDestroyMainException(string message, Exception inner)
        : base(message, inner)
    {
    }
}

// load完成， 全部被destroy
public class LoadDoneAndDestroyAllException : Exception
{
    public AssetBundle assetBundle;
    public int asset;
    
    public LoadDoneAndDestroyAllException()
    {
    }

    public LoadDoneAndDestroyAllException(AssetBundle assetBundle, int asset)
    {
        this.assetBundle = assetBundle;
        this.asset = asset;
    }

    public LoadDoneAndDestroyAllException(string message)
        : base(message)
    {
    }

    public LoadDoneAndDestroyAllException(string message, Exception inner)
        : base(message, inner)
    {
    }
}

public class UnknownException : Exception
{
    public UnknownException()
    {
    }

    public UnknownException(string message)
        : base(message)
    {
    }

    public UnknownException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
