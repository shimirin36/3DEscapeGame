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

    //���
    public Type type;
    //Slot�ɕ\������摜
    public Sprite sprite;

    public Item(Type type, Sprite sprite)
    {
        this.type = type;
        this.sprite = sprite;
    }
}
