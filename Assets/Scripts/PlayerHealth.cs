using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    private readonly int _maxHealth = 100;
    private readonly int _minHealth = 0;
    private int _currentHealth;

    public event UnityAction<int, int> HealthChanged;

    private void Awake()
    {
        _currentHealth = _maxHealth;
        HealthChanged?.Invoke(_currentHealth, _maxHealth);
    }

    public void TakeDamage(int damage)
    {
        _currentHealth -= damage;
        _currentHealth = _currentHealth < _minHealth ? _minHealth : _currentHealth;
        HealthChanged?.Invoke(_currentHealth, _maxHealth);
    }

    public void TakeHealth(int health)
    {
        _currentHealth += health;
        _currentHealth = _currentHealth > _maxHealth ? _maxHealth : _currentHealth;
        HealthChanged?.Invoke(_currentHealth, _maxHealth);
    }
}
