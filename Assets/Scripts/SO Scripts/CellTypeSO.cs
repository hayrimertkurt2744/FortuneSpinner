using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CellType", menuName = "ScriptableObjects/Cell Types")]
public class CellTypeSO : ScriptableObject
{
    public string cellTypeName;

    public string cellScript;

    public bool isPrize;

    public bool isPoint;

    public bool isReSpin;

    public bool isFailed;

}
