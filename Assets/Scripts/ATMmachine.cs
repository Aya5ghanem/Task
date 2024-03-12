using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ATMmachine : MonoBehaviour
{

    public ShopManager Sh_M;
    public BedButton BB;
   

    public void Deposit()
    {
      
        BB.BankAccount = Sh_M.coin + BB.BankAccount;
        BB.BankAccountcoin.text = BB.BankAccount.ToString();
        Sh_M.coin = 0;
        Sh_M.coinUI.text = Sh_M.coin.ToString();
       

    }
    public void Withdraw()
    {
        Sh_M.coin = Sh_M.coin + BB.BankAccount;
        Sh_M.coinUI.text = Sh_M.coin.ToString();
        BB.BankAccount = 0;
        BB.BankAccountcoin.text = BB.BankAccount.ToString();
    }

}
