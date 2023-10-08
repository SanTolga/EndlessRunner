using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] _selection;
    public int _zpos = 50;
    public bool _creatingSelection;
    public int _secnum;

    private void Update()
    {
        if (_creatingSelection == false)
        {
            _creatingSelection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        _secnum = Random.Range(0, 2);
        Instantiate(_selection[_secnum], new Vector3(0, 0, _zpos), quaternion.identity);
        _zpos += 100;
        yield return new WaitForSeconds(2); 
        _creatingSelection = false;
    }
}