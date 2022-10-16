using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CellTypeList", menuName = "ScriptableObjects/Cell Type List")]
public class CellTypeListSO : ScriptableObject
{
    #region Header

    [Header("The list containing cell type data")]

    public List<CellTypeSO> cellTypes = new List<CellTypeSO>();

    #endregion  
}
