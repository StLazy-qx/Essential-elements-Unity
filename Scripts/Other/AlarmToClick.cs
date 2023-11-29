using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmToClick : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        _animator.SetTrigger("Alarm");
    }
}
