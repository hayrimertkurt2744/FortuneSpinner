using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellManager : MonoBehaviour
{
    [SerializeField] private SpinnerCellSO spinnerCellSO;

    [HideInInspector] public string cellName;
    [HideInInspector] public string cellScript;
    [HideInInspector] public int cellAmount;
    [HideInInspector] public List<string> prizeList;
    [HideInInspector] public CellTypeSO cellType;
    public Sprite logo;
     

    //private void OnEnable()
    //{   
    //    Cursor.OnDecreaseEvent += DecreaseAmount;
    //}
    //private void OnDisable()
    //{
    //    Cursor.OnDecreaseEvent -= DecreaseAmount;
    //}

    private void Start()
    {
        if (spinnerCellSO.cellTypeName!=null)
        {
            cellName = spinnerCellSO.cellTypeName;
            cellScript = spinnerCellSO.cellScript;
            cellAmount = spinnerCellSO.amount;
            prizeList = spinnerCellSO.prizes;
            cellType = spinnerCellSO.cellType;
            logo = spinnerCellSO.cellSprite;
           
        }
    }
    //private void DecreaseAmount()
    //{
        
    //    if (spinnerCellSO.amount>0)
    //    {
    //        spinnerCellSO.amount--;
    //    }
    //    //else if (spinnerCellSO.amount > 0)
    //    //{
    //    //    //else
    //    //}
    //}


}
