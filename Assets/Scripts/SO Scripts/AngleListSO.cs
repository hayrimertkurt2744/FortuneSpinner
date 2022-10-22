using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AngleList", menuName = "ScriptableObjects/Angle List")]
public class AngleListSO :ScriptableObject
{

   #region Header

    [Header("The list containing angle data")]

    public List<int> angleList = new List<int>();

    #endregion
 
}
