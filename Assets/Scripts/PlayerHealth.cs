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
        RunEventWithCorrectedHealth();
    }

    public void TakeHealth(int health)
    {
        _currentHealth += health;
        RunEventWithCorrectedHealth();
    }

    private void RunEventWithCorrectedHealth()
    {
        _currentHealth = Mathf.Clamp(_currentHealth, _minHealth, _maxHealth);
        HealthChanged?.Invoke(_currentHealth, _maxHealth);
    } 
}
