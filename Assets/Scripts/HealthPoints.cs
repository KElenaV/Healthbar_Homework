using TMPro;
using UnityEngine;

public class HealthPoints : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;

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
        _text.text = currentHealth.ToString();
    }
}
