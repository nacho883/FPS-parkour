using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneyManager : MonoBehaviour
{
    public float money;
    public UIMANAGER uimanager;

    void Start()
    {
        
    }

  public void  updateMoney(float moneyToAdd){
    if(money + moneyToAdd < 0)
    {
        Debug.Log("no te alcanza");
        return;
    }
    money += moneyToAdd;
    uiManager.UpdatemoneyTxt(money.ToString());
  }
}
