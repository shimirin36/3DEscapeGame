using System;
using UnityEngine;

[Serializable]
public class Item
{
    public enum Type 
    {
        Cube,
        Ball,
    }

    //種類
    public Type type;
    //Slotに表示する画像
    public Sprite sprite;

    public Item(Type type, Sprite sprite)
    {
        this.type = type;
        this.sprite = sprite;
    }
}
