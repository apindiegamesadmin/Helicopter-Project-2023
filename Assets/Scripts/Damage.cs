using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public static Damage instance;

    int currentHealth;
    [SerializeField] int maxHealth;
    int minHealth = 0;

    void Start()
    {
        currentHealth = maxHealth;
    }

    // Check Health
    public void CheckHealth()
    {
        if (currentHealth <= minHealth)
        {
            Die();
        }
    }

    // Die
    void Die()
    {
        // Play explode animation and sound effect
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        CheckHealth();
    }
}
