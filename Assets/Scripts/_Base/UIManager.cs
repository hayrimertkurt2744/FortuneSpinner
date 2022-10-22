using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public UnityEvent onPrizeUI;
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private TMP_Text scriptText;
    [SerializeField] private Button spinnerButton;
    public Image logoImage;
    public GameObject cursor;
    private void OnEnable()
    {
        Cursor cursorScript = cursor.GetComponent<Cursor>();

        cursorScript.OnPrizeEvent += ExecuteOnPrizeEvent;
        GameManager.onWinEvent += ActivateWinUI;
    }
    private void Update()
    {
        if (GameManager.Instance.currentState==GameManager.GameState.Spinning)
        {
            spinnerButton.enabled = false;
        }
        else if (GameManager.Instance.currentState == GameManager.GameState.Normal)
        {
            spinnerButton.enabled = true;
        }
    }
    //private void OnDisable()
    //{
    //    Cursor.OnPrizeEvent -= ExecuteOnPrizeEvent;
    //}
    private void ExecuteOnPrizeEvent(string script,Sprite logoSprite ) 
    {
        //Debug.Log( name );
        //Debug.Log(script);

        //nameText.text = name;
        scriptText.text = script;
        logoImage.sprite= logoSprite;


        

    }

    private void ActivateWinUI()
    {
        onPrizeUI?.Invoke();
        
    }
}

