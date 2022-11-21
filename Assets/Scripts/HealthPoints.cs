using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthPoints : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private PlayerHealth _playerHealth;

    public void ChangeHealthPoints()
    {
        _text.text = _playerHealth.CurrentHealth.ToString();
    }
}
