using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Console : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Start" + gameObject.name);
    }

    private void Update()
    {
        Debug.Log("Update" + gameObject.name);
    }
}
