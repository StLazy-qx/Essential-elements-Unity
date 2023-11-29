using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetColorSetter : MonoBehaviour
{
    [SerializeField] private Material _materialColor;
    [SerializeField] private Color _reachedColor;

    public void Change()
    {
        _materialColor.color = _reachedColor;
    }
}
