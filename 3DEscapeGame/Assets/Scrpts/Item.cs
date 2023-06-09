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

    //Ží—Þ
    public Type type;
    //Slot‚É•\Ž¦‚·‚é‰æ‘œ
    public Sprite sprite;

    public Item(Type type, Sprite sprite)
    {
        this.type = type;
        this.sprite = sprite;
    }
}
