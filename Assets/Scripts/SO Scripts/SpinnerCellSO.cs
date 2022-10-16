using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

[CreateAssetMenu(fileName ="SpinnerCell",menuName ="ScriptableObjects/Spinner/Spinner Cell")]
public class SpinnerCellSO : ScriptableObject
{
    [SerializeField] private CellTypeSO cellType;

    [SerializeField] private Sprite cellSprite;
    [SerializeField] private Sprite cellSpriteWon;

    [HideInInspector] public bool isWon;


    //[HideInInspector]public CellTypeListSO cellTypeList;

    
}
