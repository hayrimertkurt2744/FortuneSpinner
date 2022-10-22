using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cursor : MonoBehaviour
{
    public event Action<string,Sprite> OnPrizeEvent;
    
    //public event Action OnEvent;

    public  string script;
    public Sprite logoSprite;
    

    public TMP_Text tmpTextName;
    public TMP_Text tmpTextScript;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<CellManager>() != null)
        {
            if (GameManager.Instance.currentState!=GameManager.GameState.AfterSpin)
            {
               
                script = other.gameObject.GetComponent<CellManager>().prizeList[other.gameObject.GetComponent<CellManager>().cellAmount ];
                logoSprite = other.gameObject.GetComponent<CellManager>().logo;   
               
               
                OnPrizeEvent?.Invoke(script,logoSprite);
            } 
            

        }  
  
    }
}
