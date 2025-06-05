using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIMANAGER : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;
    void Start()
    {
        
    }

   public void UpdateMoneyTxt(string moneyAmount)
   {
    txtMoney.text = moneyAmount;
   }
}
