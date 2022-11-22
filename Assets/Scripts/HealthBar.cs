using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private float _speed = 0.001f;
    private float _conversionIndex;
    private float _targetValue;

    private void Awake()
    {
        _conversionIndex = PlayerHealth.MaxHealth;
    }

    private void OnEnable()
    {
        PlayerHealth.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        PlayerHealth.HealthChanged -= OnHealthChanged;
    }

    public void OnHealthChanged(int currentHealth)
    {
        _targetValue = (float)currentHealth / _conversionIndex;
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
