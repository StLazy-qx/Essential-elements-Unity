using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(AudioSource))]

public class SoundManager : MonoBehaviour
{
    [SerializeField] private float _maxVolume;
    [SerializeField] private float _minVolume;
    [SerializeField] private float _duration;
    [SerializeField] private AudioSource _sound;

    private void Start()
    {
        _sound = GetComponent<AudioSource>();
        _sound.volume = 0;
    }

    //private void OnEnable()
    //{
    //    AlarmTrigger.Action += IncreaseSound;
    //}

    //private void OnDisable()
    //{
    //    AlarmTrigger.Action -= IncreaseSound;
    //}

    //public void GetSound()
    //{
    //    if (_isPlay == false)
    //    {
    //        _isPlay = true;
    //        _sound.DOFade(_maxVolume, _duration);
    //        _sound.Play();
    //    }
    //    else
    //    {
    //        _isPlay = false;
    //        _sound.DOFade(_minVolume, _duration);
    //        _sound.Play();
    //    }
    //}

    public void IncreaseSound() // поменять название
    {
        Debug.Log($"Вошли");
        _sound.DOFade(_maxVolume, _duration);
        _sound.Play();
    }
}
