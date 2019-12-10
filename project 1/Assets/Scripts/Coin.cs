using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
   public int coinValue = 1;

   private void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.CompareTag("Player"))
      {
         CoinCollection.instance.ChangeScore(coinValue);
      }
   }
}
