using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private PlayerHealth _playerHealth;
    [SerializeField] private Slider _slider;

    private float _speed = 0.001f;
    private float _conversionIndex = 100f;
    private float _previousValue = 1f;
    private float _targetValue;

    public void ChangeHealthValue()
    {
        _targetValue = (float)_playerHealth.CurrentHealth / _conversionIndex;
        StartCoroutine(ChangeValue());
    }

    private IEnumerator ChangeValue()
    {
        while(_slider.value != _targetValue)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _targetValue, _speed);
            yield return null;
        }
    }

}
