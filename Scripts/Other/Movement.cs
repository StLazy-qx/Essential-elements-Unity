using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0,0, _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, 0, _speed * Time.deltaTime * -1);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);
        }
    }
}
