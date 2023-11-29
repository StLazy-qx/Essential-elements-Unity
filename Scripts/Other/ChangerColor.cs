using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChangerColor : MonoBehaviour
{
    private SpriteRenderer _renderer;

    void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _renderer.DOFade(0,3).SetLoops(-1, LoopType.Yoyo);
    }
}
