using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public AngleListSO AngleListSO;

   

    public static GameManager Instance { get { return instance; } }
    public enum GameState
    {
        Normal,
        Spinning,
        AfterSpin,
        //UI,
        None  
    }


    public static Action onWinEvent;
    public static Action onFailEvent;
    public static Action onRespinEvent;
    
    [Header("Game Settings")]
    public GameState currentState = GameState.Normal;
    //public int spinSpeed=50;
    



    
    private void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }



}
