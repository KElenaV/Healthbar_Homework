using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private PlayerHealth _playerHealth;

    private float _speed = 0.001f;
    private float _targetValue;

    private void OnEnable()
    {
        _playerHealth.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _playerHealth.HealthChanged -= OnHealthChanged;
    }

    public void OnHealthChanged(int currentHealth, int maxHealth)
    {
        _targetValue = (float)currentHealth / maxHealth;
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
