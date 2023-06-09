using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjj : MonoBehaviour
{
    [SerializeField]
    private Item.Type itemType;
    Item item;

    private void Start()
    {
        //itemTypeに応じてitemを生成
        item = ItemGenerater.instance.Spawn(itemType);
    }

    public void OnClickObj()
    {
        ItemBox.instance.SetItem(item);
        gameObject.SetActive(false);
    }
}
