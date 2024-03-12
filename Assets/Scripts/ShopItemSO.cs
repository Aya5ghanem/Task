using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName ="Item",menuName ="Scriptable Object/New Shop Item",order =1)]
public class ShopItemSO : ScriptableObject
{
    public Sprite Itemimg;
    public int price;

}
