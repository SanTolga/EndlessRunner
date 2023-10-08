using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFlip : MonoBehaviour
{
    public Vector3 _rotate;
    public float _speed = 5f;
   
    void Update()
    {
        transform.Rotate(_rotate*Time.deltaTime*_speed);
    }
    
    
}
