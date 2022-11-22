using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    public static readonly int MaxHealth = 100;

    private int _minHealth = 0;

    public static event UnityAction<int> HealthChanged;

    public int CurrentHealth { get; private set; }

    private void Awake()
    {
        CurrentHealth = MaxHealth;
        HealthChanged?.Invoke(CurrentHealth);
    }

    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        CurrentHealth = CurrentHealth < _minHealth ? _minHealth : CurrentHealth;
        HealthChanged?.Invoke(CurrentHealth);
    }

    public void TakeHealth(int health)
    {
        CurrentHealth += health;
        CurrentHealth = CurrentHealth > MaxHealth ? MaxHealth : CurrentHealth;
        HealthChanged?.Invoke(CurrentHealth);
    }
}
