using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EndPoint
    : MonoBehaviour
{
    //[SerializeField] private Material _material;
    //[SerializeField] private Color _reachedColor;

    [SerializeField] private UnityEvent _reached = new UnityEvent();
    public bool IsReached { get; private set; }

    public event UnityAction Reached
    {
        add => _reached.AddListener(value);
        remove => _reached.RemoveListener(value);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (IsReached == true)
        {
            return;
        }

        if (other.TryGetComponent<Player>(out Player player))
        {
            //_material.color = _reachedColor;
            //Debug.Log("Контрольная точка");
            IsReached = true;
            _reached?.Invoke();
        }
    }
}
