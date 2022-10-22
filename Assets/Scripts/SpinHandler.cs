using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;

public class SpinHandler : MonoBehaviour
{
    public Transform spinnerTransform;
    private int chosenSpinAngle;
    private Cursor cursor;


    public void Spin()
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        
        GameManager.Instance.currentState = GameManager.GameState.Spinning;
            spinnerTransform.DORotate(new Vector3(0, 0, 360+360+GameManager.Instance.AngleListSO.angleList[Random.Range(0, GameManager.Instance.AngleListSO.angleList.Count - 1)]), 
                3,RotateMode.FastBeyond360).OnComplete(() =>
                {
                    GameManager.onWinEvent?.Invoke();
                    GameManager.Instance.currentState = GameManager.GameState.AfterSpin;


                    //GameManager.Instance.AngleListSO.angleList[chosenSpeenAngle]=0;
                    //if the choosen angle's prize's amount is zero, control it then open a new type of uý 

                });
        GameManager.Instance.currentState = GameManager.GameState.Normal;
        //Wait for 4 seconds
        yield return new WaitForSeconds(4);

    }



}

