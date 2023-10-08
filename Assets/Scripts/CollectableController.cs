using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollectableController : MonoBehaviour
{
   public static int _coinCount;
   public GameObject _coinCountDisplay;

   private void Update()
   {
      _coinCountDisplay.GetComponent<TMP_Text>().text = "Coin " +" "+ _coinCount;
   }
}
