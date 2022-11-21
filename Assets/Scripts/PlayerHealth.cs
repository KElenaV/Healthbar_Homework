using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private int _minHealth = 0;
    private int _maxHealth = 100;

    public int CurrentHealth { get; private set; }

    private void Awake()
    {
        CurrentHealth = _maxHealth;
    }

    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        CurrentHealth = CurrentHealth < _minHealth ? _minHealth : CurrentHealth;
    }

    public void TakeHealth(int health)
    {
        CurrentHealth += health;
        CurrentHealth = CurrentHealth > _maxHealth ? _maxHealth : CurrentHealth;
    }
}
