using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BeatEffect : MonoBehaviour
{
    public float baseSize = 1f;

    private void Update()
    {
        float animation = baseSize + Mathf.Sin(Time.time * 8f) * baseSize / 7f;
        transform.localScale = this.transform.localScale * animation;
    }
    private void Start()
    {
        //this.transform.DOScale(new Vector3(1, 1, 1), 0.5f,).OnComplete(() => {
        //    this.transform.DOScale(new Vector3(0.5f, 0.5f, 0.5f), 0.5f);
        //});
    }
}
