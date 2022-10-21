using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<CellManager>() != null) 
        {
            Debug.Log(other.GetComponent<CellManager>().cellName);
        }  
        
        
    }
}
