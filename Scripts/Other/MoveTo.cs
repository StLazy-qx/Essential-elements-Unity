using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveTo : MonoBehaviour
{
    void Update()
    {
        transform.DOMove(new Vector3(1, 4, -75), 3).From();
    }
}
