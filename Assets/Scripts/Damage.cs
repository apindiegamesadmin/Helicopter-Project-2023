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
        Debug.Log("Die");
    }

    public void TakeDamage(int damage)
    {
        Debug.Log("Take damage!");
        currentHealth -= damage;
        CheckHealth();
    }
}
