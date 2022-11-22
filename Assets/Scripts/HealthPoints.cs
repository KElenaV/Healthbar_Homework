using TMPro;
using UnityEngine;

public class HealthPoints : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private PlayerHealth _playerHealth;

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
        _text.text = currentHealth.ToString();
    }
}
