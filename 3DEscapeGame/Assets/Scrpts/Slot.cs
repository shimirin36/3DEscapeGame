using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    Item item;
    Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    public bool IsEmpty()
    {
        if(item == null)
        {
            return true;
        }
        return false;
    }

    public void SetItem(Item item)
    {
        this.item = item;
        UpdateImage(item);
    }

    //アイテムを受け取ったら画像をスロットに表示する
    void UpdateImage(Item item)
    {
        image.sprite = item.sprite;
    }
}
