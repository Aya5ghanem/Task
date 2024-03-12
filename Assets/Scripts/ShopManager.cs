using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ShopManager : MonoBehaviour
{
    public  float coin =1000;
    public TMP_Text coinUI;
    public ShopItemSO[] _ShopItemSO;
    public ShopTemplate[] ShopPanels;
    public Button[] PurchaseBTN;
     void Start()
    {
        Debug.Log("ShopManager");
        coinUI.text = coin.ToString();
        LoadData();
        CheckPurchase();
    }
    public void LoadData()
    {
        for(int i=0;i< _ShopItemSO.Length;i++)
        {
            ShopPanels[i].img = _ShopItemSO[i].Itemimg;
            ShopPanels[i].coin.text = _ShopItemSO[i].price.ToString();
        }
    }
    public void CheckPurchase()
    {
        for(int i=0;i< _ShopItemSO.Length; i++)
        {
            if(coin>= _ShopItemSO[i].price)
            
                PurchaseBTN[i].interactable = true;
            else
                PurchaseBTN[i].interactable = false;
        }
    }

    public void purchaseItem(int btno)
    {
        if(coin>= _ShopItemSO[btno].price)
        {
            coin = coin - _ShopItemSO[btno].price;
            coinUI.text = coin.ToString();
            CheckPurchase();
        }
    }
    public void sell(int btno)
    {
        coin=coin + _ShopItemSO[btno].price;
        coinUI.text = coin.ToString();
    }
}
