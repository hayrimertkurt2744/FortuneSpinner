using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }
    public enum GameState
    {
        Normal,
        Spinning,
        AfterSpin,
        UI,
        None  
    }

    [Header("Game Settings")]
    public int spinSpeed=50;
    public List<int> spinAngles = new List<int>();

    
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
