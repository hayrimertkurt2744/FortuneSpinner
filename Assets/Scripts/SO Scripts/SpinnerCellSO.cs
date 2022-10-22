using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName ="SpinnerCell",menuName ="ScriptableObjects/Spinner/Spinner Cell")]
public class SpinnerCellSO : ScriptableObject
{
    public string cellTypeName;
    public string cellScript;

    public int amount;

    public List<string> prizes;

    public  CellTypeSO cellType;

     public Sprite cellSprite;
     public Sprite cellSpriteWon;

    [HideInInspector] public bool isWon;



    //[HideInInspector]public CellTypeListSO cellTypeList;


}
