using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : Singleton<UIManager>
{
    public TextMeshProUGUI health;

    private int maxHealth;
    private int currentHealth;

    public void SetPlayerMaxHealth(int setMax)
    {
        currentHealth = maxHealth = setMax;
        RedrawHealth();
    }

    public void SetPlayerCurrentHealth(int setHealth)
    {
        currentHealth = setHealth;
        RedrawHealth();
    }

    private void RedrawHealth()
    {
        health.text = currentHealth.ToString() + " / " + maxHealth.ToString();
    }
}
