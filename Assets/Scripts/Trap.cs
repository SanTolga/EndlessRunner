using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trap : MonoBehaviour
{
    public bool _boolDead = false;
     
    private void FixedUpdate()
    {
        if (_boolDead == true)
        {
            SceneManager.LoadScene(0);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Trap"))
        {
            if (_boolDead == false)
            {
                _boolDead = true;
            }
        }
    }
    
}
