using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementForvard : MonoBehaviour
{
    [SerializeField] private float _speedMove;
    [SerializeField] private float _zPositionMove;

    private Vector3 initialPosition;
    private bool isMovingForward = true;
    
    private void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        Vector3 movementDirection = isMovingForward ? Vector3.forward : Vector3.back;
        Vector3 newPosition = transform.position + movementDirection * _speedMove * Time.deltaTime;
        transform.position = newPosition;       
        
        if (transform.position.z >= _zPositionMove || transform.position.z <= initialPosition.z) 
        {
            isMovingForward = !isMovingForward;
        }
    }
}