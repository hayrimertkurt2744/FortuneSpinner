using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellManager : MonoBehaviour
{
    [SerializeField] private SpinnerCellSO spinnerCellSO;
    [HideInInspector]public string cellName;

    private void Start()
    {
        if (spinnerCellSO.cellTypeName!=null)
        {
            cellName = spinnerCellSO.cellTypeName;
        }
        
        
    }


}
