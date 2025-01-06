using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ScaleObject : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Animation();
    }

    public void Animation()
    {
        Vector3 targetScale = new Vector3(1.25f, 1.25f, 1);
        float duration = 1f;
        transform.DOScale(targetScale, duration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
    }
    
}
