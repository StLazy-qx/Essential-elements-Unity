using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamOperation : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offset;
    public float camPositionSpeed = 5f;

    void FixedUpdate()
    {
        Vector3 newCamPosition = new Vector3(offset.x, playerTransform.position.y + offset.y, playerTransform.position.z + offset.z);
        transform.position = Vector3.Lerp(transform.position, newCamPosition, camPositionSpeed * Time.deltaTime);
    }

    //[SerializeField] private Transform _targetTransform;
    //[SerializeField] private float _cameraSpeed;

    //private float __rotationY;
    //private Vector3 _offset;

    //private void Start()
    //{
    //    __rotationY = transform.eulerAngles.y;
    //    _offset = _targetTransform - transform.position;
    //}

    //private void LateUpdate()
    //{
    //    float horizontalInput = Input.GetAxis("Horizontal");

    //    if (horizontalInput != 0)
    //    {
    //        __rotationY += horizontalInput * _cameraSpeed;
    //    }
    //    else
    //    {
    //        __rotationY += Input.GetAxis("MouseX") * _cameraSpeed * 3;
    //    }

    //    Quaternion rotation = Quaternion.Euler(0, __rotationY, 0);
    //    transform.position = _targetTransform - (rotation * _offset);
    //    transform.LookAt(_targetTransform);
    //}




}
