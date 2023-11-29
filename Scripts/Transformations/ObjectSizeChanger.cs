using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSizeChanger : MonoBehaviour
{
    [SerializeField] private float _growthSpeed;
    [SerializeField] private Vector3 _targetScale = new Vector3(2.0f, 2.0f, 2.0f);

    private bool _isScalingUp = true;
    private Vector3 initialSize;

    private void Start()
    {
        initialSize = transform.localScale;
    }

    void Update()
    {
        Vector3 newScale = _isScalingUp
            ? Vector3.Lerp(transform.localScale, _targetScale, 
            _growthSpeed * Time.deltaTime)
            : Vector3.Lerp(transform.localScale, initialSize, 
            _growthSpeed * Time.deltaTime);

        transform.localScale = newScale;

        if (_isScalingUp && Vector3.Distance(transform.localScale, _targetScale) < 0.01f)
        {
            _isScalingUp = false;
        }
        else if (_isScalingUp == false && Vector3.Distance(transform.localScale, initialSize) < 0.01f)
        {
            _isScalingUp = true;
        }
    }
}
