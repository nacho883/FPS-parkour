using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mercanciaScript : MonoBehaviour{
  
  public moneyManager moneymanager;
  public float cost;
  void start()
  {
    moneymanager = FindObjectOfType<moneyManager>();
  }

  void OnCollisionEnter(Collision collision){
      if(collision.gameObject.name == "Player"){
        moneymanager.updateMoney(cost);
        Destroy(gameObject);
    }
  }
}
