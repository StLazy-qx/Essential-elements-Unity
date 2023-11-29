using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [HideInInspector] public MeshRenderer Target;
    [SerializeField] private float _duration;
    [SerializeField] private Color _targetColor;

    private float _runningTime;
    private Color _startColor;

    private void Start()
    {
        Target = GetComponent<MeshRenderer>();
        _startColor = Target.material.color;
    }

    private void Update()
    {
        if (_runningTime <= _duration)
        {
            _runningTime += Time.deltaTime;
            float timer = _runningTime / _duration;

            //Color newColor = new Color(_targetColor.r * timer, _targetColor.g * timer, _targetColor.b * timer);

            Target.material.color = Color.Lerp(_startColor, _targetColor, timer);
        }

    }
}
