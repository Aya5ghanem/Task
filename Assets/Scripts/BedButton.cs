using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class BedButton : MonoBehaviour
{
    public  float BankAccount=3000;
    public TMP_Text BankAccountcoin;
    
    
    public void Increase()
    {
        BankAccount =BankAccount+( BankAccount *0.1f);
        BankAccountcoin.text = BankAccount.ToString();
    }
}
