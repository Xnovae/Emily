using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using System.IO;

public class TexturePackerSprite
{
    public string n;

    public int x;
    public int y;
    public int w;
    public int h;

    public float pX;
    public float pY;

    // only available if trimmed
    public int oX;
    public int oY;
    public int oW;
    public int oH;

    // only set if sprite is rotated
    public bool r;

    // with polygon mode enabled
    public int[] vertices;
    public int[] verticesUV;
    public int[] triangles;

    public TexturePackerSprite(XElement element)
    {
        try
        {
            this.n = element.Attribute("n").Value;

            this.x = Convert.ToInt32(element.Attribute("x").Value);
            this.y = Convert.ToInt32(element.Attribute("y").Value);
            this.w = Convert.ToInt32(element.Attribute("w").Value);
            this.h = Convert.ToInt32(element.Attribute("h").Value);

            this.pX = Convert.ToSingle(element.Attribute("pX").Value);
            this.pY = Convert.ToSingle(element.Attribute("pY").Value);

            var oXElement = element.Attribute("oX");
            this.oX = oXElement != null ? Convert.ToInt32(oXElement.Value) : 0;

            var oYElement = element.Attribute("oY");
            this.oY = oYElement != null ? Convert.ToInt32(oYElement.Value) : 0;

            var oWElement = element.Attribute("oW");
            this.oW = oWElement != null ? Convert.ToInt32(oWElement.Value) : 0;

            var oHElement = element.Attribute("oH");
            this.oH = oHElement != null ? Convert.ToInt32(oHElement.Value) : 0;

            var rElement = element.Attribute("r");
            this.r = rElement != null && rElement.Value == "y";

            var verticesElement = element.Element("vertices");
            if (verticesElement != null)
            {
                string[] param = verticesElement.Value.Split(' ');

                this.vertices = new int[param.Length];
                for (int i = 0, length = param.Length; i < length; ++i)
                {
                    this.vertices[i] = Convert.ToInt32(param[i]);
                }
            }

            var verticesUVElement = element.Element("verticesUV");
            if (verticesUVElement != null)
            {
                string[] param = verticesUVElement.Value.Split(' ');

                this.verticesUV = new int[param.Length];
                for (int i = 0, length = param.Length; i < length; ++i)
                {
                    this.verticesUV[i] = Convert.ToInt32(param[i]);
                }
            }

            var trianglesElement = element.Element("triangles");
            if (trianglesElement != null)
            {
                string[] param = trianglesElement.Value.Split(' ');

                this.triangles = new int[param.Length];
                for (int i = 0, length = param.Length; i < length; ++i)
                {
                    this.triangles[i] = Convert.ToInt32(param[i]);
                }
            }
        }
        catch (Exception e)
        {
            Debug.LogException(e);
        }
    }
}

public class TexturePackerAtlas
{
    public string imagePath;
    public int width;
    public int height;

    public Dictionary<string, TexturePackerSprite> dicts = new Dictionary<string, TexturePackerSprite>();

    public TexturePackerAtlas(string path)
    {
        try
        {
            var document = XElement.Load(path);

            var atlasElement = document;

            this.imagePath = atlasElement.Attribute("imagePath").Value;
            this.width = Convert.ToInt32(atlasElement.Attribute("width").Value);
            this.height = Convert.ToInt32(atlasElement.Attribute("height").Value);

            var spriteElemnts = atlasElement.Elements("sprite");

            foreach (var spriteElemnt in spriteElemnts)
            {
                var texturePackerSprite = new TexturePackerSprite(spriteElemnt);

                dicts.Add(Path.GetFileNameWithoutExtension(texturePackerSprite.n), texturePackerSprite);
            }
        }
        catch (Exception e)
        {
            Debug.LogException(e);
        }
    }
}
